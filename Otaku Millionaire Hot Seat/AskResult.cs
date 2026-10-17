using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class AskResult
    {
        public AskResult()
        {
            InitializeComponent();
        }
        internal int questionsRemaining = default(int);
        internal int AskA = default(int);
        internal int AskB = default(int);
        internal int AskC = default(int);
        internal int AskD = default(int);
        internal int ask = default(int);
        private int asksum = default(int);
        private void AskResult_Load(object sender, EventArgs e)
        {
            if (questionsRemaining == 5)
            {
                AskA = Forms.Q11.AskA;
                AskB = Forms.Q11.AskB;
                AskC = Forms.Q11.AskC;
                AskD = Forms.Q11.AskD;
                asksum = Forms.Q11.AskSum;
            }
            else if (questionsRemaining == 4)
            {
                AskA = Forms.Q12.AskA;
                AskB = Forms.Q12.AskB;
                AskC = Forms.Q12.AskC;
                AskD = Forms.Q12.AskD;
                asksum = Forms.Q12.AskSum;
            }
            else if (questionsRemaining == 3)
            {
                AskA = Forms.Q13.AskA;
                AskB = Forms.Q13.AskB;
                AskC = Forms.Q13.AskC;
                AskD = Forms.Q13.AskD;
                asksum = Forms.Q13.AskSum;
            }
            else if (questionsRemaining == 2)
            {
                AskA = Forms.Q14.AskA;
                AskB = Forms.Q14.AskB;
                AskC = Forms.Q14.AskC;
                AskD = Forms.Q14.AskD;
                asksum = Forms.Q14.AskSum;
            }
            else
            {
                AskA = Forms.Q15.AskA;
                AskB = Forms.Q15.AskB;
                AskC = Forms.Q15.AskC;
                AskD = Forms.Q15.AskD;
                asksum = Forms.Q15.AskSum;
            }
            AskA = asksum == 0 ? 0 : Convert.ToInt32((double)AskA / asksum * 100);
            AskB = asksum == 0 ? 0 : Convert.ToInt32((double)AskB / asksum * 100);
            AskC = asksum == 0 ? 0 : Convert.ToInt32((double)AskC / asksum * 100);
            AskD = asksum == 0 ? 0 : Convert.ToInt32((double)AskD / asksum * 100);
            Result1.Text = Convert.ToString(AskA);
            Result2.Text = Convert.ToString(AskB);
            Result3.Text = Convert.ToString(AskC);
            Result4.Text = Convert.ToString(AskD);
            Forms.PlayerScreen.Result1.Text = Result1.Text;
            Forms.PlayerScreen.Result2.Text = Result2.Text;
            Forms.PlayerScreen.Result3.Text = Result3.Text;
            Forms.PlayerScreen.Result4.Text = Result4.Text;
            GameAudio.Play(Properties.Resources.AskLifelineResults, AudioPlayMode.WaitToComplete);
            A.Visible = true;
            Result1.Visible = true;
            PercentA.Visible = true;
            B.Visible = true;
            Result2.Visible = true;
            PercentB.Visible = true;
            C.Visible = true;
            Result3.Visible = true;
            PercentC.Visible = true;
            D.Visible = true;
            Result4.Visible = true;
            PercentD.Visible = true;
            Forms.PlayerScreen.A.Visible = true;
            Forms.PlayerScreen.Result1.Visible = true;
            Forms.PlayerScreen.PercentA.Visible = true;
            Forms.PlayerScreen.B.Visible = true;
            Forms.PlayerScreen.Result2.Visible = true;
            Forms.PlayerScreen.PercentB.Visible = true;
            Forms.PlayerScreen.C.Visible = true;
            Forms.PlayerScreen.Result3.Visible = true;
            Forms.PlayerScreen.PercentC.Visible = true;
            Forms.PlayerScreen.D.Visible = true;
            Forms.PlayerScreen.Result4.Visible = true;
            Forms.PlayerScreen.PercentD.Visible = true;
        }
        private void CloseAndRestart_Click(object sender, EventArgs e)
        {
            ask += 1;
            if (questionsRemaining == 5)
            {
                Forms.Q11.ask = ask;
                Forms.Q11.asklifeline();
            }
            else if (questionsRemaining == 4)
            {
                Forms.Q12.ask = ask;
                Forms.Q12.asklifeline();
            }
            else if (questionsRemaining == 3)
            {
                Forms.Q13.ask = ask;
                Forms.Q13.asklifeline();
            }
            else if (questionsRemaining == 2)
            {
                Forms.Q14.ask = ask;
                Forms.Q14.asklifeline();
            }
            else
            {
                Forms.Q15.ask = ask;
                Forms.Q15.asklifeline();
            }
        }
    }
}
