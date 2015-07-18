namespace MatchReporter.Forms.MatchStats
{
    partial class FrmPlayersUndo
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
            this.lblPlayerNameLabel = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblGoals = new System.Windows.Forms.Label();
            this.lblGoals7m = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblSuspension1st = new System.Windows.Forms.Label();
            this.lblSuspension2nd = new System.Windows.Forms.Label();
            this.lblSuspension3rd = new System.Windows.Forms.Label();
            this.lblDisqualification = new System.Windows.Forms.Label();
            this.lblDisqualificationReport = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtGoals = new System.Windows.Forms.NumericUpDown();
            this.txtGoals7m = new System.Windows.Forms.NumericUpDown();
            this.txtWarning = new System.Windows.Forms.TextBox();
            this.txtSuspension2nd = new System.Windows.Forms.TextBox();
            this.txtSuspension3rd = new System.Windows.Forms.TextBox();
            this.txtDisqualification = new System.Windows.Forms.TextBox();
            this.txtDisqualificationReport = new System.Windows.Forms.TextBox();
            this.txtSuspension1st = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoals7m)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerNameLabel
            // 
            this.lblPlayerNameLabel.AutoSize = true;
            this.lblPlayerNameLabel.Location = new System.Drawing.Point(110, 25);
            this.lblPlayerNameLabel.Name = "lblPlayerNameLabel";
            this.lblPlayerNameLabel.Size = new System.Drawing.Size(34, 13);
            this.lblPlayerNameLabel.TabIndex = 0;
            this.lblPlayerNameLabel.Text = "Igrač:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(150, 25);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(74, 13);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "lblPlayerName";
            // 
            // lblGoals
            // 
            this.lblGoals.AutoSize = true;
            this.lblGoals.Location = new System.Drawing.Point(74, 55);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(70, 13);
            this.lblGoals.TabIndex = 2;
            this.lblGoals.Text = "Golovi iz igre:";
            // 
            // lblGoals7m
            // 
            this.lblGoals7m.AutoSize = true;
            this.lblGoals7m.Location = new System.Drawing.Point(45, 85);
            this.lblGoals7m.Name = "lblGoals7m";
            this.lblGoals7m.Size = new System.Drawing.Size(99, 13);
            this.lblGoals7m.TabIndex = 3;
            this.lblGoals7m.Text = "Golovi iz sedmerca:";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(88, 115);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(56, 13);
            this.lblWarning.TabIndex = 4;
            this.lblWarning.Text = "Opomena:";
            // 
            // lblSuspension1st
            // 
            this.lblSuspension1st.AutoSize = true;
            this.lblSuspension1st.Location = new System.Drawing.Point(73, 145);
            this.lblSuspension1st.Name = "lblSuspension1st";
            this.lblSuspension1st.Size = new System.Drawing.Size(71, 13);
            this.lblSuspension1st.TabIndex = 6;
            this.lblSuspension1st.Text = "1. isključenje:";
            // 
            // lblSuspension2nd
            // 
            this.lblSuspension2nd.AutoSize = true;
            this.lblSuspension2nd.Location = new System.Drawing.Point(73, 175);
            this.lblSuspension2nd.Name = "lblSuspension2nd";
            this.lblSuspension2nd.Size = new System.Drawing.Size(71, 13);
            this.lblSuspension2nd.TabIndex = 7;
            this.lblSuspension2nd.Text = "2. isključenje:";
            // 
            // lblSuspension3rd
            // 
            this.lblSuspension3rd.AutoSize = true;
            this.lblSuspension3rd.Location = new System.Drawing.Point(73, 205);
            this.lblSuspension3rd.Name = "lblSuspension3rd";
            this.lblSuspension3rd.Size = new System.Drawing.Size(71, 13);
            this.lblSuspension3rd.TabIndex = 8;
            this.lblSuspension3rd.Text = "3. isključenje:";
            // 
            // lblDisqualification
            // 
            this.lblDisqualification.AutoSize = true;
            this.lblDisqualification.Location = new System.Drawing.Point(64, 235);
            this.lblDisqualification.Name = "lblDisqualification";
            this.lblDisqualification.Size = new System.Drawing.Size(80, 13);
            this.lblDisqualification.TabIndex = 9;
            this.lblDisqualification.Text = "Diskvalifikacija:";
            // 
            // lblDisqualificationReport
            // 
            this.lblDisqualificationReport.AutoSize = true;
            this.lblDisqualificationReport.Location = new System.Drawing.Point(14, 265);
            this.lblDisqualificationReport.Name = "lblDisqualificationReport";
            this.lblDisqualificationReport.Size = new System.Drawing.Size(130, 13);
            this.lblDisqualificationReport.TabIndex = 10;
            this.lblDisqualificationReport.Text = "Diskvalifikacija s prijavom:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(150, 301);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Spremi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtGoals
            // 
            this.txtGoals.Location = new System.Drawing.Point(150, 53);
            this.txtGoals.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtGoals.Name = "txtGoals";
            this.txtGoals.Size = new System.Drawing.Size(100, 20);
            this.txtGoals.TabIndex = 20;
            // 
            // txtGoals7m
            // 
            this.txtGoals7m.Location = new System.Drawing.Point(150, 83);
            this.txtGoals7m.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtGoals7m.Name = "txtGoals7m";
            this.txtGoals7m.Size = new System.Drawing.Size(100, 20);
            this.txtGoals7m.TabIndex = 21;
            // 
            // txtWarning
            // 
            this.txtWarning.Location = new System.Drawing.Point(150, 112);
            this.txtWarning.Name = "txtWarning";
            this.txtWarning.Size = new System.Drawing.Size(100, 20);
            this.txtWarning.TabIndex = 22;
            // 
            // txtSuspension2nd
            // 
            this.txtSuspension2nd.Location = new System.Drawing.Point(150, 172);
            this.txtSuspension2nd.Name = "txtSuspension2nd";
            this.txtSuspension2nd.Size = new System.Drawing.Size(100, 20);
            this.txtSuspension2nd.TabIndex = 23;
            // 
            // txtSuspension3rd
            // 
            this.txtSuspension3rd.Location = new System.Drawing.Point(150, 202);
            this.txtSuspension3rd.Name = "txtSuspension3rd";
            this.txtSuspension3rd.Size = new System.Drawing.Size(100, 20);
            this.txtSuspension3rd.TabIndex = 24;
            // 
            // txtDisqualification
            // 
            this.txtDisqualification.Location = new System.Drawing.Point(150, 232);
            this.txtDisqualification.Name = "txtDisqualification";
            this.txtDisqualification.Size = new System.Drawing.Size(100, 20);
            this.txtDisqualification.TabIndex = 25;
            // 
            // txtDisqualificationReport
            // 
            this.txtDisqualificationReport.Location = new System.Drawing.Point(150, 262);
            this.txtDisqualificationReport.Name = "txtDisqualificationReport";
            this.txtDisqualificationReport.Size = new System.Drawing.Size(100, 20);
            this.txtDisqualificationReport.TabIndex = 26;
            // 
            // txtSuspension1st
            // 
            this.txtSuspension1st.Location = new System.Drawing.Point(150, 142);
            this.txtSuspension1st.Name = "txtSuspension1st";
            this.txtSuspension1st.Size = new System.Drawing.Size(100, 20);
            this.txtSuspension1st.TabIndex = 27;
            // 
            // FrmPlayersUndo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 345);
            this.Controls.Add(this.txtSuspension1st);
            this.Controls.Add(this.txtDisqualificationReport);
            this.Controls.Add(this.txtDisqualification);
            this.Controls.Add(this.txtSuspension3rd);
            this.Controls.Add(this.txtSuspension2nd);
            this.Controls.Add(this.txtWarning);
            this.Controls.Add(this.txtGoals7m);
            this.Controls.Add(this.txtGoals);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDisqualificationReport);
            this.Controls.Add(this.lblDisqualification);
            this.Controls.Add(this.lblSuspension3rd);
            this.Controls.Add(this.lblSuspension2nd);
            this.Controls.Add(this.lblSuspension1st);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblGoals7m);
            this.Controls.Add(this.lblGoals);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblPlayerNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlayersUndo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena podataka";
            ((System.ComponentModel.ISupportInitialize)(this.txtGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoals7m)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerNameLabel;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblGoals;
        private System.Windows.Forms.Label lblGoals7m;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblSuspension1st;
        private System.Windows.Forms.Label lblSuspension2nd;
        private System.Windows.Forms.Label lblSuspension3rd;
        private System.Windows.Forms.Label lblDisqualification;
        private System.Windows.Forms.Label lblDisqualificationReport;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown txtGoals;
        private System.Windows.Forms.NumericUpDown txtGoals7m;
        private System.Windows.Forms.TextBox txtWarning;
        private System.Windows.Forms.TextBox txtSuspension2nd;
        private System.Windows.Forms.TextBox txtSuspension3rd;
        private System.Windows.Forms.TextBox txtDisqualification;
        private System.Windows.Forms.TextBox txtDisqualificationReport;
        private System.Windows.Forms.TextBox txtSuspension1st;
    }
}