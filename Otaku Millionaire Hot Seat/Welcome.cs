using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class Welcome
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void StartButton2Screen_Click(object sender, EventArgs e)
        {
            TopicFile.Title = "Topic File";
            TopicFile.Filter = "Text Files|*.txt";
            TopicFile.ShowDialog();
        }
        private void TopicFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, TopicFile.FileName, true, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.PlayerScreen.subjects = lines;
            Forms.Level1MoneyTree.subjects = lines;
            Forms.Level2MoneyTree.subjects = lines;
            Forms.Level3MoneyTree.subjects = lines;
            Forms.Level4MoneyTree.subjects = lines;
            Question01.Title = "Question 1 File";
            Question01.Filter = "Text Files|*.txt";
            Question01.ShowDialog();
        }
        private void Question01_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question01.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q01.Q1GamePlay = lines;
            Question02.Title = "Question 2 File";
            Question02.Filter = "Text Files|*.txt";
            Question02.ShowDialog();
        }
        private void Question02_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question02.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q02.Q2GamePlay = lines;
            Question03.Title = "Question 3 File";
            Question03.Filter = "Text Files|*.txt";
            Question03.ShowDialog();
        }
        private void Question03_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question03.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q03.Q3GamePlay = lines;
            Question04.Title = "Question 4 File";
            Question04.Filter = "Text Files|*.txt";
            Question04.ShowDialog();
        }
        private void Question04_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question04.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q04.Q4GamePlay = lines;
            Question05.Title = "Question 5 File";
            Question05.Filter = "Text Files|*.txt";
            Question05.ShowDialog();
        }
        private void Question05_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question05.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q05.Q5GamePlay = lines;
            Question06.Title = "Question 6 File";
            Question06.Filter = "Text Files|*.txt";
            Question06.ShowDialog();
        }
        private void Question06_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question06.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q06.Q6GamePlay = lines;
            Question07.Title = "Question 7 File";
            Question07.Filter = "Text Files|*.txt";
            Question07.ShowDialog();
        }
        private void Question07_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question07.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q07.Q7GamePlay = lines;
            Question08.Title = "Question 8 File";
            Question08.Filter = "Text Files|*.txt";
            Question08.ShowDialog();
        }
        private void Question08_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question08.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q08.Q8GamePlay = lines;
            Question09.Title = "Question 9 File";
            Question09.Filter = "Text Files|*.txt";
            Question09.ShowDialog();
        }
        private void Question09_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question09.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q09.Q9GamePlay = lines;
            Question10.Title = "Question 10 File";
            Question10.Filter = "Text Files|*.txt";
            Question10.ShowDialog();
        }
        private void Question10_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question10.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q10.Q10GamePlay = lines;
            Question11.Title = "Question 11 File";
            Question11.Filter = "Text Files|*.txt";
            Question11.ShowDialog();
        }
        private void Question11_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question11.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q11.Q11GamePlay = lines;
            Question12.Title = "Question 12 File";
            Question12.Filter = "Text Files|*.txt";
            Question12.ShowDialog();
        }
        private void Question12_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question12.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q12.Q12GamePlay = lines;
            Question13.Title = "Question 13 File";
            Question13.Filter = "Text Files|*.txt";
            Question13.ShowDialog();
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AboutBox.Show();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Question13_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question13.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q13.Q13GamePlay = lines;
            Question14.Title = "Question 14 File";
            Question14.Filter = "Text Files|*.txt";
            Question14.ShowDialog();
        }
        private void Question14_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question14.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q14.Q14GamePlay = lines;
            Question15.Title = "Question 15 File";
            Question15.Filter = "Text Files|*.txt";
            Question15.ShowDialog();
        }
        private void Question15_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] lines;
            if (!GameInput.TryRead(this, Question15.FileName, false, out lines))
            {
                e.Cancel = true;
                return;
            }
            Forms.Q15.Q15GamePlay = lines;
            Forms.OpeningScreen.Show();
            Forms.PlayerScreen.Show();
        }
    }
}
