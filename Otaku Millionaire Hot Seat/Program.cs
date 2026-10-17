using System;
using System.Linq;
using System.Windows.Forms;

namespace Otaku_Millionaire_Hot_Seat
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            using (var context = new GameApplicationContext())
                Application.Run(context);
            GameAudio.Stop();
        }
    }

    // The original application exits after all forms close, not when Welcome closes.
    internal sealed class GameApplicationContext : ApplicationContext
    {
        private readonly Timer lifetime = new Timer { Interval = 100 };
        internal GameApplicationContext()
        {
            Forms.Welcome.Show();
            lifetime.Tick += (sender, args) =>
            {
                if (Application.OpenForms.Count == 0) ExitThread();
            };
            lifetime.Start();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing) lifetime.Dispose();
            base.Dispose(disposing);
        }
    }
}
