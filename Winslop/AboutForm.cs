using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Winslop
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Update version label
            this.lblVersionInfo.Text = $"{Program.GetAppVersion()} ";
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.paypal.me/Hasanovic7",
                UseShellExecute = true
            });
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/builtbybel/Winslop/releases");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}