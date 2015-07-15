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
    public partial class FrmPlayersUndo : Form
    {
        public TeamPlayer Player;
        public Team Team;
        public FrmPlayersUndo(TeamPlayer player, Team team)
        {
            InitializeComponent();

            this.Player = player;
            this.Team = team;
            
            lblPlayerName.Text = this.Player.Name;
            txtGoals.Value = this.Player.Goals - this.Player.Goals7m;
            txtGoals7m.Value = this.Player.Goals7m;
            txtWarning.Text = this.Player.Warning.ToString();
            txtSuspension1st.Text = this.Player.Suspension1st.ToString();
            txtSuspension2nd.Text = this.Player.Suspension2nd.ToString();
            txtSuspension3rd.Text = this.Player.Suspension3rd.ToString();
            txtDisqualification.Text = this.Player.Disqualification.ToString();
            txtDisqualificationReport.Text = this.Player.DisqualificationReport.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Team.Goals -= (short)this.Player.Goals;
            this.Team.Goals7m -= (short)this.Player.Goals7m;
            this.Team.Attempts7m -= (short)this.Player.Goals7m;

            this.Player.Goals = (int)(txtGoals.Value + txtGoals7m.Value);
            this.Player.Goals7m = (int)txtGoals7m.Value;

            this.Team.Goals += (short)this.Player.Goals;
            this.Team.Goals7m += (short)this.Player.Goals7m;
            this.Team.Attempts7m += (short)this.Player.Goals7m;

            if (txtWarning.Text.Length > 0)
                this.Player.Warning = int.Parse(txtWarning.Text);
            else
                this.Player.Warning = null;

            if (txtSuspension1st.Text.Length > 0)
                this.Player.Suspension1st = int.Parse(txtSuspension1st.Text);
            else
                this.Player.Suspension1st = null;

            if (txtSuspension2nd.Text.Length > 0)
                this.Player.Suspension2nd = int.Parse(txtSuspension2nd.Text);
            else
                this.Player.Suspension2nd = null;

            if (txtSuspension3rd.Text.Length > 0)
                this.Player.Suspension3rd = int.Parse(txtSuspension3rd.Text);
            else
                this.Player.Suspension3rd = null;

            if (txtDisqualification.Text.Length > 0)
                this.Player.Disqualification = int.Parse(txtDisqualification.Text);
            else
                this.Player.Disqualification = null;

            if (txtDisqualificationReport.Text.Length > 0)
                this.Player.DisqualificationReport = int.Parse(txtDisqualificationReport.Text);
            else
                this.Player.DisqualificationReport = null;

            this.Close();
        }
    }
}
