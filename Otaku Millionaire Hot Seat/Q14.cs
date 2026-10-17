using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class Q14
    {
        public Q14()
        {
            InitializeComponent();
        }
        internal string[] Q14GamePlay = new string[14];
        internal int GPlayersRemaining = default(int);
        internal int GPlayerNumber = default(int);
        internal int questionsRemaining = default(int);
        internal int AskFriendCount = default(int);
        internal int DoubleDipCount = default(int);
        internal int AskAudienceCount = default(int);
        internal int AskA = default(int);
        internal int AskB = default(int);
        internal int AskC = default(int);
        internal int AskD = default(int);
        internal int Trust = default(int);
        internal int TimeSeconds = 45;
        internal int TimeTenths = 0;
        private string choice = default(string);
        private string answer = default(string);
        private int CountA = default(int);
        private int CountB = default(int);
        private int CountC = default(int);
        private int CountD = default(int);
        private int ButtonCount = default(int);
        private int guess = default(int);
        internal int ask = default(int);
        internal int AskSum = default(int);
        private int DDEnable = 0;
        private void Q14_Load(object sender, EventArgs e)
        {
            GPlayersRemaining = Forms.Q13.GPlayersRemaining;
            GPlayerNumber = Forms.Q13.GPlayerNumber;
            questionsRemaining = Forms.Q13.questionsRemaining;
            AskFriendCount = Forms.Q13.AskFriendCount;
            DoubleDipCount = Forms.Q13.DoubleDipCount;
            AskAudienceCount = Forms.Q13.AskAudienceCount;
            TopPrizeAmount.Text = Forms.Q13.TopPrizeAmount.Text;
            Trust = Forms.Q13.Trust;
            Forms.Winnings.question = 14;
            GameAudio.Play(Properties.Resources.QuestionTransitionMusic, AudioPlayMode.Background);
            Forms.PlayerScreen.Seconds.Text = Convert.ToString(45);
            Forms.PlayerScreen.Tenths.Text = Convert.ToString(0);
            QuestionLoading();
            if (GPlayersRemaining == 6)
            {
                QuestionValue.Text = "¥250,000";
                Forms.PlayerScreen.QuestionValue.Text = QuestionValue.Text;
            }
            else if (GPlayersRemaining == 5)
            {
                AmountAtRisk.Text = "¥150,000";
                QuestionValue.Text = "¥100,000";
                Forms.PlayerScreen.QuestionValue.Text = QuestionValue.Text;
            }
            else if (GPlayersRemaining == 4)
            {
                AmountAtRisk.Text = "¥50,000";
                QuestionValue.Text = "¥50,000";
                Forms.PlayerScreen.QuestionValue.Text = QuestionValue.Text;
            }
            else if (GPlayersRemaining == 3)
            {
                AmountAtRisk.Text = "¥30,000";
                QuestionValue.Text = "¥20,000";
                Forms.PlayerScreen.QuestionValue.Text = QuestionValue.Text;
            }
            else if (GPlayersRemaining == 2)
            {
                AmountAtRisk.Text = "¥10,000";
                QuestionValue.Text = "¥10,000";
                Forms.PlayerScreen.QuestionValue.Text = QuestionValue.Text;
            }
            else
            {
                AmountAtRisk.Text = "¥9,000";
                QuestionValue.Text = "¥6,000";
                Forms.PlayerScreen.QuestionValue.Text = QuestionValue.Text;
            }
            LifelineUsed();
            TopPrizeQuestionRemaining.Text = Convert.ToString(questionsRemaining);
            PlayersRemaining.Text = Convert.ToString(GPlayersRemaining);
            Forms.Q13.Close();
        }
        public void LifelineUsed()
        {
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
            if (AskAudienceCount == 1)
            {
                AskPic.Visible = false;
                Forms.PlayerScreen.AskPic.Visible = false;
            }
            if (Trust == 0)
            {
                TrustPic.Visible = true;
                Forms.PlayerScreen.TrustPic.Visible = true;
            }
            else
            {
                TrustPic.Visible = false;
                Forms.PlayerScreen.TrustPic.Visible = false;
            }
        }
        public void QuestionLoading()
        {
            Topic.Text = Q14GamePlay[0];
            Question1.Text = Q14GamePlay[1];
            Question2.Text = Q14GamePlay[2];
            Question3.Text = Q14GamePlay[3];
            ChoiceA.Text = Q14GamePlay[4];
            ChoiceB.Text = Q14GamePlay[5];
            ChoiceC.Text = Q14GamePlay[6];
            ChoiceD.Text = Q14GamePlay[7];
            Forms.PlayerScreen.Topic.Text = Q14GamePlay[0];
            Forms.PlayerScreen.question[0] = Q14GamePlay[1];
            Forms.PlayerScreen.question[1] = Q14GamePlay[2];
            Forms.PlayerScreen.question[2] = Q14GamePlay[3];
            Forms.PlayerScreen.question[3] = Q14GamePlay[4];
            Forms.PlayerScreen.question[4] = Q14GamePlay[5];
            Forms.PlayerScreen.question[5] = Q14GamePlay[6];
            Forms.PlayerScreen.question[6] = Q14GamePlay[7];
            Forms.PlayerScreen.QuestionLoader();
            answer = Q14GamePlay[8];
            CountA = Numbers.ToInteger(Q14GamePlay[9]);
            CountB = Numbers.ToInteger(Q14GamePlay[10]);
            CountC = Numbers.ToInteger(Q14GamePlay[11]);
            CountD = Numbers.ToInteger(Q14GamePlay[12]);
            if (CountA >= 60)
            {
                ChoiceA.Font = new Font(ChoiceA.Font.FontFamily, 12);
                Forms.PlayerScreen.ChoiceA.Font = new Font(Forms.PlayerScreen.ChoiceA.Font.FontFamily, 12);
            }
            else if (CountA >= 30 & CountA < 60)
            {
                ChoiceA.Font = new Font(ChoiceA.Font.FontFamily, 18);
                Forms.PlayerScreen.ChoiceA.Font = new Font(Forms.PlayerScreen.ChoiceA.Font.FontFamily, 18);
            }
            if (CountB >= 60)
            {
                ChoiceB.Font = new Font(ChoiceB.Font.FontFamily, 12);
                Forms.PlayerScreen.ChoiceB.Font = new Font(Forms.PlayerScreen.ChoiceB.Font.FontFamily, 12);
            }
            else if (CountB >= 30 & CountB < 60)
            {
                ChoiceB.Font = new Font(ChoiceB.Font.FontFamily, 18);
                Forms.PlayerScreen.ChoiceB.Font = new Font(Forms.PlayerScreen.ChoiceB.Font.FontFamily, 18);
            }
            if (CountC >= 60)
            {
                ChoiceC.Font = new Font(ChoiceC.Font.FontFamily, 12);
                Forms.PlayerScreen.ChoiceC.Font = new Font(Forms.PlayerScreen.ChoiceC.Font.FontFamily, 12);
            }
            else if (CountC >= 30 & CountC < 60)
            {
                ChoiceC.Font = new Font(ChoiceC.Font.FontFamily, 18);
                Forms.PlayerScreen.ChoiceC.Font = new Font(Forms.PlayerScreen.ChoiceC.Font.FontFamily, 18);
            }
            if (CountD >= 60)
            {
                ChoiceD.Font = new Font(ChoiceD.Font.FontFamily, 12);
                Forms.PlayerScreen.ChoiceD.Font = new Font(Forms.PlayerScreen.ChoiceD.Font.FontFamily, 12);
            }
            else if (CountD >= 30 & CountD < 60)
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
                GameAudio.Stop();
                GameAudio.Play(Properties.Resources.Questions14and15, AudioPlayMode.Background);
                MasterButton.Enabled = false;
                MasterButton.Text = "Answer";
            }
            else if (selection1 == 2)
            {
                QuestionResult();
                GameAudio.Stop();
                questionsRemaining -= 1;
                TopPrizeQuestionRemaining.Text = Convert.ToString(questionsRemaining);
                if (Correct.Visible == true | choice == answer)
                {
                    if (GPlayersRemaining == 2)
                    {
                        GameAudio.Play(Properties.Resources.Question10Correct, AudioPlayMode.Background);
                    }
                    else
                    {
                        GameAudio.Play(Properties.Resources.Question14Correct, AudioPlayMode.Background);
                    }
                    if (DoubleDipCount == 1)
                    {
                        DoubleDipPic.Visible = false;
                        Forms.PlayerScreen.DoubleDipPic.Visible = false;
                    }
                    if (AskFriendCount == 0)
                    {
                        AskFriendPic.Visible = true;
                        Forms.PlayerScreen.AskFriendPic.Visible = true;
                    }
                    if (AskAudienceCount == 0)
                    {
                        AskPic.Visible = true;
                        Forms.PlayerScreen.AskPic.Visible = true;
                    }
                    TrustPic.Visible = false;
                    Forms.PlayerScreen.TrustPic.Visible = false;
                    if (GPlayersRemaining == 6)
                    {
                        AmountAtRisk.Text = "¥999,000";
                        TopPrizeAmount.Text = "¥1,000,000";
                    }
                    else if (GPlayersRemaining == 5)
                    {
                        TopPrizeAmount.Text = "¥250,000";
                        AmountAtRisk.Text = "¥249,000";
                    }
                    else if (GPlayersRemaining == 4)
                    {
                        TopPrizeAmount.Text = "¥100,000";
                        AmountAtRisk.Text = "¥99,000";
                    }
                    else if (GPlayersRemaining == 3)
                    {
                        TopPrizeAmount.Text = "¥50,000";
                        AmountAtRisk.Text = "¥49,000";
                    }
                    else if (GPlayersRemaining == 2)
                    {
                        TopPrizeAmount.Text = "¥20,000";
                        AmountAtRisk.Text = "¥19,000";
                    }
                    else
                    {
                        TopPrizeAmount.Text = "¥10,000";
                        AmountAtRisk.Text = "¥9,000";
                    }
                }
                else
                {
                    GameAudio.Play(Properties.Resources.Questions14and15Wrong, AudioPlayMode.Background);
                    GPlayersRemaining -= 1;
                    Forms.PlayerScreen.Players -= 1;
                    PlayersRemaining.Text = Convert.ToString(GPlayersRemaining);
                }
            }
            else if (selection1 == 3)
            {
                if (Incorrect.Visible == true | choice != answer)
                {
                    if (GPlayersRemaining == 5)
                    {
                        Forms.PlayerScreen.ResetQuestionArea();
                        GameAudio.Play(Properties.Resources.Next_Player_In, AudioPlayMode.Background);
                        TopPrizeAmount.Text = "¥250,000";
                        AmountAtRisk.Text = "¥249,000";
                    }
                    else if (GPlayersRemaining == 4)
                    {
                        Forms.PlayerScreen.ResetQuestionArea();
                        GameAudio.Play(Properties.Resources.Next_Player_In, AudioPlayMode.Background);
                        TopPrizeAmount.Text = "¥100,000";
                        AmountAtRisk.Text = "¥99,000";
                    }
                    else if (GPlayersRemaining == 3)
                    {
                        Forms.PlayerScreen.ResetQuestionArea();
                        GameAudio.Play(Properties.Resources.Next_Player_In, AudioPlayMode.Background);
                        TopPrizeAmount.Text = "¥50,000";
                        AmountAtRisk.Text = "¥49,000";
                    }
                    else if (GPlayersRemaining == 2)
                    {
                        Forms.PlayerScreen.ResetQuestionArea();
                        GameAudio.Play(Properties.Resources.Next_Player_In, AudioPlayMode.Background);
                        TopPrizeAmount.Text = "¥20,000";
                        AmountAtRisk.Text = "¥19,000";
                    }
                    else if (GPlayersRemaining == 1)
                    {
                        Forms.PlayerScreen.ResetQuestionArea();
                        GameAudio.Play(Properties.Resources.Next_Player_In, AudioPlayMode.Background);
                        TopPrizeAmount.Text = "¥10,000";
                        AmountAtRisk.Text = "¥9,000";
                    }
                    else
                    {
                        Forms.Winnings.Show();
                        Forms.Winnings.AmountWon.Text = "¥1,000";
                        Forms.PlayerScreen.AmountWon.Text = "¥1,000";
                        Forms.PlayerScreen.EndShowLogo.Visible = true;
                        Forms.PlayerScreen.AmountWon.Visible = true;
                        Forms.PlayerScreen.EndOfGame();
                        Close();
                        return;
                    }
                    DoubleDipPic.Visible = false;
                    Forms.PlayerScreen.DoubleDipPic.Visible = false;
                    if (AskFriendCount == 0)
                    {
                        AskFriendPic.Visible = true;
                        Forms.PlayerScreen.AskFriendPic.Visible = true;
                    }
                    if (AskAudienceCount == 0)
                    {
                        AskPic.Visible = true;
                        Forms.PlayerScreen.AskPic.Visible = true;
                    }
                    TrustPic.Visible = false;
                    Forms.PlayerScreen.TrustPic.Visible = false;
                }
                else
                {
                    GameAudio.Play(Properties.Resources.FirstandThirdAdBreaksStart, AudioPlayMode.Background);
                }
            }
            else if (selection1 == 4)
            {
                if (Incorrect.Visible == true | choice != answer)
                {
                    GameAudio.Play(Properties.Resources.FirstandThirdAdBreaksStart, AudioPlayMode.Background);
                }
                else
                {
                    Forms.PlayerScreen.LevelWindow();
                    Forms.PlayerScreen.ResetQuestionArea();
                    Forms.Level4MoneyTree.Show();
                }
            }
            else if (selection1 == 5)
            {
                Forms.PlayerScreen.LevelWindow();
                Forms.Level4MoneyTree.Show();
            }
            ButtonCount += 1;
        }
        private void TenthsClock_Tick(object sender, EventArgs e)
        {
            if (TimeTenths == 0)
            {
                if (TimeSeconds == 45 | TimeSeconds == 30 | TimeSeconds == 15)
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
                    Incorrect.Visible = true;
                    MasterButton.Enabled = true;
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
            GameAudio.Stop();
            if (DoubleDipPic.Visible == true & guess == 1)
            {
                GameAudio.Play(Properties.Resources.DoubleDipFinalAnswer, AudioPlayMode.Background);
            }
            else
            {
                GameAudio.Play(Properties.Resources.Questions14and15FinalAnswer, AudioPlayMode.Background);
            }
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
                if (DoubleDipCount == 1 | DDEnable == 0)
                {
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
                else
                {
                    if (Trust == 1 & (DoubleDipCount == 1 | DDEnable == 0))
                    {
                        var selection4 = answer;
                        if (selection4 == ChoiceA.Text)
                        {
                            ChoiceA.BackColor = Color.Green;
                            ChoiceA.ForeColor = Color.White;
                        }
                        else if (selection4 == ChoiceB.Text)
                        {
                            ChoiceB.BackColor = Color.Green;
                            ChoiceB.ForeColor = Color.White;
                        }
                        else if (selection4 == ChoiceC.Text)
                        {
                            ChoiceC.BackColor = Color.Green;
                            ChoiceC.ForeColor = Color.White;
                        }
                        else if (selection4 == ChoiceD.Text)
                        {
                            ChoiceD.BackColor = Color.Green;
                            ChoiceD.ForeColor = Color.White;
                        }
                    }
                }
            }
            if (guess == 1 & DoubleDipPic.Visible == true)
            {
                MasterButton.Enabled = false;
            }
            else
            {
                MasterButton.Enabled = true;
            }
        }
        public void QuestionResult()
        {
            var selection5 = answer;
            if (selection5 == ChoiceA.Text)
            {
                ChoiceA.BackColor = Color.Green;
                ChoiceA.ForeColor = Color.White;
                Forms.PlayerScreen.ChoiceA.BackColor = Color.Green;
                Forms.PlayerScreen.ChoiceA.ForeColor = Color.White;
            }
            else if (selection5 == ChoiceB.Text)
            {
                ChoiceB.BackColor = Color.Green;
                ChoiceB.ForeColor = Color.White;
                Forms.PlayerScreen.ChoiceB.BackColor = Color.Green;
                Forms.PlayerScreen.ChoiceB.ForeColor = Color.White;
            }
            else if (selection5 == ChoiceC.Text)
            {
                ChoiceC.BackColor = Color.Green;
                ChoiceC.ForeColor = Color.White;
                Forms.PlayerScreen.ChoiceC.BackColor = Color.Green;
                Forms.PlayerScreen.ChoiceC.ForeColor = Color.White;
            }
            else if (selection5 == ChoiceD.Text)
            {
                ChoiceD.BackColor = Color.Green;
                ChoiceD.ForeColor = Color.White;
                Forms.PlayerScreen.ChoiceD.BackColor = Color.Green;
                Forms.PlayerScreen.ChoiceD.ForeColor = Color.White;
            }
            if (choice == answer)
            {
                if (GPlayersRemaining == 6)
                {
                    Forms.PlayerScreen.Money14.BackColor = Color.Green;
                    Forms.PlayerScreen.Money14.ForeColor = Color.White;
                }
                else if (GPlayersRemaining == 5)
                {
                    Forms.PlayerScreen.Money13.BackColor = Color.Green;
                    Forms.PlayerScreen.Money13.ForeColor = Color.White;
                }
                else if (GPlayersRemaining == 4)
                {
                    Forms.PlayerScreen.Money12.BackColor = Color.Green;
                    Forms.PlayerScreen.Money12.ForeColor = Color.White;
                }
                else if (GPlayersRemaining == 3)
                {
                    Forms.PlayerScreen.Money11.BackColor = Color.Green;
                    Forms.PlayerScreen.Money11.ForeColor = Color.White;
                }
                else if (GPlayersRemaining == 2)
                {
                    Forms.PlayerScreen.Money10.BackColor = Color.Green;
                    Forms.PlayerScreen.Money10.ForeColor = Color.White;
                }
                else
                {
                    Forms.PlayerScreen.Money09.BackColor = Color.Green;
                    Forms.PlayerScreen.Money09.ForeColor = Color.White;
                }
                QuestionValue.BackColor = Color.Green;
                QuestionValue.ForeColor = Color.White;
                Forms.Level4MoneyTree.Topic14.BackColor = Color.Green;
                Forms.Level4MoneyTree.Topic14.ForeColor = Color.White;
                Forms.PlayerScreen.Topic14.BackColor = Color.Green;
                Forms.PlayerScreen.Topic14.ForeColor = Color.White;
            }
            else
            {
                Forms.Level4MoneyTree.Topic14.BackColor = Color.Red;
                Forms.Level4MoneyTree.Topic14.ForeColor = Color.White;
                Forms.PlayerScreen.Topic14.BackColor = Color.Red;
                Forms.PlayerScreen.Topic14.ForeColor = Color.White;
            }
        }
        private void DoubleDipPic_Click(object sender, EventArgs e)
        {
            var selection6 = guess;
            if (selection6 == 0)
            {
                TenthsClock.Stop();
                SecondsClock.Stop();
                var selection7 = TimeSeconds;
                if (selection7 >= 30)
                {
                    TimeSeconds = 45;
                }
                else if (selection7 >= 15)
                {
                    TimeSeconds = 30;
                }
                else
                {
                    TimeSeconds = 15;
                }
                Seconds.Text = Convert.ToString(TimeSeconds);
                Forms.PlayerScreen.Seconds.Text = Convert.ToString(TimeSeconds);
                if (TimeTenths != 0)
                {
                    TimeTenths = 0;
                    Tenths.Text = Convert.ToString(TimeTenths);
                    Forms.PlayerScreen.Tenths.Text = Convert.ToString(TimeTenths);
                }
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
                AskFriendPic.Visible = false;
                AskPic.Visible = false;
                TrustPic.Visible = false;
                Forms.PlayerScreen.AskFriendPic.Visible = false;
                Forms.PlayerScreen.PassPic.Visible = false;
                Forms.PlayerScreen.TrustPic.Visible = false;
                DDEnable = 1;
                GameAudio.Stop();
                GameAudio.Play(Properties.Resources.DoubleDipLifelineFirstGuess, AudioPlayMode.Background);
            }
            else if (selection6 == 1)
            {
                if (Correct.Visible == true)
                {
                    QuestionResult();
                    GameAudio.Stop();
                    questionsRemaining = questionsRemaining - 1;
                    TopPrizeQuestionRemaining.Text = Convert.ToString(questionsRemaining);
                    if (GPlayersRemaining == 2)
                    {
                        GameAudio.Play(Properties.Resources.Question10Correct, AudioPlayMode.Background);
                    }
                    else
                    {
                        GameAudio.Play(Properties.Resources.Question14Correct, AudioPlayMode.Background);
                    }
                    if (AskAudienceCount == 0)
                    {
                        AskPic.Visible = true;
                        Forms.PlayerScreen.AskPic.Visible = true;
                    }
                    if (AskFriendCount == 0)
                    {
                        AskFriendPic.Visible = true;
                        Forms.PlayerScreen.AskFriendPic.Visible = true;
                    }
                    TrustPic.Visible = false;
                    Forms.PlayerScreen.TrustPic.Visible = false;
                    MasterButton.Enabled = true;
                    DoubleDipPic.Visible = false;
                    Forms.PlayerScreen.DoubleDipPic.Visible = false;
                    ButtonCount = 3;
                }
                else
                {
                    var selection8 = choice;
                    if (selection8 == ChoiceA.Text)
                    {
                        ChoiceA.Visible = false;
                        Forms.PlayerScreen.ChoiceA.Visible = false;
                    }
                    else if (selection8 == ChoiceB.Text)
                    {
                        ChoiceB.Visible = false;
                        Forms.PlayerScreen.ChoiceB.Visible = false;
                    }
                    else if (selection8 == ChoiceC.Text)
                    {
                        ChoiceC.Visible = false;
                        Forms.PlayerScreen.ChoiceC.Visible = false;
                    }
                    else if (selection8 == ChoiceD.Text)
                    {
                        ChoiceD.Visible = false;
                        Forms.PlayerScreen.ChoiceD.Visible = false;
                    }
                    choice = "";
                    GameAudio.Play(Properties.Resources.DoubleDipSecondChance, AudioPlayMode.Background);
                }
                DoubleDipCount += 1;
            }
            else if (selection6 == 2)
            {
                RestartQuestionClock();
                Incorrect.Visible = false;
                return;
            }
            guess += 1;
        }
        public void RestartQuestionClock()
        {
            SecondsClock.Start();
            TenthsClock.Start();
            var selection9 = TimeSeconds;
            if (selection9 == 45)
            {
                GameAudio.Play(Properties.Resources.Questions14and15, AudioPlayMode.Background);
            }
            else if (selection9 == 30)
            {
                GameAudio.Play(Properties.Resources.Questions14and15_30, AudioPlayMode.Background);
            }
            else if (selection9 == 15)
            {
                GameAudio.Play(Properties.Resources.Questions14and15_15, AudioPlayMode.Background);
            }
        }
        private void AskFriendPic_Click(object sender, EventArgs e)
        {
            var selection10 = AskFriendCount;
            if (selection10 == 0)
            {
                TenthsClock.Stop();
                SecondsClock.Stop();
                GameAudio.Stop();
                GameAudio.Play(Properties.Resources.AskAFriend, AudioPlayMode.Background);
                AskPic.Visible = false;
                Forms.PlayerScreen.AskPic.Visible = false;
                DoubleDipPic.Visible = false;
                Forms.PlayerScreen.DoubleDipPic.Visible = false;
                TrustPic.Visible = false;
                Forms.PlayerScreen.TrustPic.Visible = false;
                if (TimeSeconds >= 30)
                {
                    TimeSeconds = 45;
                }
                else if (TimeSeconds >= 15)
                {
                    TimeSeconds = 30;
                }
                else
                {
                    TimeSeconds = 15;
                }
                Seconds.Text = Convert.ToString(TimeSeconds);
                Forms.PlayerScreen.Seconds.Text = Convert.ToString(TimeSeconds);
                if (TimeTenths != 0)
                {
                    TimeTenths = 0;
                    Tenths.Text = Convert.ToString(TimeTenths);
                    Forms.PlayerScreen.Tenths.Text = Convert.ToString(TimeTenths);
                }
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
                AskFriendCount += 1;
            }
            else if (selection10 == 1)
            {
                AskFriendPic.Visible = false;
                RestartQuestionClock();
            }
        }
        private void AskPic_Click(object sender, EventArgs e)
        {
            asklifeline();
            Forms.AskResult.Show();
        }
        public void asklifeline()
        {
            var selection11 = ask;
            if (selection11 == 0)
            {
                TenthsClock.Stop();
                SecondsClock.Stop();
                GameAudio.Stop();
                GameAudio.Play(Properties.Resources.AskLifelineSurvay, AudioPlayMode.BackgroundLoop);
                var selection12 = TimeSeconds;
                if (selection12 >= 30)
                {
                    TimeSeconds = 45;
                }
                else if (selection12 >= 15)
                {
                    TimeSeconds = 30;
                }
                else
                {
                    TimeSeconds = 15;
                }
                Seconds.Text = Convert.ToString(TimeSeconds);
                Forms.PlayerScreen.Seconds.Text = Convert.ToString(TimeSeconds);
                if (TimeTenths != 0)
                {
                    TimeTenths = 0;
                    Tenths.Text = Convert.ToString(TimeTenths);
                    Forms.PlayerScreen.Tenths.Text = Convert.ToString(TimeTenths);
                }
                Seconds.BackColor = DefaultBackColor;
                Seconds.ForeColor = DefaultForeColor;
                Placeholder.BackColor = DefaultBackColor;
                Placeholder.ForeColor = DefaultForeColor;
                Tenths.BackColor = DefaultBackColor;
                Tenths.ForeColor = DefaultForeColor;
                Forms.AskResult.questionsRemaining = questionsRemaining;
                AskA = GameInput.ReadVotes("How many voted for Choice A?");
                AskB = GameInput.ReadVotes("How many voted for Choice B?");
                AskC = GameInput.ReadVotes("How many voted for Choice C?");
                AskD = GameInput.ReadVotes("How many voted for Choice D?");
                AskSum = AskA + AskB + AskC + AskD;
                AskAudienceCount += 1;
            }
            else if (selection11 == 1)
            {
                Forms.PlayerScreen.A.Visible = false;
                Forms.PlayerScreen.Result1.Visible = false;
                Forms.PlayerScreen.PercentA.Visible = false;
                Forms.PlayerScreen.B.Visible = false;
                Forms.PlayerScreen.Result2.Visible = false;
                Forms.PlayerScreen.PercentB.Visible = false;
                Forms.PlayerScreen.C.Visible = false;
                Forms.PlayerScreen.Result3.Visible = false;
                Forms.PlayerScreen.PercentC.Visible = false;
                Forms.PlayerScreen.D.Visible = false;
                Forms.PlayerScreen.Result4.Visible = false;
                Forms.PlayerScreen.PercentD.Visible = false;
                AskPic.Visible = false;
                Forms.PlayerScreen.AskPic.Visible = false;
                Forms.AskResult.Close();
                RestartQuestionClock();
            }
        }
        private void TrustPic_Click(object sender, EventArgs e)
        {
            int computerSelection = default(int);
            int min = 0;
            int max = 4;
            Random randomNum = new Random();
            computerSelection = randomNum.Next(min, max);
            if (computerSelection == 0)
            {
                choice = ChoiceA.Text;
            }
            else if (computerSelection == 1)
            {
                choice = ChoiceB.Text;
            }
            else if (computerSelection == 2)
            {
                choice = ChoiceC.Text;
            }
            else
            {
                choice = ChoiceD.Text;
            }
            TrustPic.Visible = false;
            Trust += 1;
            FinalAnswer();
        }
    }
}
