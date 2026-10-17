using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class EnterHost
    {
        public EnterHost()
        {
            InitializeComponent();
        }
        private int count = default(int);
        private void Transition_Click(object sender, EventArgs e)
        {
            var selection1 = count;
            if (selection1 == 0)
            {
                GameAudio.Play(Properties.Resources.contestentIntro, AudioPlayMode.Background);
                Transition.Text = "First Player In";
            }
            else if (selection1 == 1)
            {
                GameAudio.Play(Properties.Resources.Next_Player_In, AudioPlayMode.Background);
                Transition.Text = "Show Level 1 Money Tree";
            }
            else if (selection1 == 2)
            {
                Forms.Level1MoneyTree.Show();
                Forms.PlayerScreen.ShowLogo.Visible = false;
                Close();
            }
            count += 1;
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
