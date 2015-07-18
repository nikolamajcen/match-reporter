using MatchReporter.Classes;
using MatchReporter.Forms.Data;
using MatchReporter.Forms.Data.Add;
using MatchReporter.Forms.Loading;
using MatchReporter.Forms.MatchStats;
using MatchReporter.Forms.Other;
using MatchReporter.Forms.Podaci.Unos;
using MatchReporter.Forms.Reports;
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

        public string RefereePairName;

        // Match info
        private int Minutes;
        private int Seconds;

        // Saving status
        public bool SavedTeams;
        public bool SavedPlays;
        public bool SavedManages;

        public void showLoadingForm()
        {
            FrmLoading loading = new FrmLoading();
            loading.ShowDialog();
            Application.Run();
        }

        public void showSavingForm()
        {
            FrmLoading loading = new FrmLoading("Spremanje podataka", "Podaci se spremaju.");
            loading.ShowDialog();
            Application.Run();
        }

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

            this.HomeTeamPlayers = new BindingList<TeamPlayer>();
            this.GuestTeamPlayers = new BindingList<TeamPlayer>();

            this.HomeTeamOfficials = new BindingList<TeamOfficial>();
            this.GuestTeamOfficials = new BindingList<TeamOfficial>();
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
            panelMain.Enabled = true;

            lblTeamA.Text = "";
            lblTeamB.Text = "";

            lblResultA.Text = "0";
            lblResultB.Text = "0";

            txtTeamATTO1.Text = "";
            txtTeamATTO2.Text = "";
            txtTeamATTO3.Text = "";
            txtTeamBTTO1.Text = "";
            txtTeamBTTO2.Text = "";
            txtTeamBTTO3.Text = "";

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

            this.SavedTeams = false;
            this.SavedPlays = false;
            this.SavedManages = false;

            dgvHomeTeam.DataSource = null;
            dgvGuestTeam.DataSource = null;
            dgvHomeTeam.Refresh();
            dgvGuestTeam.Refresh();

            dgvHomeOfficials.DataSource = null;
            dgvGuestOfficials.DataSource = null;
            dgvHomeOfficials.Refresh();
            dgvGuestOfficials.Refresh();
        }

        private void matchSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Thread savingDataThread = new Thread(new ThreadStart(showSavingForm));
                savingDataThread.Start();

                // HomeTeamPlayers > HomePlays, GuestTeamPlayers > GuestPlays

                foreach(TeamPlayer teamPlayer in HomeTeamPlayers)
                {
                    Play play = HomePlays
                        .Where(p => p.MatchId == this.Match.MatchId)
                        .Where(p => p.PlayerId == teamPlayer.TeamPlayerId)
                        .FirstOrDefault();

                    if(play != null)
                    {
                        play.Goals = teamPlayer.Goals;
                        play.Goals7m = teamPlayer.Goals7m;
                        play.Warning = teamPlayer.Warning;
                        play.SuspensionFirst = teamPlayer.Suspension1st;
                        play.SuspensionSecond = teamPlayer.Suspension2nd;
                        play.SuspensionThird = teamPlayer.Suspension3rd;
                        play.Disqualification = teamPlayer.Disqualification;
                        play.DisqualificationAdnReport = teamPlayer.DisqualificationReport;
                    }
                }

                foreach (TeamPlayer teamPlayer in GuestTeamPlayers)
                {
                    Play play = GuestPlays
                        .Where(p => p.MatchId == this.Match.MatchId)
                        .Where(p => p.PlayerId == teamPlayer.TeamPlayerId)
                        .FirstOrDefault();

                    if (play != null)
                    {
                        play.Goals = teamPlayer.Goals;
                        play.Goals7m = teamPlayer.Goals7m;
                        play.Warning = teamPlayer.Warning;
                        play.SuspensionFirst = teamPlayer.Suspension1st;
                        play.SuspensionSecond = teamPlayer.Suspension2nd;
                        play.SuspensionThird = teamPlayer.Suspension3rd;
                        play.Disqualification = teamPlayer.Disqualification;
                        play.DisqualificationAdnReport = teamPlayer.DisqualificationReport;
                    }
                }

                // HomeTeamOfficials > HomeManages, GuestTeamOfficials > GuestManages
                foreach(TeamOfficial teamOfficial in HomeTeamOfficials)
                {
                    Manage manage = HomeManages
                        .Where(m => m.MatchId == this.Match.MatchId)
                        .Where(m => m.ClubOfficialId == teamOfficial.TeamOfficialId)
                        .FirstOrDefault();

                    if(manage != null)
                    {
                        manage.Warning = teamOfficial.Warning;
                        manage.Suspension = teamOfficial.Suspension;
                        manage.Disqualification = teamOfficial.Disqualification;
                    }
                }

                foreach (TeamOfficial teamOfficial in GuestTeamOfficials)
                {
                    Manage manage = GuestManages
                        .Where(m => m.MatchId == this.Match.MatchId)
                        .Where(m => m.ClubOfficialId == teamOfficial.TeamOfficialId)
                        .FirstOrDefault();

                    if (manage != null)
                    {
                        manage.Warning = teamOfficial.Warning;
                        manage.Suspension = teamOfficial.Suspension;
                        manage.Disqualification = teamOfficial.Disqualification;
                    }
                }

                // Saving data
                using (var db = new MatchReporterEntities())
                {
                    db.Entry(this.Match).State = this.Match.MatchId == 0 ? EntityState.Added : EntityState.Modified;

                    db.Entry(this.HomeTeam).State = this.SavedTeams == false ? EntityState.Added : EntityState.Modified;
                    db.Entry(this.GuestTeam).State = this.SavedTeams == false ? EntityState.Added : EntityState.Modified;
                    this.SavedTeams = true;

                    foreach (Play play in HomePlays)
                    {
                        db.Entry(play).State = this.SavedPlays == false ? EntityState.Added : EntityState.Modified;
                    }
                    foreach (Play play in GuestPlays)
                    {
                        db.Entry(play).State = this.SavedPlays == false ? EntityState.Added : EntityState.Modified;
                    }
                    this.SavedPlays = true;


                    foreach (Manage manage in HomeManages)
                    {
                        db.Entry(manage).State = this.SavedManages == false ? EntityState.Added : EntityState.Modified;
                    }
                    foreach (Manage manage in GuestManages)
                    {
                        db.Entry(manage).State = this.SavedManages == false ? EntityState.Added : EntityState.Modified;
                    }
                    this.SavedManages = true;

                    db.SaveChanges();
                }
                savingDataThread.Abort();

                MessageBox.Show(this, "Podaci su uspješno spremljeni.", "Spremanje podataka",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(this, "Došlo je do pogreške.\nPodaci nisu spremljeni.", "Spremanje podataka",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void matchConcludeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(int.Parse(lblTimeMinutes.Text) == 60)
            {
                if (MessageBox.Show(this, "Jeste li sigurni da želite zaključiti utakmicu? \nViše neće biti moguće mijenjati podatke o utakmici.",
                "Zaključi utakmicu", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    try
                    {
                        this.Match.Concluded = 1;

                        panelMain.Enabled = false;

                        this.dataMatchDetailsToolStripMenuItem.Enabled = false;
                        this.dataTeamsToolStripMenuItem.Enabled = false;
                        this.dataPlayersToolStripMenuItem.Enabled = false;
                        this.dataOfficialsToolStripMenuItem.Enabled = false;

                        this.matchSaveToolStripMenuItem.Enabled = false;
                        this.matchConcludeToolStripMenuItem.Enabled = false;

                        using (var db = new MatchReporterEntities())
                        {
                            db.Entry(this.Match).State = this.Match.MatchId == 0 ? EntityState.Added : EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    catch
                    {
                        MessageBox.Show(this, "Došlo je do greške. \nUtakmica nije zaključena.", "Greška",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Ne možete zaključiti utakmicu jer \nutakmica nije završena.", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void matchCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Jeste li sigurni da želite zatvoriti utakmicu?\nPristup utakmici će biti onemogućen.",
                "Zatvori utakmicu", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
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

                lblTeamA.Text = "";
                lblTeamB.Text = "";
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
        }

        private void dataMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddMatchDetails dataAddMatchDetails = new FrmAddMatchDetails(this.Match);
            dataAddMatchDetails.ShowDialog();

            if (dataAddMatchDetails.MatchDetailsAddSuccess)
            {
                this.Match.LeagueId = dataAddMatchDetails.LeagueId;
                this.Match.Round = dataAddMatchDetails.Round;
                this.Match.Date = dataAddMatchDetails.Date;
                this.Match.Time = dataAddMatchDetails.Time;
                this.Match.HallId = dataAddMatchDetails.HallId;
                this.Match.Spectators = dataAddMatchDetails.Spectators;
                this.Match.RefereePairId = dataAddMatchDetails.RefereePairId;
                this.Match.DelegateId = dataAddMatchDetails.DelegateId;
                this.Match.TimeKeeper = dataAddMatchDetails.TimeKeeper;
                this.Match.Scorer = dataAddMatchDetails.Scorer;
                this.RefereePairName = dataAddMatchDetails.RefereePairName;
                
                using (var db = new MatchReporterEntities())
                {
                    db.Entry(this.Match).State = this.Match.MatchId == 0 ? EntityState.Added : EntityState.Modified;
                    db.SaveChanges();
                } 
            }
            //dataAddMatchDetails.Dispose();
        }

        private void dataTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.Match.MatchId != 0)
            {
                FrmAddTeam dataAddTeam = new FrmAddTeam(this.HomeClub.ClubId, this.GuestClub.ClubId);
                dataAddTeam.ShowDialog();

                if (dataAddTeam.TeamsSelected)
                {
                    Thread loadingThread = new Thread(new ThreadStart(showLoadingForm));
                    loadingThread.Start();

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
                            db.SaveChanges();
                        }
                    }

                    using (var db = new MatchReporterEntities())
                    {
                        db.Entry(this.HomeTeam).State = dataAddTeam.TeamSelectionChanged == true ? EntityState.Added : EntityState.Modified;
                        db.Entry(this.GuestTeam).State = dataAddTeam.TeamSelectionChanged == true ? EntityState.Added : EntityState.Modified;
                        db.SaveChanges();

                        this.SavedTeams = true;
                    }
                    loadingThread.Abort();
                }
                //dataAddTeam.Dispose();
            }
            else
            {
                MessageBox.Show(this, "Da biste dodali momčadi, prvo je potrebno unijeti podatke o utakmici.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.HomeClub.ClubId != 0 && this.GuestClub.ClubId != 0)
            {
                FrmAddPlayers dataAddPlayers = new FrmAddPlayers(this.HomeClub.ClubId, this.GuestClub.ClubId, this.HomePlayers, this.GuestPlayers);
                dataAddPlayers.ShowDialog();

                if (dataAddPlayers.PlayersAddSuccess)
                {
                    Thread loadingThread = new Thread(new ThreadStart(showLoadingForm));
                    loadingThread.Start();

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

                        this.SavedPlays = true;
                    }

                    dgvHomeTeam.DataSource = this.HomeTeamPlayers;
                    dgvGuestTeam.DataSource = this.GuestTeamPlayers;
                    dgvHomeTeam.Refresh();
                    dgvGuestTeam.Refresh();

                    loadingThread.Abort();
                }
                //dataAddPlayers.Dispose();
            }
            else
            {
                MessageBox.Show(this, "Da biste dodali igrače, prvo je potrebno dodati momčadi.", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataOfficialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.HomeClub.ClubId != 0 && this.GuestClub.ClubId != 0)
            {
                FrmAddOfficials dataAddOfficials = new FrmAddOfficials(this.HomeClub.ClubId, this.GuestClub.ClubId, this.HomeClubOfficials, this.GuestClubOfficials);
                dataAddOfficials.ShowDialog();

                if (dataAddOfficials.OfficialsAddSuccess)
                {
                    Thread loadingThread = new Thread(new ThreadStart(showLoadingForm));
                    loadingThread.Start();

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

                        this.SavedManages = true;
                    }

                    dgvHomeOfficials.DataSource = this.HomeTeamOfficials;
                    dgvGuestOfficials.DataSource = this.GuestTeamOfficials;
                    dgvHomeOfficials.Refresh();
                    dgvGuestOfficials.Refresh();

                    loadingThread.Abort();
                }
                //dataAddOfficials.Dispose();
            }
            else
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

        private void btnHomeGoal_Click(object sender, EventArgs e)
        {
            TeamPlayer teamPlayer = (TeamPlayer)(dgvHomeTeam.CurrentRow.DataBoundItem);
            teamPlayer.Goals += 1;
            dgvHomeTeam.Refresh();

            // Dodati da se u Play dodaju informacije

            this.HomeTeam.Goals += 1;
            lblResultA.Text = this.HomeTeam.Goals.ToString();
        }

        private void btnGuestGoal_Click(object sender, EventArgs e)
        {
            TeamPlayer teamPlayer = (TeamPlayer)(dgvGuestTeam.CurrentRow.DataBoundItem);
            teamPlayer.Goals += 1;
            dgvGuestTeam.Refresh();

            // Dodati da se u Play dodaju informacije

            this.GuestTeam.Goals += 1;
            lblResultB.Text = this.GuestTeam.Goals.ToString();
        }

        private void btnHome7m_Click(object sender, EventArgs e)
        {
            TeamPlayer teamPlayer = (TeamPlayer)(dgvHomeTeam.CurrentRow.DataBoundItem);
            FrmMatch7m goal7m = new FrmMatch7m(teamPlayer, this.HomeTeam);
            goal7m.ShowDialog();

            dgvHomeTeam.Refresh();
            lblResultA.Text = this.HomeTeam.Goals.ToString();

            // Dodati da se u Play i Team dodaju informacije
        }

        private void btnGuest7m_Click(object sender, EventArgs e)
        {
            TeamPlayer teamPlayer = (TeamPlayer)(dgvGuestTeam.CurrentRow.DataBoundItem);
            FrmMatch7m goal7m = new FrmMatch7m(teamPlayer, this.GuestTeam);
            goal7m.ShowDialog();

            dgvGuestTeam.Refresh();
            lblResultB.Text = this.GuestTeam.Goals.ToString();

            // Dodati da se u Play i Team dodaju informacije
        }

        private void btnHomeWarning_Click(object sender, EventArgs e)
        {
            TeamPlayer teamPlayer = (TeamPlayer)(dgvHomeTeam.CurrentRow.DataBoundItem);
            if(teamPlayer.Warning == null)
            {
                teamPlayer.Warning = this.Minutes + 1;
                dgvHomeTeam.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Igrač već ima opomenu.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            // Dodati da se u Play dodaju informacije
        }

        private void btnGuestWarning_Click(object sender, EventArgs e)
        {
            TeamPlayer teamPlayer = (TeamPlayer)(dgvGuestTeam.CurrentRow.DataBoundItem);
            if (teamPlayer.Warning == null)
            {
                teamPlayer.Warning = this.Minutes + 1;
                dgvGuestTeam.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Igrač već ima opomenu.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Dodati da se u Play dodaju informacije
        }

        private void btnHomeSuspension_Click(object sender, EventArgs e)
        {
            this.timerMatch.Stop();

            TeamPlayer teamPlayer = (TeamPlayer)(dgvHomeTeam.CurrentRow.DataBoundItem);
            if (teamPlayer.Suspension1st == null)
            {
                teamPlayer.Suspension1st = this.Minutes + 1;
            }
            else if (teamPlayer.Suspension2nd == null)
            {
                teamPlayer.Suspension2nd = this.Minutes + 1;
            }
            else if (teamPlayer.Suspension3rd == null)
            {
                teamPlayer.Suspension3rd = this.Minutes + 1;
            }
            else
            {
                MessageBox.Show(this, "Igrač već ima tri isključenja.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvHomeTeam.Refresh();

            // Dodati da se u Play dodaju informacije
        }

        private void btnGuestSuspension_Click(object sender, EventArgs e)
        {
            this.timerMatch.Stop();

            TeamPlayer teamPlayer = (TeamPlayer)(dgvGuestTeam.CurrentRow.DataBoundItem);
            if (teamPlayer.Suspension1st == null)
            {
                teamPlayer.Suspension1st = this.Minutes + 1;
            }
            else if (teamPlayer.Suspension2nd == null)
            {
                teamPlayer.Suspension2nd = this.Minutes + 1;
            }
            else if (teamPlayer.Suspension3rd == null)
            {
                teamPlayer.Suspension3rd = this.Minutes + 1;
            }
            else
            {
                MessageBox.Show(this, "Igrač već ima tri isključenja.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvGuestTeam.Refresh();

            // Dodati da se u Play dodaju informacije
        }

        private void btnHomeDisqualification_Click(object sender, EventArgs e)
        {
            this.timerMatch.Stop();

            TeamPlayer teamPlayer = (TeamPlayer)(dgvHomeTeam.CurrentRow.DataBoundItem);
            if (teamPlayer.Disqualification == null)
            {
                teamPlayer.Disqualification = this.Minutes + 1;
                dgvHomeTeam.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Igrač je već diskvalificiran.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Dodati da se u Play dodaju informacije
        }

        private void btnGuestDisqualification_Click(object sender, EventArgs e)
        {
            this.timerMatch.Stop();

            TeamPlayer teamPlayer = (TeamPlayer)(dgvGuestTeam.CurrentRow.DataBoundItem);
            if (teamPlayer.Disqualification == null)
            {
                teamPlayer.Disqualification = this.Minutes + 1;
                dgvGuestTeam.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Igrač je već diskvalificiran.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Dodati da se u Play dodaju informacije
        }

        private void btnHomeDisqualificationReport_Click(object sender, EventArgs e)
        {
            this.timerMatch.Stop();

            TeamPlayer teamPlayer = (TeamPlayer)(dgvHomeTeam.CurrentRow.DataBoundItem);
            if (teamPlayer.DisqualificationReport == null)
            {
                teamPlayer.DisqualificationReport = this.Minutes + 1;
                dgvHomeTeam.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Igrač je već diskvalificiran.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Dodati da se u Play dodaju informacije
        }

        private void btnGuestDisqualificationReport_Click(object sender, EventArgs e)
        {
            this.timerMatch.Stop();

            TeamPlayer teamPlayer = (TeamPlayer)(dgvGuestTeam.CurrentRow.DataBoundItem);
            if (teamPlayer.DisqualificationReport == null)
            {
                teamPlayer.DisqualificationReport = this.Minutes + 1;
                dgvGuestTeam.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Igrač je već diskvalificiran.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Dodati da se u Play dodaju informacije
        }

        private void btnHomeUndo_Click(object sender, EventArgs e)
        {
            TeamPlayer teamPlayer = (TeamPlayer)(dgvHomeTeam.CurrentRow.DataBoundItem);
            FrmPlayersUndo playerUndo = new FrmPlayersUndo(teamPlayer, this.HomeTeam);
            playerUndo.ShowDialog();

            dgvHomeTeam.Refresh();
            lblResultA.Text = this.HomeTeam.Goals.ToString();
        }

        private void btnGuestUndo_Click(object sender, EventArgs e)
        {
            TeamPlayer teamPlayer = (TeamPlayer)(dgvGuestTeam.CurrentRow.DataBoundItem);
            FrmPlayersUndo playerUndo = new FrmPlayersUndo(teamPlayer, this.GuestTeam);
            playerUndo.ShowDialog();

            dgvGuestTeam.Refresh();
            lblResultB.Text = this.GuestTeam.Goals.ToString();
        }

        private void btnHomeOfficialWarning_Click(object sender, EventArgs e)
        {
            TeamOfficial teamOfficial = (TeamOfficial)(dgvHomeOfficials.CurrentRow.DataBoundItem);
            if (teamOfficial.Warning == null)
            {
                teamOfficial.Warning = this.Minutes + 1;
                dgvHomeOfficials.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Službena osoba već ima opomenu.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Dodati da se u Manage dodaju informacije
        }

        private void btnGuestOfficialWarning_Click(object sender, EventArgs e)
        {
            TeamOfficial teamOfficial = (TeamOfficial)(dgvGuestOfficials.CurrentRow.DataBoundItem);
            if (teamOfficial.Warning == null)
            {
                teamOfficial.Warning = this.Minutes + 1;
                dgvGuestOfficials.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Službena osoba već ima opomenu.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Dodati da se u Manage dodaju informacije
        }

        private void btnHomeOfficialSuspension_Click(object sender, EventArgs e)
        {
            TeamOfficial teamOfficial = (TeamOfficial)(dgvHomeOfficials.CurrentRow.DataBoundItem);
            if (teamOfficial.Suspension == null)
            {
                teamOfficial.Suspension = this.Minutes + 1;
                dgvHomeOfficials.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Službena osoba već ima isključenje.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Dodati da se u Manage dodaju informacije
        }

        private void btnGuestOfficialSuspension_Click(object sender, EventArgs e)
        {
            TeamOfficial teamOfficial = (TeamOfficial)(dgvGuestOfficials.CurrentRow.DataBoundItem);
            if (teamOfficial.Suspension == null)
            {
                teamOfficial.Suspension = this.Minutes + 1;
                dgvGuestOfficials.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Službena osoba već ima isključenje.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Dodati da se u Manage dodaju informacije
        }

        private void btnHomeOfficialDisqualification_Click(object sender, EventArgs e)
        {
            TeamOfficial teamOfficial = (TeamOfficial)(dgvHomeOfficials.CurrentRow.DataBoundItem);
            if (teamOfficial.Disqualification == null)
            {
                teamOfficial.Disqualification = this.Minutes + 1;
                dgvHomeOfficials.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Službena osoba je već diskvalificirana.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Dodati da se u Manage dodaju informacije
        }

        private void btnGuestOfficialDisqualification_Click(object sender, EventArgs e)
        {
            TeamOfficial teamOfficial = (TeamOfficial)(dgvGuestOfficials.CurrentRow.DataBoundItem);
            if (teamOfficial.Disqualification == null)
            {
                teamOfficial.Disqualification = this.Minutes + 1;
                dgvGuestOfficials.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Službena osoba je već diskvalificirana.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Dodati da se u Manage dodaju informacije
        }

        private void btnHomeOfficialUndo_Click(object sender, EventArgs e)
        {
            TeamOfficial teamOfficial = (TeamOfficial)(dgvHomeOfficials.CurrentRow.DataBoundItem);
            FrmOfficialsUndo officialUndo = new FrmOfficialsUndo(teamOfficial);
            officialUndo.ShowDialog();

            dgvHomeOfficials.Refresh();
        }

        private void btnGuestOfficialUndo_Click(object sender, EventArgs e)
        {
            TeamOfficial teamOfficial = (TeamOfficial)(dgvGuestOfficials.CurrentRow.DataBoundItem);
            FrmOfficialsUndo officialUndo = new FrmOfficialsUndo(teamOfficial);
            officialUndo.ShowDialog();

            dgvGuestOfficials.Refresh();
        }

        private void reportSendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Match.Concluded == 1)
            {
                FrmReportEmailSend reportEmailSend = new FrmReportEmailSend(this.Match, this.HomeClub, this.HomeTeam, this.GuestClub, this.GuestTeam);
                reportEmailSend.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Da biste poslali rezultat potrebno je\nprethodno zaključiti utakmicu.", "Slanje rezultata",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void reportPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatchReport fullMatchReport = new FrmMatchReport(this.Match, this.HomeClub, this.GuestClub,
                this.HomeTeam, this.GuestTeam, this.HomeTeamPlayers, this.GuestTeamPlayers,
                this.HomeTeamOfficials, this.GuestTeamOfficials, this.RefereePairName);
            fullMatchReport.ShowDialog();
        }

        private void otherAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }
    }
}
