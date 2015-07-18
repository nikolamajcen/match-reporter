namespace MatchReporter.Forms.Reports
{
    partial class FrmReportEmailSend
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
            this.lblReceiver = new System.Windows.Forms.Label();
            this.txtReceiverEmail = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblMailText = new System.Windows.Forms.Label();
            this.txtMailBody = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReceiver
            // 
            this.lblReceiver.AutoSize = true;
            this.lblReceiver.Location = new System.Drawing.Point(46, 25);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(49, 13);
            this.lblReceiver.TabIndex = 0;
            this.lblReceiver.Text = "Primatelj:";
            // 
            // txtReceiverEmail
            // 
            this.txtReceiverEmail.Location = new System.Drawing.Point(101, 22);
            this.txtReceiverEmail.Name = "txtReceiverEmail";
            this.txtReceiverEmail.Size = new System.Drawing.Size(237, 20);
            this.txtReceiverEmail.TabIndex = 1;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(52, 55);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Naslov:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(101, 52);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(237, 20);
            this.txtSubject.TabIndex = 3;
            // 
            // lblMailText
            // 
            this.lblMailText.AutoSize = true;
            this.lblMailText.Location = new System.Drawing.Point(22, 85);
            this.lblMailText.Name = "lblMailText";
            this.lblMailText.Size = new System.Drawing.Size(73, 13);
            this.lblMailText.TabIndex = 4;
            this.lblMailText.Text = "Tekst poruke:";
            // 
            // txtMailBody
            // 
            this.txtMailBody.Location = new System.Drawing.Point(101, 82);
            this.txtMailBody.Multiline = true;
            this.txtMailBody.Name = "txtMailBody";
            this.txtMailBody.Size = new System.Drawing.Size(237, 70);
            this.txtMailBody.TabIndex = 5;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(33, 165);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(62, 13);
            this.lblRemark.TabIndex = 6;
            this.lblRemark.Text = "Napomena:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(101, 162);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(237, 70);
            this.txtRemarks.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(263, 244);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Pošalji";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(182, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(101, 244);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "Postavke";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // FrmReportEmailSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 283);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtMailBody);
            this.Controls.Add(this.lblMailText);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtReceiverEmail);
            this.Controls.Add(this.lblReceiver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportEmailSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slanje rezultata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.TextBox txtReceiverEmail;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblMailText;
        private System.Windows.Forms.TextBox txtMailBody;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSettings;
    }
}