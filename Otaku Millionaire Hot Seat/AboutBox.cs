using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Otaku_Millionaire_Hot_Seat
{
    public sealed partial class AboutBox
    {
        public AboutBox()
        {
            InitializeComponent();
        }
        private void AboutBox_Load(System.Object sender, System.EventArgs e)
        {
            string ApplicationTitle = default(string);
            if (AppInfo.Title != "")
            {
                ApplicationTitle = AppInfo.Title;
            }
            else
            {
                ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(AppInfo.AssemblyName);
            }
            this.Text = string.Format("About {0}", ApplicationTitle);
            this.LabelProductName.Text = AppInfo.ProductName;
            this.LabelVersion.Text = string.Format("Version {0}", AppInfo.Version.ToString());
            this.LabelCopyright.Text = AppInfo.Copyright;
            this.LabelCompanyName.Text = AppInfo.CompanyName;
            this.TextBoxDescription.Text = AppInfo.Description;
        }
        private void OKButton_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
