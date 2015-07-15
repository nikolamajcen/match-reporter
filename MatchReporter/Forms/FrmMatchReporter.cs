﻿using MatchReporter.Classes;
using MatchReporter.Forms.Data;
using MatchReporter.Forms.Data.Add;
using MatchReporter.Forms.Podaci.Unos;
using MatchReporter.Forms.Timer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchReporter.Forms
{
    public partial class FrmMatchReporter : Form
    {
        public Match Match;

        // Club info
        public Club HomeClub;
        public Club GuestClub;

        // Team game stats
        public Team HomeTeam;
        public Team GuestTeam;

        // Players info
        public BindingList<Player> HomePlayers;
        public BindingList<Player> GuestPlayers;

        // Players game stats in DataGridView
        public BindingList<TeamPlayer> HomeTeamPlayers;
        public BindingList<TeamPlayer> GuestTeamPlayers;

        // Players game stats
        public BindingList<Play> HomePlays;
        public BindingList<Play> GuestPlays;

        // Officials info
        public BindingList<ClubOfficial> HomeClubOfficials;
        public BindingList<ClubOfficial> GuestClubOfficials;

        // Officials game stats in DataGridView
        public BindingList<TeamOfficial> HomeTeamOfficials;
        public BindingList<TeamOfficial> GuestTeamOfficials;

        // Officials game stats
        public BindingList<Manage> HomeManages;
        public BindingList<Manage> GuestManages;

        // Match info
        private int Minutes;
        private int Seconds;

        public static Thread loadingThread;

        public FrmMatchReporter()
        {
            InitializeComponent();

            this.dataMatchDetailsToolStripMenuItem.Enabled = false;
            this.dataTeamsToolStripMenuItem.Enabled = false;
            this.dataPlayersToolStripMenuItem.Enabled = false;
            this.dataOfficialsToolStripMenuItem.Enabled = false;

            this.matchSaveToolStripMenuItem.Enabled = false;
            this.matchConcludeToolStripMenuItem.Enabled = false;
            this.matchCloseToolStripMenuItem.Enabled = false;

            this.reportPrintToolStripMenuItem.Enabled = false;
            this.reportSendToolStripMenuItem.Enabled = false;

            this.Minutes = 0;
            this.Seconds = 0;
            panelMain.Hide();

            this.HomePlayers = new BindingList<Player>();
            this.GuestPlayers = new BindingList<Player>();

            HomeTeamPlayers = new BindingList<TeamPlayer>();
            GuestTeamPlayers = new BindingList<TeamPlayer>();

            HomeTeamOfficials = new BindingList<TeamOfficial>();
            GuestTeamOfficials = new BindingList<TeamOfficial>();
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

            if(this.Minutes == 30 && this.Seconds == 0 || this.Minutes == 60 && this.Seconds == 0)
            {
                timerMatch.Stop();
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

        private void FrmMatchReporter_Load(object sender, EventArgs e)
        {
            //dgvTeamA.RowCount = 16;
            //dgvTeamB.RowCount = 16;
        }

        private void matchNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Show();

            lblTeamA.Text = "";
            lblTeamB.Text = "";

            this.Match = new Match();

            this.HomeClub = new Club();
            this.GuestClub = new Club();

            this.HomePlayers = new BindingList<Player>();
            this.GuestPlayers = new BindingList<Player>();

            this.HomeClubOfficials = new BindingList<ClubOfficial>();
            this.GuestClubOfficials = new BindingList<ClubOfficial>();

            this.dataMatchDetailsToolStripMenuItem.Enabled = true;
            this.dataTeamsToolStripMenuItem.Enabled = true;
            this.dataPlayersToolStripMenuItem.Enabled = true;
            this.dataOfficialsToolStripMenuItem.Enabled = true;

            this.matchSaveToolStripMenuItem.Enabled = true;
            this.matchConcludeToolStripMenuItem.Enabled = true;
            this.matchCloseToolStripMenuItem.Enabled = true;

            this.reportPrintToolStripMenuItem.Enabled = true;
            this.reportSendToolStripMenuItem.Enabled = true;
        }

        private void matchCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Match = null;

            this.HomeClub = null;
            this.HomePlayers = null;
            this.HomePlays = null;
            this.HomeClubOfficials = null;
            this.HomeManages = null;

            this.GuestClub = null;
            this.GuestPlayers = null;
            this.GuestPlays = null;
            this.GuestClubOfficials = null;
            this.GuestManages = null;

            lblTeamA.Text = "Team A";
            lblTeamB.Text = "Team B";
            lblResultA.Text = "0";
            lblResultB.Text = "0";
            lblTimeMinutes.Text = "00";
            lblTimeSeconds.Text = "00";

            this.dataMatchDetailsToolStripMenuItem.Enabled = false;
            this.dataTeamsToolStripMenuItem.Enabled = false;
            this.dataPlayersToolStripMenuItem.Enabled = false;
            this.dataOfficialsToolStripMenuItem.Enabled = false;

            this.matchSaveToolStripMenuItem.Enabled = false;
            this.matchConcludeToolStripMenuItem.Enabled = false;
            this.matchCloseToolStripMenuItem.Enabled = false;

            this.reportPrintToolStripMenuItem.Enabled = false;
            this.reportSendToolStripMenuItem.Enabled = false;

            panelMain.Hide();
        }

        private void dataMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddMatchDetails dataAddMatchDetails = new FrmAddMatchDetails();
            dataAddMatchDetails.ShowDialog();

            if (dataAddMatchDetails.MatchDetailsAddSuccess)
            {
                this.Match.LeagueId = dataAddMatchDetails.LeagueId;
                this.Match.Date = dataAddMatchDetails.Date;
                this.Match.Time = dataAddMatchDetails.Time;
                this.Match.HallId = dataAddMatchDetails.HallId;
                this.Match.Spectators = dataAddMatchDetails.Spectators;
                this.Match.RefereePairId = dataAddMatchDetails.RefereePairId;
                this.Match.DelegateId = dataAddMatchDetails.DelegateId;
                this.Match.TimeKeeper = dataAddMatchDetails.TimeKeeper;
                this.Match.Scorer = dataAddMatchDetails.Scorer;
                
                using (var db = new MatchReporterEntities())
                {
                    db.Entry(this.Match).State = this.Match.MatchId == 0 ? EntityState.Added : EntityState.Modified;
                    db.SaveChanges();
                }
            }
            dataAddMatchDetails.Dispose();
        }

        private void dataTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddTeam dataAddTeam = new FrmAddTeam(this.HomeClub.ClubId, this.GuestClub.ClubId);
                dataAddTeam.ShowDialog();

                if (dataAddTeam.TeamsSelected)
                {
                    this.HomeClub = dataAddTeam.HomeTeam;
                    this.GuestClub = dataAddTeam.GuestTeam;

                    this.HomeTeam = new Team(this.Match.MatchId, this.HomeClub.ClubId);
                    this.GuestTeam = new Team(this.Match.MatchId, this.GuestClub.ClubId);
                    this.HomeTeam.JerseyColor = this.HomeClub.JerseyColorHome;
                    this.GuestTeam.JerseyColor = this.GuestClub.JerseyColorGuest;

                    this.lblTeamA.Text = HomeClub.Name;
                    this.lblTeamB.Text = GuestClub.Name;

                    if (dataAddTeam.TeamSelectionChanged)
                    {
                        this.HomePlayers = new BindingList<Player>();
                        this.GuestPlayers = new BindingList<Player>();

                        this.HomeTeamPlayers = new BindingList<TeamPlayer>();
                        this.GuestTeamPlayers = new BindingList<TeamPlayer>();

                        dgvHomeTeam.DataSource = HomeTeamPlayers;
                        dgvHomeTeam.Refresh();
                        dgvGuestTeam.DataSource = GuestTeamPlayers;
                        dgvGuestTeam.Refresh();

                        this.HomePlays = new BindingList<Play>();
                        this.GuestPlays = new BindingList<Play>();

                        this.HomeClubOfficials = new BindingList<ClubOfficial>();
                        this.GuestClubOfficials = new BindingList<ClubOfficial>();

                        this.HomeTeamOfficials = new BindingList<TeamOfficial>();
                        this.GuestTeamOfficials = new BindingList<TeamOfficial>();

                        dgvHomeOfficials.DataSource = this.HomeTeamOfficials;
                        dgvHomeOfficials.Refresh();
                        dgvGuestOfficials.DataSource = this.GuestTeamOfficials;
                        dgvGuestOfficials.Refresh();

                        this.HomeManages = new BindingList<Manage>();
                        this.GuestManages = new BindingList<Manage>();

                        using (var db = new MatchReporterEntities())
                        {
                            List<Team> previousTeams = new List<Team>(db.Team.Where<Team>(t => t.MatchId == this.Match.MatchId).ToList<Team>());
                            foreach (Team team in previousTeams)
                            {
                                db.Team.Remove(team);
                            }
                        }
                    }

                    using (var db = new MatchReporterEntities())
                    {
                        db.Entry(this.HomeTeam).State = dataAddTeam.TeamSelectionChanged == true ? EntityState.Added : EntityState.Modified;
                        db.Entry(this.GuestTeam).State = dataAddTeam.TeamSelectionChanged == true ? EntityState.Added : EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                dataAddTeam.Dispose();
            }
            catch
            {
                MessageBox.Show(this, "Da biste dodali momčadi, prvo je potrebno unijeti podatke o utakmici.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dataPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddPlayers dataAddPlayers = new FrmAddPlayers(this.HomeClub.ClubId, this.GuestClub.ClubId, this.HomePlayers, this.GuestPlayers);
                dataAddPlayers.ShowDialog();

                if (dataAddPlayers.PlayersAddSuccess)
                {
                    this.HomePlays = new BindingList<Play>();
                    this.GuestPlays = new BindingList<Play>();

                    this.HomePlayers = dataAddPlayers.HomePlayersPlay;
                    this.GuestPlayers = dataAddPlayers.GuestPlayersPlay;

                    this.HomeTeamPlayers.Clear();
                    this.GuestTeamPlayers.Clear();

                    using (var db = new MatchReporterEntities())
                    {
                        List<Play> previousPlays = new List<Play>(db.Play.Where<Play>(p => p.MatchId == this.Match.MatchId).ToList<Play>());
                        foreach(Play play in previousPlays)
                        {
                            db.Play.Remove(play);
                        }
                        db.SaveChanges();
                    }

                    foreach (Player player in this.HomePlayers)
                    {
                        TeamPlayer teamPlayer = new TeamPlayer(player.PlayerId, player.FirstName, player.LastName, player.Number);
                        this.HomeTeamPlayers.Add(teamPlayer);

                        Play play = new Play(this.Match.MatchId, player.PlayerId);
                        this.HomePlays.Add(play);
                    }

                    foreach (Player player in this.GuestPlayers)
                    {
                        TeamPlayer teamPlayer = new TeamPlayer(player.PlayerId, player.FirstName, player.LastName, player.Number);
                        this.GuestTeamPlayers.Add(teamPlayer);

                        Play play = new Play(this.Match.MatchId, player.PlayerId);
                        this.GuestPlays.Add(play);
                    }

                    using (var db = new MatchReporterEntities())
                    {
                        foreach(Play play in this.HomePlays)
                        {
                            db.Play.Add(play);
                        }

                        foreach(Play play in this.GuestPlays)
                        {
                            db.Play.Add(play);
                        }
                        db.SaveChanges();
                    }

                    dgvHomeTeam.DataSource = this.HomeTeamPlayers;
                    dgvGuestTeam.DataSource = this.GuestTeamPlayers;
                    dgvHomeTeam.Refresh();
                    dgvGuestTeam.Refresh();
                }
                dataAddPlayers.Dispose();
            }
            catch
            {
                MessageBox.Show(this, "Da biste dodali igrače, prvo je potrebno dodati momčadi.", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataOfficialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddOfficials dataAddOfficials = new FrmAddOfficials(this.HomeClub.ClubId, this.GuestClub.ClubId, this.HomeClubOfficials, this.GuestClubOfficials);
                dataAddOfficials.ShowDialog();

                if (dataAddOfficials.OfficialsAddSuccess)
                {
                    this.HomeManages = new BindingList<Manage>();
                    this.GuestManages = new BindingList<Manage>();

                    this.HomeClubOfficials = dataAddOfficials.HomeOfficialsManage;
                    this.GuestClubOfficials = dataAddOfficials.GuestOfficialsManage;

                    this.HomeTeamOfficials.Clear();
                    this.GuestTeamOfficials.Clear();

                    using (var db = new MatchReporterEntities())
                    {
                        List<Manage> previousManages = new List<Manage>(db.Manage.Where<Manage>(m => m.MatchId == this.Match.MatchId).ToList<Manage>());
                        foreach (Manage manage in previousManages)
                        {
                            db.Manage.Remove(manage);
                        }
                        db.SaveChanges();
                    }

                    foreach (ClubOfficial official in this.HomeClubOfficials)
                    {
                        TeamOfficial teamOfficial = new TeamOfficial(official.ClubOfficialId, official.FirstName, official.LastName);
                        this.HomeTeamOfficials.Add(teamOfficial);

                        Manage manage = new Manage(this.Match.MatchId, official.ClubOfficialId);
                        this.HomeManages.Add(manage);
                    }

                    foreach (ClubOfficial official in this.GuestClubOfficials)
                    {
                        TeamOfficial teamOfficial = new TeamOfficial(official.ClubOfficialId, official.FirstName, official.LastName);
                        this.GuestTeamOfficials.Add(teamOfficial);

                        Manage manage = new Manage(this.Match.MatchId, official.ClubOfficialId);
                        this.GuestManages.Add(manage);
                    }

                    using (var db = new MatchReporterEntities())
                    {
                        foreach (Manage manage in this.HomeManages)
                        {
                            db.Manage.Add(manage);
                        }

                        foreach (Manage manage in this.GuestManages)
                        {
                            db.Manage.Add(manage);
                        }
                        db.SaveChanges();
                    }

                    dgvHomeOfficials.DataSource = this.HomeTeamOfficials;
                    dgvGuestOfficials.DataSource = this.GuestTeamOfficials;
                    dgvHomeOfficials.Refresh();
                    dgvGuestOfficials.Refresh();
                }
                dataAddOfficials.Dispose();
            }
            catch
            {
                MessageBox.Show(this, "Da biste dodali službene osobe, prvo je potrebno dodati momčadi.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnTeamATTO1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.HomeTeam.TTO1 == null)
                {
                    this.timerMatch.Stop();

                    string minutes = this.Minutes.ToString();
                    string seconds = this.Seconds.ToString();

                    if(this.Minutes < 10)
                    {
                        minutes = "0" + this.Minutes.ToString();
                    }

                    if(this.Seconds < 10)
                    {
                        seconds = "0" + this.Seconds.ToString();
                    }
                    
                    this.HomeTeam.TTO1 = minutes + ":" + seconds;
                    txtTeamATTO1.Text = this.HomeTeam.TTO1 = this.HomeTeam.TTO1;
                }
                else
                {
                    MessageBox.Show(this, "Već ste iskoristili TTO1.", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show(this, "Potrebno je unijeti podatke o utakmici.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTeamATTO2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.HomeTeam.TTO2 == null)
                {
                    this.timerMatch.Stop();

                    string minutes = this.Minutes.ToString();
                    string seconds = this.Seconds.ToString();

                    if (this.Minutes < 10)
                    {
                        minutes = "0" + this.Minutes.ToString();
                    }

                    if (this.Seconds < 10)
                    {
                        seconds = "0" + this.Seconds.ToString();
                    }

                    this.HomeTeam.TTO2 = minutes + ":" + seconds;
                    txtTeamATTO2.Text = this.HomeTeam.TTO2 = this.HomeTeam.TTO2;
                }
                else
                {
                    MessageBox.Show(this, "Već ste iskoristili TTO1.", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show(this, "Potrebno je unijeti podatke o utakmici.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTeamATTO3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.HomeTeam.TTO3 == null)
                {
                    this.timerMatch.Stop();

                    string minutes = this.Minutes.ToString();
                    string seconds = this.Seconds.ToString();

                    if (this.Minutes < 10)
                    {
                        minutes = "0" + this.Minutes.ToString();
                    }

                    if (this.Seconds < 10)
                    {
                        seconds = "0" + this.Seconds.ToString();
                    }

                    this.HomeTeam.TTO3 = minutes + ":" + seconds;
                    txtTeamATTO3.Text = this.HomeTeam.TTO3 = this.HomeTeam.TTO3;
                }
                else
                {
                    MessageBox.Show(this, "Već ste iskoristili TTO2.", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show(this, "Potrebno je unijeti podatke o utakmici.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTeamBTTO1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GuestTeam.TTO1 == null)
                {
                    this.timerMatch.Stop();

                    string minutes = this.Minutes.ToString();
                    string seconds = this.Seconds.ToString();

                    if (this.Minutes < 10)
                    {
                        minutes = "0" + this.Minutes.ToString();
                    }

                    if (this.Seconds < 10)
                    {
                        seconds = "0" + this.Seconds.ToString();
                    }

                    this.GuestTeam.TTO1 = minutes + ":" + seconds;
                    txtTeamBTTO1.Text = this.GuestTeam.TTO1 = this.GuestTeam.TTO1;
                }
                else
                {
                    MessageBox.Show(this, "Već ste iskoristili TTO3.", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show(this, "Potrebno je unijeti podatke o utakmici.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTeamBTTO2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GuestTeam.TTO2 == null)
                {
                    this.timerMatch.Stop();

                    string minutes = this.Minutes.ToString();
                    string seconds = this.Seconds.ToString();

                    if (this.Minutes < 10)
                    {
                        minutes = "0" + this.Minutes.ToString();
                    }

                    if (this.Seconds < 10)
                    {
                        seconds = "0" + this.Seconds.ToString();
                    }

                    this.GuestTeam.TTO2 = minutes + ":" + seconds;
                    txtTeamBTTO2.Text = this.GuestTeam.TTO2 = this.GuestTeam.TTO2;
                }
                else
                {
                    MessageBox.Show(this, "Već ste iskoristili TTO2.", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show(this, "Potrebno je unijeti podatke o utakmici.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTeamBTTO3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GuestTeam.TTO3 == null)
                {
                    this.timerMatch.Stop();

                    string minutes = this.Minutes.ToString();
                    string seconds = this.Seconds.ToString();

                    if (this.Minutes < 10)
                    {
                        minutes = "0" + this.Minutes.ToString();
                    }

                    if (this.Seconds < 10)
                    {
                        seconds = "0" + this.Seconds.ToString();
                    }

                    this.GuestTeam.TTO3 = minutes + ":" + seconds;
                    txtTeamBTTO3.Text = this.GuestTeam.TTO3 = this.GuestTeam.TTO3;
                }
                else
                {
                    MessageBox.Show(this, "Već ste iskoristili TTO3.", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show(this, "Potrebno je unijeti podatke o utakmici.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
