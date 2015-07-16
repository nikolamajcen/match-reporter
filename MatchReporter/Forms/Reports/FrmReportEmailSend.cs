using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchReporter.Forms.Reports
{
    public partial class FrmReportEmailSend : Form
    {
        public FrmReportEmailSend(Match match, Club homeClub, Team homeTeam, Club guestClub, Team guestTeam)
        {
            InitializeComponent();

            txtSubject.Text = "Utakmica br. " + match.MatchId + ": " + homeClub.Name + " - " + guestClub.Name;
            txtMailBody.Text = "Rezultat utakmice br. " + match.MatchId + ":\n" +
                homeClub.Name + " - " + guestClub.Name + " " + homeTeam.Goals + ":" + guestTeam.Goals;
            txtRemarks.Text = "";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmReportEmailSettings reportEmailSettings = new FrmReportEmailSettings();
            reportEmailSettings.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtReceiverEmail.Text.Length == 0)
            {
                MessageBox.Show(this, "Potrebno je unijeti e-mail pošiljatelja.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string remarks = "";
                    if(txtRemarks.Text.Length > 0)
                    {
                        remarks = "\n\nNapomena: " + txtRemarks;
                    }

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(EmailSettings.Default.EmailAddress);
                    mail.To.Add(txtReceiverEmail.Text);
                    mail.Subject = txtSubject.Text;
                    mail.Body = txtMailBody.Text + remarks;

                    SmtpClient smtp = new SmtpClient(EmailSettings.Default.SmtpServer, EmailSettings.Default.SmtpPort);
                    smtp.EnableSsl = EmailSettings.Default.EnableSsl;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new System.Net.NetworkCredential(EmailSettings.Default.EmailUsername, EmailSettings.Default.EmailPassword);
                    smtp.Timeout = 20000;
                    smtp.Send(mail);

                    MessageBox.Show(this, "E-mail je uspješno poslan.", "Slanje rezultata",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show(this, "Slanje e-maila nije uspjelo.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
