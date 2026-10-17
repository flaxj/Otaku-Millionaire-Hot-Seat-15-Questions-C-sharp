using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class Winnings
    {
        public Winnings()
        {
            InitializeComponent();
        }
        private string winnings = default(string);
        internal int question = default(int);
        private void Winnings_Load(object sender, EventArgs e)
        {
            if (question == 15)
            {
                if (Forms.Q15.TopPrizeAmount.BackColor == Color.Green)
                {
                    winnings = Forms.Q15.TopPrizeAmount.Text;
                }
                else
                {
                    winnings = Forms.Q15.WonSoFar.Text;
                }
                var selection1 = winnings;
                if (selection1 == "¥1,000,000")
                {
                    AmountWon.Text = "¥1,000,000";
                    Forms.PlayerScreen.AmountWon.Text = "¥1,000,000";
                    Forms.PlayerScreen.EndShowLogo.Visible = true;
                    Forms.PlayerScreen.AmountWon.Visible = true;
                    Forms.PlayerScreen.EndOfGame();
                }
                else if (selection1 == "¥250,000")
                {
                    AmountWon.Text = "¥250,000";
                    Forms.PlayerScreen.AmountWon.Text = "¥250,000";
                    Forms.PlayerScreen.EndShowLogo.Visible = true;
                    Forms.PlayerScreen.AmountWon.Visible = true;
                    Forms.PlayerScreen.EndOfGame();
                }
                else if (selection1 == "¥100,000")
                {
                    AmountWon.Text = "¥100,000";
                    Forms.PlayerScreen.AmountWon.Text = "¥100,000";
                    Forms.PlayerScreen.EndShowLogo.Visible = true;
                    Forms.PlayerScreen.AmountWon.Visible = true;
                    Forms.PlayerScreen.EndOfGame();
                }
                else if (selection1 == "¥50,000")
                {
                    AmountWon.Text = "¥50,000";
                    Forms.PlayerScreen.AmountWon.Text = "¥50,000";
                    Forms.PlayerScreen.EndShowLogo.Visible = true;
                    Forms.PlayerScreen.AmountWon.Visible = true;
                    Forms.PlayerScreen.EndOfGame();
                }
                else if (selection1 == "¥20,000")
                {
                    AmountWon.Text = "¥20,000";
                    Forms.PlayerScreen.AmountWon.Text = "¥20,000";
                    Forms.PlayerScreen.EndShowLogo.Visible = true;
                    Forms.PlayerScreen.AmountWon.Visible = true;
                    Forms.PlayerScreen.EndOfGame();
                }
                else if (selection1 == "¥10,000")
                {
                    AmountWon.Text = "¥10,000";
                    Forms.PlayerScreen.AmountWon.Text = "¥10,000";
                    Forms.PlayerScreen.EndShowLogo.Visible = true;
                    Forms.PlayerScreen.AmountWon.Visible = true;
                    Forms.PlayerScreen.EndOfGame();
                }
                else if (selection1 == "¥1,000")
                {
                    AmountWon.Text = "¥1,000";
                    Forms.PlayerScreen.AmountWon.Text = "¥1,000";
                    Forms.PlayerScreen.EndShowLogo.Visible = true;
                    Forms.PlayerScreen.AmountWon.Visible = true;
                    Forms.PlayerScreen.EndOfGame();
                }
                Forms.Q15.Close();
            }
            else
            {
                if (question > 10 & question < 15)
                {
                    AmountWon.Text = "¥1,000";
                    Forms.PlayerScreen.AmountWon.Text = "¥1,000";
                    Forms.PlayerScreen.EndShowLogo.Visible = true;
                    Forms.PlayerScreen.AmountWon.Visible = true;
                    Forms.PlayerScreen.EndOfGame();
                    Forms.Q14.Close();
                    Forms.Q13.Close();
                    Forms.Q12.Close();
                    Forms.Q11.Close();
                }
                else
                {
                    Forms.PlayerScreen.EndShowLogo.Visible = true;
                    Forms.PlayerScreen.AmountWon.Visible = true;
                    Forms.PlayerScreen.EndOfGame();
                    Forms.Q10.Close();
                    Forms.Q09.Close();
                    Forms.Q08.Close();
                    Forms.Q07.Close();
                    Forms.Q06.Close();
                }
            }
            GameAudio.Play(Properties.Resources.End_of_Game, AudioPlayMode.BackgroundLoop);
        }
        private void EndGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AboutBox.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
