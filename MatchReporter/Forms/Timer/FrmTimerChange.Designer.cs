namespace MatchReporter.Forms.Timer
{
    partial class FrmTimerChange
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
            this.lblMinute = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.btnChangeTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(42, 32);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(133, 13);
            this.lblMinute.TabIndex = 0;
            this.lblMinute.Text = "Vrijeme (minuta i sekunda):";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(45, 57);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(53, 20);
            this.txtMinutes.TabIndex = 2;
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(117, 57);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(53, 20);
            this.txtSeconds.TabIndex = 3;
            // 
            // btnChangeTime
            // 
            this.btnChangeTime.Location = new System.Drawing.Point(45, 92);
            this.btnChangeTime.Name = "btnChangeTime";
            this.btnChangeTime.Size = new System.Drawing.Size(125, 23);
            this.btnChangeTime.TabIndex = 4;
            this.btnChangeTime.Text = "Promijeni";
            this.btnChangeTime.UseVisualStyleBackColor = true;
            this.btnChangeTime.Click += new System.EventHandler(this.btnChangeTime_Click);
            // 
            // FrmTimerChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 149);
            this.Controls.Add(this.btnChangeTime);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.lblMinute);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTimerChange";
            this.Text = "Promjena vremena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Button btnChangeTime;
    }
}