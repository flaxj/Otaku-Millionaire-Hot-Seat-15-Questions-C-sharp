# Otaku Millionaire Hot Seat — C#

Windows Forms quiz-show software targeting **.NET Framework 4.8.1**. The application keeps the original host/player screens, fifteen-question flow, money trees, lifelines, graphics, and audio.

## Build and run

Use Visual Studio with the **.NET desktop development** workload and the **.NET Framework 4.8.1 targeting pack**. Open `Otaku Millionaire Hot Seat.slnx`, select Debug or Release, and build the application project. No external NuGet packages are required.

From a Visual Studio Developer PowerShell:

```powershell
msbuild 'Otaku Millionaire Hot Seat/Otaku Millionaire Hot Seat.csproj' /t:Rebuild /p:Configuration=Release
& './Otaku Millionaire Hot Seat/bin/CSharp/Release/Otaku Millionaire Hot Seat.exe'
```

Distribute the executable and its `.exe.config` from that output folder. Images and WAV audio are embedded. The destination PC needs Windows and .NET Framework 4.8.1.

## Game files

The start button asks for one topic file followed by fifteen question files. Sample files are in `Verification/Fixtures`.

- Topic file: at least fifteen lines, one topic per question.
- Question file: topic on line 1; three question-text lines on lines 2–4; answers A–D on lines 5–8; the exact correct answer text on line 9; four numeric answer character counts on lines 10–13, used for font sizing.
- Blank question-text lines are allowed. Keep their line positions. Extra lines are ignored as before.

After loading, use the host controls to reveal questions, choices, results, and transitions. Keep the separate Player Screen visible for the audience; it can be moved to another display.

Invalid files now show a recoverable warning. Cancelling file selection leaves the game at its current setup stage. Audience votes use a nonnegative numeric input; cancelling records zero votes for that choice, and an all-zero poll displays zero percentages.

## Verification

```powershell
powershell -ExecutionPolicy Bypass -File ./Verification/Run.ps1 -Configuration Release
```

Run in an interactive Windows session with a 1920×1080 primary display at 100% scaling and English numeric formatting, matching the recorded UI baseline. The checks open and close test windows, operate file dialogs, and play game audio; allow several minutes and avoid interacting with those windows.

The C# runner compares actual forms and game state with compressed baseline snapshots, exercises invalid input and rounding, and starts/stops the standalone executable. Results are written beneath `Verification/bin/<configuration>/Results`. A mismatch fails the run; do not replace the baseline simply to make a failure pass.

See [the migration verification report](Verification/MigrationReport.md) for coverage, intentional safety changes, and environmental limits.
