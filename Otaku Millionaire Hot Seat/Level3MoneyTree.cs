using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class Level3MoneyTree
    {
        public Level3MoneyTree()
        {
            InitializeComponent();
        }
        internal string[] subjects = new string[16];
        internal int GPlayersRemaining = default(int);
        internal int passUsage = default(int);
        internal int AskFriendCount = default(int);
        internal int AskCount = default(int);
        internal int DoubleDipCount = default(int);
        internal int trust = default(int);
        private int count = default(int);
        private void Level3MoneyTree_Load(object sender, EventArgs e)
        {
            GPlayersRemaining = Forms.Q10.GPlayersRemaining;
            passUsage = Forms.Q10.passUsage;
            AskFriendCount = Forms.Q10.AskFriendCount;
            DoubleDipCount = Forms.Q10.DoubleDipCount;
            trust = Forms.Q10.Trust;
            Loadtopics();
            Values();
            LifelineUsed();
            GameAudio.Play(Properties.Resources.Battle_Royle_Intro, AudioPlayMode.BackgroundLoop);
            Forms.Q10.Hide();
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
        public void LifelineUsed()
        {
            Forms.PlayerScreen.PassPic.Visible = false;
            if (AskFriendCount == 1)
            {
                AskFriendPic.Visible = false;
                Forms.PlayerScreen.AskFriendPic.Visible = false;
            }
            if (DoubleDipCount == 1)
            {
                DoubleDipPic.Visible = false;
                Forms.PlayerScreen.DoubleDipPic.Visible = false;
            }
            if (trust == 1)
            {
                TrustPic.Visible = false;
                Forms.PlayerScreen.TrustPic.Visible = false;
            }
        }
        private void ShowMoneyTree_Click(object sender, EventArgs e)
        {
            var selection1 = count;
            if (selection1 == 0)
            {
                ShowTopics();
                Forms.PlayerScreen.ShowTopics();
                ShowMoneyTree.Text = "Hide Topics";
            }
            else if (selection1 == 1)
            {
                HideTopics();
                Forms.PlayerScreen.HideTopics();
                Values();
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
            Forms.PlayerScreen.Values();
            if (GPlayersRemaining == 6)
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
                Money06.BackColor = Color.Green;
                Money06.ForeColor = Color.White;
                Money07.BackColor = Color.Green;
                Money07.ForeColor = Color.White;
                Money08.BackColor = Color.Green;
                Money08.ForeColor = Color.White;
                Money09.BackColor = Color.Green;
                Money09.ForeColor = Color.White;
                Money10.BackColor = Color.Green;
                Money10.ForeColor = Color.White;
                Forms.PlayerScreen.Money01.BackColor = Color.Green;
                Forms.PlayerScreen.Money01.ForeColor = Color.White;
                Forms.PlayerScreen.Money02.BackColor = Color.Green;
                Forms.PlayerScreen.Money02.ForeColor = Color.White;
                Forms.PlayerScreen.Money03.BackColor = Color.Green;
                Forms.PlayerScreen.Money03.ForeColor = Color.White;
                Forms.PlayerScreen.Money04.BackColor = Color.Green;
                Forms.PlayerScreen.Money04.ForeColor = Color.White;
                Forms.PlayerScreen.Money05.BackColor = Color.Green;
                Forms.PlayerScreen.Money05.ForeColor = Color.White;
                Forms.PlayerScreen.Money06.BackColor = Color.Green;
                Forms.PlayerScreen.Money06.ForeColor = Color.White;
                Forms.PlayerScreen.Money07.BackColor = Color.Green;
                Forms.PlayerScreen.Money07.ForeColor = Color.White;
                Forms.PlayerScreen.Money08.BackColor = Color.Green;
                Forms.PlayerScreen.Money08.ForeColor = Color.White;
                Forms.PlayerScreen.Money09.BackColor = Color.Green;
                Forms.PlayerScreen.Money09.ForeColor = Color.White;
                Forms.PlayerScreen.Money10.BackColor = Color.Green;
                Forms.PlayerScreen.Money10.ForeColor = Color.White;
            }
            else if (GPlayersRemaining == 5)
            {
                Money15.Visible = false;
                Forms.PlayerScreen.Money15.Visible = false;
                Money14.BackColor = Color.Gold;
                Forms.PlayerScreen.Money14.BackColor = Color.Gold;
                Money14.ForeColor = Color.White;
                Forms.PlayerScreen.Money14.ForeColor = Color.White;
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
                Money06.BackColor = Color.Green;
                Money06.ForeColor = Color.White;
                Money07.BackColor = Color.Green;
                Money07.ForeColor = Color.White;
                Money08.BackColor = Color.Green;
                Money08.ForeColor = Color.White;
                Money09.BackColor = Color.Green;
                Money09.ForeColor = Color.White;
                Forms.PlayerScreen.Money01.BackColor = Color.Green;
                Forms.PlayerScreen.Money01.ForeColor = Color.White;
                Forms.PlayerScreen.Money02.BackColor = Color.Green;
                Forms.PlayerScreen.Money02.ForeColor = Color.White;
                Forms.PlayerScreen.Money03.BackColor = Color.Green;
                Forms.PlayerScreen.Money03.ForeColor = Color.White;
                Forms.PlayerScreen.Money04.BackColor = Color.Green;
                Forms.PlayerScreen.Money04.ForeColor = Color.White;
                Forms.PlayerScreen.Money05.BackColor = Color.Green;
                Forms.PlayerScreen.Money05.ForeColor = Color.White;
                Forms.PlayerScreen.Money06.BackColor = Color.Green;
                Forms.PlayerScreen.Money06.ForeColor = Color.White;
                Forms.PlayerScreen.Money07.BackColor = Color.Green;
                Forms.PlayerScreen.Money07.ForeColor = Color.White;
                Forms.PlayerScreen.Money08.BackColor = Color.Green;
                Forms.PlayerScreen.Money08.ForeColor = Color.White;
                Forms.PlayerScreen.Money09.BackColor = Color.Green;
                Forms.PlayerScreen.Money09.ForeColor = Color.White;
            }
            else if (GPlayersRemaining == 4)
            {
                Money15.Visible = false;
                Money14.Visible = false;
                Forms.PlayerScreen.Money15.Visible = false;
                Forms.PlayerScreen.Money14.Visible = false;
                Money13.BackColor = Color.Gold;
                Forms.PlayerScreen.Money13.BackColor = Color.Gold;
                Money13.ForeColor = Color.White;
                Forms.PlayerScreen.Money13.ForeColor = Color.White;
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
                Money06.BackColor = Color.Green;
                Money06.ForeColor = Color.White;
                Money07.BackColor = Color.Green;
                Money07.ForeColor = Color.White;
                Money08.BackColor = Color.Green;
                Money08.ForeColor = Color.White;
                Forms.PlayerScreen.Money01.BackColor = Color.Green;
                Forms.PlayerScreen.Money01.ForeColor = Color.White;
                Forms.PlayerScreen.Money02.BackColor = Color.Green;
                Forms.PlayerScreen.Money02.ForeColor = Color.White;
                Forms.PlayerScreen.Money03.BackColor = Color.Green;
                Forms.PlayerScreen.Money03.ForeColor = Color.White;
                Forms.PlayerScreen.Money04.BackColor = Color.Green;
                Forms.PlayerScreen.Money04.ForeColor = Color.White;
                Forms.PlayerScreen.Money05.BackColor = Color.Green;
                Forms.PlayerScreen.Money05.ForeColor = Color.White;
                Forms.PlayerScreen.Money06.BackColor = Color.Green;
                Forms.PlayerScreen.Money06.ForeColor = Color.White;
                Forms.PlayerScreen.Money07.BackColor = Color.Green;
                Forms.PlayerScreen.Money07.ForeColor = Color.White;
                Forms.PlayerScreen.Money08.BackColor = Color.Green;
                Forms.PlayerScreen.Money08.ForeColor = Color.White;
            }
            else if (GPlayersRemaining == 3)
            {
                Money15.Visible = false;
                Money14.Visible = false;
                Money13.Visible = false;
                Forms.PlayerScreen.Money15.Visible = false;
                Forms.PlayerScreen.Money14.Visible = false;
                Forms.PlayerScreen.Money13.Visible = false;
                Money12.BackColor = Color.Gold;
                Forms.PlayerScreen.Money12.BackColor = Color.Gold;
                Money12.ForeColor = Color.White;
                Forms.PlayerScreen.Money12.ForeColor = Color.White;
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
                Money06.BackColor = Color.Green;
                Money06.ForeColor = Color.White;
                Money07.BackColor = Color.Green;
                Money07.ForeColor = Color.White;
                Forms.PlayerScreen.Money01.BackColor = Color.Green;
                Forms.PlayerScreen.Money01.ForeColor = Color.White;
                Forms.PlayerScreen.Money02.BackColor = Color.Green;
                Forms.PlayerScreen.Money02.ForeColor = Color.White;
                Forms.PlayerScreen.Money03.BackColor = Color.Green;
                Forms.PlayerScreen.Money03.ForeColor = Color.White;
                Forms.PlayerScreen.Money04.BackColor = Color.Green;
                Forms.PlayerScreen.Money04.ForeColor = Color.White;
                Forms.PlayerScreen.Money05.BackColor = Color.Green;
                Forms.PlayerScreen.Money05.ForeColor = Color.White;
                Forms.PlayerScreen.Money06.BackColor = Color.Green;
                Forms.PlayerScreen.Money06.ForeColor = Color.White;
                Forms.PlayerScreen.Money07.BackColor = Color.Green;
                Forms.PlayerScreen.Money07.ForeColor = Color.White;
            }
            else if (GPlayersRemaining == 2)
            {
                Money15.Visible = false;
                Money14.Visible = false;
                Money13.Visible = false;
                Money12.Visible = false;
                Forms.PlayerScreen.Money15.Visible = false;
                Forms.PlayerScreen.Money14.Visible = false;
                Forms.PlayerScreen.Money13.Visible = false;
                Forms.PlayerScreen.Money12.Visible = false;
                Money11.BackColor = Color.Gold;
                Forms.PlayerScreen.Money11.BackColor = Color.Gold;
                Money11.ForeColor = Color.White;
                Forms.PlayerScreen.Money11.ForeColor = Color.White;
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
                Money06.BackColor = Color.Green;
                Money06.ForeColor = Color.White;
                Forms.PlayerScreen.Money01.BackColor = Color.Green;
                Forms.PlayerScreen.Money01.ForeColor = Color.White;
                Forms.PlayerScreen.Money02.BackColor = Color.Green;
                Forms.PlayerScreen.Money02.ForeColor = Color.White;
                Forms.PlayerScreen.Money03.BackColor = Color.Green;
                Forms.PlayerScreen.Money03.ForeColor = Color.White;
                Forms.PlayerScreen.Money04.BackColor = Color.Green;
                Forms.PlayerScreen.Money04.ForeColor = Color.White;
                Forms.PlayerScreen.Money05.BackColor = Color.Green;
                Forms.PlayerScreen.Money05.ForeColor = Color.White;
                Forms.PlayerScreen.Money06.BackColor = Color.Green;
                Forms.PlayerScreen.Money06.ForeColor = Color.White;
            }
            else if (GPlayersRemaining == 1)
            {
                Money15.Visible = false;
                Money14.Visible = false;
                Money13.Visible = false;
                Money12.Visible = false;
                Money11.Visible = false;
                Forms.PlayerScreen.Money15.Visible = false;
                Forms.PlayerScreen.Money14.Visible = false;
                Forms.PlayerScreen.Money13.Visible = false;
                Forms.PlayerScreen.Money12.Visible = false;
                Forms.PlayerScreen.Money11.Visible = false;
                Money10.BackColor = Color.Gold;
                Forms.PlayerScreen.Money10.BackColor = Color.Gold;
                Money10.ForeColor = Color.White;
                Forms.PlayerScreen.Money10.ForeColor = Color.White;
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
                Forms.PlayerScreen.Money01.BackColor = Color.Green;
                Forms.PlayerScreen.Money01.ForeColor = Color.White;
                Forms.PlayerScreen.Money02.BackColor = Color.Green;
                Forms.PlayerScreen.Money02.ForeColor = Color.White;
                Forms.PlayerScreen.Money03.BackColor = Color.Green;
                Forms.PlayerScreen.Money03.ForeColor = Color.White;
                Forms.PlayerScreen.Money04.BackColor = Color.Green;
                Forms.PlayerScreen.Money04.ForeColor = Color.White;
                Forms.PlayerScreen.Money05.BackColor = Color.Green;
                Forms.PlayerScreen.Money05.ForeColor = Color.White;
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
            if (selection2 == 2)
            {
                AskPic.Visible = true;
                Forms.PlayerScreen.AskPic.Visible = true;
            }
            else if (selection2 == 3)
            {
                Level3Label.Visible = true;
                Level3Rules.Visible = true;
                ResumeGame.Visible = true;
                Transition.Visible = false;
            }
            count += 1;
        }
        private void ResumeGame_Click(object sender, EventArgs e)
        {
            GameAudio.Play(Properties.Resources.LevelTransitionMusic, AudioPlayMode.Background);
            Forms.Q11.Show();
            Forms.PlayerScreen.StartandResumeGame();
            Close();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
