using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class OpeningScreen
    {
        public OpeningScreen()
        {
            InitializeComponent();
        }
        private void OpeningScreen_Load(object sender, EventArgs e)
        {
            Forms.Welcome.Hide();
        }
        private void OpenTheme_Click(object sender, EventArgs e)
        {
            GameAudio.Play(Properties.Resources.OpeningTheme, AudioPlayMode.Background);
            Forms.EnterHost.Show();
            Close();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
