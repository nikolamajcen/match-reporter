using MatchReporter.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchReporter.Forms.MatchStats
{
    public partial class FrmMatch7m : Form
    {
        public TeamPlayer Player;
        public Team Team;

        public FrmMatch7m(TeamPlayer player, Team team)
        {
            InitializeComponent();

            this.Player = player;
            this.Team = team;

            lblPlayerName.Text = this.Player.Name;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(cbxGoal.Checked == true)
            {
                this.Player.Goals += 1;
                this.Player.Goals7m += 1;

                this.Team.Goals += 1;
                this.Team.Goals7m += 1;
                this.Team.Attempts7m += 1;
            }
            else
            {
                this.Team.Attempts7m += 1;
            }
            this.Close();
        }
    }
}
