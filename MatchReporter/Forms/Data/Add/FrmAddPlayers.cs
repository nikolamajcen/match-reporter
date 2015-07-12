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
    public partial class FrmAddPlayers : Form
    {
        public int HomeTeamId;
        public int GuestTeamId;

        public BindingList<Player> HomePlayersAll;
        public BindingList<Player> GuestPlayersAll;

        public BindingList<Player> HomePlayersPlay;
        public BindingList<Player> GuestPlayersPlay;

        public int HomePlayersAddedCount;
        public int GuestPlayersAddedCount;

        public bool PlayersAddSuccess;

        public FrmAddPlayers(int homeTeamId, int guestTeamId)
        {
            InitializeComponent();

            this.HomeTeamId = homeTeamId;
            this.GuestTeamId = guestTeamId;

            this.HomePlayersAddedCount = 0;
            this.GuestPlayersAddedCount = 0;

            string homeTeamName;
            string guestTeamName;

            this.PlayersAddSuccess = false;

            using (var db = new MatchReporterEntities())
            {
                HomePlayersAll = new BindingList<Player>(db.Player
                    .Where(p => p.ClubId == homeTeamId).ToList<Player>());
                GuestPlayersAll = new BindingList<Player>(db.Player
                    .Where(p => p.ClubId == guestTeamId).ToList<Player>());

                homeTeamName = (db.Club
                    .Where(c => c.ClubId == homeTeamId).FirstOrDefault().Name).ToString();

                guestTeamName = (db.Club
                    .Where(c => c.ClubId == guestTeamId).FirstOrDefault().Name).ToString();
            }

            lblHomeTeamName.Text = homeTeamName;
            lblGuestTeamName.Text = guestTeamName;

            HomePlayersPlay = new BindingList<Player>();
            GuestPlayersPlay = new BindingList<Player>();

            dgvHomePlayersAll.DataSource = HomePlayersAll;
            dgvHomePlayersPlay.DataSource = HomePlayersPlay;

            dgvGuestPlayersAll.DataSource = GuestPlayersAll;
            dgvGuestPlayersPlay.DataSource = GuestPlayersPlay;
        }

        private void btnHomePlayerAdd_Click(object sender, EventArgs e)
        {
            if(this.HomePlayersAll.Count > 0 && this.HomePlayersAddedCount < 16)
            {
                Player selectedPlayer = (Player)dgvHomePlayersAll.CurrentRow.DataBoundItem;
                this.HomePlayersPlay.Add(selectedPlayer);
                this.HomePlayersAll.Remove(selectedPlayer);
                dgvHomePlayersAll.Refresh();
                dgvHomePlayersPlay.Refresh();

                this.HomePlayersAddedCount += 1;

                lblHomeCurrentPlayerNumber.Text = this.HomePlayersAddedCount.ToString() + "/16";
            }
        }

        private void btnHomePlayerRemove_Click(object sender, EventArgs e)
        {
            if (this.HomePlayersPlay.Count > 0)
            {
                Player selectedPlayer = (Player)dgvHomePlayersPlay.CurrentRow.DataBoundItem;
                this.HomePlayersAll.Add(selectedPlayer);
                this.HomePlayersPlay.Remove(selectedPlayer);
                dgvHomePlayersAll.Refresh();
                dgvHomePlayersPlay.Refresh();

                this.HomePlayersAddedCount -= 1;

                lblHomeCurrentPlayerNumber.Text = this.HomePlayersAddedCount.ToString() + "/16";
            }
        }

        private void btnGuestPlayerAdd_Click(object sender, EventArgs e)
        {
            if (this.GuestPlayersAll.Count > 0 && this.GuestPlayersAddedCount < 16)
            {
                Player selectedPlayer = (Player)dgvGuestPlayersAll.CurrentRow.DataBoundItem;
                this.GuestPlayersPlay.Add(selectedPlayer);
                this.GuestPlayersAll.Remove(selectedPlayer);
                dgvGuestPlayersAll.Refresh();
                dgvGuestPlayersPlay.Refresh();

                this.GuestPlayersAddedCount += 1;

                lblGuestCurrentPlayerNumber.Text = this.GuestPlayersAddedCount.ToString() + "/16";
            }
        }

        private void btnGuestPlayerRemove_Click(object sender, EventArgs e)
        {
            if (this.GuestPlayersPlay.Count > 0)
            {
                Player selectedPlayer = (Player)dgvHomePlayersPlay.CurrentRow.DataBoundItem;
                this.GuestPlayersAll.Add(selectedPlayer);
                this.GuestPlayersPlay.Remove(selectedPlayer);
                dgvGuestPlayersAll.Refresh();
                dgvGuestPlayersPlay.Refresh();

                this.GuestPlayersAddedCount -= 1;

                lblGuestCurrentPlayerNumber.Text = this.GuestPlayersAddedCount.ToString() + "/16";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(this.HomePlayersAddedCount >= 7 && this.GuestPlayersAddedCount >= 7)
            {
                this.PlayersAddSuccess = true;
                this.Close();
            }
            else
            {
                this.PlayersAddSuccess = false;
                MessageBox.Show(this, "Za svaku momčad je potrebno odabrati minimalno 7 igrača.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
