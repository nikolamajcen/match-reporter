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
            this.utakmicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaključiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosPodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosIgračaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosSlužbenihOsobaMomčadiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaPodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaMomčadiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaIgračaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaSlužbenihOsobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjePodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeMomčadiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeIgračaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeSlužbenihOsobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ispisIzvještajaUtakmiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slanjeRezultataUtakmiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikcijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnDisqualificationReport = new System.Windows.Forms.Button();
            this.btnDisqualification = new System.Windows.Forms.Button();
            this.btnSuspension = new System.Windows.Forms.Button();
            this.btnWarning = new System.Windows.Forms.Button();
            this.btn7mGoal = new System.Windows.Forms.Button();
            this.btnGoal = new System.Windows.Forms.Button();
            this.dgvTeamB = new System.Windows.Forms.DataGridView();
            this.dgvTeamA = new System.Windows.Forms.DataGridView();
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
            this.menuMainMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamA)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainMenu
            // 
            this.menuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utakmicaToolStripMenuItem,
            this.podaciToolStripMenuItem,
            this.izvještajToolStripMenuItem,
            this.oAplikacijiToolStripMenuItem});
            this.menuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuMainMenu.Name = "menuMainMenu";
            this.menuMainMenu.Size = new System.Drawing.Size(884, 24);
            this.menuMainMenu.TabIndex = 0;
            this.menuMainMenu.Text = "menuStrip1";
            // 
            // utakmicaToolStripMenuItem
            // 
            this.utakmicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaToolStripMenuItem,
            this.otvoriToolStripMenuItem,
            this.spremiToolStripMenuItem,
            this.zaključiToolStripMenuItem});
            this.utakmicaToolStripMenuItem.Name = "utakmicaToolStripMenuItem";
            this.utakmicaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utakmicaToolStripMenuItem.Text = "Utakmica";
            // 
            // novaToolStripMenuItem
            // 
            this.novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            this.novaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.novaToolStripMenuItem.Text = "Nova...";
            // 
            // otvoriToolStripMenuItem
            // 
            this.otvoriToolStripMenuItem.Name = "otvoriToolStripMenuItem";
            this.otvoriToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.otvoriToolStripMenuItem.Text = "Otvori...";
            // 
            // spremiToolStripMenuItem
            // 
            this.spremiToolStripMenuItem.Name = "spremiToolStripMenuItem";
            this.spremiToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.spremiToolStripMenuItem.Text = "Spremi...";
            // 
            // zaključiToolStripMenuItem
            // 
            this.zaključiToolStripMenuItem.Name = "zaključiToolStripMenuItem";
            this.zaključiToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.zaključiToolStripMenuItem.Text = "Zaključi...";
            // 
            // podaciToolStripMenuItem
            // 
            this.podaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosPodatakaToolStripMenuItem,
            this.promjenaPodatakaToolStripMenuItem,
            this.brisanjePodatakaToolStripMenuItem});
            this.podaciToolStripMenuItem.Name = "podaciToolStripMenuItem";
            this.podaciToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.podaciToolStripMenuItem.Text = "Podaci";
            // 
            // unosPodatakaToolStripMenuItem
            // 
            this.unosPodatakaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.unosIgračaToolStripMenuItem,
            this.unosSlužbenihOsobaMomčadiToolStripMenuItem});
            this.unosPodatakaToolStripMenuItem.Name = "unosPodatakaToolStripMenuItem";
            this.unosPodatakaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.unosPodatakaToolStripMenuItem.Text = "Unos...";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.unosToolStripMenuItem.Text = "Unos momčadi";
            // 
            // unosIgračaToolStripMenuItem
            // 
            this.unosIgračaToolStripMenuItem.Name = "unosIgračaToolStripMenuItem";
            this.unosIgračaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.unosIgračaToolStripMenuItem.Text = "Unos igrača";
            // 
            // unosSlužbenihOsobaMomčadiToolStripMenuItem
            // 
            this.unosSlužbenihOsobaMomčadiToolStripMenuItem.Name = "unosSlužbenihOsobaMomčadiToolStripMenuItem";
            this.unosSlužbenihOsobaMomčadiToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.unosSlužbenihOsobaMomčadiToolStripMenuItem.Text = "Unos službenih osoba";
            // 
            // promjenaPodatakaToolStripMenuItem
            // 
            this.promjenaPodatakaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promjenaMomčadiToolStripMenuItem,
            this.promjenaIgračaToolStripMenuItem,
            this.promjenaSlužbenihOsobaToolStripMenuItem});
            this.promjenaPodatakaToolStripMenuItem.Name = "promjenaPodatakaToolStripMenuItem";
            this.promjenaPodatakaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.promjenaPodatakaToolStripMenuItem.Text = "Promjena...";
            // 
            // promjenaMomčadiToolStripMenuItem
            // 
            this.promjenaMomčadiToolStripMenuItem.Name = "promjenaMomčadiToolStripMenuItem";
            this.promjenaMomčadiToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.promjenaMomčadiToolStripMenuItem.Text = "Promjena momčadi";
            // 
            // promjenaIgračaToolStripMenuItem
            // 
            this.promjenaIgračaToolStripMenuItem.Name = "promjenaIgračaToolStripMenuItem";
            this.promjenaIgračaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.promjenaIgračaToolStripMenuItem.Text = "Promjena igrača";
            // 
            // promjenaSlužbenihOsobaToolStripMenuItem
            // 
            this.promjenaSlužbenihOsobaToolStripMenuItem.Name = "promjenaSlužbenihOsobaToolStripMenuItem";
            this.promjenaSlužbenihOsobaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.promjenaSlužbenihOsobaToolStripMenuItem.Text = "Promjena službenih osoba";
            // 
            // brisanjePodatakaToolStripMenuItem
            // 
            this.brisanjePodatakaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brisanjeMomčadiToolStripMenuItem,
            this.brisanjeIgračaToolStripMenuItem,
            this.brisanjeSlužbenihOsobaToolStripMenuItem});
            this.brisanjePodatakaToolStripMenuItem.Name = "brisanjePodatakaToolStripMenuItem";
            this.brisanjePodatakaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.brisanjePodatakaToolStripMenuItem.Text = "Brisanje...";
            // 
            // brisanjeMomčadiToolStripMenuItem
            // 
            this.brisanjeMomčadiToolStripMenuItem.Name = "brisanjeMomčadiToolStripMenuItem";
            this.brisanjeMomčadiToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.brisanjeMomčadiToolStripMenuItem.Text = "Brisanje momčadi";
            // 
            // brisanjeIgračaToolStripMenuItem
            // 
            this.brisanjeIgračaToolStripMenuItem.Name = "brisanjeIgračaToolStripMenuItem";
            this.brisanjeIgračaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.brisanjeIgračaToolStripMenuItem.Text = "Brisanje igrača";
            // 
            // brisanjeSlužbenihOsobaToolStripMenuItem
            // 
            this.brisanjeSlužbenihOsobaToolStripMenuItem.Name = "brisanjeSlužbenihOsobaToolStripMenuItem";
            this.brisanjeSlužbenihOsobaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.brisanjeSlužbenihOsobaToolStripMenuItem.Text = "Brisanje službenih osoba";
            // 
            // izvještajToolStripMenuItem
            // 
            this.izvještajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ispisIzvještajaUtakmiceToolStripMenuItem,
            this.slanjeRezultataUtakmiceToolStripMenuItem});
            this.izvještajToolStripMenuItem.Name = "izvještajToolStripMenuItem";
            this.izvještajToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvještajToolStripMenuItem.Text = "Izvještaj";
            // 
            // ispisIzvještajaUtakmiceToolStripMenuItem
            // 
            this.ispisIzvještajaUtakmiceToolStripMenuItem.Name = "ispisIzvještajaUtakmiceToolStripMenuItem";
            this.ispisIzvještajaUtakmiceToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ispisIzvještajaUtakmiceToolStripMenuItem.Text = "Ispis izvještaja utakmice";
            // 
            // slanjeRezultataUtakmiceToolStripMenuItem
            // 
            this.slanjeRezultataUtakmiceToolStripMenuItem.Name = "slanjeRezultataUtakmiceToolStripMenuItem";
            this.slanjeRezultataUtakmiceToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.slanjeRezultataUtakmiceToolStripMenuItem.Text = "Slanje rezultata utakmice";
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikcijiToolStripMenuItem});
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.oAplikacijiToolStripMenuItem.Text = "Ostalo";
            // 
            // oAplikcijiToolStripMenuItem
            // 
            this.oAplikcijiToolStripMenuItem.Name = "oAplikcijiToolStripMenuItem";
            this.oAplikcijiToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.oAplikcijiToolStripMenuItem.Text = "O aplikaciji";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSize = true;
            this.panelMain.Controls.Add(this.btnDisqualificationReport);
            this.panelMain.Controls.Add(this.btnDisqualification);
            this.panelMain.Controls.Add(this.btnSuspension);
            this.panelMain.Controls.Add(this.btnWarning);
            this.panelMain.Controls.Add(this.btn7mGoal);
            this.panelMain.Controls.Add(this.btnGoal);
            this.panelMain.Controls.Add(this.dgvTeamB);
            this.panelMain.Controls.Add(this.dgvTeamA);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Location = new System.Drawing.Point(0, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(886, 10296);
            this.panelMain.TabIndex = 1;
            // 
            // btnDisqualificationReport
            // 
            this.btnDisqualificationReport.Location = new System.Drawing.Point(386, 409);
            this.btnDisqualificationReport.Name = "btnDisqualificationReport";
            this.btnDisqualificationReport.Size = new System.Drawing.Size(112, 40);
            this.btnDisqualificationReport.TabIndex = 28;
            this.btnDisqualificationReport.Text = "Diskalifikacija i Prijava";
            this.btnDisqualificationReport.UseVisualStyleBackColor = true;
            // 
            // btnDisqualification
            // 
            this.btnDisqualification.Location = new System.Drawing.Point(386, 363);
            this.btnDisqualification.Name = "btnDisqualification";
            this.btnDisqualification.Size = new System.Drawing.Size(112, 40);
            this.btnDisqualification.TabIndex = 27;
            this.btnDisqualification.Text = "Diskvalifikacija";
            this.btnDisqualification.UseVisualStyleBackColor = true;
            // 
            // btnSuspension
            // 
            this.btnSuspension.Location = new System.Drawing.Point(386, 317);
            this.btnSuspension.Name = "btnSuspension";
            this.btnSuspension.Size = new System.Drawing.Size(112, 40);
            this.btnSuspension.TabIndex = 26;
            this.btnSuspension.Text = "2 minute";
            this.btnSuspension.UseVisualStyleBackColor = true;
            // 
            // btnWarning
            // 
            this.btnWarning.Location = new System.Drawing.Point(386, 271);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(112, 40);
            this.btnWarning.TabIndex = 25;
            this.btnWarning.Text = "Opomena";
            this.btnWarning.UseVisualStyleBackColor = true;
            // 
            // btn7mGoal
            // 
            this.btn7mGoal.Location = new System.Drawing.Point(386, 184);
            this.btn7mGoal.Name = "btn7mGoal";
            this.btn7mGoal.Size = new System.Drawing.Size(112, 40);
            this.btn7mGoal.TabIndex = 24;
            this.btn7mGoal.Text = "7m pogodak";
            this.btn7mGoal.UseVisualStyleBackColor = true;
            // 
            // btnGoal
            // 
            this.btnGoal.Location = new System.Drawing.Point(386, 138);
            this.btnGoal.Name = "btnGoal";
            this.btnGoal.Size = new System.Drawing.Size(112, 40);
            this.btnGoal.TabIndex = 23;
            this.btnGoal.Text = "Pogodak";
            this.btnGoal.UseVisualStyleBackColor = true;
            // 
            // dgvTeamB
            // 
            this.dgvTeamB.AllowUserToAddRows = false;
            this.dgvTeamB.AllowUserToDeleteRows = false;
            this.dgvTeamB.AllowUserToResizeColumns = false;
            this.dgvTeamB.AllowUserToResizeRows = false;
            this.dgvTeamB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamB.Location = new System.Drawing.Point(504, 109);
            this.dgvTeamB.Name = "dgvTeamB";
            this.dgvTeamB.ReadOnly = true;
            this.dgvTeamB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamB.Size = new System.Drawing.Size(368, 372);
            this.dgvTeamB.TabIndex = 22;
            // 
            // dgvTeamA
            // 
            this.dgvTeamA.AllowUserToAddRows = false;
            this.dgvTeamA.AllowUserToDeleteRows = false;
            this.dgvTeamA.AllowUserToResizeColumns = false;
            this.dgvTeamA.AllowUserToResizeRows = false;
            this.dgvTeamA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamA.Location = new System.Drawing.Point(12, 109);
            this.dgvTeamA.Name = "dgvTeamA";
            this.dgvTeamA.ReadOnly = true;
            this.dgvTeamA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamA.Size = new System.Drawing.Size(368, 372);
            this.dgvTeamA.TabIndex = 1;
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
            this.panelTop.Size = new System.Drawing.Size(880, 100);
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
            this.btnTimeReset.Location = new System.Drawing.Point(501, 73);
            this.btnTimeReset.Name = "btnTimeReset";
            this.btnTimeReset.Size = new System.Drawing.Size(75, 23);
            this.btnTimeReset.TabIndex = 19;
            this.btnTimeReset.Text = "Resetiraj";
            this.btnTimeReset.UseVisualStyleBackColor = true;
            this.btnTimeReset.Click += new System.EventHandler(this.btnTimeReset_Click);
            // 
            // btnTimeChange
            // 
            this.btnTimeChange.Location = new System.Drawing.Point(501, 46);
            this.btnTimeChange.Name = "btnTimeChange";
            this.btnTimeChange.Size = new System.Drawing.Size(75, 23);
            this.btnTimeChange.TabIndex = 18;
            this.btnTimeChange.Text = "Promijeni";
            this.btnTimeChange.UseVisualStyleBackColor = true;
            this.btnTimeChange.Click += new System.EventHandler(this.btnTimeChange_Click);
            // 
            // btnTimeStop
            // 
            this.btnTimeStop.Location = new System.Drawing.Point(302, 73);
            this.btnTimeStop.Name = "btnTimeStop";
            this.btnTimeStop.Size = new System.Drawing.Size(75, 23);
            this.btnTimeStop.TabIndex = 17;
            this.btnTimeStop.Text = "Stop";
            this.btnTimeStop.UseVisualStyleBackColor = true;
            this.btnTimeStop.Click += new System.EventHandler(this.btnTimeStop_Click);
            // 
            // btnTimeStart
            // 
            this.btnTimeStart.Location = new System.Drawing.Point(302, 46);
            this.btnTimeStart.Name = "btnTimeStart";
            this.btnTimeStart.Size = new System.Drawing.Size(75, 23);
            this.btnTimeStart.TabIndex = 16;
            this.btnTimeStart.Text = "Start";
            this.btnTimeStart.UseVisualStyleBackColor = true;
            this.btnTimeStart.Click += new System.EventHandler(this.btnTimeStart_Click);
            // 
            // txtTeamBTTO3
            // 
            this.txtTeamBTTO3.Location = new System.Drawing.Point(744, 75);
            this.txtTeamBTTO3.Name = "txtTeamBTTO3";
            this.txtTeamBTTO3.Size = new System.Drawing.Size(75, 20);
            this.txtTeamBTTO3.TabIndex = 15;
            // 
            // txtTeamBTTO2
            // 
            this.txtTeamBTTO2.Location = new System.Drawing.Point(663, 75);
            this.txtTeamBTTO2.Name = "txtTeamBTTO2";
            this.txtTeamBTTO2.Size = new System.Drawing.Size(75, 20);
            this.txtTeamBTTO2.TabIndex = 14;
            // 
            // txtTeamBTTO1
            // 
            this.txtTeamBTTO1.Location = new System.Drawing.Point(582, 75);
            this.txtTeamBTTO1.Name = "txtTeamBTTO1";
            this.txtTeamBTTO1.Size = new System.Drawing.Size(75, 20);
            this.txtTeamBTTO1.TabIndex = 13;
            // 
            // txtTeamATTO3
            // 
            this.txtTeamATTO3.Location = new System.Drawing.Point(221, 75);
            this.txtTeamATTO3.Name = "txtTeamATTO3";
            this.txtTeamATTO3.Size = new System.Drawing.Size(75, 20);
            this.txtTeamATTO3.TabIndex = 12;
            // 
            // txtTeamATTO2
            // 
            this.txtTeamATTO2.Location = new System.Drawing.Point(140, 75);
            this.txtTeamATTO2.Name = "txtTeamATTO2";
            this.txtTeamATTO2.Size = new System.Drawing.Size(75, 20);
            this.txtTeamATTO2.TabIndex = 11;
            // 
            // txtTeamATTO1
            // 
            this.txtTeamATTO1.Location = new System.Drawing.Point(59, 75);
            this.txtTeamATTO1.Name = "txtTeamATTO1";
            this.txtTeamATTO1.Size = new System.Drawing.Size(75, 20);
            this.txtTeamATTO1.TabIndex = 10;
            // 
            // btnTeamBTTO3
            // 
            this.btnTeamBTTO3.Location = new System.Drawing.Point(744, 46);
            this.btnTeamBTTO3.Name = "btnTeamBTTO3";
            this.btnTeamBTTO3.Size = new System.Drawing.Size(75, 23);
            this.btnTeamBTTO3.TabIndex = 9;
            this.btnTeamBTTO3.Text = "Time out [3]";
            this.btnTeamBTTO3.UseVisualStyleBackColor = true;
            // 
            // btnTeamBTTO2
            // 
            this.btnTeamBTTO2.Location = new System.Drawing.Point(663, 46);
            this.btnTeamBTTO2.Name = "btnTeamBTTO2";
            this.btnTeamBTTO2.Size = new System.Drawing.Size(75, 23);
            this.btnTeamBTTO2.TabIndex = 8;
            this.btnTeamBTTO2.Text = "Time out [2]";
            this.btnTeamBTTO2.UseVisualStyleBackColor = true;
            // 
            // btnTeamBTTO1
            // 
            this.btnTeamBTTO1.Location = new System.Drawing.Point(582, 46);
            this.btnTeamBTTO1.Name = "btnTeamBTTO1";
            this.btnTeamBTTO1.Size = new System.Drawing.Size(75, 23);
            this.btnTeamBTTO1.TabIndex = 7;
            this.btnTeamBTTO1.Text = "Time out [1]";
            this.btnTeamBTTO1.UseVisualStyleBackColor = true;
            // 
            // btnTeamATTO3
            // 
            this.btnTeamATTO3.Location = new System.Drawing.Point(221, 46);
            this.btnTeamATTO3.Name = "btnTeamATTO3";
            this.btnTeamATTO3.Size = new System.Drawing.Size(75, 23);
            this.btnTeamATTO3.TabIndex = 6;
            this.btnTeamATTO3.Text = "Time out [3]";
            this.btnTeamATTO3.UseVisualStyleBackColor = true;
            // 
            // btnTeamATTO2
            // 
            this.btnTeamATTO2.Location = new System.Drawing.Point(140, 46);
            this.btnTeamATTO2.Name = "btnTeamATTO2";
            this.btnTeamATTO2.Size = new System.Drawing.Size(75, 23);
            this.btnTeamATTO2.TabIndex = 5;
            this.btnTeamATTO2.Text = "Time out [2]";
            this.btnTeamATTO2.UseVisualStyleBackColor = true;
            // 
            // btnTeamATTO1
            // 
            this.btnTeamATTO1.Location = new System.Drawing.Point(59, 46);
            this.btnTeamATTO1.Name = "btnTeamATTO1";
            this.btnTeamATTO1.Size = new System.Drawing.Size(75, 23);
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
            this.lblTeamB.Location = new System.Drawing.Point(577, 5);
            this.lblTeamB.Name = "lblTeamB";
            this.lblTeamB.Size = new System.Drawing.Size(86, 25);
            this.lblTeamB.TabIndex = 1;
            this.lblTeamB.Text = "Team B";
            // 
            // lblTeamA
            // 
            this.lblTeamA.AutoSize = true;
            this.lblTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTeamA.Location = new System.Drawing.Point(135, 5);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamA)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem utakmicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaključiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosPodatakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosIgračaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosSlužbenihOsobaMomčadiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promjenaPodatakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promjenaMomčadiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promjenaIgračaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promjenaSlužbenihOsobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjePodatakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeMomčadiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeIgračaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeSlužbenihOsobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ispisIzvještajaUtakmiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slanjeRezultataUtakmiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikcijiToolStripMenuItem;
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
        private System.Windows.Forms.DataGridView dgvTeamA;
        private System.Windows.Forms.DataGridView dgvTeamB;
        private System.Windows.Forms.Button btnDisqualificationReport;
        private System.Windows.Forms.Button btnDisqualification;
        private System.Windows.Forms.Button btnSuspension;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.Button btn7mGoal;
        private System.Windows.Forms.Button btnGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamPlayerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goals7mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspension1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspension2ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspension3rdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualificationReportDataGridViewTextBoxColumn;
    }
}