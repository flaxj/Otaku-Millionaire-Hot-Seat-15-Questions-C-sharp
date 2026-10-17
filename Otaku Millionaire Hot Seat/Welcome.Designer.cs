using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class Welcome : Form
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }
        private System.ComponentModel.IContainer components = default(System.ComponentModel.IContainer);
        private void InitializeComponent()
        {
            this.StartButton2Screen = new System.Windows.Forms.Button();
            this.ShowLogo = new System.Windows.Forms.PictureBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Question12 = new System.Windows.Forms.OpenFileDialog();
            this.Question11 = new System.Windows.Forms.OpenFileDialog();
            this.Question10 = new System.Windows.Forms.OpenFileDialog();
            this.Question09 = new System.Windows.Forms.OpenFileDialog();
            this.Question08 = new System.Windows.Forms.OpenFileDialog();
            this.Question07 = new System.Windows.Forms.OpenFileDialog();
            this.Question06 = new System.Windows.Forms.OpenFileDialog();
            this.Question05 = new System.Windows.Forms.OpenFileDialog();
            this.Question04 = new System.Windows.Forms.OpenFileDialog();
            this.Question03 = new System.Windows.Forms.OpenFileDialog();
            this.Question02 = new System.Windows.Forms.OpenFileDialog();
            this.Question01 = new System.Windows.Forms.OpenFileDialog();
            this.TopicFile = new System.Windows.Forms.OpenFileDialog();
            this.Question13 = new System.Windows.Forms.OpenFileDialog();
            this.Question14 = new System.Windows.Forms.OpenFileDialog();
            this.Question15 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ShowLogo)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.StartButton2Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton2Screen.Location = new System.Drawing.Point(962, 38);
            this.StartButton2Screen.Name = "StartButton2Screen";
            this.StartButton2Screen.Size = new System.Drawing.Size(266, 619);
            this.StartButton2Screen.TabIndex = 4;
            this.StartButton2Screen.Text = "Load Topics and Questions";
            this.StartButton2Screen.UseVisualStyleBackColor = true;
            this.ShowLogo.Image = Otaku_Millionaire_Hot_Seat.Properties.Resources.Otaku_Millionaire_Hot_Seat;
            this.ShowLogo.Location = new System.Drawing.Point(45, 38);
            this.ShowLogo.Name = "ShowLogo";
            this.ShowLogo.Size = new System.Drawing.Size(872, 619);
            this.ShowLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowLogo.TabIndex = 3;
            this.ShowLogo.TabStop = false;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FileToolStripMenuItem, this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.MenuStrip1.TabIndex = 5;
            this.MenuStrip1.Text = "MenuStrip1";
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.Question12.FileName = "Question 12";
            this.Question12.Title = "Question 12";
            this.Question11.FileName = "Question 11";
            this.Question11.Title = "Question 11";
            this.Question10.FileName = "Question 10";
            this.Question10.Title = "Question 10";
            this.Question09.FileName = "Question 09";
            this.Question09.Title = "Question 09";
            this.Question08.FileName = "Question 08";
            this.Question08.Title = "Question 08";
            this.Question07.FileName = "Question 07";
            this.Question07.Title = "Question 07";
            this.Question06.FileName = "Question 06";
            this.Question06.Title = "Question 06";
            this.Question05.FileName = "Question 05";
            this.Question05.Title = "Question 05";
            this.Question04.FileName = "Question 04";
            this.Question04.Title = "Question 04";
            this.Question03.FileName = "Question03";
            this.Question03.Title = "Question 03";
            this.Question02.FileName = "Question02";
            this.Question02.Title = "Question 02";
            this.Question01.FileName = "Question01";
            this.Question01.Title = "Question 01";
            this.TopicFile.FileName = "Topic File";
            this.TopicFile.Title = "Topic";
            this.Question13.FileName = "Question 13";
            this.Question13.Title = "Question 12";
            this.Question14.FileName = "Question 14";
            this.Question14.Title = "Question 12";
            this.Question15.FileName = "Question 15";
            this.Question15.Title = "Question 12";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.StartButton2Screen);
            this.Controls.Add(this.ShowLogo);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Welcome";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.ShowLogo)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            StartButton2Screen.Click += StartButton2Screen_Click;
            TopicFile.FileOk += TopicFile_FileOk;
            Question01.FileOk += Question01_FileOk;
            Question02.FileOk += Question02_FileOk;
            Question03.FileOk += Question03_FileOk;
            Question04.FileOk += Question04_FileOk;
            Question05.FileOk += Question05_FileOk;
            Question06.FileOk += Question06_FileOk;
            Question07.FileOk += Question07_FileOk;
            Question08.FileOk += Question08_FileOk;
            Question09.FileOk += Question09_FileOk;
            Question10.FileOk += Question10_FileOk;
            Question11.FileOk += Question11_FileOk;
            Question12.FileOk += Question12_FileOk;
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            Question13.FileOk += Question13_FileOk;
            Question14.FileOk += Question14_FileOk;
            Question15.FileOk += Question15_FileOk;
        }
        internal Button StartButton2Screen = default(Button);
        internal PictureBox ShowLogo = default(PictureBox);
        internal MenuStrip MenuStrip1 = default(MenuStrip);
        internal ToolStripMenuItem FileToolStripMenuItem = default(ToolStripMenuItem);
        internal ToolStripMenuItem ExitToolStripMenuItem = default(ToolStripMenuItem);
        internal ToolStripMenuItem HelpToolStripMenuItem = default(ToolStripMenuItem);
        internal ToolStripMenuItem AboutToolStripMenuItem = default(ToolStripMenuItem);
        internal OpenFileDialog Question12 = default(OpenFileDialog);
        internal OpenFileDialog Question11 = default(OpenFileDialog);
        internal OpenFileDialog Question10 = default(OpenFileDialog);
        internal OpenFileDialog Question09 = default(OpenFileDialog);
        internal OpenFileDialog Question08 = default(OpenFileDialog);
        internal OpenFileDialog Question07 = default(OpenFileDialog);
        internal OpenFileDialog Question06 = default(OpenFileDialog);
        internal OpenFileDialog Question05 = default(OpenFileDialog);
        internal OpenFileDialog Question04 = default(OpenFileDialog);
        internal OpenFileDialog Question03 = default(OpenFileDialog);
        internal OpenFileDialog Question02 = default(OpenFileDialog);
        internal OpenFileDialog Question01 = default(OpenFileDialog);
        internal OpenFileDialog TopicFile = default(OpenFileDialog);
        internal OpenFileDialog Question13 = default(OpenFileDialog);
        internal OpenFileDialog Question14 = default(OpenFileDialog);
        internal OpenFileDialog Question15 = default(OpenFileDialog);
    }
}
