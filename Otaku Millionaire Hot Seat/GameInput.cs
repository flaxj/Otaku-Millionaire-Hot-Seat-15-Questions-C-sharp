using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Otaku_Millionaire_Hot_Seat
{
    internal static class GameInput
    {
        internal static string[] ReadTopics(string path)
        {
            var lines = File.ReadAllLines(path);
            if (lines.Length < 15) throw new FormatException("The topic file must contain at least 15 lines.");
            return lines;
        }

        internal static string[] ReadQuestion(string path)
        {
            var lines = File.ReadAllLines(path);
            if (lines.Length < 13) throw new FormatException("A question file must contain at least 13 lines.");
            if (Array.IndexOf(lines, lines[8], 4, 4) < 0)
                throw new FormatException("Line 9 must exactly match one of the four answer choices on lines 5–8.");
            for (int i = 9; i < 13; i++)
            {
                int count = Numbers.ToInteger(lines[i]);
                if (count < 0) throw new FormatException("Answer character counts on lines 10–13 cannot be negative.");
            }
            return lines;
        }

        internal static bool TryRead(IWin32Window owner, string path, bool topics, out string[] lines)
        {
            try { lines = topics ? ReadTopics(path) : ReadQuestion(path); return true; }
            catch (Exception error) when (error is IOException || error is UnauthorizedAccessException ||
                error is FormatException || error is OverflowException || error is ArgumentException ||
                error is System.Security.SecurityException || error is NotSupportedException)
            {
                lines = null;
                MessageBox.Show(owner, error.Message, "Cannot load game file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // A cancelled audience prompt is a zero vote, preventing the former conversion exception.
        internal static int ReadVotes(string prompt)
        {
            using (var dialog = new Form { Text = "Ask The Audience", ClientSize = new Size(370, 126),
                FormBorderStyle = FormBorderStyle.FixedDialog, MinimizeBox = false, MaximizeBox = false,
                StartPosition = FormStartPosition.CenterParent })
            using (var input = new NumericUpDown { Location = new Point(14, 45), Width = 340,
                Minimum = 0, Maximum = int.MaxValue / 4 })
            {
                var label = new Label { Text = prompt, AutoSize = true, Location = new Point(14, 15) };
                var ok = new Button { Text = "OK", Location = new Point(198, 84), DialogResult = DialogResult.OK };
                var cancel = new Button { Text = "Cancel", Location = new Point(279, 84), DialogResult = DialogResult.Cancel };
                dialog.Controls.AddRange(new Control[] { label, input, ok, cancel });
                dialog.AcceptButton = ok;
                dialog.CancelButton = cancel;
                return dialog.ShowDialog(Form.ActiveForm) == DialogResult.OK ? (int)input.Value : 0;
            }
        }
    }

    internal static class Numbers
    {
        // CInt rounds midpoint values to even and accepts culture-specific numeric text.
        internal static int ToInteger(string value)
        {
            return checked((int)Math.Round(double.Parse(value, NumberStyles.Float | NumberStyles.AllowThousands,
                CultureInfo.CurrentCulture), MidpointRounding.ToEven));
        }
    }
}
