namespace MatchReporter.Forms.MatchStats
{
    partial class FrmMatch7m
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
            this.cbxGoal = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerNameLabel
            // 
            this.lblPlayerNameLabel.AutoSize = true;
            this.lblPlayerNameLabel.Location = new System.Drawing.Point(21, 18);
            this.lblPlayerNameLabel.Name = "lblPlayerNameLabel";
            this.lblPlayerNameLabel.Size = new System.Drawing.Size(34, 13);
            this.lblPlayerNameLabel.TabIndex = 2;
            this.lblPlayerNameLabel.Text = "Igrač:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(75, 18);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(74, 13);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "lblPlayerName";
            // 
            // cbxGoal
            // 
            this.cbxGoal.AutoSize = true;
            this.cbxGoal.Location = new System.Drawing.Point(78, 50);
            this.cbxGoal.Name = "cbxGoal";
            this.cbxGoal.Size = new System.Drawing.Size(69, 17);
            this.cbxGoal.TabIndex = 4;
            this.cbxGoal.Text = "Pogodak";
            this.cbxGoal.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(74, 80);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Spremi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmMatch7m
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 121);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbxGoal);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblPlayerNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMatch7m";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sedmerac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerNameLabel;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.CheckBox cbxGoal;
        private System.Windows.Forms.Button btnSubmit;
    }
}