using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

internal static class Program
{
    const BindingFlags Flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.IgnoreCase;
    const string Ns = "Otaku_Millionaire_Hot_Seat.";
    static Assembly assembly;
    static object registry;
    static Type registryType;
    static StreamWriter log;
    static string[] names;
    static int checks;
    static readonly System.Threading.Timer Watchdog = new System.Threading.Timer(_ =>
    {
        Console.Error.WriteLine("Verification exceeded ten minutes; a dialog or application may be stuck.");
        Environment.Exit(2);
    }, null, TimeSpan.FromMinutes(10), System.Threading.Timeout.InfiniteTimeSpan);

    [STAThread]
    static int Main(string[] args)
    {
        try
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            Application.SetCompatibleTextRenderingDefault(false);
            assembly = Assembly.LoadFrom(Path.GetFullPath(args[0]));
            registryType = assembly.GetType(Ns + "Forms");
            if (registryType == null)
            {
                registry = assembly.GetType(Ns + "My.MyProject").GetProperty("Forms", Flags).GetValue(null);
                registryType = registry.GetType();
            }
            names = assembly.GetTypes().Where(t => t.BaseType == typeof(Form)).Select(t => t.Name).OrderBy(n => n).ToArray();
            using (log = new StreamWriter(args[1]))
            {
                if (args.Contains("--extended"))
                {
                    TestWinnings();
                    TestAudience();
                    TestTrust();
                    TestElimination();
                    if (assembly.GetType(Ns + "GameInput") != null) TestSafety();
                }
                else if (args.Contains("--preview"))
                {
                    var f = StartQuestion(6);
                    Click(f, "MasterButton"); Click(f, "MasterButton");
                    using (var bitmap = new Bitmap(f.Width, f.Height))
                    {
                        f.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
                        bitmap.Save(args[1] + ".png");
                    }
                }
                else if (args.Contains("--imports")) TestImports();
                else if (args.Contains("--launch")) TestLaunch();
                else if (args.Contains("--edges")) TestEdges();
                else
                {
                TestResources();
                TestDesigners();
                for (int q = 1; q <= 15; q++)
                {
                    for (int answer = 0; answer < 4; answer++) TestQuestion(q, answer);
                    TestTimeout(q);
                    TestLifelines(q);
                    Console.WriteLine("Verified Q" + q.ToString("00"));
                }
                TestTrees();
                TestWinnings();
                TestFullGame();
                if (assembly.GetType(Ns + "GameInput") != null) TestSafety();
                }
            }
            Reset();
            Watchdog.Dispose();
            Console.WriteLine("PASS: " + checks + " checkpoints");
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
            return 1;
        }
    }

    static Form Form(string name) => (Form)registryType.GetProperty(name, Flags).GetValue(registry);
    static object Get(object target, string name)
    {
        var type = target.GetType();
        var field = type.GetField(name, Flags);
        return field != null ? field.GetValue(target) : type.GetProperty(name, Flags).GetValue(target);
    }
    static void Set(object target, string name, object value) => target.GetType().GetField(name, Flags).SetValue(target, value);
    static bool Has(object target, string name) => target.GetType().GetField(name, Flags) != null || target.GetType().GetProperty(name, Flags) != null;
    static void Invoke(object target, string method)
    {
        var m = target.GetType().GetMethod(method, Flags);
        try { m.Invoke(target, m.GetParameters().Length == 0 ? null : new object[] { target, EventArgs.Empty }); }
        catch (TargetInvocationException ex) { throw new Exception(target.GetType().Name + "." + method, ex.InnerException); }
        StopTimers();
    }
    static void Click(object target, string control)
    {
        var button = Get(target, control) as Button;
        if (button == null || !button.Enabled || !button.Visible) throw new Exception("Cannot click " + control);
        button.PerformClick();
        StopTimers();
    }
    static void StopTimers()
    {
        foreach (Form f in Application.OpenForms)
            foreach (var field in f.GetType().GetFields(Flags))
                if (field.GetValue(f) is Timer timer) timer.Stop();
    }
    static void Reset()
    {
        foreach (var n in names) Form(n).Dispose();
        Application.DoEvents();
    }
    static void Seed()
    {
        Reset();
        string[] topics = Enumerable.Range(1, 15).Select(i => "Topic " + i).ToArray();
        foreach (var n in new[] { "PlayerScreen", "Level1MoneyTree", "Level2MoneyTree", "Level3MoneyTree", "Level4MoneyTree" })
            Set(Form(n), "subjects", topics);
        for (int i = 1; i <= 15; i++)
            Set(Form("Q" + i.ToString("00")), "Q" + i + "GamePlay", new[] { "Topic " + i, "Question " + i, "Second line", "Third line", "Alpha", "Beta", "Gamma", "Delta", "Alpha", "5", "4", "5", "5" });
    }
    static Form StartQuestion(int q)
    {
        Seed();
        var f = Form("Q" + q.ToString("00"));
        // Later questions copy state from their predecessor during Load.
        for (int i = 1; i <= 15; i++)
        {
            var prior = Form("Q" + i.ToString("00"));
            Set(prior, "GPlayersRemaining", 6);
            Set(prior, "GPlayerNumber", 1);
        }
        Form("PlayerScreen").Show();
        f.Show();
        StopTimers();
        return f;
    }
    static void Snapshot(string label, params Form[] forms)
    {
        log.WriteLine("## " + label);
        foreach (var f in forms)
        {
            log.WriteLine(f.GetType().Name + "|" + f.Visible + "|" + f.IsDisposed);
            if (f.IsDisposed) continue;
            foreach (var c in Controls(f).OrderBy(c => c.Name))
                log.WriteLine(c.Name + "|" + c.Text.Replace("\r", "\\r").Replace("\n", "\\n") + "|" + c.Visible + "|" + c.Enabled + "|" + c.Bounds + "|" + c.ForeColor.ToArgb() + "|" + c.BackColor.ToArgb() + "|" + c.Font + "|" + (c is CheckBox cb ? cb.Checked.ToString() : ""));
            foreach (var field in f.GetType().GetFields(Flags).OrderBy(x => x.Name))
                if (field.FieldType == typeof(int) || field.FieldType == typeof(string))
                    log.WriteLine("state:" + field.Name.ToLowerInvariant() + "=" + field.GetValue(f));
        }
        checks++;
    }
    static IEnumerable<Control> Controls(Control parent)
    {
        foreach (Control c in parent.Controls) { yield return c; foreach (var d in Controls(c)) yield return d; }
    }
    static void TestDesigners()
    {
        Seed();
        foreach (var n in names)
        {
            var f = Form(n);
            Snapshot("designer/" + n, f);
            using (var bitmap = new Bitmap(f.Width, f.Height)) f.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
        }
        var old = Form("AboutBox"); old.Show(); old.Close();
        if (ReferenceEquals(old, Form("AboutBox")) || Form("AboutBox").IsDisposed) throw new Exception("Disposed form was reused");
    }
    static void TestQuestion(int q, int answer)
    {
        var f = StartQuestion(q);
        Snapshot(q + "/" + answer + "/loaded", f, Form("PlayerScreen"));
        Click(f, "MasterButton"); Click(f, "MasterButton");
        ((CheckBox)Get(f, "Choice" + (char)('A' + answer))).Checked = true;
        StopTimers();
        Snapshot(q + "/" + answer + "/selected", f, Form("PlayerScreen"));
        Click(f, "MasterButton");
        Snapshot(q + "/" + answer + "/result", f, Form("PlayerScreen"));
    }
    static void TestTimeout(int q)
    {
        var f = StartQuestion(q);
        Click(f, "MasterButton"); Click(f, "MasterButton");
        foreach (int seconds in new[] { 45, 30, 15, 10, 5, 1, 0 })
        {
            Set(f, "TimeSeconds", seconds); Set(f, "TimeTenths", 0);
            Invoke(f, "TenthsClock_Tick");
            Snapshot(q + "/timeout/" + seconds, f, Form("PlayerScreen"));
        }
    }
    static void TestLifelines(int q)
    {
        foreach (var lifeline in new[] { "PassPic", "AskFriendPic", "DoubleDipPic" })
        {
            var f = StartQuestion(q);
            if (!Has(f, lifeline)) continue;
            Click(f, "MasterButton"); Click(f, "MasterButton");
            Invoke(f, lifeline + "_Click");
            Snapshot(q + "/" + lifeline + "/start", f, Form("PlayerScreen"));
            if (lifeline == "DoubleDipPic")
            {
                ((CheckBox)Get(f, "ChoiceB")).Checked = true;
                Invoke(f, lifeline + "_Click");
                Snapshot(q + "/double/wrong", f, Form("PlayerScreen"));
            }
            Invoke(f, lifeline + "_Click");
            Snapshot(q + "/" + lifeline + "/resume", f, Form("PlayerScreen"));
        }
    }
    static void TestTrees()
    {
        foreach (var n in names.Where(n => n.StartsWith("Level")))
        {
            Seed(); Form("PlayerScreen").Show(); var f = Form(n); f.Show(); StopTimers();
            for (int i = 0; i < 16; i++)
            {
                Invoke(f, "Transition_Click"); Snapshot(n + "/" + i, f, Form("PlayerScreen"));
            }
        }
    }
    static void TestWinnings()
    {
        foreach (string prize in new[] { "¥1,000,000", "¥250,000", "¥100,000", "¥50,000", "¥20,000", "¥10,000", "¥1,000" })
        {
            Seed(); ((Control)Get(Form("Q15"), "WonSoFar")).Text = prize;
            Form("PlayerScreen").Show(); var f = Form("Winnings"); Set(f, "question", 15); f.Show(); StopTimers();
            Snapshot("winnings/" + prize, f, Form("PlayerScreen"));
        }
    }
    static void TestFullGame()
    {
        Seed(); Form("Welcome").Show(); Form("PlayerScreen").Show(); Form("OpeningScreen").Show();
        Click(Form("OpeningScreen"), "OpenTheme");
        for (int i = 0; i < 3; i++) Click(Form("EnterHost"), "Transition");
        Invoke(Form("Level1MoneyTree"), "StartGame_Click");
        for (int q = 1; q <= 15; q++)
        {
            var f = Form("Q" + q.ToString("00"));
            if (!f.Visible) throw new Exception("Full game failed to reach " + f.Name);
            Click(f, "MasterButton"); Click(f, "MasterButton");
            ((CheckBox)Get(f, "ChoiceA")).Checked = true;
            Click(f, "MasterButton");
            bool reached = false;
            for (int step = 0; step < 8; step++)
            {
                if (q == 15 ? Form("Winnings").Visible : Form("Q" + (q + 1).ToString("00")).Visible)
                { reached = true; break; }
                var tree = new[] { "Level2MoneyTree", "Level3MoneyTree", "Level4MoneyTree" }.Select(Form).FirstOrDefault(t => t.Visible);
                if (tree != null) Invoke(tree, "ResumeGame_Click");
                else Click(f, "MasterButton");
            }
            if (!reached) throw new Exception("Navigation stalled after question " + q);
            Snapshot("full/" + q, Form("PlayerScreen"));
        }
        if (!Form("Winnings").Visible) throw new Exception("Full game did not reach winnings");
    }
    static void TestResources()
    {
        foreach (var name in assembly.GetManifestResourceNames().OrderBy(n => n))
            using (var stream = assembly.GetManifestResourceStream(name))
            using (var sha = SHA256.Create()) log.WriteLine("resource:" + name + "=" + Convert.ToBase64String(sha.ComputeHash(stream)));
    }
    static Timer AnswerDialogs(bool cancel = false)
    {
        var timer = new Timer { Interval = 20 };
        timer.Tick += (s, e) =>
        {
            var dialog = Application.OpenForms.Cast<Form>().LastOrDefault(f => f.Text == "Ask The Audience");
            if (dialog == null) return;
            foreach (var input in Controls(dialog).OfType<TextBox>()) input.Text = "10";
            foreach (var input in Controls(dialog).OfType<NumericUpDown>()) input.Value = 10;
            var button = Controls(dialog).OfType<Button>().FirstOrDefault(b => b.DialogResult == (cancel ? DialogResult.Cancel : DialogResult.OK)
                || b.Text.Replace("&", "").Equals(cancel ? "Cancel" : "OK", StringComparison.OrdinalIgnoreCase));
            if (button != null) button.PerformClick();
        };
        timer.Start();
        return timer;
    }
    static void TestAudience()
    {
        for (int q = 11; q <= 15; q++)
        {
            var f = StartQuestion(q);
            Set(f, "questionsRemaining", 16 - q);
            Click(f, "MasterButton"); Click(f, "MasterButton");
            using (var dialogs = AnswerDialogs()) Invoke(f, "AskPic_Click");
            Snapshot(q + "/audience", f, Form("AskResult"), Form("PlayerScreen"));
            Click(Form("AskResult"), "CloseAndRestart");
            Snapshot(q + "/audience/resume", f, Form("PlayerScreen"));
            Console.WriteLine("Verified audience Q" + q);
        }
    }
    static void TestTrust()
    {
        for (int q = 6; q <= 14; q++)
        {
            var f = StartQuestion(q);
            Click(f, "MasterButton"); Click(f, "MasterButton");
            Invoke(f, "TrustPic_Click");
            var choice = (string)Get(f, "choice");
            if (!new[] { "Alpha", "Beta", "Gamma", "Delta" }.Contains(choice)) throw new Exception("Invalid random answer");
            log.WriteLine("trust/" + q + "/valid-choice"); checks++;
        }
    }
    static void TestElimination()
    {
        for (int players = 1; players <= 6; players++)
        {
            var f = StartQuestion(10);
            Set(f, "GPlayersRemaining", players); Set(Form("PlayerScreen"), "Players", players);
            Click(f, "MasterButton"); Click(f, "MasterButton");
            ((CheckBox)Get(f, "ChoiceB")).Checked = true;
            Click(f, "MasterButton");
            Snapshot("elimination/" + players, f, Form("PlayerScreen"));
            // Exercise the follow-up navigation, including the final player path.
            Click(f, "MasterButton");
            Snapshot("elimination/" + players + "/next", Form("PlayerScreen"));
        }
    }
    static void TestSafety()
    {
        var input = assembly.GetType(Ns + "GameInput");
        var path = Path.GetTempFileName();
        try
        {
            File.WriteAllText(path, "short");
            foreach (string method in new[] { "ReadTopics", "ReadQuestion" })
            {
                try { input.GetMethod(method, Flags).Invoke(null, new object[] { path }); throw new Exception("Accepted short file"); }
                catch (TargetInvocationException ex) when (ex.InnerException is FormatException) { checks++; }
            }
            string[] valid = { "Topic", "Question", "", "", "A", "B", "C", "D", "A", "1", "1", "1", "1" };
            File.WriteAllLines(path, valid);
            input.GetMethod("ReadQuestion", Flags).Invoke(null, new object[] { path }); checks++;
            foreach (var invalid in new[] { "bad", "-1", "9999999999999999999999" })
            {
                valid[9] = invalid; File.WriteAllLines(path, valid);
                try { input.GetMethod("ReadQuestion", Flags).Invoke(null, new object[] { path }); throw new Exception("Accepted invalid count"); }
                catch (TargetInvocationException ex) when (ex.InnerException is FormatException || ex.InnerException is OverflowException) { checks++; }
            }
            valid[9] = "1"; valid[8] = "not an answer"; File.WriteAllLines(path, valid);
            try { input.GetMethod("ReadQuestion", Flags).Invoke(null, new object[] { path }); throw new Exception("Accepted invalid answer"); }
            catch (TargetInvocationException ex) when (ex.InnerException is FormatException) { checks++; }
            File.Delete(path);
            try { input.GetMethod("ReadQuestion", Flags).Invoke(null, new object[] { path }); throw new Exception("Accepted missing file"); }
            catch (TargetInvocationException ex) when (ex.InnerException is IOException) { checks++; }
            var numbers = assembly.GetType(Ns + "Numbers").GetMethod("ToInteger", Flags);
            if ((int)numbers.Invoke(null, new object[] { "2.5" }) != 2 || (int)numbers.Invoke(null, new object[] { "3.5" }) != 4)
                throw new Exception("Midpoint rounding changed");
            checks++;
            using (var dialogs = AnswerDialogs(true))
                if ((int)input.GetMethod("ReadVotes", Flags).Invoke(null, new object[] { "Cancellation test" }) != 0)
                    throw new Exception("Cancel did not return zero");
            checks++;
            var f = StartQuestion(11);
            Set(f, "AskSum", 0);
            var result = Form("AskResult"); Set(result, "questionsRemaining", 5); result.Show(); StopTimers();
            if ((int)Get(result, "AskA") != 0) throw new Exception("Zero votes should yield zero percent");
            checks++;
        }
        finally { File.Delete(path); }
    }

    private delegate bool WindowCallback(IntPtr window, IntPtr parameter);
    [DllImport("user32.dll")] static extern bool EnumThreadWindows(uint thread, WindowCallback callback, IntPtr parameter);
    [DllImport("user32.dll")] static extern bool EnumWindows(WindowCallback callback, IntPtr parameter);
    [DllImport("user32.dll")] static extern uint GetWindowThreadProcessId(IntPtr window, out uint processId);
    [DllImport("kernel32.dll")] static extern uint GetCurrentThreadId();
    [DllImport("user32.dll", CharSet = CharSet.Unicode)] static extern int GetWindowText(IntPtr window, StringBuilder text, int capacity);
    [DllImport("user32.dll")] static extern IntPtr GetDlgItem(IntPtr window, int id);
    [DllImport("user32.dll")] static extern bool IsWindowVisible(IntPtr window);
    [DllImport("user32.dll")] static extern bool PostMessage(IntPtr window, uint message, IntPtr wparam, IntPtr lparam);

    static void TestImports()
    {
        Seed();
        var welcome = Form("Welcome"); welcome.Show();
        var fixtures = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Fixtures"));
        foreach (var name in Enumerable.Range(1, 15).Select(q => "Question" + q.ToString("00")).Concat(new[] { "TopicFile" }))
        {
            var dialog = (OpenFileDialog)Get(welcome, name);
            dialog.AutoUpgradeEnabled = false; // Deterministic native dialog control IDs for UI automation.
            dialog.FileName = Path.Combine(fixtures, name == "TopicFile" ? "Topics.txt" : "Q" + name.Substring(8) + ".txt");
        }
        int accepted = 0;
        var thread = GetCurrentThreadId();
        var seen = new HashSet<IntPtr>();
        using (var timer = new Timer { Interval = 100 })
        {
            timer.Tick += (s, e) => EnumThreadWindows(thread, (window, p) =>
            {
                var title = new StringBuilder(256); GetWindowText(window, title, title.Capacity);
                if ((title.ToString() == "Topic File" || title.ToString().StartsWith("Question ")) && title.ToString().EndsWith("File")
                    && IsWindowVisible(window) && GetDlgItem(window, 1) != IntPtr.Zero && seen.Add(window))
                {
                    PostMessage(GetDlgItem(window, 1), 0x00F5, IntPtr.Zero, IntPtr.Zero); // BM_CLICK on Open.
                    accepted++;
                    Console.WriteLine("Opening " + title);
                }
                return true;
            }, IntPtr.Zero);
            timer.Start();
            Click(welcome, "StartButton2Screen");
        }
        if (accepted != 16 || !Form("OpeningScreen").Visible || !Form("PlayerScreen").Visible)
            throw new Exception("File import did not reach opening screen: " + accepted);
        Snapshot("imports/complete", Form("PlayerScreen"), Form("OpeningScreen"));
        for (int q = 1; q <= 15; q++)
        {
            string[] data = (string[])Get(Form("Q" + q.ToString("00")), "Q" + q + "GamePlay");
            if (data[1] != "Question " + q) throw new Exception("Wrong imported question " + q);
        }
        Console.WriteLine("Imported all 16 files through the native dialogs");
    }

    static void TestLaunch()
    {
        if (assembly.GetType(Ns + "GameInput") != null && assembly.GetReferencedAssemblies().Any(a => a.Name == "Microsoft.VisualBasic"))
            throw new Exception("C# executable depends on the VB runtime");
        string title = Form("Welcome").Text;
        using (var process = System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(assembly.Location)
            { UseShellExecute = true, WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden }))
        {
            try
            {
                if (!process.WaitForInputIdle(15000)) throw new Exception("Startup did not become idle");
                var clock = System.Diagnostics.Stopwatch.StartNew();
                IntPtr main = IntPtr.Zero;
                while (main == IntPtr.Zero && clock.ElapsedMilliseconds < 15000 && !process.HasExited)
                {
                    EnumWindows((window, p) =>
                    {
                        uint pid; GetWindowThreadProcessId(window, out pid);
                        if (pid != process.Id) return true;
                        var text = new StringBuilder(256); GetWindowText(window, text, text.Capacity);
                        if (text.ToString() == title) main = window;
                        return true;
                    }, IntPtr.Zero);
                    System.Threading.Thread.Sleep(50);
                }
                if (main == IntPtr.Zero) throw new Exception("Startup form not found");
                PostMessage(main, 0x0010, IntPtr.Zero, IntPtr.Zero); // WM_CLOSE, including hidden startup windows.
                if (!process.WaitForExit(15000) || process.ExitCode != 0) throw new Exception("Application did not shut down cleanly");
                checks++;
                Console.WriteLine("Executable startup and clean shutdown passed");
            }
            finally { if (!process.HasExited) process.Kill(); }
        }
    }

    static void TestEdges()
    {
        for (int q = 1; q <= 15; q++)
        {
            var f = StartQuestion(q);
            Click(f, "MasterButton"); Click(f, "MasterButton");
            foreach (int seconds in new[] { 45, 30, 15, 10, 5, 1 })
            {
                Set(f, "TimeSeconds", seconds); Set(f, "TimeTenths", 5);
                Invoke(f, "SecondsClock_Tick"); Invoke(f, "TenthsClock_Tick");
                Snapshot(q + "/second-tick/" + seconds, f, Form("PlayerScreen"));
            }
        }
        for (int q = 6; q <= 15; q++)
            foreach (bool wrongFirst in new[] { false, true })
            {
                var f = StartQuestion(q);
                Click(f, "MasterButton"); Click(f, "MasterButton");
                Invoke(f, "DoubleDipPic_Click");
                ((CheckBox)Get(f, wrongFirst ? "ChoiceB" : "ChoiceA")).Checked = true;
                Invoke(f, "DoubleDipPic_Click");
                if (wrongFirst)
                {
                    Invoke(f, "DoubleDipPic_Click");
                    ((CheckBox)Get(f, "ChoiceA")).Checked = true;
                    Click(f, "MasterButton");
                }
                Snapshot(q + "/double-dip/correct/" + wrongFirst, f, Form("PlayerScreen"));
            }
        Seed(); Form("PlayerScreen").Show();
        var first = Form("Level1MoneyTree"); first.Show();
        Invoke(first, "ShowMoneyTree_Click"); Invoke(first, "ShowMoneyTree_Click");
        for (int tick = 0; tick < 40; tick++) Invoke(first, "MoneyTreeClock_Tick");
        Invoke(first, "ShowMoneyTree_Click"); Invoke(first, "ShowMoneyTree_Click");
        Snapshot("money-tree/presentation", first, Form("PlayerScreen"));
        Seed(); Form("PlayerScreen").Show(); var last = Form("Level4MoneyTree"); last.Show();
        Invoke(last, "btnSecondChance_Click");
        Snapshot("second-chance", last, Form("PlayerScreen"));
    }
}
