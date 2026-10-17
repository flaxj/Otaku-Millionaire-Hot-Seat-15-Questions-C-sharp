using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class OpeningScreen : Form
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
            this.OpenTheme = new System.Windows.Forms.Button();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLogo = new System.Windows.Forms.PictureBox();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowLogo)).BeginInit();
            this.SuspendLayout();
            this.OpenTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTheme.Location = new System.Drawing.Point(962, 50);
            this.OpenTheme.Name = "OpenTheme";
            this.OpenTheme.Size = new System.Drawing.Size(266, 619);
            this.OpenTheme.TabIndex = 7;
            this.OpenTheme.Text = "Enter Host";
            this.OpenTheme.UseVisualStyleBackColor = true;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FileToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.MenuStrip1.TabIndex = 8;
            this.MenuStrip1.Text = "MenuStrip1";
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ShowLogo.Image = Otaku_Millionaire_Hot_Seat.Properties.Resources.Otaku_Millionaire_Hot_Seat;
            this.ShowLogo.Location = new System.Drawing.Point(45, 50);
            this.ShowLogo.Name = "ShowLogo";
            this.ShowLogo.Size = new System.Drawing.Size(872, 619);
            this.ShowLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowLogo.TabIndex = 6;
            this.ShowLogo.TabStop = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.OpenTheme);
            this.Controls.Add(this.ShowLogo);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "OpeningScreen";
            this.Text = "Opening Screen";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            base.Load += OpeningScreen_Load;
            OpenTheme.Click += OpenTheme_Click;
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
        }
        internal Button OpenTheme = default(Button);
        internal PictureBox ShowLogo = default(PictureBox);
        internal MenuStrip MenuStrip1 = default(MenuStrip);
        internal ToolStripMenuItem FileToolStripMenuItem = default(ToolStripMenuItem);
        internal ToolStripMenuItem ExitToolStripMenuItem = default(ToolStripMenuItem);
    }
}
