using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class PlayerScreen
    {
        public PlayerScreen()
        {
            InitializeComponent();
        }
        internal int Players = 6;
        internal string[] subjects = new string[16];
        internal string[] question = new string[8];
        private void PlayerScreen_Load(object sender, EventArgs e)
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
        public void StartandResumeGame()
        {
            HideValue();
        }
        public void QuestionLoader()
        {
            Question1.Text = question[0];
            Question2.Text = question[1];
            Question3.Text = question[2];
            ChoiceA.Text = question[3];
            ChoiceB.Text = question[4];
            ChoiceC.Text = question[5];
            ChoiceD.Text = question[6];
        }
        public void ShowQuestions()
        {
            Question1.Visible = true;
            Question2.Visible = true;
            Question3.Visible = true;
        }
        public void ShowChoices()
        {
            ChoiceA.Visible = true;
            ChoiceB.Visible = true;
            ChoiceC.Visible = true;
            ChoiceD.Visible = true;
        }
        public void ResetQuestionArea()
        {
            Question1.Visible = false;
            Question2.Visible = false;
            Question3.Visible = false;
            ChoiceA.Visible = false;
            ChoiceB.Visible = false;
            ChoiceC.Visible = false;
            ChoiceD.Visible = false;
            Array.Clear(question, 0, 7);
            question = new string[8];
            QuestionLoader();
            ChoiceA.Font = new Font(ChoiceA.Font.FontFamily, 30);
            ChoiceB.Font = new Font(ChoiceB.Font.FontFamily, 30);
            ChoiceC.Font = new Font(ChoiceC.Font.FontFamily, 30);
            ChoiceD.Font = new Font(ChoiceD.Font.FontFamily, 30);
            ChoiceA.BackColor = DefaultBackColor;
            ChoiceA.ForeColor = DefaultForeColor;
            ChoiceB.BackColor = DefaultBackColor;
            ChoiceB.ForeColor = DefaultForeColor;
            ChoiceC.BackColor = DefaultBackColor;
            ChoiceC.ForeColor = DefaultForeColor;
            ChoiceD.BackColor = DefaultBackColor;
            ChoiceD.ForeColor = DefaultForeColor;
            Seconds.BackColor = DefaultBackColor;
            Seconds.ForeColor = DefaultForeColor;
            Placeholder.BackColor = DefaultBackColor;
            Placeholder.ForeColor = DefaultForeColor;
            Tenths.BackColor = DefaultBackColor;
            Tenths.ForeColor = DefaultForeColor;
        }
        public void HideChoices()
        {
            ChoiceA.Visible = false;
            ChoiceB.Visible = false;
            ChoiceC.Visible = false;
            ChoiceD.Visible = false;
        }
        public void LevelWindow()
        {
            Topic.Visible = false;
            Seconds.Visible = false;
            Placeholder.Visible = false;
            Tenths.Visible = false;
            QuestionValue.Visible = false;
        }
        public void EndOfGame()
        {
            Topic.Visible = false;
            Seconds.Visible = false;
            Placeholder.Visible = false;
            Tenths.Visible = false;
            QuestionValue.Visible = false;
            AskPic.Visible = false;
            AskFriendPic.Visible = false;
            DoubleDipPic.Visible = false;
            TrustPic.Visible = false;
            PassPic.Visible = false;
            Prize.Visible = true;
            ResetQuestionArea();
        }
    }
}
