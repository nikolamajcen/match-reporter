using MatchReporter.Forms.Timer;
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
    public partial class FrmMatchReporter : Form
    {
        private int Minutes;
        private int Seconds;
        public FrmMatchReporter()
        {
            InitializeComponent();
            this.Minutes = 0;
            this.Seconds = 0;
        }

        private void btnTimeStart_Click(object sender, EventArgs e)
        {
            timerMatch.Start();
        }

        private void timerMatch_Tick(object sender, EventArgs e)
        {
            this.Seconds++;
            if(this.Seconds == 60)
            {
                this.Minutes++;
                if(this.Minutes >= 10)
                {
                    lblTimeMinutes.Text = this.Minutes.ToString();
                }
                else
                {
                    lblTimeMinutes.Text = "0" + this.Minutes.ToString();
                }
                this.Seconds = 0;
            }
            if (this.Seconds >= 10)
            {
                lblTimeSeconds.Text = this.Seconds.ToString();
            }
            else
            {
                lblTimeSeconds.Text = "0" + this.Seconds.ToString();
            }
        }

        private void btnTimeStop_Click(object sender, EventArgs e)
        {
            timerMatch.Stop();
        }

        private void btnTimeChange_Click(object sender, EventArgs e)
        {
            timerMatch.Stop();
            FrmTimerChange timeChange = new FrmTimerChange(this.Minutes, this.Seconds);
            timeChange.ShowDialog();
            this.Minutes = timeChange.matchMinute;
            this.Seconds = timeChange.matchSeconds;

            if (this.Minutes >= 10)
            {
                lblTimeMinutes.Text = this.Minutes.ToString();
            }
            else
            {
                lblTimeMinutes.Text = "0" + this.Minutes.ToString();
            }

            if (this.Seconds >= 10)
            {
                lblTimeSeconds.Text = this.Seconds.ToString();
            }
            else
            {
                lblTimeSeconds.Text = "0" + this.Seconds.ToString();
            }
        }

        private void btnTimeReset_Click(object sender, EventArgs e)
        {
            timerMatch.Stop();
            this.Seconds = 0;
            this.Minutes = 0;
            lblTimeSeconds.Text = "00";
            lblTimeMinutes.Text = "00";
        }
    }
}
