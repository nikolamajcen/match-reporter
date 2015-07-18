namespace MatchReporter.Forms.Reports
{
    partial class FrmMatchReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.matchReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HomeTeamPlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GuestTeamPlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HomeTeamOfficialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GuestTeamOfficialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HomeTeamPlayerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestTeamPlayerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeTeamOfficialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestTeamOfficialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // matchReport
            // 
            this.matchReport.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HomeTeamPlayers";
            reportDataSource1.Value = this.HomeTeamPlayerBindingSource;
            reportDataSource2.Name = "GuestTeamPlayers";
            reportDataSource2.Value = this.GuestTeamPlayerBindingSource;
            reportDataSource3.Name = "HomeTeamOfficials";
            reportDataSource3.Value = this.HomeTeamOfficialBindingSource;
            reportDataSource4.Name = "GuestTeamOfficials";
            reportDataSource4.Value = this.GuestTeamOfficialBindingSource;
            this.matchReport.LocalReport.DataSources.Add(reportDataSource1);
            this.matchReport.LocalReport.DataSources.Add(reportDataSource2);
            this.matchReport.LocalReport.DataSources.Add(reportDataSource3);
            this.matchReport.LocalReport.DataSources.Add(reportDataSource4);
            this.matchReport.LocalReport.ReportEmbeddedResource = "MatchReporter.Forms.Reports.MatchReport.rdlc";
            this.matchReport.Location = new System.Drawing.Point(0, 0);
            this.matchReport.Name = "matchReport";
            this.matchReport.Size = new System.Drawing.Size(673, 492);
            this.matchReport.TabIndex = 0;
            // 
            // HomeTeamPlayerBindingSource
            // 
            this.HomeTeamPlayerBindingSource.DataSource = typeof(MatchReporter.Classes.TeamPlayer);
            // 
            // GuestTeamPlayerBindingSource
            // 
            this.GuestTeamPlayerBindingSource.DataSource = typeof(MatchReporter.Classes.TeamPlayer);
            // 
            // HomeTeamOfficialBindingSource
            // 
            this.HomeTeamOfficialBindingSource.DataSource = typeof(MatchReporter.Classes.TeamOfficial);
            // 
            // GuestTeamOfficialBindingSource
            // 
            this.GuestTeamOfficialBindingSource.DataSource = typeof(MatchReporter.Classes.TeamOfficial);
            // 
            // FrmMatchReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 492);
            this.Controls.Add(this.matchReport);
            this.Name = "FrmMatchReport";
            this.Text = "FrmMatchReport";
            this.Load += new System.EventHandler(this.FrmMatchReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomeTeamPlayerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestTeamPlayerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeTeamOfficialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestTeamOfficialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer matchReport;
        private System.Windows.Forms.BindingSource HomeTeamPlayerBindingSource;
        private System.Windows.Forms.BindingSource GuestTeamPlayerBindingSource;
        private System.Windows.Forms.BindingSource HomeTeamOfficialBindingSource;
        private System.Windows.Forms.BindingSource GuestTeamOfficialBindingSource;
    }
}