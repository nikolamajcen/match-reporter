﻿using System;
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

        public FrmAddPlayers(int homeTeamId, int guestTeamId, BindingList<Player> homePlayers, BindingList<Player> guestPlayers)
        {
            InitializeComponent();

            this.HomeTeamId = homeTeamId;
            this.GuestTeamId = guestTeamId;

            string homeTeamName;
            string guestTeamName;

            this.PlayersAddSuccess = false;

            using (var db = new MatchReporterEntities())
            {
                this.HomePlayersAll = new BindingList<Player>(db.Player
                    .Where(p => p.ClubId == homeTeamId).ToList<Player>());
                this.GuestPlayersAll = new BindingList<Player>(db.Player
                    .Where(p => p.ClubId == guestTeamId).ToList<Player>());

                homeTeamName = (db.Club
                    .Where(c => c.ClubId == homeTeamId).FirstOrDefault().Name).ToString();

                guestTeamName = (db.Club
                    .Where(c => c.ClubId == guestTeamId).FirstOrDefault().Name).ToString();
            }

            lblHomeTeamName.Text = homeTeamName;
            lblGuestTeamName.Text = guestTeamName;

            this.HomePlayersPlay = new BindingList<Player>();
            this.GuestPlayersPlay = new BindingList<Player>();

            foreach(Player player in HomePlayersAll)
            {
                foreach(Player homePlayer in homePlayers)
                {
                    if(player.PlayerId == homePlayer.PlayerId)
                    {
                        this.HomePlayersPlay.Add(player);
                        break;
                    }
                }
            }

            foreach (Player player in GuestPlayersAll)
            {
                foreach (Player guestPlayer in guestPlayers)
                {
                    if (player.PlayerId == guestPlayer.PlayerId)
                    {
                        this.GuestPlayersPlay.Add(player);
                        break;
                    }
                }
            }

            this.HomePlayersAddedCount = HomePlayersPlay.Count;
            this.GuestPlayersAddedCount = GuestPlayersPlay.Count;
            lblHomeCurrentPlayerNumber.Text = this.HomePlayersAddedCount.ToString() + "/16";
            lblGuestCurrentPlayerNumber.Text = this.GuestPlayersAddedCount.ToString() + "/16";

            for (int i = 0; i < HomePlayersAll.Count; i++ )
            {
                Player player = HomePlayersAll[i];
                for(int j = 0; j < HomePlayersPlay.Count; j++)
                {
                    if(player.PlayerId == HomePlayersPlay[j].PlayerId)
                    {
                        HomePlayersAll.Remove(player);
                        i--;
                        break;
                    }
                }
            }

            for (int i = 0; i < GuestPlayersAll.Count; i++)
            {
                Player player = this.GuestPlayersAll[i];
                for (int j = 0; j < this.GuestPlayersPlay.Count; j++)
                {
                    if (player.PlayerId == this.GuestPlayersPlay[j].PlayerId)
                    {
                        this.GuestPlayersAll.Remove(player);
                        i--;
                        break;
                    }
                }
            }

            dgvHomePlayersAll.DataSource = this.HomePlayersAll;
            dgvHomePlayersPlay.DataSource = this.HomePlayersPlay;

            dgvGuestPlayersAll.DataSource = this.GuestPlayersAll;
            dgvGuestPlayersPlay.DataSource = this.GuestPlayersPlay;
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
            else if (this.HomePlayersAddedCount == 16)
            {
                MessageBox.Show(this, "Dodali ste maksimalan broj igrača.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this, "Ne postoji više igrača koje možete dodati.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (this.HomePlayersAddedCount == 16)
            {
                MessageBox.Show(this, "Dodali ste maksimalan broj igrača.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this, "Ne postoji više igrača koje možete dodati.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuestPlayerRemove_Click(object sender, EventArgs e)
        {
            if (this.GuestPlayersPlay.Count > 0)
            {
                Player selectedPlayer = (Player)dgvGuestPlayersPlay.CurrentRow.DataBoundItem;
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
            if(this.HomePlayersAddedCount >= 5 && this.GuestPlayersAddedCount >= 5)
            {
                
                List<Player> homePlayers = this.HomePlayersPlay.ToList();
                this.HomePlayersPlay = new BindingList<Player>(homePlayers.OrderBy(p => p.Number).ToList());

                List<Player> guestPlayers = this.GuestPlayersPlay.ToList();
                this.GuestPlayersPlay = new BindingList<Player>(guestPlayers.OrderBy(p => p.Number).ToList());
                
                this.PlayersAddSuccess = true;
                this.Close();
            }
            else
            {
                this.PlayersAddSuccess = false;
                MessageBox.Show(this, "Za svaku momčad je potrebno odabrati minimalno 5 igrača.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
