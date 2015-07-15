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
    public partial class FrmOfficialsUndo : Form
    {
        public TeamOfficial Official;
        public FrmOfficialsUndo(TeamOfficial official)
        {
            InitializeComponent();

            this.Official = official;

            lblOfficialName.Text = this.Official.Name;
            txtWarning.Text = this.Official.Warning.ToString();
            txtSuspension.Text = this.Official.Suspension.ToString();
            txtDisqualification.Text = this.Official.Disqualification.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtWarning.Text.Length > 0)
                this.Official.Warning = int.Parse(txtWarning.Text);
            else
                this.Official.Warning = null;

            if (txtSuspension.Text.Length > 0)
                this.Official.Suspension = int.Parse(txtSuspension.Text);
            else
                this.Official.Suspension = null;

            if (txtDisqualification.Text.Length > 0)
                this.Official.Disqualification = int.Parse(txtDisqualification.Text);
            else
                this.Official.Disqualification = null;

            this.Close();
        }
    }
}
