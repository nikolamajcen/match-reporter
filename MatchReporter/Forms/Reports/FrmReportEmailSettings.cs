using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchReporter.Forms.Reports
{
    public partial class FrmReportEmailSettings : Form
    {
        public FrmReportEmailSettings()
        {
            InitializeComponent();

            txtEmail.Text = EmailSettings.Default.EmailAddress;
            txtUsername.Text = EmailSettings.Default.EmailUsername;
            txtPassword.Text = EmailSettings.Default.EmailPassword;
            txtSmtpServer.Text = EmailSettings.Default.SmtpServer;
            txtSmtpPort.Value = EmailSettings.Default.SmtpPort;

            if(EmailSettings.Default.EnableSsl == true)
            {
                cbxEnableSsl.Checked = true;
            }
        }

        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            EmailSettings.Default.Reset();
            EmailSettings.Default.Reload();
            EmailSettings.Default.Save();

            txtEmail.Text = EmailSettings.Default.EmailAddress;
            txtUsername.Text = EmailSettings.Default.EmailUsername;
            txtPassword.Text = EmailSettings.Default.EmailPassword;
            txtSmtpServer.Text = EmailSettings.Default.SmtpServer;
            txtSmtpPort.Value = EmailSettings.Default.SmtpPort;

            if (EmailSettings.Default.EnableSsl == true)
            {
                cbxEnableSsl.Checked = true;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            EmailSettings.Default.EmailAddress = txtEmail.Text;
            EmailSettings.Default.EmailUsername = txtUsername.Text;
            EmailSettings.Default.EmailPassword = txtPassword.Text;
            EmailSettings.Default.SmtpServer = txtSmtpServer.Text;
            EmailSettings.Default.SmtpPort = (int)txtSmtpPort.Value;

            if(cbxEnableSsl.Checked == true)
            {
                EmailSettings.Default.EnableSsl = true;
            }
            else
            {
                EmailSettings.Default.EnableSsl = false;
            }

            EmailSettings.Default.Save();
            
            this.Close();
        }
    }
}
