param(
    [ValidateSet('Debug', 'Release')][string]$Configuration = 'Release'
)
$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio/Installer/vswhere.exe'
$msbuild = & $vswhere -latest -products '*' -requires Microsoft.Component.MSBuild -find 'MSBuild/**/Bin/MSBuild.exe' | Select-Object -First 1
if (-not $msbuild) { throw 'Install Visual Studio Build Tools with .NET Framework 4.8.1 targeting tools.' }
& $msbuild (Join-Path $root 'Otaku Millionaire Hot Seat/Otaku Millionaire Hot Seat.csproj') /t:Rebuild "/p:Configuration=$Configuration" /p:UseSharedCompilation=false /nr:false /m:1 /v:minimal /nologo
if ($LASTEXITCODE -ne 0) { throw 'Application build failed.' }
& $msbuild (Join-Path $PSScriptRoot 'Verification.csproj') /t:Rebuild "/p:Configuration=$Configuration" /p:UseSharedCompilation=false /nr:false /m:1 /v:minimal /nologo
if ($LASTEXITCODE -ne 0) { throw 'Verification build failed.' }
$runner = Join-Path $PSScriptRoot "bin/$Configuration/Verification.exe"
$app = Join-Path $root "Otaku Millionaire Hot Seat/bin/CSharp/$Configuration/Otaku Millionaire Hot Seat.exe"
$results = Join-Path $PSScriptRoot "bin/$Configuration/Results"
New-Item -ItemType Directory -Path $results -Force | Out-Null
foreach ($suite in @('core', 'extended', 'imports', 'edges')) {
    $actual = Join-Path $results "$suite.txt"
    $arguments = @($app, $actual)
    if ($suite -ne 'core') { $arguments += "--$suite" }
    & $runner @arguments
    if ($LASTEXITCODE -ne 0) { throw "$suite runtime checks failed." }
    $baselinePath = Join-Path $PSScriptRoot "Baselines/$suite.txt.gz"
    $file = [System.IO.File]::OpenRead($baselinePath)
    try {
        $gzip = [System.IO.Compression.GZipStream]::new($file, [System.IO.Compression.CompressionMode]::Decompress)
        try {
            $reader = [System.IO.StreamReader]::new($gzip)
            try { $expected = $reader.ReadToEnd() } finally { $reader.Dispose() }
        } finally { $gzip.Dispose() }
    } finally { $file.Dispose() }
    if ([System.IO.File]::ReadAllText($actual) -cne $expected) { throw "$suite differs from the recorded baseline. Inspect $actual." }
    Write-Host "$suite matches the recorded baseline."
}
& $runner $app (Join-Path $results 'launch.txt') --launch
if ($LASTEXITCODE -ne 0) { throw 'Executable startup or shutdown check failed.' }
Write-Host 'All parity, safety, startup and shutdown checks passed.'
