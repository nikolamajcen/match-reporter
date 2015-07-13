using MatchReporter.Classes;
using MatchReporter.Forms.Data.Add;
using MatchReporter.Forms.Podaci.Unos;
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

        public FrmMatchReporter()
        {
            InitializeComponent();
            this.Minutes = 0;
            this.Seconds = 0;
            panelMain.Hide();

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

            this.Match = new Match();

            this.HomeClub = new Club();
            this.HomePlayers = new BindingList<Player>();
            this.HomePlays = new BindingList<Play>();
            this.HomeClubOfficials = new BindingList<ClubOfficial>();
            this.HomeManages = new BindingList<Manage>();

            this.GuestClub = new Club();
            this.GuestPlayers = new BindingList<Player>();
            this.GuestPlays = new BindingList<Play>();
            this.GuestClubOfficials = new BindingList<ClubOfficial>();
            this.GuestManages = new BindingList<Manage>();
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

            panelMain.Hide();
        }

        private void dataAddTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddTeam dataAddTeam = new FrmAddTeam();
            dataAddTeam.ShowDialog();
            
            if(dataAddTeam.TeamsSelected)
            {
                this.lblTeamA.Text = dataAddTeam.HomeTeam;
                this.lblTeamB.Text = dataAddTeam.GuestTeam;

                using (var db = new MatchReporterEntities())
                {
                    this.HomeClub = (Club)(db.Club
                        .Where(c => c.Name == dataAddTeam.HomeTeam)
                        .FirstOrDefault<Club>());

                    this.GuestClub = (Club)(db.Club
                        .Where(c => c.Name == dataAddTeam.GuestTeam)
                        .FirstOrDefault<Club>());
                }
            }
            dataAddTeam.Dispose();
        }

        private void dataAddPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddPlayers dataAddPlayers = new FrmAddPlayers(this.HomeClub.ClubId, this.GuestClub.ClubId);
            dataAddPlayers.ShowDialog();

            if(dataAddPlayers.PlayersAddSuccess)
            {
                this.HomePlayers = dataAddPlayers.HomePlayersPlay;
                this.GuestPlayers = dataAddPlayers.GuestPlayersPlay;

                foreach (Player player in this.HomePlayers)
                {
                    TeamPlayer teamPlayer = new TeamPlayer(player.PlayerId, player.FirstName, player.LastName, player.Number);
                    this.HomeTeamPlayers.Add(teamPlayer);
                }

                foreach (Player player in this.GuestPlayers)
                {
                    TeamPlayer teamPlayer = new TeamPlayer(player.PlayerId, player.FirstName, player.LastName, player.Number);
                    this.GuestTeamPlayers.Add(teamPlayer);
                }

                dgvHomeTeam.DataSource = this.HomeTeamPlayers;
                dgvGuestTeam.DataSource = this.GuestTeamPlayers;
                dgvHomeTeam.Refresh();
                dgvGuestTeam.Refresh();
            }
            dataAddPlayers.Dispose();
        }

        private void dataAddOfficialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddOfficials dataAddOfficials = new FrmAddOfficials(this.HomeClub.ClubId, this.GuestClub.ClubId);
            dataAddOfficials.ShowDialog();

            if(dataAddOfficials.OfficialsAddSuccess)
            {
                this.HomeClubOfficials = dataAddOfficials.HomeOfficialsManage;
                this.GuestClubOfficials = dataAddOfficials.GuestOfficialsManage;

                foreach (ClubOfficial official in this.HomeClubOfficials)
                {
                    TeamOfficial teamOfficial = new TeamOfficial(official.ClubOfficialId, official.FirstName, official.LastName);
                    this.HomeTeamOfficials.Add(teamOfficial);
                }

                foreach (ClubOfficial official in this.GuestClubOfficials)
                {
                    TeamOfficial teamOfficial = new TeamOfficial(official.ClubOfficialId, official.FirstName, official.LastName);
                    this.GuestTeamOfficials.Add(teamOfficial);
                }

                dgvHomeOfficials.DataSource = this.HomeTeamOfficials;
                dgvGuestOfficials.DataSource = this.GuestTeamOfficials;
                dgvHomeOfficials.Refresh();
                dgvGuestOfficials.Refresh();
            }
            dataAddOfficials.Dispose();
        }
    }
}
