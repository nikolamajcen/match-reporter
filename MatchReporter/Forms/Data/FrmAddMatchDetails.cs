using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchReporter.Forms.Data.Add
{
    public partial class FrmAddMatchDetails : Form
    {
        private MatchReporterEntities db = new MatchReporterEntities();

        public bool MatchDetailsAddSuccess;

        public int LeagueId;
        public int Round;
        public DateTime Date;
        public TimeSpan Time;
        public int HallId;
        public int RefereePairId;
        public int DelegateId;
        public int Spectators;
        public string TimeKeeper;
        public string Scorer;
        public string RefereePairName;

        public BindingList<League> Leagues;
        public BindingList<Hall> Halls;
        public BindingList<RefereePair> RefereePairs;
        public BindingList<Delegate> Delegates;

        public Match Match;
        public FrmAddMatchDetails(Match match)
        {
            InitializeComponent();

            this.Match = match;

            this.MatchDetailsAddSuccess = false;

            this.Leagues = new BindingList<League>(db.League.ToList());
            this.Halls = new BindingList<Hall>(db.Hall.ToList());
            this.RefereePairs = new BindingList<RefereePair>(db.RefereePair.ToList());
            this.Delegates = new BindingList<Delegate>(db.Delegate.ToList());

            cbxLeague.DataSource = this.Leagues;
            cbxHall.DataSource = this.Halls;
            cbxRefereePair.DataSource = this.RefereePairs;
            cbxDelegate.DataSource = this.Delegates;

            dtpDateTime.MinDate = DateTime.Now;
            dtpDateTime.Value = DateTime.Now.AddMinutes(15);

            if(match.MatchId != 0)
            {
                txtRound.Value = this.Match.Round;
                txtSpectators.Value = this.Match.Spectators;
                txtScorer.Text = this.Match.Scorer;
                txtTimeKeeper.Text = this.Match.TimeKeeper;

                dtpDateTime.Value = new DateTime(this.Match.Date.Year, this.Match.Date.Month, this.Match.Date.Day,
                    this.Match.Time.Hours, this.Match.Time.Minutes, 0);

                foreach(object row in cbxLeague.Items)
                {
                    League data = (League)row;
                    if(data.LeagueId == this.Match.LeagueId)
                    {
                        cbxLeague.SelectedItem = row;
                        break;
                    }
                }

                foreach (object row in cbxHall.Items)
                {
                    Hall data = (Hall)row;
                    if (data.HallId == this.Match.HallId)
                    {
                        cbxLeague.SelectedItem = row;
                        break;
                    }
                }

                foreach (object row in cbxRefereePair.Items)
                {
                    RefereePair data = (RefereePair)row;
                    if (data.RefereePairId == this.Match.RefereePairId)
                    {
                        cbxLeague.SelectedItem = row;
                        break;
                    }
                }

                foreach (object row in cbxDelegate.Items)
                {
                    Delegate data = (Delegate)row;
                    if (data.DelegateId == this.Match.DelegateId)
                    {
                        cbxLeague.SelectedItem = row;
                        break;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool dateTimeStatus = false;
            bool scorerAndTimeKeeperStatus = false;
            bool spectatorsNumberStatus = false;

            this.LeagueId = ((League)(cbxLeague.SelectedItem)).LeagueId;
            this.HallId = ((Hall)(cbxHall.SelectedItem)).HallId;
            this.RefereePairId = ((RefereePair)(cbxRefereePair.SelectedItem)).RefereePairId;
            this.DelegateId = ((Delegate)(cbxDelegate.SelectedItem)).DelegateId;

            this.RefereePairName = cbxRefereePair.DisplayMember;

            this.Round = (int)txtRound.Value;

            // Date (Provjera)
            // Time 
            if(dtpDateTime.Value > DateTime.Now)
            {
                this.Date = dtpDateTime.Value.Date;
                this.Time = dtpDateTime.Value.TimeOfDay;
                dateTimeStatus = true;
            }
            this.RefereePairName = cbxRefereePair.Text;

            // Spectators
            if((int)txtSpectators.Value <= ((Hall)cbxHall.SelectedItem).Capacity)
            {
                this.Spectators = (int)txtSpectators.Value;
                spectatorsNumberStatus = true;
            }

            // TimeKeeper (Provjera)
            // Scorer (Provjera)
            if(txtTimeKeeper.Text.Length > 0 && txtScorer.Text.Length > 0)
            {
                this.TimeKeeper = txtTimeKeeper.Text;
                this.Scorer = txtScorer.Text;
                scorerAndTimeKeeperStatus = true;
            }

            if (dateTimeStatus == false && scorerAndTimeKeeperStatus == false && spectatorsNumberStatus == false)
            {
                MessageBox.Show(this, "Odabrali ste krivi datum/vrijeme. " +
                    "\nMaksimalni kapacitet ove dvorane je " + ((Hall)cbxHall.SelectedItem).Capacity.ToString() + "." + 
                    "\nNiste unijeli zapisničara i/ili mjeritelja vremena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimeStatus == false)
            {
                MessageBox.Show(this, "Odabrali ste krivi datum i vrijeme. \nPočetak utakmice mora biti nakon trenutnog vremena.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (scorerAndTimeKeeperStatus == false)
            {
                MessageBox.Show(this, "Niste unijeli zapisničara i/ili mjeritelja vremena", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (spectatorsNumberStatus == false)
            {
                MessageBox.Show(this, "Maksimalni kapacitet ove dvorane je " + ((Hall)cbxHall.SelectedItem).Capacity.ToString() + ".", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.MatchDetailsAddSuccess = true;
                this.Close();
            }
        }
    }
}
