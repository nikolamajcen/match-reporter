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
    public partial class FrmAddOfficials : Form
    {
        public int HomeTeamId;
        public int GuestTeamId;

        public BindingList<ClubOfficial> HomeOfficialsAll;
        public BindingList<ClubOfficial> GuestOfficialsAll;

        public BindingList<ClubOfficial> HomeOfficialsManage;
        public BindingList<ClubOfficial> GuestOfficialsManage;

        public int HomeOfficialsAddedCount;
        public int GuestOfficialsAddedCount;

        public bool OfficialsAddSuccess;

        public FrmAddOfficials(int homeTeamId, int guestTeamId)
        {
            InitializeComponent();

            this.HomeTeamId = homeTeamId;
            this.GuestTeamId = guestTeamId;

            this.HomeOfficialsAddedCount = 0;
            this.GuestOfficialsAddedCount = 0;

            string homeTeamName;
            string guestTeamName;

            this.OfficialsAddSuccess = false;

            using (var db = new MatchReporterEntities())
            {
                HomeOfficialsAll = new BindingList<ClubOfficial>(db.ClubOfficial
                    .Where(p => p.ClubId == homeTeamId).ToList<ClubOfficial>());
                GuestOfficialsAll = new BindingList<ClubOfficial>(db.ClubOfficial
                    .Where(p => p.ClubId == guestTeamId).ToList<ClubOfficial>());

                homeTeamName = (db.Club
                    .Where(c => c.ClubId == homeTeamId).FirstOrDefault().Name).ToString();

                guestTeamName = (db.Club
                    .Where(c => c.ClubId == guestTeamId).FirstOrDefault().Name).ToString();
            }

            lblHomeTeamName.Text = homeTeamName;
            lblGuestTeamName.Text = guestTeamName;

            HomeOfficialsManage = new BindingList<ClubOfficial>();
            GuestOfficialsManage = new BindingList<ClubOfficial>();

            dgvHomeOfficialsAll.DataSource = HomeOfficialsAll;
            dgvHomeOfficialsManage.DataSource = HomeOfficialsManage;

            dgvGuestOfficialsAll.DataSource = GuestOfficialsAll;
            dgvGuestOfficialsManage.DataSource = GuestOfficialsManage;
        }

        private void btnHomeOfficialsAdd_Click(object sender, EventArgs e)
        {
            if (this.HomeOfficialsAll.Count > 0 && this.HomeOfficialsAddedCount < 4)
            {
                ClubOfficial selectedOfficial = (ClubOfficial)dgvHomeOfficialsAll.CurrentRow.DataBoundItem;
                this.HomeOfficialsManage.Add(selectedOfficial);
                this.HomeOfficialsAll.Remove(selectedOfficial);
                dgvHomeOfficialsAll.Refresh();
                dgvHomeOfficialsManage.Refresh();

                this.HomeOfficialsAddedCount += 1;

                lblHomeOfficialsCount.Text = this.HomeOfficialsAddedCount.ToString() + "/4";
            }
            else if (this.HomeOfficialsAddedCount == 4)
            {
                MessageBox.Show(this, "Dodali ste maksimalan broj službenih osoba.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this, "Ne postoji više službenih osoba koje možete dodati.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHomeOfficialsRemove_Click(object sender, EventArgs e)
        {
            if (this.HomeOfficialsManage.Count > 0)
            {
                ClubOfficial selectedOfficial = (ClubOfficial)dgvHomeOfficialsManage.CurrentRow.DataBoundItem;
                this.HomeOfficialsAll.Add(selectedOfficial);
                this.HomeOfficialsManage.Remove(selectedOfficial);
                dgvHomeOfficialsAll.Refresh();
                dgvHomeOfficialsManage.Refresh();

                this.HomeOfficialsAddedCount -= 1;

                lblHomeOfficialsCount.Text = this.HomeOfficialsAddedCount.ToString() + "/4";
            }
        }

        private void btnGuestOfficialsAdd_Click(object sender, EventArgs e)
        {
            if (this.GuestOfficialsAll.Count > 0 && this.GuestOfficialsAddedCount < 4)
            {
                ClubOfficial selectedOfficial = (ClubOfficial)dgvGuestOfficialsAll.CurrentRow.DataBoundItem;
                this.GuestOfficialsManage.Add(selectedOfficial);
                this.GuestOfficialsAll.Remove(selectedOfficial);
                dgvGuestOfficialsAll.Refresh();
                dgvGuestOfficialsManage.Refresh();

                this.GuestOfficialsAddedCount += 1;

                lblGuestOfficialsCount.Text = this.GuestOfficialsAddedCount.ToString() + "/4";
            }
            else if (this.GuestOfficialsAddedCount == 4)
            {
                MessageBox.Show(this, "Dodali ste maksimalan broj službenih osoba.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this, "Ne postoji više službenih osoba koje možete dodati.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuestOfficialsRemove_Click(object sender, EventArgs e)
        {
            if (this.GuestOfficialsManage.Count > 0)
            {
                ClubOfficial selectedOfficial = (ClubOfficial)dgvGuestOfficialsManage.CurrentRow.DataBoundItem;
                this.GuestOfficialsAll.Add(selectedOfficial);
                this.GuestOfficialsManage.Remove(selectedOfficial);
                dgvGuestOfficialsAll.Refresh();
                dgvGuestOfficialsManage.Refresh();

                this.GuestOfficialsAddedCount -= 1;

                lblGuestOfficialsCount.Text = this.GuestOfficialsAddedCount.ToString() + "/4";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.HomeOfficialsAddedCount >= 1 && this.GuestOfficialsAddedCount >= 1)
            {

                List<ClubOfficial> homeOfficials = this.HomeOfficialsManage.ToList();
                this.HomeOfficialsManage = new BindingList<ClubOfficial>(homeOfficials.OrderBy(o => o.ClubOfficialId).ToList());

                List<ClubOfficial> guestOfficials = this.GuestOfficialsManage.ToList();
                this.GuestOfficialsManage = new BindingList<ClubOfficial>(guestOfficials.OrderBy(o => o.ClubOfficialId).ToList());

                this.OfficialsAddSuccess = true;
                this.Close();
            }
            else
            {
                this.OfficialsAddSuccess = false;
                MessageBox.Show(this, "Za svaku momčad je potrebno odabrati minimalno 1 službenu osobu.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
