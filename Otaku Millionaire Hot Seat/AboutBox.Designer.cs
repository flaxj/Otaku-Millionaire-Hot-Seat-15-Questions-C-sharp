using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public partial class AboutBox : Form
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
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel = default(System.Windows.Forms.TableLayoutPanel);
        internal System.Windows.Forms.PictureBox LogoPictureBox = default(System.Windows.Forms.PictureBox);
        internal System.Windows.Forms.Label LabelProductName = default(System.Windows.Forms.Label);
        internal System.Windows.Forms.Label LabelVersion = default(System.Windows.Forms.Label);
        internal System.Windows.Forms.Label LabelCompanyName = default(System.Windows.Forms.Label);
        internal System.Windows.Forms.TextBox TextBoxDescription = default(System.Windows.Forms.TextBox);
        internal System.Windows.Forms.Button OKButton = default(System.Windows.Forms.Button);
        internal System.Windows.Forms.Label LabelCopyright = default(System.Windows.Forms.Label);
        private System.ComponentModel.IContainer components = default(System.ComponentModel.IContainer);
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.LabelCompanyName = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0f));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0f));
            this.TableLayoutPanel.Controls.Add(this.LogoPictureBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelProductName, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelVersion, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.LabelCopyright, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.LabelCompanyName, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.TextBoxDescription, 1, 4);
            this.TableLayoutPanel.Controls.Add(this.OKButton, 1, 5);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 6;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0f));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0f));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0f));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0f));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0f));
            this.TableLayoutPanel.Size = new System.Drawing.Size(396, 258);
            this.TableLayoutPanel.TabIndex = 0;
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.TableLayoutPanel.SetRowSpan(this.LogoPictureBox, 6);
            this.LogoPictureBox.Size = new System.Drawing.Size(124, 252);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            this.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelProductName.Location = new System.Drawing.Point(136, 0);
            this.LabelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.LabelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(257, 17);
            this.LabelProductName.TabIndex = 0;
            this.LabelProductName.Text = "Product Name";
            this.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelVersion.Location = new System.Drawing.Point(136, 25);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.LabelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(257, 17);
            this.LabelVersion.TabIndex = 0;
            this.LabelVersion.Text = "Version";
            this.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCopyright.Location = new System.Drawing.Point(136, 50);
            this.LabelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.LabelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(257, 17);
            this.LabelCopyright.TabIndex = 0;
            this.LabelCopyright.Text = "Copyright";
            this.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCompanyName.Location = new System.Drawing.Point(136, 75);
            this.LabelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.LabelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.LabelCompanyName.Name = "LabelCompanyName";
            this.LabelCompanyName.Size = new System.Drawing.Size(257, 17);
            this.LabelCompanyName.TabIndex = 0;
            this.LabelCompanyName.Text = "Company Name";
            this.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxDescription.Location = new System.Drawing.Point(136, 103);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxDescription.Size = new System.Drawing.Size(257, 123);
            this.TextBoxDescription.TabIndex = 0;
            this.TextBoxDescription.TabStop = false;
            this.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text");
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OKButton.Location = new System.Drawing.Point(318, 232);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "&OK";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.OKButton;
            this.ClientSize = new System.Drawing.Size(414, 276);
            this.Controls.Add(this.TableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            base.Load += AboutBox_Load;
            OKButton.Click += OKButton_Click;
        }
    }
}
