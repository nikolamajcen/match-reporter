using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchReporter.Forms.Timer
{
    public partial class FrmTimerChange : Form
    {
        public int matchMinute;
        public int matchSeconds;

        public FrmTimerChange(int matchMinute, int matchSeconds)
        {
            InitializeComponent();
            this.matchMinute = matchMinute;
            this.matchSeconds = matchSeconds;
        }

        private void btnChangeTime_Click(object sender, EventArgs e)
        {
            int minutes;
            int seconds;
            try
            {
                minutes = int.Parse(txtMinutes.Text);
                seconds = int.Parse(txtSeconds.Text);
            }
            catch
            {
                minutes = this.matchMinute;
                seconds = this.matchSeconds;
                txtMinutes.Text = minutes.ToString();
                txtSeconds.Text = seconds.ToString();
                MessageBox.Show("Krivo ste unijeli vrijeme utakmice.\n Uzeti su trenutni podaci.",
                    "Greška");
            }
            if(minutes < 60 && seconds < 60)
            {
                this.matchMinute = minutes;
                this.matchSeconds = seconds;
                this.Close();
            }
            else
            {
                MessageBox.Show("Unijeli ste krive podatke za vrijeme", "Greška");
            }
        }
    }
}
