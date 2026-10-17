# C# migration verification

## Baseline and conversion

The baseline was built from commit `b33d42eebfa6415939ee646837d5218eac58a48c`, in both Debug and Release, before removing the Visual Basic implementation. Existing checked-in binaries were not used as the reference.

For GitHub publication, commit `5eb0f44` preserves that baseline's source and assets while excluding only `bin`, `obj`, and `.vs` artifacts. The original commit contains binaries exceeding GitHub's file limit and remains preserved locally on `codex/original-vb-local`. The published C# conversion follows the source-only baseline, so the original implementation remains recoverable from Git history.

All 26 forms and their designers were converted to C#. The application remains WinForms on .NET Framework 4.8.1 with the same namespace, assembly name/version, layouts, text, embedded assets, question-file format, and host/player flow. The C# executable has no direct Microsoft.VisualBasic assembly reference.

The replacement explicitly implements lazy form instances and recreation after disposal, all-forms-close application lifetime, shared audio playback, and midpoint-to-even numeric conversion. The unused empty settings definition was removed. A resource that referenced a personal OneDrive directory was copied into the repository so builds are self-contained.

## Verification before removal

Each suite executed against the separately built VB and C# applications on an STA thread, using real forms, event handlers, checkboxes, buttons, and native file dialogs. Normal timer delivery was stopped between checkpoints; timer boundaries were driven deterministically.

File-import automation selects the legacy native dialog style only inside the test runner to obtain stable control IDs. Production retains its existing file-dialog style.

| Suite | Coverage | Result |
| --- | --- | --- |
| Core | All 26 form designs; all 15 questions and four answer choices; correct/wrong results; timeout boundaries; passing, friend and double-dip lifelines; money trees; prizes; complete opening-to-winnings game | 467 checkpoints, exact baseline match |
| Extended | Audience dialogs/results/resume on Q11–Q15; computer choices; all six remaining-player counts; seven final prizes | 38 checks, exact baseline match; random choices checked for valid answers rather than identical randomness |
| Imports | Topic file and all 15 question files selected through native dialogs; expected opening/player windows and imported contents | Passed, exact baseline match |
| Edges | Seconds/tenths boundaries; double-dip first-correct and second-correct paths; animated money-tree presentation; second-chance presentation | 112 checkpoints, exact baseline match |
| Safety | Short/missing files, invalid/negative/overflowing counts, invalid correct-answer text, midpoint rounding, cancelled voting, zero-vote results | 11 checks passed in each C# core/extended run |
| Executable | Standalone startup and closing the startup window, including application message-loop shutdown | Both implementations passed |

The complete recorded normal-behavior output matched byte-for-byte in all four comparison suites. Baselines are retained as compressed text, with the original revision and SHA-256 hashes in `Baselines/metadata.json`; no original executable is shipped.

The Q06 host-screen render matched pixel-for-pixel. Its reference image is `Baselines/question06.png`. All embedded resource containers also matched their baseline hashes. A source audit before removal verified the ordered resource/mode pairs for **254 audio cues**, **219 event bindings**, and **22 array declarations**. Playback paths were exercised during UI tests; this was not a separate subjective audio-listening review.

## Intentional safety differences

- Invalid or inaccessible game files display a warning and keep the current file-selection step active. Valid files retain their original interpretation. File reads no longer leave an unused open stream behind.
- Audience inputs accept nonnegative integer counts, capped at `Int32.MaxValue / 4` so summing four choices cannot overflow. Cancelling a vote input contributes zero for that choice.
- A poll with no votes displays zero percent for every answer instead of dividing by zero.
- The original abrupt termination statement is replaced by graceful application exit.

The verification runner also prevents indefinite hangs with a ten-minute per-process timeout. Earlier test-harness failures were resolved by following the existing ad-break transitions, supplying the correct remaining-question state for isolated audience tests, and waiting until native dialogs were visible before pressing Open. These did not require changes to normal gameplay.

## Final cutover

The solution now contains the C# application and C# verification runner. VB source/designer/project/application-generation files and obsolete tracked build/cache artifacts were removed only after the comparisons above passed. The original implementation remains recoverable from Git history.

Final clean-build verification: **passed**. The C#-only solution rebuilt successfully in Debug; the Release application and runner were then rebuilt and passed **641 automated checks** (478 core, 49 extended, 1 import, 112 edge, and 1 standalone launch/shutdown check). All four snapshot suites matched the saved baseline exactly after VB removal. Both builds report two existing unused-state-field warnings in Q15 (`topAmount` and `DDEnable`); there are no build errors. These fields were retained to keep the state comparison intact.

Run `Verification/Run.ps1 -Configuration Release` to reproduce the final verification. Temporary baseline executables, generated VB intermediates, and conversion scripts were removed after verification.

## Environment and limits

Validation used Windows, .NET Framework 4.8.1, a 1920×1080 primary display at 100% scaling, and English numeric formatting. Only one physical display was available: both host and player windows were exercised, but physical second-monitor placement was not tested. Snapshots include layout/font details, so different DPI, fonts, or locale can require investigation rather than blindly updating baselines.

These passing scenarios provide regression evidence; they do not prove that every possible input, device, timing sequence, or operating-system configuration is crash-free. No gameplay redesign or runtime upgrade was included.
