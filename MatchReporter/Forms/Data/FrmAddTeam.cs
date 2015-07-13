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
        public string HomeTeam;
        public string GuestTeam;
        public bool TeamsSelected;

        public FrmAddTeam()
        {
            InitializeComponent();

            TeamsSelected = false;

            BindingList<Club> homeTeams;
            BindingList<Club> guestTeams;

            using (var db = new MatchReporterEntities())
            {
                homeTeams = new BindingList<Club>(db.Club.ToList());
                guestTeams = new BindingList<Club>(db.Club.ToList());
            }

            cbxHomeTeam.DataSource = homeTeams;
            cbxGuestTeam.DataSource = guestTeams;
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
                HomeTeam = cbxHomeTeam.Text;
                GuestTeam = cbxGuestTeam.Text;
                TeamsSelected = true;
                this.Close();
            }
        }
    }
}
