namespace MatchReporter.Forms.MatchStats
{
    partial class FrmOfficialsUndo
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
            this.lblOfficialNameLabel = new System.Windows.Forms.Label();
            this.lblOfficialName = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblSuspension = new System.Windows.Forms.Label();
            this.lblDisqualification = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtWarning = new System.Windows.Forms.TextBox();
            this.txtSuspension = new System.Windows.Forms.TextBox();
            this.txtDisqualification = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOfficialNameLabel
            // 
            this.lblOfficialNameLabel.AutoSize = true;
            this.lblOfficialNameLabel.Location = new System.Drawing.Point(25, 25);
            this.lblOfficialNameLabel.Name = "lblOfficialNameLabel";
            this.lblOfficialNameLabel.Size = new System.Drawing.Size(86, 13);
            this.lblOfficialNameLabel.TabIndex = 0;
            this.lblOfficialNameLabel.Text = "Službena osoba:";
            // 
            // lblOfficialName
            // 
            this.lblOfficialName.AutoSize = true;
            this.lblOfficialName.Location = new System.Drawing.Point(117, 25);
            this.lblOfficialName.Name = "lblOfficialName";
            this.lblOfficialName.Size = new System.Drawing.Size(77, 13);
            this.lblOfficialName.TabIndex = 1;
            this.lblOfficialName.Text = "lblOfficialName";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(55, 55);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(56, 13);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Text = "Opomena:";
            // 
            // lblSuspension
            // 
            this.lblSuspension.AutoSize = true;
            this.lblSuspension.Location = new System.Drawing.Point(51, 85);
            this.lblSuspension.Name = "lblSuspension";
            this.lblSuspension.Size = new System.Drawing.Size(60, 13);
            this.lblSuspension.TabIndex = 3;
            this.lblSuspension.Text = "Isključenje:";
            // 
            // lblDisqualification
            // 
            this.lblDisqualification.AutoSize = true;
            this.lblDisqualification.Location = new System.Drawing.Point(31, 115);
            this.lblDisqualification.Name = "lblDisqualification";
            this.lblDisqualification.Size = new System.Drawing.Size(80, 13);
            this.lblDisqualification.TabIndex = 4;
            this.lblDisqualification.Text = "Diskvalifikacija:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(117, 153);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Spremi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtWarning
            // 
            this.txtWarning.Location = new System.Drawing.Point(117, 52);
            this.txtWarning.Name = "txtWarning";
            this.txtWarning.Size = new System.Drawing.Size(100, 20);
            this.txtWarning.TabIndex = 6;
            // 
            // txtSuspension
            // 
            this.txtSuspension.Location = new System.Drawing.Point(117, 82);
            this.txtSuspension.Name = "txtSuspension";
            this.txtSuspension.Size = new System.Drawing.Size(100, 20);
            this.txtSuspension.TabIndex = 7;
            // 
            // txtDisqualification
            // 
            this.txtDisqualification.Location = new System.Drawing.Point(117, 112);
            this.txtDisqualification.Name = "txtDisqualification";
            this.txtDisqualification.Size = new System.Drawing.Size(100, 20);
            this.txtDisqualification.TabIndex = 8;
            // 
            // FrmOfficialsUndo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 201);
            this.Controls.Add(this.txtDisqualification);
            this.Controls.Add(this.txtSuspension);
            this.Controls.Add(this.txtWarning);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDisqualification);
            this.Controls.Add(this.lblSuspension);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblOfficialName);
            this.Controls.Add(this.lblOfficialNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOfficialsUndo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOfficialNameLabel;
        private System.Windows.Forms.Label lblOfficialName;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblSuspension;
        private System.Windows.Forms.Label lblDisqualification;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtWarning;
        private System.Windows.Forms.TextBox txtSuspension;
        private System.Windows.Forms.TextBox txtDisqualification;
    }
}