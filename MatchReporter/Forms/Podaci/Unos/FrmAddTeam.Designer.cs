namespace MatchReporter.Forms.Podaci.Unos
{
    partial class FrmAddTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.cbxHomeTeam = new System.Windows.Forms.ComboBox();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxGuestTeam = new System.Windows.Forms.ComboBox();
            this.lblGuestTeam = new System.Windows.Forms.Label();
            this.btnAddTeams = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Location = new System.Drawing.Point(63, 49);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(37, 13);
            this.lblHomeTeam.TabIndex = 1;
            this.lblHomeTeam.Text = "Tim A:";
            // 
            // cbxHomeTeam
            // 
            this.cbxHomeTeam.DataSource = this.clubBindingSource;
            this.cbxHomeTeam.DisplayMember = "Name";
            this.cbxHomeTeam.FormattingEnabled = true;
            this.cbxHomeTeam.Location = new System.Drawing.Point(121, 46);
            this.cbxHomeTeam.Name = "cbxHomeTeam";
            this.cbxHomeTeam.Size = new System.Drawing.Size(143, 21);
            this.cbxHomeTeam.TabIndex = 3;
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataSource = typeof(MatchReporter.Club);
            // 
            // cbxGuestTeam
            // 
            this.cbxGuestTeam.DataSource = this.clubBindingSource;
            this.cbxGuestTeam.DisplayMember = "Name";
            this.cbxGuestTeam.FormattingEnabled = true;
            this.cbxGuestTeam.Location = new System.Drawing.Point(121, 89);
            this.cbxGuestTeam.Name = "cbxGuestTeam";
            this.cbxGuestTeam.Size = new System.Drawing.Size(143, 21);
            this.cbxGuestTeam.TabIndex = 4;
            // 
            // lblGuestTeam
            // 
            this.lblGuestTeam.AutoSize = true;
            this.lblGuestTeam.Location = new System.Drawing.Point(63, 92);
            this.lblGuestTeam.Name = "lblGuestTeam";
            this.lblGuestTeam.Size = new System.Drawing.Size(37, 13);
            this.lblGuestTeam.TabIndex = 5;
            this.lblGuestTeam.Text = "Tim B:";
            // 
            // btnAddTeams
            // 
            this.btnAddTeams.Location = new System.Drawing.Point(189, 141);
            this.btnAddTeams.Name = "btnAddTeams";
            this.btnAddTeams.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeams.TabIndex = 6;
            this.btnAddTeams.Text = "Spremi";
            this.btnAddTeams.UseVisualStyleBackColor = true;
            this.btnAddTeams.Click += new System.EventHandler(this.btnAddTeams_Click);
            // 
            // FrmAddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 195);
            this.Controls.Add(this.btnAddTeams);
            this.Controls.Add(this.lblGuestTeam);
            this.Controls.Add(this.cbxGuestTeam);
            this.Controls.Add(this.cbxHomeTeam);
            this.Controls.Add(this.lblHomeTeam);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj momčadi";
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.ComboBox cbxHomeTeam;
        private System.Windows.Forms.ComboBox cbxGuestTeam;
        private System.Windows.Forms.Label lblGuestTeam;
        private System.Windows.Forms.Button btnAddTeams;
        private System.Windows.Forms.BindingSource clubBindingSource;
    }
}