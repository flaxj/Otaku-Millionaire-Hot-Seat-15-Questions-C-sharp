using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class Q01
    {
        public Q01()
        {
            InitializeComponent();
        }
        internal string[] Q1GamePlay = new string[14];
        internal int GPlayersRemaining = 6;
        internal int GPlayerNumber = 1;
        internal int questionsRemaining = 12;
        internal int SHQuestionsRemaining = 5;
        internal int passUsage = default(int);
        internal int TimeSeconds = 15;
        internal int TimeTenths = 0;
        private string choice = default(string);
        private string answer = default(string);
        private int CountA = default(int);
        private int CountB = default(int);
        private int CountC = default(int);
        private int CountD = default(int);
        private int ButtonCount = default(int);
        private int passcount = default(int);
        private void Q01_Load(object sender, EventArgs e)
        {
            Forms.PlayerScreen.Topic.Visible = true;
            Forms.PlayerScreen.Seconds.Visible = true;
            Forms.PlayerScreen.Placeholder.Visible = true;
            Forms.PlayerScreen.Tenths.Visible = true;
            Forms.PlayerScreen.QuestionValue.Visible = true;
            QuestionLoading();
            Forms.Level1MoneyTree.Close();
            GameAudio.Play(Properties.Resources.StartGame, AudioPlayMode.Background);
        }
        public void QuestionLoading()
        {
            Topic.Text = Q1GamePlay[0];
            Question1.Text = Q1GamePlay[1];
            Question2.Text = Q1GamePlay[2];
            Question3.Text = Q1GamePlay[3];
            ChoiceA.Text = Q1GamePlay[4];
            ChoiceB.Text = Q1GamePlay[5];
            ChoiceC.Text = Q1GamePlay[6];
            ChoiceD.Text = Q1GamePlay[7];
            Forms.PlayerScreen.Topic.Text = Q1GamePlay[0];
            Forms.PlayerScreen.question[0] = Q1GamePlay[1];
            Forms.PlayerScreen.question[1] = Q1GamePlay[2];
            Forms.PlayerScreen.question[2] = Q1GamePlay[3];
            Forms.PlayerScreen.question[3] = Q1GamePlay[4];
            Forms.PlayerScreen.question[4] = Q1GamePlay[5];
            Forms.PlayerScreen.question[5] = Q1GamePlay[6];
            Forms.PlayerScreen.question[6] = Q1GamePlay[7];
            Forms.PlayerScreen.QuestionLoader();
            answer = Q1GamePlay[8];
            CountA = Numbers.ToInteger(Q1GamePlay[9]);
            CountB = Numbers.ToInteger(Q1GamePlay[10]);
            CountC = Numbers.ToInteger(Q1GamePlay[11]);
            CountD = Numbers.ToInteger(Q1GamePlay[12]);
            if (CountA >= 30)
            {
                ChoiceA.Font = new Font(ChoiceA.Font.FontFamily, 18);
                Forms.PlayerScreen.ChoiceA.Font = new Font(Forms.PlayerScreen.ChoiceA.Font.FontFamily, 18);
            }
            if (CountB >= 30)
            {
                ChoiceB.Font = new Font(ChoiceB.Font.FontFamily, 18);
                Forms.PlayerScreen.ChoiceB.Font = new Font(Forms.PlayerScreen.ChoiceB.Font.FontFamily, 18);
            }
            if (CountC >= 30)
            {
                ChoiceC.Font = new Font(ChoiceC.Font.FontFamily, 18);
                Forms.PlayerScreen.ChoiceC.Font = new Font(Forms.PlayerScreen.ChoiceC.Font.FontFamily, 18);
            }
            if (CountD >= 30)
            {
                ChoiceD.Font = new Font(ChoiceD.Font.FontFamily, 18);
                Forms.PlayerScreen.ChoiceD.Font = new Font(Forms.PlayerScreen.ChoiceD.Font.FontFamily, 18);
            }
        }
        private void MasterButton_Click(object sender, EventArgs e)
        {
            var selection1 = ButtonCount;
            if (selection1 == 0)
            {
                GameAudio.Play(Properties.Resources.Level1QuestionMusic, AudioPlayMode.BackgroundLoop);
                Question1.Visible = true;
                Question2.Visible = true;
                Question3.Visible = true;
                Forms.PlayerScreen.ShowQuestions();
                MasterButton.Text = "Show Choices";
            }
            else if (selection1 == 1)
            {
                ChoiceA.Visible = true;
                ChoiceB.Visible = true;
                ChoiceC.Visible = true;
                ChoiceD.Visible = true;
                Forms.PlayerScreen.ShowChoices();
                SecondsClock.Start();
                TenthsClock.Start();
                MasterButton.Enabled = false;
                MasterButton.Text = "Answer";
            }
            else if (selection1 == 2)
            {
                QuestionResult();
                if (Correct.Visible == true | choice == answer)
                {
                    SHQuestionsRemaining -= 1;
                    SafeHavenQuestionsRemaining.Text = Convert.ToString(SHQuestionsRemaining);
                    GameAudio.Play(Properties.Resources.Level1Correct, AudioPlayMode.Background);
                    PassPic.Visible = true;
                    Forms.PlayerScreen.PassPic.Visible = true;
                }
                else
                {
                    GPlayersRemaining -= 1;
                    Forms.PlayerScreen.Players -= 1;
                    GameAudio.Play(Properties.Resources.Level1Wrong, AudioPlayMode.Background);
                    PlayersRemaining.Text = Convert.ToString(GPlayersRemaining);
                }
            }
            else if (selection1 == 3)
            {
                Forms.PlayerScreen.ResetQuestionArea();
                GameAudio.Play(Properties.Resources.Level1QuestionMusic, AudioPlayMode.BackgroundLoop);
                if (Incorrect.Visible == true)
                {
                    TopPrizeAmount.Text = "¥250,000";
                    AmountAtRisk.Text = "¥150,000";
                    PassPic.Visible = true;
                    Forms.PlayerScreen.PassPic.Visible = true;
                }
                else
                {
                    Forms.PlayerScreen.ResetQuestionArea();
                    Forms.Q02.Show();
                }
            }
            else if (selection1 == 4)
            {
                Forms.Q02.Show();
            }
            ButtonCount += 1;
        }
        private void TenthsClock_Tick(object sender, EventArgs e)
        {
            if (TimeTenths == 0)
            {
                if (TimeSeconds == 15)
                {
                    TimeSeconds -= 1;
                    Seconds.Text = Convert.ToString(TimeSeconds);
                    Forms.PlayerScreen.Seconds.Text = Seconds.Text;
                    TimeTenths = 9;
                    Tenths.Text = Convert.ToString(TimeTenths);
                    Forms.PlayerScreen.Tenths.Text = Tenths.Text;
                }
                else if (TimeSeconds == 0)
                {
                    TenthsClock.Stop();
                    SecondsClock.Stop();
                    if (PassPic.Visible == false)
                    {
                        Incorrect.Visible = true;
                        MasterButton.Enabled = true;
                    }
                }
            }
            else
            {
                TimeTenths -= 1;
                Tenths.Text = Convert.ToString(TimeTenths);
                Forms.PlayerScreen.Tenths.Text = Tenths.Text;
            }
            if (TimeSeconds >= 10 & TimeSeconds < 15)
            {
                Seconds.BackColor = Color.Yellow;
                Placeholder.BackColor = Color.Yellow;
                Tenths.BackColor = Color.Yellow;
                Forms.PlayerScreen.Seconds.BackColor = Color.Yellow;
                Forms.PlayerScreen.Placeholder.BackColor = Color.Yellow;
                Forms.PlayerScreen.Tenths.BackColor = Color.Yellow;
            }
            else if (TimeSeconds >= 5 & TimeSeconds < 10)
            {
                Seconds.BackColor = Color.Orange;
                Placeholder.BackColor = Color.Orange;
                Tenths.BackColor = Color.Orange;
                Forms.PlayerScreen.Seconds.BackColor = Color.Orange;
                Forms.PlayerScreen.Placeholder.BackColor = Color.Orange;
                Forms.PlayerScreen.Tenths.BackColor = Color.Orange;
            }
            else if (TimeSeconds < 5)
            {
                Seconds.BackColor = Color.Red;
                Seconds.ForeColor = Color.White;
                Placeholder.BackColor = Color.Red;
                Placeholder.ForeColor = Color.White;
                Tenths.BackColor = Color.Red;
                Tenths.ForeColor = Color.White;
                Forms.PlayerScreen.Seconds.BackColor = Color.Red;
                Forms.PlayerScreen.Seconds.ForeColor = Color.White;
                Forms.PlayerScreen.Placeholder.BackColor = Color.Red;
                Forms.PlayerScreen.Placeholder.ForeColor = Color.White;
                Forms.PlayerScreen.Tenths.BackColor = Color.Red;
                Forms.PlayerScreen.Tenths.ForeColor = Color.White;
            }
        }
        private void SecondsClock_Tick(object sender, EventArgs e)
        {
            if (TimeSeconds == 0)
            {
                SecondsClock.Stop();
            }
            else
            {
                TimeSeconds -= 1;
                Seconds.Text = Convert.ToString(TimeSeconds);
                Forms.PlayerScreen.Seconds.Text = Seconds.Text;
                TimeTenths = 9;
                Tenths.Text = Convert.ToString(TimeTenths);
                Forms.PlayerScreen.Tenths.Text = Tenths.Text;
            }
        }
        private void ChoiceA_CheckedChanged(object sender, EventArgs e)
        {
            choice = ChoiceA.Text;
            FinalAnswer();
        }
        private void ChoiceB_CheckedChanged(object sender, EventArgs e)
        {
            choice = ChoiceB.Text;
            FinalAnswer();
        }
        private void ChoiceC_CheckedChanged(object sender, EventArgs e)
        {
            choice = ChoiceC.Text;
            FinalAnswer();
        }
        private void ChoiceD_CheckedChanged(object sender, EventArgs e)
        {
            choice = ChoiceD.Text;
            FinalAnswer();
        }
        public void FinalAnswer()
        {
            TenthsClock.Stop();
            SecondsClock.Stop();
            var selection2 = choice;
            if (selection2 == ChoiceA.Text)
            {
                ChoiceA.BackColor = Color.Orange;
                Forms.PlayerScreen.ChoiceA.BackColor = Color.Orange;
            }
            else if (selection2 == ChoiceB.Text)
            {
                ChoiceB.BackColor = Color.Orange;
                Forms.PlayerScreen.ChoiceB.BackColor = Color.Orange;
            }
            else if (selection2 == ChoiceC.Text)
            {
                ChoiceC.BackColor = Color.Orange;
                Forms.PlayerScreen.ChoiceC.BackColor = Color.Orange;
            }
            else if (selection2 == ChoiceD.Text)
            {
                ChoiceD.BackColor = Color.Orange;
                Forms.PlayerScreen.ChoiceD.BackColor = Color.Orange;
            }
            if (choice == answer)
            {
                Correct.Visible = true;
            }
            else
            {
                Incorrect.Visible = true;
                var selection3 = answer;
                if (selection3 == ChoiceA.Text)
                {
                    ChoiceA.BackColor = Color.Green;
                    ChoiceA.ForeColor = Color.White;
                }
                else if (selection3 == ChoiceB.Text)
                {
                    ChoiceB.BackColor = Color.Green;
                    ChoiceB.ForeColor = Color.White;
                }
                else if (selection3 == ChoiceC.Text)
                {
                    ChoiceC.BackColor = Color.Green;
                    ChoiceC.ForeColor = Color.White;
                }
                else if (selection3 == ChoiceD.Text)
                {
                    ChoiceD.BackColor = Color.Green;
                    ChoiceD.ForeColor = Color.White;
                }
            }
            MasterButton.Enabled = true;
        }
        public void QuestionResult()
        {
            questionsRemaining -= 1;
            TopPrizeQuestionRemaining.Text = Convert.ToString(questionsRemaining);
            var selection4 = answer;
            if (selection4 == ChoiceA.Text)
            {
                ChoiceA.BackColor = Color.Green;
                ChoiceA.ForeColor = Color.White;
                Forms.PlayerScreen.ChoiceA.BackColor = Color.Green;
                Forms.PlayerScreen.ChoiceA.ForeColor = Color.White;
            }
            else if (selection4 == ChoiceB.Text)
            {
                ChoiceB.BackColor = Color.Green;
                ChoiceB.ForeColor = Color.White;
                Forms.PlayerScreen.ChoiceB.BackColor = Color.Green;
                Forms.PlayerScreen.ChoiceB.ForeColor = Color.White;
            }
            else if (selection4 == ChoiceC.Text)
            {
                ChoiceC.BackColor = Color.Green;
                ChoiceC.ForeColor = Color.White;
                Forms.PlayerScreen.ChoiceC.BackColor = Color.Green;
                Forms.PlayerScreen.ChoiceC.ForeColor = Color.White;
            }
            else if (selection4 == ChoiceD.Text)
            {
                ChoiceD.BackColor = Color.Green;
                ChoiceD.ForeColor = Color.White;
                Forms.PlayerScreen.ChoiceD.BackColor = Color.Green;
                Forms.PlayerScreen.ChoiceD.ForeColor = Color.White;
            }
            if (choice == answer)
            {
                Forms.PlayerScreen.Money01.BackColor = Color.Green;
                Forms.PlayerScreen.Money01.ForeColor = Color.White;
                QuestionValue.BackColor = Color.Green;
                QuestionValue.ForeColor = Color.White;
                Forms.Level2MoneyTree.Topic01.BackColor = Color.Green;
                Forms.Level2MoneyTree.Topic01.ForeColor = Color.White;
                Forms.Level3MoneyTree.Topic01.BackColor = Color.Green;
                Forms.Level3MoneyTree.Topic01.ForeColor = Color.White;
                Forms.Level4MoneyTree.Topic01.BackColor = Color.Green;
                Forms.Level4MoneyTree.Topic01.ForeColor = Color.White;
                Forms.PlayerScreen.Topic01.BackColor = Color.Green;
                Forms.PlayerScreen.Topic01.ForeColor = Color.White;
            }
            else
            {
                Forms.Level2MoneyTree.Topic01.BackColor = Color.Red;
                Forms.Level2MoneyTree.Topic01.ForeColor = Color.White;
                Forms.Level3MoneyTree.Topic01.BackColor = Color.Red;
                Forms.Level3MoneyTree.Topic01.ForeColor = Color.White;
                Forms.Level4MoneyTree.Topic01.BackColor = Color.Red;
                Forms.Level4MoneyTree.Topic01.ForeColor = Color.White;
                Forms.PlayerScreen.Topic01.BackColor = Color.Red;
                Forms.PlayerScreen.Topic01.ForeColor = Color.White;
            }
        }
        private void PassPic_Click(object sender, EventArgs e)
        {
            if (passcount == 0)
            {
                TenthsClock.Stop();
                SecondsClock.Stop();
                TimeSeconds = 15;
                Seconds.Text = Convert.ToString(TimeSeconds);
                Forms.PlayerScreen.Seconds.Text = Convert.ToString(TimeSeconds);
                TimeTenths = 0;
                Tenths.Text = Convert.ToString(TimeTenths);
                Forms.PlayerScreen.Tenths.Text = Convert.ToString(TimeTenths);
                Seconds.BackColor = DefaultBackColor;
                Seconds.ForeColor = DefaultForeColor;
                Placeholder.BackColor = DefaultBackColor;
                Placeholder.ForeColor = DefaultForeColor;
                Tenths.BackColor = DefaultBackColor;
                Tenths.ForeColor = DefaultForeColor;
                Forms.PlayerScreen.Seconds.BackColor = DefaultBackColor;
                Forms.PlayerScreen.Seconds.ForeColor = DefaultForeColor;
                Forms.PlayerScreen.Placeholder.BackColor = DefaultBackColor;
                Forms.PlayerScreen.Placeholder.ForeColor = DefaultForeColor;
                Forms.PlayerScreen.Tenths.BackColor = DefaultBackColor;
                Forms.PlayerScreen.Tenths.ForeColor = DefaultForeColor;
                Forms.PlayerScreen.PassPic.Visible = false;
                Forms.PlayerScreen.HideChoices();
                passUsage += 1;
                passcount += 1;
            }
            else
            {
                Forms.PlayerScreen.ShowChoices();
                PassPic.Visible = false;
                SecondsClock.Start();
                TenthsClock.Start();
            }
        }
    }
}
