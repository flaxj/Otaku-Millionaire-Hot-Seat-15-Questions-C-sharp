using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class AskResult : Form
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
            this.A = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.Result4 = new System.Windows.Forms.Label();
            this.Result3 = new System.Windows.Forms.Label();
            this.Result2 = new System.Windows.Forms.Label();
            this.Result1 = new System.Windows.Forms.Label();
            this.CloseAndRestart = new System.Windows.Forms.Button();
            this.PercentD = new System.Windows.Forms.Label();
            this.PercentC = new System.Windows.Forms.Label();
            this.PercentB = new System.Windows.Forms.Label();
            this.PercentA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(142, 60);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(47, 46);
            this.A.TabIndex = 150;
            this.A.Text = "A";
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(142, 125);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(47, 46);
            this.B.TabIndex = 151;
            this.B.Text = "B";
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(142, 193);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(49, 46);
            this.C.TabIndex = 152;
            this.C.Text = "C";
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(142, 264);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(49, 46);
            this.D.TabIndex = 153;
            this.D.Text = "D";
            this.Result4.AutoSize = true;
            this.Result4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result4.Location = new System.Drawing.Point(247, 264);
            this.Result4.Name = "Result4";
            this.Result4.Size = new System.Drawing.Size(42, 46);
            this.Result4.TabIndex = 157;
            this.Result4.Text = "0";
            this.Result3.AutoSize = true;
            this.Result3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result3.Location = new System.Drawing.Point(247, 193);
            this.Result3.Name = "Result3";
            this.Result3.Size = new System.Drawing.Size(42, 46);
            this.Result3.TabIndex = 156;
            this.Result3.Text = "0";
            this.Result2.AutoSize = true;
            this.Result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result2.Location = new System.Drawing.Point(247, 125);
            this.Result2.Name = "Result2";
            this.Result2.Size = new System.Drawing.Size(42, 46);
            this.Result2.TabIndex = 155;
            this.Result2.Text = "0";
            this.Result1.AutoSize = true;
            this.Result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result1.Location = new System.Drawing.Point(247, 60);
            this.Result1.Name = "Result1";
            this.Result1.Size = new System.Drawing.Size(42, 46);
            this.Result1.TabIndex = 154;
            this.Result1.Text = "0";
            this.CloseAndRestart.Location = new System.Drawing.Point(597, 389);
            this.CloseAndRestart.Name = "CloseAndRestart";
            this.CloseAndRestart.Size = new System.Drawing.Size(172, 49);
            this.CloseAndRestart.TabIndex = 158;
            this.CloseAndRestart.Text = "Restart";
            this.CloseAndRestart.UseVisualStyleBackColor = true;
            this.PercentD.AutoSize = true;
            this.PercentD.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentD.Location = new System.Drawing.Point(358, 264);
            this.PercentD.Name = "PercentD";
            this.PercentD.Size = new System.Drawing.Size(55, 46);
            this.PercentD.TabIndex = 294;
            this.PercentD.Text = "%";
            this.PercentD.Visible = false;
            this.PercentC.AutoSize = true;
            this.PercentC.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentC.Location = new System.Drawing.Point(358, 193);
            this.PercentC.Name = "PercentC";
            this.PercentC.Size = new System.Drawing.Size(55, 46);
            this.PercentC.TabIndex = 293;
            this.PercentC.Text = "%";
            this.PercentC.Visible = false;
            this.PercentB.AutoSize = true;
            this.PercentB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentB.Location = new System.Drawing.Point(358, 125);
            this.PercentB.Name = "PercentB";
            this.PercentB.Size = new System.Drawing.Size(55, 46);
            this.PercentB.TabIndex = 292;
            this.PercentB.Text = "%";
            this.PercentB.Visible = false;
            this.PercentA.AutoSize = true;
            this.PercentA.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentA.Location = new System.Drawing.Point(358, 60);
            this.PercentA.Name = "PercentA";
            this.PercentA.Size = new System.Drawing.Size(55, 46);
            this.PercentA.TabIndex = 291;
            this.PercentA.Text = "%";
            this.PercentA.Visible = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PercentD);
            this.Controls.Add(this.PercentC);
            this.Controls.Add(this.PercentB);
            this.Controls.Add(this.PercentA);
            this.Controls.Add(this.CloseAndRestart);
            this.Controls.Add(this.Result4);
            this.Controls.Add(this.Result3);
            this.Controls.Add(this.Result2);
            this.Controls.Add(this.Result1);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AskResult";
            this.Text = "Ask Result";
            this.ResumeLayout(false);
            this.PerformLayout();
            base.Load += AskResult_Load;
            CloseAndRestart.Click += CloseAndRestart_Click;
        }
        internal Label A = default(Label);
        internal Label B = default(Label);
        internal Label C = default(Label);
        internal Label D = default(Label);
        internal Label Result4 = default(Label);
        internal Label Result3 = default(Label);
        internal Label Result2 = default(Label);
        internal Label Result1 = default(Label);
        internal Button CloseAndRestart = default(Button);
        internal Label PercentD = default(Label);
        internal Label PercentC = default(Label);
        internal Label PercentB = default(Label);
        internal Label PercentA = default(Label);
    }
}
