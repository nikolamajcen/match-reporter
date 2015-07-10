using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchReporter.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            lblStatus.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                lblStatus.Text = "Unesite pristupne podatke.";
            }
            else
            {
                lblStatus.Text = "Povezivanje...";
                using (var db = new MatchReporterEntities())
                {
                    User creditials = (User)db.Users
                        .Where(u => u.Username == username)
                        .Where(u => u.Password == password)
                        .FirstOrDefault();

                    if (creditials == null)
                    {
                        lblStatus.Text = "Krivo uneseni korisnički podaci.";
                    }
                    else
                    {
                        lblStatus.Text = "";
                        this.Hide();
                        FrmMatchReporter matchReporter = new FrmMatchReporter();
                        matchReporter.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}
