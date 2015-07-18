namespace MatchReporter.Forms.Other
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.lblApplicationNameText = new System.Windows.Forms.Label();
            this.lblAuthorText = new System.Windows.Forms.Label();
            this.lblPurposeText = new System.Windows.Forms.Label();
            this.txtDescriptionText = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(27, 65);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(82, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Autor aplikacije:";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(71, 105);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(38, 13);
            this.lblPurpose.TabIndex = 2;
            this.lblPurpose.Text = "Svrha:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(78, 142);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(31, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Opis:";
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.Location = new System.Drawing.Point(25, 25);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(84, 13);
            this.lblApplicationName.TabIndex = 4;
            this.lblApplicationName.Text = "Naziv aplikacije:";
            // 
            // lblApplicationNameText
            // 
            this.lblApplicationNameText.AutoSize = true;
            this.lblApplicationNameText.Location = new System.Drawing.Point(115, 25);
            this.lblApplicationNameText.Name = "lblApplicationNameText";
            this.lblApplicationNameText.Size = new System.Drawing.Size(81, 13);
            this.lblApplicationNameText.TabIndex = 5;
            this.lblApplicationNameText.Text = "Match Reporter";
            // 
            // lblAuthorText
            // 
            this.lblAuthorText.AutoSize = true;
            this.lblAuthorText.Location = new System.Drawing.Point(115, 65);
            this.lblAuthorText.Name = "lblAuthorText";
            this.lblAuthorText.Size = new System.Drawing.Size(75, 13);
            this.lblAuthorText.TabIndex = 6;
            this.lblAuthorText.Text = "Nikola Majcen";
            // 
            // lblPurposeText
            // 
            this.lblPurposeText.AutoSize = true;
            this.lblPurposeText.Location = new System.Drawing.Point(115, 105);
            this.lblPurposeText.Name = "lblPurposeText";
            this.lblPurposeText.Size = new System.Drawing.Size(203, 13);
            this.lblPurposeText.TabIndex = 7;
            this.lblPurposeText.Text = "Program je izrađen kao dio završnog rada";
            // 
            // txtDescriptionText
            // 
            this.txtDescriptionText.Location = new System.Drawing.Point(118, 142);
            this.txtDescriptionText.Multiline = true;
            this.txtDescriptionText.Name = "txtDescriptionText";
            this.txtDescriptionText.ReadOnly = true;
            this.txtDescriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionText.Size = new System.Drawing.Size(204, 78);
            this.txtDescriptionText.TabIndex = 8;
            this.txtDescriptionText.Text = resources.GetString("txtDescriptionText.Text");
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(247, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDescriptionText);
            this.Controls.Add(this.lblPurposeText);
            this.Controls.Add(this.lblAuthorText);
            this.Controls.Add(this.lblApplicationNameText);
            this.Controls.Add(this.lblApplicationName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblAuthor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "O aplikaciji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.Label lblApplicationNameText;
        private System.Windows.Forms.Label lblAuthorText;
        private System.Windows.Forms.Label lblPurposeText;
        private System.Windows.Forms.TextBox txtDescriptionText;
        private System.Windows.Forms.Button btnClose;
    }
}