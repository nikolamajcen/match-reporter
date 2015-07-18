using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchReporter.Forms.Podaci.Unos
{
    public partial class FrmAddTeam : Form
    {
        public Club HomeTeam;
        public Club GuestTeam;
        public bool TeamsSelected;
        public bool TeamSelectionChanged;

        public int? LastHomeTeamId;
        public int? LastGuestTeamId;

        public FrmAddTeam(int? homeTeamId, int? guestTeamId)
        {
            InitializeComponent();

            this.TeamsSelected = false;
            this.TeamSelectionChanged = false;

            this.LastHomeTeamId = homeTeamId;
            this.LastGuestTeamId = guestTeamId;

            BindingList<Club> homeTeams;
            BindingList<Club> guestTeams;

            using (var db = new MatchReporterEntities())
            {
                homeTeams = new BindingList<Club>(db.Club.ToList());
                guestTeams = new BindingList<Club>(db.Club.ToList());
            }

            cbxHomeTeam.DataSource = homeTeams;
            cbxGuestTeam.DataSource = guestTeams;

            if(homeTeamId != 0 && guestTeamId != 0)
            {
                foreach (object row in cbxHomeTeam.Items)
                {
                    Club data = (Club)row;
                    if (data.ClubId == homeTeamId)
                    {
                        cbxHomeTeam.SelectedItem = row;
                        break;
                    }
                }

                foreach (object row in cbxGuestTeam.Items)
                {
                    Club data = (Club)row;
                    if (data.ClubId == guestTeamId)
                    {
                        cbxGuestTeam.SelectedItem = row;
                        break;
                    }
                }
            }
        }

        private void btnAddTeams_Click(object sender, EventArgs e)
        {
            if (cbxHomeTeam.Text == cbxGuestTeam.Text)
            {
                MessageBox.Show(this, "Odabrali ste istu momčad kao domaću i gostujuću ekipu.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cbxHomeTeam.Text.Length == 0 || cbxGuestTeam.Text.Length == 0)
            {
                MessageBox.Show(this, "Niste odabrali obje momčadi.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.HomeTeam = (Club)cbxHomeTeam.SelectedItem;
                this.GuestTeam = (Club)cbxGuestTeam.SelectedItem;
                TeamsSelected = true;
                if (this.HomeTeam.ClubId != this.LastHomeTeamId || this.GuestTeam.ClubId != this.LastGuestTeamId)
                {
                    this.TeamSelectionChanged = true;
                }
                this.Close();
            }
        }
    }
}
