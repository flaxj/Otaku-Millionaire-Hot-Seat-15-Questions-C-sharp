using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class Winnings : Form
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
            this.Prize = new System.Windows.Forms.Label();
            this.AmountWon = new System.Windows.Forms.Label();
            this.EndGame = new System.Windows.Forms.Button();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EndShowLogo = new System.Windows.Forms.PictureBox();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndShowLogo)).BeginInit();
            this.SuspendLayout();
            this.Prize.AutoSize = true;
            this.Prize.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prize.Location = new System.Drawing.Point(518, 486);
            this.Prize.Name = "Prize";
            this.Prize.Size = new System.Drawing.Size(305, 46);
            this.Prize.TabIndex = 150;
            this.Prize.Text = "Total Prize Won";
            this.AmountWon.AutoSize = true;
            this.AmountWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountWon.Location = new System.Drawing.Point(518, 552);
            this.AmountWon.Name = "AmountWon";
            this.AmountWon.Size = new System.Drawing.Size(64, 46);
            this.AmountWon.TabIndex = 151;
            this.AmountWon.Text = "¥0";
            this.EndGame.Location = new System.Drawing.Point(526, 616);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(297, 53);
            this.EndGame.TabIndex = 152;
            this.EndGame.Text = "End Game";
            this.EndGame.UseVisualStyleBackColor = true;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FileToolStripMenuItem, this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.MenuStrip1.TabIndex = 153;
            this.MenuStrip1.Text = "MenuStrip1";
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.LoadToolStripMenuItem, this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.LoadToolStripMenuItem.Text = "Load";
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.EndShowLogo.Image = Otaku_Millionaire_Hot_Seat.Properties.Resources.Otaku_Millionaire_Hot_Seat;
            this.EndShowLogo.Location = new System.Drawing.Point(225, 46);
            this.EndShowLogo.Name = "EndShowLogo";
            this.EndShowLogo.Size = new System.Drawing.Size(788, 418);
            this.EndShowLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndShowLogo.TabIndex = 4;
            this.EndShowLogo.TabStop = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.EndGame);
            this.Controls.Add(this.AmountWon);
            this.Controls.Add(this.Prize);
            this.Controls.Add(this.EndShowLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Winnings";
            this.Text = "Winnings";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndShowLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            base.Load += Winnings_Load;
            EndGame.Click += EndGame_Click;
            AboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            ExitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        }
        internal PictureBox EndShowLogo = default(PictureBox);
        internal Label Prize = default(Label);
        internal Label AmountWon = default(Label);
        internal Button EndGame = default(Button);
        internal MenuStrip MenuStrip1 = default(MenuStrip);
        internal ToolStripMenuItem FileToolStripMenuItem = default(ToolStripMenuItem);
        internal ToolStripMenuItem LoadToolStripMenuItem = default(ToolStripMenuItem);
        internal ToolStripMenuItem ExitToolStripMenuItem = default(ToolStripMenuItem);
        internal ToolStripMenuItem HelpToolStripMenuItem = default(ToolStripMenuItem);
        internal ToolStripMenuItem AboutToolStripMenuItem = default(ToolStripMenuItem);
    }
}
