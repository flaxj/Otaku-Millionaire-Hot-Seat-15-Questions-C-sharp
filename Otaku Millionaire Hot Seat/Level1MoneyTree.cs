using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class Level1MoneyTree
    {
        public Level1MoneyTree()
        {
            InitializeComponent();
        }
        internal string[] subjects = new string[16];
        internal int questionsAsked = 0;
        private int count = default(int);
        private int time = default(int);
        private void Level1MoneyTree_Load(object sender, EventArgs e)
        {
            Loadtopics();
        }
        public void Loadtopics()
        {
            Topic01.Text = subjects[0];
            Topic02.Text = subjects[1];
            Topic03.Text = subjects[2];
            Topic04.Text = subjects[3];
            Topic05.Text = subjects[4];
            Topic06.Text = subjects[5];
            Topic07.Text = subjects[6];
            Topic08.Text = subjects[7];
            Topic09.Text = subjects[8];
            Topic10.Text = subjects[9];
            Topic11.Text = subjects[10];
            Topic12.Text = subjects[11];
            Topic13.Text = subjects[12];
            Topic14.Text = subjects[13];
            Topic15.Text = subjects[14];
        }
        private void ShowMoneyTree_Click(object sender, EventArgs e)
        {
            var selection1 = count;
            if (selection1 == 0)
            {
                Values();
                Forms.PlayerScreen.Values();
                ShowMoneyTree.Text = "Start Money Tree";
            }
            else if (selection1 == 1)
            {
                BigColorTreeClock();
                ShowMoneyTree.Enabled = false;
            }
            else if (selection1 == 2)
            {
                ShowTopics();
                Forms.PlayerScreen.ShowTopics();
                ShowMoneyTree.Text = "Hide Topics";
            }
            else if (selection1 == 3)
            {
                HideTopics();
                Forms.PlayerScreen.HideTopics();
                Values();
                Forms.PlayerScreen.Values();
                Transition.Visible = true;
                ShowMoneyTree.Visible = false;
            }
            count += 1;
        }
        public void Values()
        {
            Money01.Visible = true;
            Money02.Visible = true;
            Money03.Visible = true;
            Money04.Visible = true;
            Money05.Visible = true;
            Money06.Visible = true;
            Money07.Visible = true;
            Money08.Visible = true;
            Money09.Visible = true;
            Money10.Visible = true;
            Money11.Visible = true;
            Money12.Visible = true;
            Money13.Visible = true;
            Money14.Visible = true;
            Money15.Visible = true;
        }
        public void BigColorTreeClock()
        {
            MoneyTreeClock.Start();
        }
        private void MoneyTreeClock_Tick(object sender, EventArgs e)
        {
            time += 1;
            if (time == 31)
            {
                ResetMoneyTree();
                Forms.PlayerScreen.ResetMoneyTree();
            }
            else
            {
                BigColorTreeChange();
            }
        }
        public void BigColorTreeChange()
        {
            if (time == 1)
            {
                Money01.BackColor = Color.Green;
                Money01.ForeColor = Color.White;
                Forms.PlayerScreen.Money01.BackColor = Color.Green;
                Forms.PlayerScreen.Money01.ForeColor = Color.White;
            }
            else if (time == 2)
            {
                Money02.BackColor = Color.Green;
                Money02.ForeColor = Color.White;
                Forms.PlayerScreen.Money02.BackColor = Color.Green;
                Forms.PlayerScreen.Money02.ForeColor = Color.White;
            }
            else if (time == 3)
            {
                Money03.BackColor = Color.Green;
                Money03.ForeColor = Color.White;
                Forms.PlayerScreen.Money03.BackColor = Color.Green;
                Forms.PlayerScreen.Money03.ForeColor = Color.White;
            }
            else if (time == 4)
            {
                Money04.BackColor = Color.Green;
                Money04.ForeColor = Color.White;
                Forms.PlayerScreen.Money04.BackColor = Color.Green;
                Forms.PlayerScreen.Money04.ForeColor = Color.White;
            }
            else if (time == 5)
            {
                Money05.BackColor = Color.Green;
                Money05.ForeColor = Color.White;
                Forms.PlayerScreen.Money05.BackColor = Color.Green;
                Forms.PlayerScreen.Money05.ForeColor = Color.White;
            }
            else if (time == 6)
            {
                Money06.BackColor = Color.Green;
                Money06.ForeColor = Color.White;
                Forms.PlayerScreen.Money06.BackColor = Color.Green;
                Forms.PlayerScreen.Money06.ForeColor = Color.White;
            }
            else if (time == 7)
            {
                Money07.BackColor = Color.Green;
                Money07.ForeColor = Color.White;
                Forms.PlayerScreen.Money07.BackColor = Color.Green;
                Forms.PlayerScreen.Money07.ForeColor = Color.White;
            }
            else if (time == 8)
            {
                Money08.BackColor = Color.Green;
                Money08.ForeColor = Color.White;
                Forms.PlayerScreen.Money08.BackColor = Color.Green;
                Forms.PlayerScreen.Money08.ForeColor = Color.White;
            }
            else if (time == 9)
            {
                Money09.BackColor = Color.Green;
                Money09.ForeColor = Color.White;
                Forms.PlayerScreen.Money09.BackColor = Color.Green;
                Forms.PlayerScreen.Money09.ForeColor = Color.White;
            }
            else if (time == 10)
            {
                Money10.BackColor = Color.Green;
                Money10.ForeColor = Color.White;
                Forms.PlayerScreen.Money10.BackColor = Color.Green;
                Forms.PlayerScreen.Money10.ForeColor = Color.White;
            }
            else if (time == 11)
            {
                Money11.BackColor = Color.Green;
                Money11.ForeColor = Color.White;
                Forms.PlayerScreen.Money11.BackColor = Color.Green;
                Forms.PlayerScreen.Money11.ForeColor = Color.White;
            }
            else if (time == 12)
            {
                Money12.BackColor = Color.Green;
                Money12.ForeColor = Color.White;
                Forms.PlayerScreen.Money12.BackColor = Color.Green;
                Forms.PlayerScreen.Money12.ForeColor = Color.White;
            }
            else if (time == 13)
            {
                Money13.BackColor = Color.Green;
                Money13.ForeColor = Color.White;
                Forms.PlayerScreen.Money13.BackColor = Color.Green;
                Forms.PlayerScreen.Money13.ForeColor = Color.White;
            }
            else if (time == 14)
            {
                Money14.BackColor = Color.Green;
                Money14.ForeColor = Color.White;
                Forms.PlayerScreen.Money14.BackColor = Color.Green;
                Forms.PlayerScreen.Money14.ForeColor = Color.White;
            }
            else if (time == 15)
            {
                Money15.BackColor = Color.Green;
                Money15.ForeColor = Color.White;
                Forms.PlayerScreen.Money15.BackColor = Color.Green;
                Forms.PlayerScreen.Money15.ForeColor = Color.White;
            }
            else if (time == 16 | time == 18 | time == 20 | time == 22 | time == 24 | time == 26 | time == 28 | time == 30)
            {
                Money15.BackColor = Color.Orange;
                Money15.ForeColor = Color.Black;
                Forms.PlayerScreen.Money15.BackColor = Color.Orange;
                Forms.PlayerScreen.Money15.ForeColor = Color.Black;
            }
            else
            {
                Money15.BackColor = Color.Green;
                Money15.ForeColor = Color.White;
                Forms.PlayerScreen.Money15.BackColor = Color.Green;
                Forms.PlayerScreen.Money15.ForeColor = Color.White;
            }
        }
        public void ResetMoneyTree()
        {
            Money01.BackColor = DefaultBackColor;
            Money01.ForeColor = DefaultForeColor;
            Money02.BackColor = DefaultBackColor;
            Money02.ForeColor = DefaultForeColor;
            Money03.BackColor = DefaultBackColor;
            Money03.ForeColor = DefaultForeColor;
            Money04.BackColor = DefaultBackColor;
            Money04.ForeColor = DefaultForeColor;
            Money05.BackColor = DefaultBackColor;
            Money05.ForeColor = DefaultForeColor;
            Money06.BackColor = DefaultBackColor;
            Money06.ForeColor = DefaultForeColor;
            Money07.BackColor = DefaultBackColor;
            Money07.ForeColor = DefaultForeColor;
            Money08.BackColor = DefaultBackColor;
            Money08.ForeColor = DefaultForeColor;
            Money09.BackColor = DefaultBackColor;
            Money09.ForeColor = DefaultForeColor;
            Money10.BackColor = DefaultBackColor;
            Money10.ForeColor = DefaultForeColor;
            Money11.BackColor = DefaultBackColor;
            Money11.ForeColor = DefaultForeColor;
            Money12.BackColor = DefaultBackColor;
            Money12.ForeColor = DefaultForeColor;
            Money13.BackColor = DefaultBackColor;
            Money13.ForeColor = DefaultForeColor;
            Money14.BackColor = DefaultBackColor;
            Money14.ForeColor = DefaultForeColor;
            Money15.BackColor = DefaultBackColor;
            Money15.ForeColor = DefaultForeColor;
            if (time == 31)
            {
                MoneyTreeClock.Stop();
                ShowMoneyTree.Text = "Show Topics";
                ShowMoneyTree.Enabled = true;
            }
        }
        public void ShowTopics()
        {
            HideValue();
            Topic01.Visible = true;
            Topic02.Visible = true;
            Topic03.Visible = true;
            Topic04.Visible = true;
            Topic05.Visible = true;
            Topic06.Visible = true;
            Topic07.Visible = true;
            Topic08.Visible = true;
            Topic09.Visible = true;
            Topic10.Visible = true;
            Topic11.Visible = true;
            Topic12.Visible = true;
            Topic13.Visible = true;
            Topic14.Visible = true;
            Topic15.Visible = true;
        }
        public void HideValue()
        {
            Money01.Visible = false;
            Money02.Visible = false;
            Money03.Visible = false;
            Money04.Visible = false;
            Money05.Visible = false;
            Money06.Visible = false;
            Money07.Visible = false;
            Money08.Visible = false;
            Money09.Visible = false;
            Money10.Visible = false;
            Money11.Visible = false;
            Money12.Visible = false;
            Money13.Visible = false;
            Money14.Visible = false;
            Money15.Visible = false;
        }
        public void HideTopics()
        {
            Topic01.Visible = false;
            Topic02.Visible = false;
            Topic03.Visible = false;
            Topic04.Visible = false;
            Topic05.Visible = false;
            Topic06.Visible = false;
            Topic07.Visible = false;
            Topic08.Visible = false;
            Topic09.Visible = false;
            Topic10.Visible = false;
            Topic11.Visible = false;
            Topic12.Visible = false;
            Topic13.Visible = false;
            Topic14.Visible = false;
            Topic15.Visible = false;
        }
        private void Transition_Click(object sender, EventArgs e)
        {
            var selection2 = count;
            if (selection2 == 4)
            {
                PassPic.Visible = true;
                Forms.PlayerScreen.PassPic.Visible = true;
            }
            else if (selection2 == 5)
            {
                LevelTwoLifelines();
                Forms.PlayerScreen.LevelTwoLifelines();
            }
            else if (selection2 == 6)
            {
                AskFriendPic.Visible = true;
                Forms.PlayerScreen.AskFriendPic.Visible = true;
            }
            else if (selection2 == 7)
            {
                TrustPic.Visible = true;
                Forms.PlayerScreen.TrustPic.Visible = true;
            }
            else if (selection2 == 8)
            {
                DoubleDipPic.Visible = true;
                Forms.PlayerScreen.DoubleDipPic.Visible = true;
            }
            else if (selection2 == 9)
            {
                LevelThreeLifelines();
                Forms.PlayerScreen.LevelThreeLifelines();
            }
            else if (selection2 == 10)
            {
                PassPic.Visible = false;
                Forms.PlayerScreen.PassPic.Visible = false;
                AskPic.Visible = true;
                Forms.PlayerScreen.AskPic.Visible = true;
            }
            else if (selection2 == 11)
            {
                Money15.BackColor = Color.Gold;
                Forms.PlayerScreen.Money15.BackColor = Color.Gold;
            }
            else if (selection2 == 12)
            {
                AskFriendPic.Visible = false;
                AskPic.Visible = false;
                TrustPic.Visible = false;
                DoubleDipPic.Visible = false;
                Forms.PlayerScreen.DoubleDipPic.Visible = false;
                Forms.PlayerScreen.AskFriendPic.Visible = false;
                Forms.PlayerScreen.AskPic.Visible = false;
                Forms.PlayerScreen.TrustPic.Visible = false;
            }
            else if (selection2 == 13)
            {
                MainDetail1.Visible = true;
            }
            else if (selection2 == 14)
            {
                ResetMoneyTree();
                Forms.PlayerScreen.ResetMoneyTree();
                PassPic.Visible = true;
                Forms.PlayerScreen.PassPic.Visible = true;
                Level1Label.Visible = true;
                Level1Rules.Visible = true;
                Transition.Visible = false;
                StartGame.Visible = true;
            }
            count += 1;
        }
        public void LevelTwoLifelines()
        {
            Money06.BackColor = Color.Yellow;
            Money07.BackColor = Color.Yellow;
            Money08.BackColor = Color.Yellow;
            Money09.BackColor = Color.Yellow;
            Money10.BackColor = Color.Yellow;
            Money11.BackColor = Color.Yellow;
            Money12.BackColor = Color.Yellow;
            Money13.BackColor = Color.Yellow;
            Money14.BackColor = Color.Yellow;
            Money15.BackColor = Color.Yellow;
        }
        public void FirstFiveCorrect()
        {
            Money01.BackColor = Color.Green;
            Money01.ForeColor = Color.White;
            Money02.BackColor = Color.Green;
            Money02.ForeColor = Color.White;
            Money03.BackColor = Color.Green;
            Money03.ForeColor = Color.White;
            Money04.BackColor = Color.Green;
            Money04.ForeColor = Color.White;
            Money05.BackColor = Color.Green;
            Money05.ForeColor = Color.White;
        }
        public void LevelThreeLifelines()
        {
            Money11.BackColor = Color.Orange;
            Money12.BackColor = Color.Orange;
            Money13.BackColor = Color.Orange;
            Money14.BackColor = Color.Orange;
            Money15.BackColor = Color.Orange;
        }
        private void StartGame_Click(object sender, EventArgs e)
        {
            Forms.Q01.Show();
            Forms.PlayerScreen.StartandResumeGame();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
