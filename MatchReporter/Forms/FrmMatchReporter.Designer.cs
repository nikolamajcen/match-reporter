namespace MatchReporter.Forms
{
    partial class FrmMatchReporter
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
            this.menuMainMenu = new System.Windows.Forms.MenuStrip();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchConcludeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataOfficialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportSendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dgvGuestOfficials = new System.Windows.Forms.DataGridView();
            this.teamOfficialIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warningDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspensionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disqualificationDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamOfficialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvHomeOfficials = new System.Windows.Forms.DataGridView();
            this.teamOfficialIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warningDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disqualificationDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGuestTeam = new System.Windows.Forms.DataGridView();
            this.teamPlayerIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goals7mDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warningDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspension1stDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspension2ndDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspension3rdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disqualificationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disqualificationReportDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamPlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHomeUndo = new System.Windows.Forms.Button();
            this.dgvHomeTeam = new System.Windows.Forms.DataGridView();
            this.teamPlayerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goals7mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspension1stDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspension2ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspension3rdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disqualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disqualificationReportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHomeDisqualificationReport = new System.Windows.Forms.Button();
            this.btnHomeDisqualification = new System.Windows.Forms.Button();
            this.btnHomeSuspension = new System.Windows.Forms.Button();
            this.btnHomeWarning = new System.Windows.Forms.Button();
            this.btnHome7m = new System.Windows.Forms.Button();
            this.btnHomeGoal = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTimeSeconds = new System.Windows.Forms.Label();
            this.lblTimeMinutes = new System.Windows.Forms.Label();
            this.btnTimeReset = new System.Windows.Forms.Button();
            this.btnTimeChange = new System.Windows.Forms.Button();
            this.btnTimeStop = new System.Windows.Forms.Button();
            this.btnTimeStart = new System.Windows.Forms.Button();
            this.txtTeamBTTO3 = new System.Windows.Forms.TextBox();
            this.txtTeamBTTO2 = new System.Windows.Forms.TextBox();
            this.txtTeamBTTO1 = new System.Windows.Forms.TextBox();
            this.txtTeamATTO3 = new System.Windows.Forms.TextBox();
            this.txtTeamATTO2 = new System.Windows.Forms.TextBox();
            this.txtTeamATTO1 = new System.Windows.Forms.TextBox();
            this.btnTeamBTTO3 = new System.Windows.Forms.Button();
            this.btnTeamBTTO2 = new System.Windows.Forms.Button();
            this.btnTeamBTTO1 = new System.Windows.Forms.Button();
            this.btnTeamATTO3 = new System.Windows.Forms.Button();
            this.btnTeamATTO2 = new System.Windows.Forms.Button();
            this.btnTeamATTO1 = new System.Windows.Forms.Button();
            this.lblResultB = new System.Windows.Forms.Label();
            this.lblResultA = new System.Windows.Forms.Label();
            this.lblTeamB = new System.Windows.Forms.Label();
            this.lblTeamA = new System.Windows.Forms.Label();
            this.timerMatch = new System.Windows.Forms.Timer(this.components);
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuestGoal = new System.Windows.Forms.Button();
            this.btnGuest7m = new System.Windows.Forms.Button();
            this.btnGuestUndo = new System.Windows.Forms.Button();
            this.btnGuestDisqualificationReport = new System.Windows.Forms.Button();
            this.btnGuestDisqualification = new System.Windows.Forms.Button();
            this.btnGuestSuspension = new System.Windows.Forms.Button();
            this.btnGuestWarning = new System.Windows.Forms.Button();
            this.btnHomeOfficialDisqualification = new System.Windows.Forms.Button();
            this.btnHomeOfficialSuspension = new System.Windows.Forms.Button();
            this.btnHomeOfficialWarning = new System.Windows.Forms.Button();
            this.btnGuestOfficialDisqualification = new System.Windows.Forms.Button();
            this.btnGuestOfficialSuspension = new System.Windows.Forms.Button();
            this.btnGuestOfficialWarning = new System.Windows.Forms.Button();
            this.menuMainMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestOfficials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamOfficialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeOfficials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamPlayerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeTeam)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMainMenu
            // 
            this.menuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuMainMenu.Name = "menuMainMenu";
            this.menuMainMenu.Size = new System.Drawing.Size(884, 24);
            this.menuMainMenu.TabIndex = 0;
            this.menuMainMenu.Text = "menuStrip1";
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchNewToolStripMenuItem,
            this.matchOpenToolStripMenuItem,
            this.matchSaveToolStripMenuItem,
            this.matchConcludeToolStripMenuItem,
            this.matchCloseToolStripMenuItem});
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.matchToolStripMenuItem.Text = "Utakmica";
            // 
            // matchNewToolStripMenuItem
            // 
            this.matchNewToolStripMenuItem.Name = "matchNewToolStripMenuItem";
            this.matchNewToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.matchNewToolStripMenuItem.Text = "Nova...";
            this.matchNewToolStripMenuItem.Click += new System.EventHandler(this.matchNewToolStripMenuItem_Click);
            // 
            // matchOpenToolStripMenuItem
            // 
            this.matchOpenToolStripMenuItem.Name = "matchOpenToolStripMenuItem";
            this.matchOpenToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.matchOpenToolStripMenuItem.Text = "Otvori...";
            // 
            // matchSaveToolStripMenuItem
            // 
            this.matchSaveToolStripMenuItem.Name = "matchSaveToolStripMenuItem";
            this.matchSaveToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.matchSaveToolStripMenuItem.Text = "Spremi...";
            // 
            // matchConcludeToolStripMenuItem
            // 
            this.matchConcludeToolStripMenuItem.Name = "matchConcludeToolStripMenuItem";
            this.matchConcludeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.matchConcludeToolStripMenuItem.Text = "Zaključi...";
            // 
            // matchCloseToolStripMenuItem
            // 
            this.matchCloseToolStripMenuItem.Name = "matchCloseToolStripMenuItem";
            this.matchCloseToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.matchCloseToolStripMenuItem.Text = "Zatvori...";
            this.matchCloseToolStripMenuItem.Click += new System.EventHandler(this.matchCloseToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMatchDetailsToolStripMenuItem,
            this.dataTeamsToolStripMenuItem,
            this.dataPlayersToolStripMenuItem,
            this.dataOfficialsToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.dataToolStripMenuItem.Text = "Podaci";
            // 
            // dataMatchDetailsToolStripMenuItem
            // 
            this.dataMatchDetailsToolStripMenuItem.Name = "dataMatchDetailsToolStripMenuItem";
            this.dataMatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dataMatchDetailsToolStripMenuItem.Text = "Opći podaci";
            this.dataMatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.dataMatchDetailsToolStripMenuItem_Click);
            // 
            // dataTeamsToolStripMenuItem
            // 
            this.dataTeamsToolStripMenuItem.Name = "dataTeamsToolStripMenuItem";
            this.dataTeamsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dataTeamsToolStripMenuItem.Text = "Momčadi";
            this.dataTeamsToolStripMenuItem.Click += new System.EventHandler(this.dataTeamsToolStripMenuItem_Click);
            // 
            // dataPlayersToolStripMenuItem
            // 
            this.dataPlayersToolStripMenuItem.Name = "dataPlayersToolStripMenuItem";
            this.dataPlayersToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dataPlayersToolStripMenuItem.Text = "Igrači";
            this.dataPlayersToolStripMenuItem.Click += new System.EventHandler(this.dataPlayersToolStripMenuItem_Click);
            // 
            // dataOfficialsToolStripMenuItem
            // 
            this.dataOfficialsToolStripMenuItem.Name = "dataOfficialsToolStripMenuItem";
            this.dataOfficialsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dataOfficialsToolStripMenuItem.Text = "Službene osobe";
            this.dataOfficialsToolStripMenuItem.Click += new System.EventHandler(this.dataOfficialsToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportPrintToolStripMenuItem,
            this.reportSendToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reportToolStripMenuItem.Text = "Izvještaj";
            // 
            // reportPrintToolStripMenuItem
            // 
            this.reportPrintToolStripMenuItem.Name = "reportPrintToolStripMenuItem";
            this.reportPrintToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.reportPrintToolStripMenuItem.Text = "Ispis izvještaja utakmice";
            // 
            // reportSendToolStripMenuItem
            // 
            this.reportSendToolStripMenuItem.Name = "reportSendToolStripMenuItem";
            this.reportSendToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.reportSendToolStripMenuItem.Text = "Slanje rezultata utakmice";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherAboutToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.otherToolStripMenuItem.Text = "Ostalo";
            // 
            // otherAboutToolStripMenuItem
            // 
            this.otherAboutToolStripMenuItem.Name = "otherAboutToolStripMenuItem";
            this.otherAboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.otherAboutToolStripMenuItem.Text = "O aplikaciji";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSize = true;
            this.panelMain.Controls.Add(this.btnGuestOfficialDisqualification);
            this.panelMain.Controls.Add(this.btnGuestOfficialSuspension);
            this.panelMain.Controls.Add(this.btnGuestOfficialWarning);
            this.panelMain.Controls.Add(this.btnHomeOfficialDisqualification);
            this.panelMain.Controls.Add(this.btnHomeOfficialSuspension);
            this.panelMain.Controls.Add(this.btnHomeOfficialWarning);
            this.panelMain.Controls.Add(this.btnGuestUndo);
            this.panelMain.Controls.Add(this.btnGuestDisqualificationReport);
            this.panelMain.Controls.Add(this.btnGuestDisqualification);
            this.panelMain.Controls.Add(this.btnGuestSuspension);
            this.panelMain.Controls.Add(this.btnGuestWarning);
            this.panelMain.Controls.Add(this.btnGuest7m);
            this.panelMain.Controls.Add(this.btnGuestGoal);
            this.panelMain.Controls.Add(this.dgvGuestOfficials);
            this.panelMain.Controls.Add(this.dgvHomeOfficials);
            this.panelMain.Controls.Add(this.dgvGuestTeam);
            this.panelMain.Controls.Add(this.btnHomeUndo);
            this.panelMain.Controls.Add(this.dgvHomeTeam);
            this.panelMain.Controls.Add(this.btnHomeDisqualificationReport);
            this.panelMain.Controls.Add(this.btnHomeDisqualification);
            this.panelMain.Controls.Add(this.btnHomeSuspension);
            this.panelMain.Controls.Add(this.btnHomeWarning);
            this.panelMain.Controls.Add(this.btnHome7m);
            this.panelMain.Controls.Add(this.btnHomeGoal);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(884, 637);
            this.panelMain.TabIndex = 1;
            // 
            // dgvGuestOfficials
            // 
            this.dgvGuestOfficials.AllowUserToAddRows = false;
            this.dgvGuestOfficials.AllowUserToDeleteRows = false;
            this.dgvGuestOfficials.AutoGenerateColumns = false;
            this.dgvGuestOfficials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestOfficials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamOfficialIdDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn3,
            this.warningDataGridViewTextBoxColumn3,
            this.suspensionDataGridViewTextBoxColumn1,
            this.disqualificationDataGridViewTextBoxColumn3});
            this.dgvGuestOfficials.DataSource = this.teamOfficialBindingSource;
            this.dgvGuestOfficials.Location = new System.Drawing.Point(506, 489);
            this.dgvGuestOfficials.MultiSelect = false;
            this.dgvGuestOfficials.Name = "dgvGuestOfficials";
            this.dgvGuestOfficials.ReadOnly = true;
            this.dgvGuestOfficials.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGuestOfficials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuestOfficials.Size = new System.Drawing.Size(366, 111);
            this.dgvGuestOfficials.TabIndex = 33;
            // 
            // teamOfficialIdDataGridViewTextBoxColumn1
            // 
            this.teamOfficialIdDataGridViewTextBoxColumn1.DataPropertyName = "TeamOfficialId";
            this.teamOfficialIdDataGridViewTextBoxColumn1.HeaderText = "Matični broj";
            this.teamOfficialIdDataGridViewTextBoxColumn1.Name = "teamOfficialIdDataGridViewTextBoxColumn1";
            this.teamOfficialIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Ime";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn3.Width = 118;
            // 
            // warningDataGridViewTextBoxColumn3
            // 
            this.warningDataGridViewTextBoxColumn3.DataPropertyName = "Warning";
            this.warningDataGridViewTextBoxColumn3.HeaderText = "O";
            this.warningDataGridViewTextBoxColumn3.Name = "warningDataGridViewTextBoxColumn3";
            this.warningDataGridViewTextBoxColumn3.ReadOnly = true;
            this.warningDataGridViewTextBoxColumn3.Width = 35;
            // 
            // suspensionDataGridViewTextBoxColumn1
            // 
            this.suspensionDataGridViewTextBoxColumn1.DataPropertyName = "Suspension";
            this.suspensionDataGridViewTextBoxColumn1.HeaderText = "2\'";
            this.suspensionDataGridViewTextBoxColumn1.Name = "suspensionDataGridViewTextBoxColumn1";
            this.suspensionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.suspensionDataGridViewTextBoxColumn1.Width = 35;
            // 
            // disqualificationDataGridViewTextBoxColumn3
            // 
            this.disqualificationDataGridViewTextBoxColumn3.DataPropertyName = "Disqualification";
            this.disqualificationDataGridViewTextBoxColumn3.HeaderText = "D";
            this.disqualificationDataGridViewTextBoxColumn3.Name = "disqualificationDataGridViewTextBoxColumn3";
            this.disqualificationDataGridViewTextBoxColumn3.ReadOnly = true;
            this.disqualificationDataGridViewTextBoxColumn3.Width = 35;
            // 
            // teamOfficialBindingSource
            // 
            this.teamOfficialBindingSource.DataSource = typeof(MatchReporter.Classes.TeamOfficial);
            // 
            // dgvHomeOfficials
            // 
            this.dgvHomeOfficials.AllowUserToAddRows = false;
            this.dgvHomeOfficials.AllowUserToDeleteRows = false;
            this.dgvHomeOfficials.AutoGenerateColumns = false;
            this.dgvHomeOfficials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeOfficials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamOfficialIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn2,
            this.warningDataGridViewTextBoxColumn2,
            this.suspensionDataGridViewTextBoxColumn,
            this.disqualificationDataGridViewTextBoxColumn2});
            this.dgvHomeOfficials.DataSource = this.teamOfficialBindingSource;
            this.dgvHomeOfficials.Location = new System.Drawing.Point(12, 489);
            this.dgvHomeOfficials.MultiSelect = false;
            this.dgvHomeOfficials.Name = "dgvHomeOfficials";
            this.dgvHomeOfficials.ReadOnly = true;
            this.dgvHomeOfficials.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHomeOfficials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHomeOfficials.Size = new System.Drawing.Size(366, 111);
            this.dgvHomeOfficials.TabIndex = 32;
            // 
            // teamOfficialIdDataGridViewTextBoxColumn
            // 
            this.teamOfficialIdDataGridViewTextBoxColumn.DataPropertyName = "TeamOfficialId";
            this.teamOfficialIdDataGridViewTextBoxColumn.HeaderText = "Matični broj";
            this.teamOfficialIdDataGridViewTextBoxColumn.Name = "teamOfficialIdDataGridViewTextBoxColumn";
            this.teamOfficialIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn2.Width = 118;
            // 
            // warningDataGridViewTextBoxColumn2
            // 
            this.warningDataGridViewTextBoxColumn2.DataPropertyName = "Warning";
            this.warningDataGridViewTextBoxColumn2.HeaderText = "O";
            this.warningDataGridViewTextBoxColumn2.Name = "warningDataGridViewTextBoxColumn2";
            this.warningDataGridViewTextBoxColumn2.ReadOnly = true;
            this.warningDataGridViewTextBoxColumn2.Width = 35;
            // 
            // suspensionDataGridViewTextBoxColumn
            // 
            this.suspensionDataGridViewTextBoxColumn.DataPropertyName = "Suspension";
            this.suspensionDataGridViewTextBoxColumn.HeaderText = "2\'";
            this.suspensionDataGridViewTextBoxColumn.Name = "suspensionDataGridViewTextBoxColumn";
            this.suspensionDataGridViewTextBoxColumn.ReadOnly = true;
            this.suspensionDataGridViewTextBoxColumn.Width = 35;
            // 
            // disqualificationDataGridViewTextBoxColumn2
            // 
            this.disqualificationDataGridViewTextBoxColumn2.DataPropertyName = "Disqualification";
            this.disqualificationDataGridViewTextBoxColumn2.HeaderText = "D";
            this.disqualificationDataGridViewTextBoxColumn2.Name = "disqualificationDataGridViewTextBoxColumn2";
            this.disqualificationDataGridViewTextBoxColumn2.ReadOnly = true;
            this.disqualificationDataGridViewTextBoxColumn2.Width = 35;
            // 
            // dgvGuestTeam
            // 
            this.dgvGuestTeam.AllowUserToAddRows = false;
            this.dgvGuestTeam.AllowUserToDeleteRows = false;
            this.dgvGuestTeam.AutoGenerateColumns = false;
            this.dgvGuestTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamPlayerIdDataGridViewTextBoxColumn1,
            this.numberDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.goalsDataGridViewTextBoxColumn1,
            this.goals7mDataGridViewTextBoxColumn1,
            this.warningDataGridViewTextBoxColumn1,
            this.suspension1stDataGridViewTextBoxColumn1,
            this.suspension2ndDataGridViewTextBoxColumn1,
            this.suspension3rdDataGridViewTextBoxColumn1,
            this.disqualificationDataGridViewTextBoxColumn1,
            this.disqualificationReportDataGridViewTextBoxColumn1});
            this.dgvGuestTeam.DataSource = this.teamPlayerBindingSource;
            this.dgvGuestTeam.Location = new System.Drawing.Point(506, 108);
            this.dgvGuestTeam.MultiSelect = false;
            this.dgvGuestTeam.Name = "dgvGuestTeam";
            this.dgvGuestTeam.ReadOnly = true;
            this.dgvGuestTeam.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGuestTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuestTeam.Size = new System.Drawing.Size(366, 375);
            this.dgvGuestTeam.TabIndex = 31;
            // 
            // teamPlayerIdDataGridViewTextBoxColumn1
            // 
            this.teamPlayerIdDataGridViewTextBoxColumn1.DataPropertyName = "TeamPlayerId";
            this.teamPlayerIdDataGridViewTextBoxColumn1.HeaderText = "TeamPlayerId";
            this.teamPlayerIdDataGridViewTextBoxColumn1.Name = "teamPlayerIdDataGridViewTextBoxColumn1";
            this.teamPlayerIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.teamPlayerIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn1
            // 
            this.numberDataGridViewTextBoxColumn1.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn1.HeaderText = "Broj";
            this.numberDataGridViewTextBoxColumn1.Name = "numberDataGridViewTextBoxColumn1";
            this.numberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn1.Width = 27;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // goalsDataGridViewTextBoxColumn1
            // 
            this.goalsDataGridViewTextBoxColumn1.DataPropertyName = "Goals";
            this.goalsDataGridViewTextBoxColumn1.HeaderText = "G";
            this.goalsDataGridViewTextBoxColumn1.Name = "goalsDataGridViewTextBoxColumn1";
            this.goalsDataGridViewTextBoxColumn1.ReadOnly = true;
            this.goalsDataGridViewTextBoxColumn1.Width = 28;
            // 
            // goals7mDataGridViewTextBoxColumn1
            // 
            this.goals7mDataGridViewTextBoxColumn1.DataPropertyName = "Goals7m";
            this.goals7mDataGridViewTextBoxColumn1.HeaderText = "Goals7m";
            this.goals7mDataGridViewTextBoxColumn1.Name = "goals7mDataGridViewTextBoxColumn1";
            this.goals7mDataGridViewTextBoxColumn1.ReadOnly = true;
            this.goals7mDataGridViewTextBoxColumn1.Visible = false;
            // 
            // warningDataGridViewTextBoxColumn1
            // 
            this.warningDataGridViewTextBoxColumn1.DataPropertyName = "Warning";
            this.warningDataGridViewTextBoxColumn1.HeaderText = "O";
            this.warningDataGridViewTextBoxColumn1.Name = "warningDataGridViewTextBoxColumn1";
            this.warningDataGridViewTextBoxColumn1.ReadOnly = true;
            this.warningDataGridViewTextBoxColumn1.Width = 28;
            // 
            // suspension1stDataGridViewTextBoxColumn1
            // 
            this.suspension1stDataGridViewTextBoxColumn1.DataPropertyName = "Suspension1st";
            this.suspension1stDataGridViewTextBoxColumn1.HeaderText = "2\'";
            this.suspension1stDataGridViewTextBoxColumn1.Name = "suspension1stDataGridViewTextBoxColumn1";
            this.suspension1stDataGridViewTextBoxColumn1.ReadOnly = true;
            this.suspension1stDataGridViewTextBoxColumn1.Width = 28;
            // 
            // suspension2ndDataGridViewTextBoxColumn1
            // 
            this.suspension2ndDataGridViewTextBoxColumn1.DataPropertyName = "Suspension2nd";
            this.suspension2ndDataGridViewTextBoxColumn1.HeaderText = "2\'";
            this.suspension2ndDataGridViewTextBoxColumn1.Name = "suspension2ndDataGridViewTextBoxColumn1";
            this.suspension2ndDataGridViewTextBoxColumn1.ReadOnly = true;
            this.suspension2ndDataGridViewTextBoxColumn1.Width = 28;
            // 
            // suspension3rdDataGridViewTextBoxColumn1
            // 
            this.suspension3rdDataGridViewTextBoxColumn1.DataPropertyName = "Suspension3rd";
            this.suspension3rdDataGridViewTextBoxColumn1.HeaderText = "2\'";
            this.suspension3rdDataGridViewTextBoxColumn1.Name = "suspension3rdDataGridViewTextBoxColumn1";
            this.suspension3rdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.suspension3rdDataGridViewTextBoxColumn1.Width = 28;
            // 
            // disqualificationDataGridViewTextBoxColumn1
            // 
            this.disqualificationDataGridViewTextBoxColumn1.DataPropertyName = "Disqualification";
            this.disqualificationDataGridViewTextBoxColumn1.HeaderText = "D";
            this.disqualificationDataGridViewTextBoxColumn1.Name = "disqualificationDataGridViewTextBoxColumn1";
            this.disqualificationDataGridViewTextBoxColumn1.ReadOnly = true;
            this.disqualificationDataGridViewTextBoxColumn1.Width = 28;
            // 
            // disqualificationReportDataGridViewTextBoxColumn1
            // 
            this.disqualificationReportDataGridViewTextBoxColumn1.DataPropertyName = "DisqualificationReport";
            this.disqualificationReportDataGridViewTextBoxColumn1.HeaderText = "DP";
            this.disqualificationReportDataGridViewTextBoxColumn1.Name = "disqualificationReportDataGridViewTextBoxColumn1";
            this.disqualificationReportDataGridViewTextBoxColumn1.ReadOnly = true;
            this.disqualificationReportDataGridViewTextBoxColumn1.Width = 28;
            // 
            // teamPlayerBindingSource
            // 
            this.teamPlayerBindingSource.DataSource = typeof(MatchReporter.Classes.TeamPlayer);
            // 
            // btnHomeUndo
            // 
            this.btnHomeUndo.Location = new System.Drawing.Point(384, 443);
            this.btnHomeUndo.Name = "btnHomeUndo";
            this.btnHomeUndo.Size = new System.Drawing.Size(53, 40);
            this.btnHomeUndo.TabIndex = 30;
            this.btnHomeUndo.Text = "Poništi";
            this.btnHomeUndo.UseVisualStyleBackColor = true;
            // 
            // dgvHomeTeam
            // 
            this.dgvHomeTeam.AllowUserToAddRows = false;
            this.dgvHomeTeam.AllowUserToDeleteRows = false;
            this.dgvHomeTeam.AutoGenerateColumns = false;
            this.dgvHomeTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamPlayerIdDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.goalsDataGridViewTextBoxColumn,
            this.goals7mDataGridViewTextBoxColumn,
            this.warningDataGridViewTextBoxColumn,
            this.suspension1stDataGridViewTextBoxColumn,
            this.suspension2ndDataGridViewTextBoxColumn,
            this.suspension3rdDataGridViewTextBoxColumn,
            this.disqualificationDataGridViewTextBoxColumn,
            this.disqualificationReportDataGridViewTextBoxColumn});
            this.dgvHomeTeam.DataSource = this.teamPlayerBindingSource;
            this.dgvHomeTeam.Location = new System.Drawing.Point(12, 108);
            this.dgvHomeTeam.MultiSelect = false;
            this.dgvHomeTeam.Name = "dgvHomeTeam";
            this.dgvHomeTeam.ReadOnly = true;
            this.dgvHomeTeam.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHomeTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHomeTeam.Size = new System.Drawing.Size(366, 375);
            this.dgvHomeTeam.TabIndex = 29;
            // 
            // teamPlayerIdDataGridViewTextBoxColumn
            // 
            this.teamPlayerIdDataGridViewTextBoxColumn.DataPropertyName = "TeamPlayerId";
            this.teamPlayerIdDataGridViewTextBoxColumn.HeaderText = "TeamPlayerId";
            this.teamPlayerIdDataGridViewTextBoxColumn.Name = "teamPlayerIdDataGridViewTextBoxColumn";
            this.teamPlayerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamPlayerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Broj";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 27;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goalsDataGridViewTextBoxColumn
            // 
            this.goalsDataGridViewTextBoxColumn.DataPropertyName = "Goals";
            this.goalsDataGridViewTextBoxColumn.HeaderText = "G";
            this.goalsDataGridViewTextBoxColumn.Name = "goalsDataGridViewTextBoxColumn";
            this.goalsDataGridViewTextBoxColumn.ReadOnly = true;
            this.goalsDataGridViewTextBoxColumn.Width = 28;
            // 
            // goals7mDataGridViewTextBoxColumn
            // 
            this.goals7mDataGridViewTextBoxColumn.DataPropertyName = "Goals7m";
            this.goals7mDataGridViewTextBoxColumn.HeaderText = "Goals7m";
            this.goals7mDataGridViewTextBoxColumn.Name = "goals7mDataGridViewTextBoxColumn";
            this.goals7mDataGridViewTextBoxColumn.ReadOnly = true;
            this.goals7mDataGridViewTextBoxColumn.Visible = false;
            // 
            // warningDataGridViewTextBoxColumn
            // 
            this.warningDataGridViewTextBoxColumn.DataPropertyName = "Warning";
            this.warningDataGridViewTextBoxColumn.HeaderText = "O";
            this.warningDataGridViewTextBoxColumn.Name = "warningDataGridViewTextBoxColumn";
            this.warningDataGridViewTextBoxColumn.ReadOnly = true;
            this.warningDataGridViewTextBoxColumn.Width = 28;
            // 
            // suspension1stDataGridViewTextBoxColumn
            // 
            this.suspension1stDataGridViewTextBoxColumn.DataPropertyName = "Suspension1st";
            this.suspension1stDataGridViewTextBoxColumn.HeaderText = "2\'";
            this.suspension1stDataGridViewTextBoxColumn.Name = "suspension1stDataGridViewTextBoxColumn";
            this.suspension1stDataGridViewTextBoxColumn.ReadOnly = true;
            this.suspension1stDataGridViewTextBoxColumn.Width = 28;
            // 
            // suspension2ndDataGridViewTextBoxColumn
            // 
            this.suspension2ndDataGridViewTextBoxColumn.DataPropertyName = "Suspension2nd";
            this.suspension2ndDataGridViewTextBoxColumn.HeaderText = "2\'";
            this.suspension2ndDataGridViewTextBoxColumn.Name = "suspension2ndDataGridViewTextBoxColumn";
            this.suspension2ndDataGridViewTextBoxColumn.ReadOnly = true;
            this.suspension2ndDataGridViewTextBoxColumn.Width = 28;
            // 
            // suspension3rdDataGridViewTextBoxColumn
            // 
            this.suspension3rdDataGridViewTextBoxColumn.DataPropertyName = "Suspension3rd";
            this.suspension3rdDataGridViewTextBoxColumn.HeaderText = "2\'";
            this.suspension3rdDataGridViewTextBoxColumn.Name = "suspension3rdDataGridViewTextBoxColumn";
            this.suspension3rdDataGridViewTextBoxColumn.ReadOnly = true;
            this.suspension3rdDataGridViewTextBoxColumn.Width = 28;
            // 
            // disqualificationDataGridViewTextBoxColumn
            // 
            this.disqualificationDataGridViewTextBoxColumn.DataPropertyName = "Disqualification";
            this.disqualificationDataGridViewTextBoxColumn.HeaderText = "D";
            this.disqualificationDataGridViewTextBoxColumn.Name = "disqualificationDataGridViewTextBoxColumn";
            this.disqualificationDataGridViewTextBoxColumn.ReadOnly = true;
            this.disqualificationDataGridViewTextBoxColumn.Width = 28;
            // 
            // disqualificationReportDataGridViewTextBoxColumn
            // 
            this.disqualificationReportDataGridViewTextBoxColumn.DataPropertyName = "DisqualificationReport";
            this.disqualificationReportDataGridViewTextBoxColumn.HeaderText = "DP";
            this.disqualificationReportDataGridViewTextBoxColumn.Name = "disqualificationReportDataGridViewTextBoxColumn";
            this.disqualificationReportDataGridViewTextBoxColumn.ReadOnly = true;
            this.disqualificationReportDataGridViewTextBoxColumn.Width = 28;
            // 
            // btnHomeDisqualificationReport
            // 
            this.btnHomeDisqualificationReport.Location = new System.Drawing.Point(384, 378);
            this.btnHomeDisqualificationReport.Name = "btnHomeDisqualificationReport";
            this.btnHomeDisqualificationReport.Size = new System.Drawing.Size(53, 40);
            this.btnHomeDisqualificationReport.TabIndex = 28;
            this.btnHomeDisqualificationReport.Text = "DP";
            this.btnHomeDisqualificationReport.UseVisualStyleBackColor = true;
            // 
            // btnHomeDisqualification
            // 
            this.btnHomeDisqualification.Location = new System.Drawing.Point(384, 332);
            this.btnHomeDisqualification.Name = "btnHomeDisqualification";
            this.btnHomeDisqualification.Size = new System.Drawing.Size(53, 40);
            this.btnHomeDisqualification.TabIndex = 27;
            this.btnHomeDisqualification.Text = "D";
            this.btnHomeDisqualification.UseVisualStyleBackColor = true;
            // 
            // btnHomeSuspension
            // 
            this.btnHomeSuspension.Location = new System.Drawing.Point(384, 286);
            this.btnHomeSuspension.Name = "btnHomeSuspension";
            this.btnHomeSuspension.Size = new System.Drawing.Size(53, 40);
            this.btnHomeSuspension.TabIndex = 26;
            this.btnHomeSuspension.Text = "2\'";
            this.btnHomeSuspension.UseVisualStyleBackColor = true;
            // 
            // btnHomeWarning
            // 
            this.btnHomeWarning.Location = new System.Drawing.Point(384, 240);
            this.btnHomeWarning.Name = "btnHomeWarning";
            this.btnHomeWarning.Size = new System.Drawing.Size(53, 40);
            this.btnHomeWarning.TabIndex = 25;
            this.btnHomeWarning.Text = "O";
            this.btnHomeWarning.UseVisualStyleBackColor = true;
            // 
            // btnHome7m
            // 
            this.btnHome7m.Location = new System.Drawing.Point(384, 175);
            this.btnHome7m.Name = "btnHome7m";
            this.btnHome7m.Size = new System.Drawing.Size(53, 40);
            this.btnHome7m.TabIndex = 24;
            this.btnHome7m.Text = "7m";
            this.btnHome7m.UseVisualStyleBackColor = true;
            // 
            // btnHomeGoal
            // 
            this.btnHomeGoal.Location = new System.Drawing.Point(384, 129);
            this.btnHomeGoal.Name = "btnHomeGoal";
            this.btnHomeGoal.Size = new System.Drawing.Size(53, 40);
            this.btnHomeGoal.TabIndex = 23;
            this.btnHomeGoal.Text = "G";
            this.btnHomeGoal.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.AutoSize = true;
            this.panelTop.Controls.Add(this.lblTimeSeconds);
            this.panelTop.Controls.Add(this.lblTimeMinutes);
            this.panelTop.Controls.Add(this.btnTimeReset);
            this.panelTop.Controls.Add(this.btnTimeChange);
            this.panelTop.Controls.Add(this.btnTimeStop);
            this.panelTop.Controls.Add(this.btnTimeStart);
            this.panelTop.Controls.Add(this.txtTeamBTTO3);
            this.panelTop.Controls.Add(this.txtTeamBTTO2);
            this.panelTop.Controls.Add(this.txtTeamBTTO1);
            this.panelTop.Controls.Add(this.txtTeamATTO3);
            this.panelTop.Controls.Add(this.txtTeamATTO2);
            this.panelTop.Controls.Add(this.txtTeamATTO1);
            this.panelTop.Controls.Add(this.btnTeamBTTO3);
            this.panelTop.Controls.Add(this.btnTeamBTTO2);
            this.panelTop.Controls.Add(this.btnTeamBTTO1);
            this.panelTop.Controls.Add(this.btnTeamATTO3);
            this.panelTop.Controls.Add(this.btnTeamATTO2);
            this.panelTop.Controls.Add(this.btnTeamATTO1);
            this.panelTop.Controls.Add(this.lblResultB);
            this.panelTop.Controls.Add(this.lblResultA);
            this.panelTop.Controls.Add(this.lblTeamB);
            this.panelTop.Controls.Add(this.lblTeamA);
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(878, 100);
            this.panelTop.TabIndex = 0;
            // 
            // lblTimeSeconds
            // 
            this.lblTimeSeconds.AutoSize = true;
            this.lblTimeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimeSeconds.Location = new System.Drawing.Point(444, 56);
            this.lblTimeSeconds.Name = "lblTimeSeconds";
            this.lblTimeSeconds.Size = new System.Drawing.Size(36, 25);
            this.lblTimeSeconds.TabIndex = 21;
            this.lblTimeSeconds.Text = "00";
            // 
            // lblTimeMinutes
            // 
            this.lblTimeMinutes.AutoSize = true;
            this.lblTimeMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimeMinutes.Location = new System.Drawing.Point(398, 56);
            this.lblTimeMinutes.Name = "lblTimeMinutes";
            this.lblTimeMinutes.Size = new System.Drawing.Size(36, 25);
            this.lblTimeMinutes.TabIndex = 20;
            this.lblTimeMinutes.Text = "00";
            // 
            // btnTimeReset
            // 
            this.btnTimeReset.Location = new System.Drawing.Point(503, 73);
            this.btnTimeReset.Name = "btnTimeReset";
            this.btnTimeReset.Size = new System.Drawing.Size(87, 23);
            this.btnTimeReset.TabIndex = 19;
            this.btnTimeReset.Text = "Resetiraj";
            this.btnTimeReset.UseVisualStyleBackColor = true;
            this.btnTimeReset.Click += new System.EventHandler(this.btnTimeReset_Click);
            // 
            // btnTimeChange
            // 
            this.btnTimeChange.Location = new System.Drawing.Point(503, 46);
            this.btnTimeChange.Name = "btnTimeChange";
            this.btnTimeChange.Size = new System.Drawing.Size(87, 23);
            this.btnTimeChange.TabIndex = 18;
            this.btnTimeChange.Text = "Promijeni";
            this.btnTimeChange.UseVisualStyleBackColor = true;
            this.btnTimeChange.Click += new System.EventHandler(this.btnTimeChange_Click);
            // 
            // btnTimeStop
            // 
            this.btnTimeStop.Location = new System.Drawing.Point(288, 74);
            this.btnTimeStop.Name = "btnTimeStop";
            this.btnTimeStop.Size = new System.Drawing.Size(85, 23);
            this.btnTimeStop.TabIndex = 17;
            this.btnTimeStop.Text = "Stop";
            this.btnTimeStop.UseVisualStyleBackColor = true;
            this.btnTimeStop.Click += new System.EventHandler(this.btnTimeStop_Click);
            // 
            // btnTimeStart
            // 
            this.btnTimeStart.Location = new System.Drawing.Point(288, 46);
            this.btnTimeStart.Name = "btnTimeStart";
            this.btnTimeStart.Size = new System.Drawing.Size(87, 23);
            this.btnTimeStart.TabIndex = 16;
            this.btnTimeStart.Text = "Start";
            this.btnTimeStart.UseVisualStyleBackColor = true;
            this.btnTimeStart.Click += new System.EventHandler(this.btnTimeStart_Click);
            // 
            // txtTeamBTTO3
            // 
            this.txtTeamBTTO3.Location = new System.Drawing.Point(782, 75);
            this.txtTeamBTTO3.Name = "txtTeamBTTO3";
            this.txtTeamBTTO3.ReadOnly = true;
            this.txtTeamBTTO3.Size = new System.Drawing.Size(87, 20);
            this.txtTeamBTTO3.TabIndex = 15;
            this.txtTeamBTTO3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTeamBTTO2
            // 
            this.txtTeamBTTO2.Location = new System.Drawing.Point(689, 75);
            this.txtTeamBTTO2.Name = "txtTeamBTTO2";
            this.txtTeamBTTO2.ReadOnly = true;
            this.txtTeamBTTO2.Size = new System.Drawing.Size(87, 20);
            this.txtTeamBTTO2.TabIndex = 14;
            this.txtTeamBTTO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTeamBTTO1
            // 
            this.txtTeamBTTO1.Location = new System.Drawing.Point(596, 75);
            this.txtTeamBTTO1.Name = "txtTeamBTTO1";
            this.txtTeamBTTO1.ReadOnly = true;
            this.txtTeamBTTO1.Size = new System.Drawing.Size(87, 20);
            this.txtTeamBTTO1.TabIndex = 13;
            this.txtTeamBTTO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTeamATTO3
            // 
            this.txtTeamATTO3.Location = new System.Drawing.Point(195, 76);
            this.txtTeamATTO3.Name = "txtTeamATTO3";
            this.txtTeamATTO3.ReadOnly = true;
            this.txtTeamATTO3.Size = new System.Drawing.Size(87, 20);
            this.txtTeamATTO3.TabIndex = 12;
            this.txtTeamATTO3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTeamATTO2
            // 
            this.txtTeamATTO2.Location = new System.Drawing.Point(102, 75);
            this.txtTeamATTO2.Name = "txtTeamATTO2";
            this.txtTeamATTO2.ReadOnly = true;
            this.txtTeamATTO2.Size = new System.Drawing.Size(87, 20);
            this.txtTeamATTO2.TabIndex = 11;
            this.txtTeamATTO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTeamATTO1
            // 
            this.txtTeamATTO1.Location = new System.Drawing.Point(9, 75);
            this.txtTeamATTO1.Name = "txtTeamATTO1";
            this.txtTeamATTO1.ReadOnly = true;
            this.txtTeamATTO1.Size = new System.Drawing.Size(87, 20);
            this.txtTeamATTO1.TabIndex = 10;
            this.txtTeamATTO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTeamBTTO3
            // 
            this.btnTeamBTTO3.Location = new System.Drawing.Point(782, 46);
            this.btnTeamBTTO3.Name = "btnTeamBTTO3";
            this.btnTeamBTTO3.Size = new System.Drawing.Size(87, 23);
            this.btnTeamBTTO3.TabIndex = 9;
            this.btnTeamBTTO3.Text = "Time out [3]";
            this.btnTeamBTTO3.UseVisualStyleBackColor = true;
            // 
            // btnTeamBTTO2
            // 
            this.btnTeamBTTO2.Location = new System.Drawing.Point(689, 46);
            this.btnTeamBTTO2.Name = "btnTeamBTTO2";
            this.btnTeamBTTO2.Size = new System.Drawing.Size(87, 23);
            this.btnTeamBTTO2.TabIndex = 8;
            this.btnTeamBTTO2.Text = "Time out [2]";
            this.btnTeamBTTO2.UseVisualStyleBackColor = true;
            // 
            // btnTeamBTTO1
            // 
            this.btnTeamBTTO1.Location = new System.Drawing.Point(596, 46);
            this.btnTeamBTTO1.Name = "btnTeamBTTO1";
            this.btnTeamBTTO1.Size = new System.Drawing.Size(87, 23);
            this.btnTeamBTTO1.TabIndex = 7;
            this.btnTeamBTTO1.Text = "Time out [1]";
            this.btnTeamBTTO1.UseVisualStyleBackColor = true;
            // 
            // btnTeamATTO3
            // 
            this.btnTeamATTO3.Location = new System.Drawing.Point(195, 46);
            this.btnTeamATTO3.Name = "btnTeamATTO3";
            this.btnTeamATTO3.Size = new System.Drawing.Size(87, 23);
            this.btnTeamATTO3.TabIndex = 6;
            this.btnTeamATTO3.Text = "Time out [3]";
            this.btnTeamATTO3.UseVisualStyleBackColor = true;
            // 
            // btnTeamATTO2
            // 
            this.btnTeamATTO2.Location = new System.Drawing.Point(102, 46);
            this.btnTeamATTO2.Name = "btnTeamATTO2";
            this.btnTeamATTO2.Size = new System.Drawing.Size(87, 23);
            this.btnTeamATTO2.TabIndex = 5;
            this.btnTeamATTO2.Text = "Time out [2]";
            this.btnTeamATTO2.UseVisualStyleBackColor = true;
            // 
            // btnTeamATTO1
            // 
            this.btnTeamATTO1.Location = new System.Drawing.Point(9, 46);
            this.btnTeamATTO1.Name = "btnTeamATTO1";
            this.btnTeamATTO1.Size = new System.Drawing.Size(87, 23);
            this.btnTeamATTO1.TabIndex = 4;
            this.btnTeamATTO1.Text = "Time out [1]";
            this.btnTeamATTO1.UseVisualStyleBackColor = true;
            // 
            // lblResultB
            // 
            this.lblResultB.AutoSize = true;
            this.lblResultB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResultB.Location = new System.Drawing.Point(496, 5);
            this.lblResultB.Name = "lblResultB";
            this.lblResultB.Size = new System.Drawing.Size(24, 25);
            this.lblResultB.TabIndex = 3;
            this.lblResultB.Text = "0";
            // 
            // lblResultA
            // 
            this.lblResultA.AutoSize = true;
            this.lblResultA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResultA.Location = new System.Drawing.Point(353, 5);
            this.lblResultA.Name = "lblResultA";
            this.lblResultA.Size = new System.Drawing.Size(24, 25);
            this.lblResultA.TabIndex = 2;
            this.lblResultA.Text = "0";
            // 
            // lblTeamB
            // 
            this.lblTeamB.AutoSize = true;
            this.lblTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTeamB.Location = new System.Drawing.Point(591, 5);
            this.lblTeamB.Name = "lblTeamB";
            this.lblTeamB.Size = new System.Drawing.Size(86, 25);
            this.lblTeamB.TabIndex = 1;
            this.lblTeamB.Text = "Team B";
            // 
            // lblTeamA
            // 
            this.lblTeamA.AutoSize = true;
            this.lblTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTeamA.Location = new System.Drawing.Point(97, 5);
            this.lblTeamA.Name = "lblTeamA";
            this.lblTeamA.Size = new System.Drawing.Size(86, 25);
            this.lblTeamA.TabIndex = 0;
            this.lblTeamA.Text = "Team A";
            // 
            // timerMatch
            // 
            this.timerMatch.Interval = 10;
            this.timerMatch.Tick += new System.EventHandler(this.timerMatch_Tick);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(MatchReporter.Player);
            // 
            // btnGuestGoal
            // 
            this.btnGuestGoal.Location = new System.Drawing.Point(447, 129);
            this.btnGuestGoal.Name = "btnGuestGoal";
            this.btnGuestGoal.Size = new System.Drawing.Size(53, 40);
            this.btnGuestGoal.TabIndex = 34;
            this.btnGuestGoal.Text = "G";
            this.btnGuestGoal.UseVisualStyleBackColor = true;
            // 
            // btnGuest7m
            // 
            this.btnGuest7m.Location = new System.Drawing.Point(447, 175);
            this.btnGuest7m.Name = "btnGuest7m";
            this.btnGuest7m.Size = new System.Drawing.Size(53, 40);
            this.btnGuest7m.TabIndex = 35;
            this.btnGuest7m.Text = "7m";
            this.btnGuest7m.UseVisualStyleBackColor = true;
            // 
            // btnGuestUndo
            // 
            this.btnGuestUndo.Location = new System.Drawing.Point(447, 443);
            this.btnGuestUndo.Name = "btnGuestUndo";
            this.btnGuestUndo.Size = new System.Drawing.Size(53, 40);
            this.btnGuestUndo.TabIndex = 40;
            this.btnGuestUndo.Text = "Poništi";
            this.btnGuestUndo.UseVisualStyleBackColor = true;
            // 
            // btnGuestDisqualificationReport
            // 
            this.btnGuestDisqualificationReport.Location = new System.Drawing.Point(447, 378);
            this.btnGuestDisqualificationReport.Name = "btnGuestDisqualificationReport";
            this.btnGuestDisqualificationReport.Size = new System.Drawing.Size(53, 40);
            this.btnGuestDisqualificationReport.TabIndex = 39;
            this.btnGuestDisqualificationReport.Text = "DP";
            this.btnGuestDisqualificationReport.UseVisualStyleBackColor = true;
            // 
            // btnGuestDisqualification
            // 
            this.btnGuestDisqualification.Location = new System.Drawing.Point(447, 332);
            this.btnGuestDisqualification.Name = "btnGuestDisqualification";
            this.btnGuestDisqualification.Size = new System.Drawing.Size(53, 40);
            this.btnGuestDisqualification.TabIndex = 38;
            this.btnGuestDisqualification.Text = "D";
            this.btnGuestDisqualification.UseVisualStyleBackColor = true;
            // 
            // btnGuestSuspension
            // 
            this.btnGuestSuspension.Location = new System.Drawing.Point(447, 286);
            this.btnGuestSuspension.Name = "btnGuestSuspension";
            this.btnGuestSuspension.Size = new System.Drawing.Size(53, 40);
            this.btnGuestSuspension.TabIndex = 37;
            this.btnGuestSuspension.Text = "2\'";
            this.btnGuestSuspension.UseVisualStyleBackColor = true;
            // 
            // btnGuestWarning
            // 
            this.btnGuestWarning.Location = new System.Drawing.Point(447, 240);
            this.btnGuestWarning.Name = "btnGuestWarning";
            this.btnGuestWarning.Size = new System.Drawing.Size(53, 40);
            this.btnGuestWarning.TabIndex = 36;
            this.btnGuestWarning.Text = "O";
            this.btnGuestWarning.UseVisualStyleBackColor = true;
            // 
            // btnHomeOfficialDisqualification
            // 
            this.btnHomeOfficialDisqualification.Location = new System.Drawing.Point(384, 574);
            this.btnHomeOfficialDisqualification.Name = "btnHomeOfficialDisqualification";
            this.btnHomeOfficialDisqualification.Size = new System.Drawing.Size(53, 26);
            this.btnHomeOfficialDisqualification.TabIndex = 43;
            this.btnHomeOfficialDisqualification.Text = "D";
            this.btnHomeOfficialDisqualification.UseVisualStyleBackColor = true;
            // 
            // btnHomeOfficialSuspension
            // 
            this.btnHomeOfficialSuspension.Location = new System.Drawing.Point(384, 542);
            this.btnHomeOfficialSuspension.Name = "btnHomeOfficialSuspension";
            this.btnHomeOfficialSuspension.Size = new System.Drawing.Size(53, 26);
            this.btnHomeOfficialSuspension.TabIndex = 42;
            this.btnHomeOfficialSuspension.Text = "2\'";
            this.btnHomeOfficialSuspension.UseVisualStyleBackColor = true;
            // 
            // btnHomeOfficialWarning
            // 
            this.btnHomeOfficialWarning.Location = new System.Drawing.Point(384, 510);
            this.btnHomeOfficialWarning.Name = "btnHomeOfficialWarning";
            this.btnHomeOfficialWarning.Size = new System.Drawing.Size(53, 26);
            this.btnHomeOfficialWarning.TabIndex = 41;
            this.btnHomeOfficialWarning.Text = "O";
            this.btnHomeOfficialWarning.UseVisualStyleBackColor = true;
            // 
            // btnGuestOfficialDisqualification
            // 
            this.btnGuestOfficialDisqualification.Location = new System.Drawing.Point(447, 574);
            this.btnGuestOfficialDisqualification.Name = "btnGuestOfficialDisqualification";
            this.btnGuestOfficialDisqualification.Size = new System.Drawing.Size(53, 26);
            this.btnGuestOfficialDisqualification.TabIndex = 46;
            this.btnGuestOfficialDisqualification.Text = "D";
            this.btnGuestOfficialDisqualification.UseVisualStyleBackColor = true;
            // 
            // btnGuestOfficialSuspension
            // 
            this.btnGuestOfficialSuspension.Location = new System.Drawing.Point(447, 542);
            this.btnGuestOfficialSuspension.Name = "btnGuestOfficialSuspension";
            this.btnGuestOfficialSuspension.Size = new System.Drawing.Size(53, 26);
            this.btnGuestOfficialSuspension.TabIndex = 45;
            this.btnGuestOfficialSuspension.Text = "2\'";
            this.btnGuestOfficialSuspension.UseVisualStyleBackColor = true;
            // 
            // btnGuestOfficialWarning
            // 
            this.btnGuestOfficialWarning.Location = new System.Drawing.Point(447, 510);
            this.btnGuestOfficialWarning.Name = "btnGuestOfficialWarning";
            this.btnGuestOfficialWarning.Size = new System.Drawing.Size(53, 26);
            this.btnGuestOfficialWarning.TabIndex = 44;
            this.btnGuestOfficialWarning.Text = "O";
            this.btnGuestOfficialWarning.UseVisualStyleBackColor = true;
            // 
            // FrmMatchReporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuMainMenu);
            this.MainMenuStrip = this.menuMainMenu;
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "FrmMatchReporter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match Reporter";
            this.Load += new System.EventHandler(this.FrmMatchReporter_Load);
            this.menuMainMenu.ResumeLayout(false);
            this.menuMainMenu.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestOfficials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamOfficialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeOfficials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamPlayerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeTeam)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchConcludeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportPrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportSendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherAboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTeamB;
        private System.Windows.Forms.Label lblTeamA;
        private System.Windows.Forms.Label lblTimeSeconds;
        private System.Windows.Forms.Label lblTimeMinutes;
        private System.Windows.Forms.Button btnTimeReset;
        private System.Windows.Forms.Button btnTimeChange;
        private System.Windows.Forms.Button btnTimeStop;
        private System.Windows.Forms.Button btnTimeStart;
        private System.Windows.Forms.TextBox txtTeamBTTO3;
        private System.Windows.Forms.TextBox txtTeamBTTO2;
        private System.Windows.Forms.TextBox txtTeamBTTO1;
        private System.Windows.Forms.TextBox txtTeamATTO3;
        private System.Windows.Forms.TextBox txtTeamATTO2;
        private System.Windows.Forms.TextBox txtTeamATTO1;
        private System.Windows.Forms.Button btnTeamBTTO3;
        private System.Windows.Forms.Button btnTeamBTTO2;
        private System.Windows.Forms.Button btnTeamBTTO1;
        private System.Windows.Forms.Button btnTeamATTO3;
        private System.Windows.Forms.Button btnTeamATTO2;
        private System.Windows.Forms.Button btnTeamATTO1;
        private System.Windows.Forms.Label lblResultB;
        private System.Windows.Forms.Label lblResultA;
        private System.Windows.Forms.Timer timerMatch;
        private System.Windows.Forms.Button btnHomeDisqualificationReport;
        private System.Windows.Forms.Button btnHomeDisqualification;
        private System.Windows.Forms.Button btnHomeSuspension;
        private System.Windows.Forms.Button btnHomeWarning;
        private System.Windows.Forms.Button btnHome7m;
        private System.Windows.Forms.Button btnHomeGoal;
        private System.Windows.Forms.ToolStripMenuItem matchCloseToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvHomeTeam;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.BindingSource teamPlayerBindingSource;
        private System.Windows.Forms.Button btnHomeUndo;
        private System.Windows.Forms.DataGridView dgvGuestTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamPlayerIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goals7mDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn warningDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspension1stDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspension2ndDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspension3rdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualificationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualificationReportDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamPlayerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goals7mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspension1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspension2ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspension3rdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualificationReportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvGuestOfficials;
        private System.Windows.Forms.DataGridView dgvHomeOfficials;
        private System.Windows.Forms.BindingSource teamOfficialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamOfficialIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn warningDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualificationDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamOfficialIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn warningDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspensionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualificationDataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripMenuItem dataMatchDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataOfficialsToolStripMenuItem;
        private System.Windows.Forms.Button btnGuestUndo;
        private System.Windows.Forms.Button btnGuestDisqualificationReport;
        private System.Windows.Forms.Button btnGuestDisqualification;
        private System.Windows.Forms.Button btnGuestSuspension;
        private System.Windows.Forms.Button btnGuestWarning;
        private System.Windows.Forms.Button btnGuest7m;
        private System.Windows.Forms.Button btnGuestGoal;
        private System.Windows.Forms.Button btnGuestOfficialDisqualification;
        private System.Windows.Forms.Button btnGuestOfficialSuspension;
        private System.Windows.Forms.Button btnGuestOfficialWarning;
        private System.Windows.Forms.Button btnHomeOfficialDisqualification;
        private System.Windows.Forms.Button btnHomeOfficialSuspension;
        private System.Windows.Forms.Button btnHomeOfficialWarning;
    }
}