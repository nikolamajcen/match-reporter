namespace MatchReporter.Forms.Data.Add
{
    partial class FrmAddPlayers
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
            this.lblHomeTeamLabel = new System.Windows.Forms.Label();
            this.lblGuestTeamLabel = new System.Windows.Forms.Label();
            this.lblHomeTeamName = new System.Windows.Forms.Label();
            this.lblGuestTeamName = new System.Windows.Forms.Label();
            this.dgvHomePlayersAll = new System.Windows.Forms.DataGridView();
            this.playerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHomePlayerAdd = new System.Windows.Forms.Button();
            this.btnHomePlayerRemove = new System.Windows.Forms.Button();
            this.dgvHomePlayersPlay = new System.Windows.Forms.DataGridView();
            this.playerIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHomeCurrentPlayerNumber = new System.Windows.Forms.Label();
            this.lblGuestCurrentPlayerNumber = new System.Windows.Forms.Label();
            this.dgvGuestPlayersAll = new System.Windows.Forms.DataGridView();
            this.playerIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGuestPlayersPlay = new System.Windows.Forms.DataGridView();
            this.playerIdDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIdDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuestPlayerAdd = new System.Windows.Forms.Button();
            this.btnGuestPlayerRemove = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayersAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayersPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestPlayersAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestPlayersPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomeTeamLabel
            // 
            this.lblHomeTeamLabel.AutoSize = true;
            this.lblHomeTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHomeTeamLabel.Location = new System.Drawing.Point(12, 23);
            this.lblHomeTeamLabel.Name = "lblHomeTeamLabel";
            this.lblHomeTeamLabel.Size = new System.Drawing.Size(64, 16);
            this.lblHomeTeamLabel.TabIndex = 2;
            this.lblHomeTeamLabel.Text = "Momčad:";
            // 
            // lblGuestTeamLabel
            // 
            this.lblGuestTeamLabel.AutoSize = true;
            this.lblGuestTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGuestTeamLabel.Location = new System.Drawing.Point(381, 23);
            this.lblGuestTeamLabel.Name = "lblGuestTeamLabel";
            this.lblGuestTeamLabel.Size = new System.Drawing.Size(64, 16);
            this.lblGuestTeamLabel.TabIndex = 3;
            this.lblGuestTeamLabel.Text = "Momčad:";
            // 
            // lblHomeTeamName
            // 
            this.lblHomeTeamName.AutoSize = true;
            this.lblHomeTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHomeTeamName.Location = new System.Drawing.Point(82, 23);
            this.lblHomeTeamName.Name = "lblHomeTeamName";
            this.lblHomeTeamName.Size = new System.Drawing.Size(95, 16);
            this.lblHomeTeamName.TabIndex = 4;
            this.lblHomeTeamName.Text = "Home Team";
            // 
            // lblGuestTeamName
            // 
            this.lblGuestTeamName.AutoSize = true;
            this.lblGuestTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGuestTeamName.Location = new System.Drawing.Point(451, 23);
            this.lblGuestTeamName.Name = "lblGuestTeamName";
            this.lblGuestTeamName.Size = new System.Drawing.Size(94, 16);
            this.lblGuestTeamName.TabIndex = 5;
            this.lblGuestTeamName.Text = "Guest Team";
            // 
            // dgvHomePlayersAll
            // 
            this.dgvHomePlayersAll.AllowUserToAddRows = false;
            this.dgvHomePlayersAll.AllowUserToDeleteRows = false;
            this.dgvHomePlayersAll.AutoGenerateColumns = false;
            this.dgvHomePlayersAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomePlayersAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.clubIdDataGridViewTextBoxColumn,
            this.clubDataGridViewTextBoxColumn,
            this.playDataGridViewTextBoxColumn});
            this.dgvHomePlayersAll.DataSource = this.playerBindingSource;
            this.dgvHomePlayersAll.Location = new System.Drawing.Point(12, 49);
            this.dgvHomePlayersAll.Name = "dgvHomePlayersAll";
            this.dgvHomePlayersAll.ReadOnly = true;
            this.dgvHomePlayersAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHomePlayersAll.Size = new System.Drawing.Size(314, 184);
            this.dgvHomePlayersAll.TabIndex = 6;
            // 
            // playerIdDataGridViewTextBoxColumn
            // 
            this.playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn.HeaderText = "Matični broj";
            this.playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
            this.playerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.playerIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.playerIdDataGridViewTextBoxColumn.Width = 85;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.firstNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lastNameDataGridViewTextBoxColumn.Width = 88;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Visible = false;
            // 
            // clubIdDataGridViewTextBoxColumn
            // 
            this.clubIdDataGridViewTextBoxColumn.DataPropertyName = "ClubId";
            this.clubIdDataGridViewTextBoxColumn.HeaderText = "ClubId";
            this.clubIdDataGridViewTextBoxColumn.Name = "clubIdDataGridViewTextBoxColumn";
            this.clubIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clubIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // clubDataGridViewTextBoxColumn
            // 
            this.clubDataGridViewTextBoxColumn.DataPropertyName = "Club";
            this.clubDataGridViewTextBoxColumn.HeaderText = "Club";
            this.clubDataGridViewTextBoxColumn.Name = "clubDataGridViewTextBoxColumn";
            this.clubDataGridViewTextBoxColumn.ReadOnly = true;
            this.clubDataGridViewTextBoxColumn.Visible = false;
            // 
            // playDataGridViewTextBoxColumn
            // 
            this.playDataGridViewTextBoxColumn.DataPropertyName = "Play";
            this.playDataGridViewTextBoxColumn.HeaderText = "Play";
            this.playDataGridViewTextBoxColumn.Name = "playDataGridViewTextBoxColumn";
            this.playDataGridViewTextBoxColumn.ReadOnly = true;
            this.playDataGridViewTextBoxColumn.Visible = false;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(MatchReporter.Player);
            // 
            // btnHomePlayerAdd
            // 
            this.btnHomePlayerAdd.Location = new System.Drawing.Point(12, 239);
            this.btnHomePlayerAdd.Name = "btnHomePlayerAdd";
            this.btnHomePlayerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnHomePlayerAdd.TabIndex = 7;
            this.btnHomePlayerAdd.Text = "Dodaj";
            this.btnHomePlayerAdd.UseVisualStyleBackColor = true;
            this.btnHomePlayerAdd.Click += new System.EventHandler(this.btnHomePlayerAdd_Click);
            // 
            // btnHomePlayerRemove
            // 
            this.btnHomePlayerRemove.Location = new System.Drawing.Point(251, 239);
            this.btnHomePlayerRemove.Name = "btnHomePlayerRemove";
            this.btnHomePlayerRemove.Size = new System.Drawing.Size(75, 23);
            this.btnHomePlayerRemove.TabIndex = 8;
            this.btnHomePlayerRemove.Text = "Ukloni";
            this.btnHomePlayerRemove.UseVisualStyleBackColor = true;
            this.btnHomePlayerRemove.Click += new System.EventHandler(this.btnHomePlayerRemove_Click);
            // 
            // dgvHomePlayersPlay
            // 
            this.dgvHomePlayersPlay.AllowUserToAddRows = false;
            this.dgvHomePlayersPlay.AllowUserToDeleteRows = false;
            this.dgvHomePlayersPlay.AutoGenerateColumns = false;
            this.dgvHomePlayersPlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomePlayersPlay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIdDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.numberDataGridViewTextBoxColumn1,
            this.clubIdDataGridViewTextBoxColumn1,
            this.clubDataGridViewTextBoxColumn1,
            this.playDataGridViewTextBoxColumn1});
            this.dgvHomePlayersPlay.DataSource = this.playerBindingSource;
            this.dgvHomePlayersPlay.Location = new System.Drawing.Point(12, 268);
            this.dgvHomePlayersPlay.Name = "dgvHomePlayersPlay";
            this.dgvHomePlayersPlay.ReadOnly = true;
            this.dgvHomePlayersPlay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHomePlayersPlay.Size = new System.Drawing.Size(314, 184);
            this.dgvHomePlayersPlay.TabIndex = 9;
            // 
            // playerIdDataGridViewTextBoxColumn1
            // 
            this.playerIdDataGridViewTextBoxColumn1.DataPropertyName = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn1.HeaderText = "Matični broj";
            this.playerIdDataGridViewTextBoxColumn1.Name = "playerIdDataGridViewTextBoxColumn1";
            this.playerIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.playerIdDataGridViewTextBoxColumn1.Width = 85;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn1.Width = 80;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Prezime";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn1.Width = 88;
            // 
            // numberDataGridViewTextBoxColumn1
            // 
            this.numberDataGridViewTextBoxColumn1.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn1.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn1.Name = "numberDataGridViewTextBoxColumn1";
            this.numberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn1.Visible = false;
            // 
            // clubIdDataGridViewTextBoxColumn1
            // 
            this.clubIdDataGridViewTextBoxColumn1.DataPropertyName = "ClubId";
            this.clubIdDataGridViewTextBoxColumn1.HeaderText = "ClubId";
            this.clubIdDataGridViewTextBoxColumn1.Name = "clubIdDataGridViewTextBoxColumn1";
            this.clubIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.clubIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // clubDataGridViewTextBoxColumn1
            // 
            this.clubDataGridViewTextBoxColumn1.DataPropertyName = "Club";
            this.clubDataGridViewTextBoxColumn1.HeaderText = "Club";
            this.clubDataGridViewTextBoxColumn1.Name = "clubDataGridViewTextBoxColumn1";
            this.clubDataGridViewTextBoxColumn1.ReadOnly = true;
            this.clubDataGridViewTextBoxColumn1.Visible = false;
            // 
            // playDataGridViewTextBoxColumn1
            // 
            this.playDataGridViewTextBoxColumn1.DataPropertyName = "Play";
            this.playDataGridViewTextBoxColumn1.HeaderText = "Play";
            this.playDataGridViewTextBoxColumn1.Name = "playDataGridViewTextBoxColumn1";
            this.playDataGridViewTextBoxColumn1.ReadOnly = true;
            this.playDataGridViewTextBoxColumn1.Visible = false;
            // 
            // lblHomeCurrentPlayerNumber
            // 
            this.lblHomeCurrentPlayerNumber.AutoSize = true;
            this.lblHomeCurrentPlayerNumber.Location = new System.Drawing.Point(157, 244);
            this.lblHomeCurrentPlayerNumber.Name = "lblHomeCurrentPlayerNumber";
            this.lblHomeCurrentPlayerNumber.Size = new System.Drawing.Size(30, 13);
            this.lblHomeCurrentPlayerNumber.TabIndex = 10;
            this.lblHomeCurrentPlayerNumber.Text = "0/16";
            // 
            // lblGuestCurrentPlayerNumber
            // 
            this.lblGuestCurrentPlayerNumber.AutoSize = true;
            this.lblGuestCurrentPlayerNumber.Location = new System.Drawing.Point(525, 244);
            this.lblGuestCurrentPlayerNumber.Name = "lblGuestCurrentPlayerNumber";
            this.lblGuestCurrentPlayerNumber.Size = new System.Drawing.Size(30, 13);
            this.lblGuestCurrentPlayerNumber.TabIndex = 11;
            this.lblGuestCurrentPlayerNumber.Text = "0/16";
            // 
            // dgvGuestPlayersAll
            // 
            this.dgvGuestPlayersAll.AllowUserToAddRows = false;
            this.dgvGuestPlayersAll.AllowUserToDeleteRows = false;
            this.dgvGuestPlayersAll.AutoGenerateColumns = false;
            this.dgvGuestPlayersAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestPlayersAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIdDataGridViewTextBoxColumn2,
            this.firstNameDataGridViewTextBoxColumn2,
            this.lastNameDataGridViewTextBoxColumn2,
            this.numberDataGridViewTextBoxColumn2,
            this.clubIdDataGridViewTextBoxColumn2,
            this.clubDataGridViewTextBoxColumn2,
            this.playDataGridViewTextBoxColumn2});
            this.dgvGuestPlayersAll.DataSource = this.playerBindingSource;
            this.dgvGuestPlayersAll.Location = new System.Drawing.Point(384, 49);
            this.dgvGuestPlayersAll.Name = "dgvGuestPlayersAll";
            this.dgvGuestPlayersAll.ReadOnly = true;
            this.dgvGuestPlayersAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuestPlayersAll.Size = new System.Drawing.Size(314, 184);
            this.dgvGuestPlayersAll.TabIndex = 12;
            // 
            // playerIdDataGridViewTextBoxColumn2
            // 
            this.playerIdDataGridViewTextBoxColumn2.DataPropertyName = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn2.HeaderText = "Matični broj";
            this.playerIdDataGridViewTextBoxColumn2.Name = "playerIdDataGridViewTextBoxColumn2";
            this.playerIdDataGridViewTextBoxColumn2.ReadOnly = true;
            this.playerIdDataGridViewTextBoxColumn2.Width = 85;
            // 
            // firstNameDataGridViewTextBoxColumn2
            // 
            this.firstNameDataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.firstNameDataGridViewTextBoxColumn2.Name = "firstNameDataGridViewTextBoxColumn2";
            this.firstNameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn2.Width = 80;
            // 
            // lastNameDataGridViewTextBoxColumn2
            // 
            this.lastNameDataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn2.HeaderText = "Prezime";
            this.lastNameDataGridViewTextBoxColumn2.Name = "lastNameDataGridViewTextBoxColumn2";
            this.lastNameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn2.Width = 88;
            // 
            // numberDataGridViewTextBoxColumn2
            // 
            this.numberDataGridViewTextBoxColumn2.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn2.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn2.Name = "numberDataGridViewTextBoxColumn2";
            this.numberDataGridViewTextBoxColumn2.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn2.Visible = false;
            // 
            // clubIdDataGridViewTextBoxColumn2
            // 
            this.clubIdDataGridViewTextBoxColumn2.DataPropertyName = "ClubId";
            this.clubIdDataGridViewTextBoxColumn2.HeaderText = "ClubId";
            this.clubIdDataGridViewTextBoxColumn2.Name = "clubIdDataGridViewTextBoxColumn2";
            this.clubIdDataGridViewTextBoxColumn2.ReadOnly = true;
            this.clubIdDataGridViewTextBoxColumn2.Visible = false;
            // 
            // clubDataGridViewTextBoxColumn2
            // 
            this.clubDataGridViewTextBoxColumn2.DataPropertyName = "Club";
            this.clubDataGridViewTextBoxColumn2.HeaderText = "Club";
            this.clubDataGridViewTextBoxColumn2.Name = "clubDataGridViewTextBoxColumn2";
            this.clubDataGridViewTextBoxColumn2.ReadOnly = true;
            this.clubDataGridViewTextBoxColumn2.Visible = false;
            // 
            // playDataGridViewTextBoxColumn2
            // 
            this.playDataGridViewTextBoxColumn2.DataPropertyName = "Play";
            this.playDataGridViewTextBoxColumn2.HeaderText = "Play";
            this.playDataGridViewTextBoxColumn2.Name = "playDataGridViewTextBoxColumn2";
            this.playDataGridViewTextBoxColumn2.ReadOnly = true;
            this.playDataGridViewTextBoxColumn2.Visible = false;
            // 
            // dgvGuestPlayersPlay
            // 
            this.dgvGuestPlayersPlay.AllowUserToAddRows = false;
            this.dgvGuestPlayersPlay.AllowUserToDeleteRows = false;
            this.dgvGuestPlayersPlay.AutoGenerateColumns = false;
            this.dgvGuestPlayersPlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestPlayersPlay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIdDataGridViewTextBoxColumn3,
            this.firstNameDataGridViewTextBoxColumn3,
            this.lastNameDataGridViewTextBoxColumn3,
            this.numberDataGridViewTextBoxColumn3,
            this.clubIdDataGridViewTextBoxColumn3,
            this.clubDataGridViewTextBoxColumn3,
            this.playDataGridViewTextBoxColumn3});
            this.dgvGuestPlayersPlay.DataSource = this.playerBindingSource;
            this.dgvGuestPlayersPlay.Location = new System.Drawing.Point(384, 268);
            this.dgvGuestPlayersPlay.Name = "dgvGuestPlayersPlay";
            this.dgvGuestPlayersPlay.ReadOnly = true;
            this.dgvGuestPlayersPlay.Size = new System.Drawing.Size(314, 184);
            this.dgvGuestPlayersPlay.TabIndex = 13;
            // 
            // playerIdDataGridViewTextBoxColumn3
            // 
            this.playerIdDataGridViewTextBoxColumn3.DataPropertyName = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn3.HeaderText = "Matični broj";
            this.playerIdDataGridViewTextBoxColumn3.Name = "playerIdDataGridViewTextBoxColumn3";
            this.playerIdDataGridViewTextBoxColumn3.ReadOnly = true;
            this.playerIdDataGridViewTextBoxColumn3.Width = 85;
            // 
            // firstNameDataGridViewTextBoxColumn3
            // 
            this.firstNameDataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn3.HeaderText = "Ime";
            this.firstNameDataGridViewTextBoxColumn3.Name = "firstNameDataGridViewTextBoxColumn3";
            this.firstNameDataGridViewTextBoxColumn3.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn3.Width = 80;
            // 
            // lastNameDataGridViewTextBoxColumn3
            // 
            this.lastNameDataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.lastNameDataGridViewTextBoxColumn3.Name = "lastNameDataGridViewTextBoxColumn3";
            this.lastNameDataGridViewTextBoxColumn3.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn3.Width = 88;
            // 
            // numberDataGridViewTextBoxColumn3
            // 
            this.numberDataGridViewTextBoxColumn3.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn3.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn3.Name = "numberDataGridViewTextBoxColumn3";
            this.numberDataGridViewTextBoxColumn3.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn3.Visible = false;
            // 
            // clubIdDataGridViewTextBoxColumn3
            // 
            this.clubIdDataGridViewTextBoxColumn3.DataPropertyName = "ClubId";
            this.clubIdDataGridViewTextBoxColumn3.HeaderText = "ClubId";
            this.clubIdDataGridViewTextBoxColumn3.Name = "clubIdDataGridViewTextBoxColumn3";
            this.clubIdDataGridViewTextBoxColumn3.ReadOnly = true;
            this.clubIdDataGridViewTextBoxColumn3.Visible = false;
            // 
            // clubDataGridViewTextBoxColumn3
            // 
            this.clubDataGridViewTextBoxColumn3.DataPropertyName = "Club";
            this.clubDataGridViewTextBoxColumn3.HeaderText = "Club";
            this.clubDataGridViewTextBoxColumn3.Name = "clubDataGridViewTextBoxColumn3";
            this.clubDataGridViewTextBoxColumn3.ReadOnly = true;
            this.clubDataGridViewTextBoxColumn3.Visible = false;
            // 
            // playDataGridViewTextBoxColumn3
            // 
            this.playDataGridViewTextBoxColumn3.DataPropertyName = "Play";
            this.playDataGridViewTextBoxColumn3.HeaderText = "Play";
            this.playDataGridViewTextBoxColumn3.Name = "playDataGridViewTextBoxColumn3";
            this.playDataGridViewTextBoxColumn3.ReadOnly = true;
            this.playDataGridViewTextBoxColumn3.Visible = false;
            // 
            // btnGuestPlayerAdd
            // 
            this.btnGuestPlayerAdd.Location = new System.Drawing.Point(384, 239);
            this.btnGuestPlayerAdd.Name = "btnGuestPlayerAdd";
            this.btnGuestPlayerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnGuestPlayerAdd.TabIndex = 14;
            this.btnGuestPlayerAdd.Text = "Dodaj";
            this.btnGuestPlayerAdd.UseVisualStyleBackColor = true;
            this.btnGuestPlayerAdd.Click += new System.EventHandler(this.btnGuestPlayerAdd_Click);
            // 
            // btnGuestPlayerRemove
            // 
            this.btnGuestPlayerRemove.Location = new System.Drawing.Point(623, 239);
            this.btnGuestPlayerRemove.Name = "btnGuestPlayerRemove";
            this.btnGuestPlayerRemove.Size = new System.Drawing.Size(75, 23);
            this.btnGuestPlayerRemove.TabIndex = 15;
            this.btnGuestPlayerRemove.Text = "Ukloni";
            this.btnGuestPlayerRemove.UseVisualStyleBackColor = true;
            this.btnGuestPlayerRemove.Click += new System.EventHandler(this.btnGuestPlayerRemove_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(623, 468);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(542, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 503);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnGuestPlayerRemove);
            this.Controls.Add(this.btnGuestPlayerAdd);
            this.Controls.Add(this.dgvGuestPlayersPlay);
            this.Controls.Add(this.dgvGuestPlayersAll);
            this.Controls.Add(this.lblGuestCurrentPlayerNumber);
            this.Controls.Add(this.lblHomeCurrentPlayerNumber);
            this.Controls.Add(this.dgvHomePlayersPlay);
            this.Controls.Add(this.btnHomePlayerRemove);
            this.Controls.Add(this.btnHomePlayerAdd);
            this.Controls.Add(this.dgvHomePlayersAll);
            this.Controls.Add(this.lblGuestTeamName);
            this.Controls.Add(this.lblHomeTeamName);
            this.Controls.Add(this.lblGuestTeamLabel);
            this.Controls.Add(this.lblHomeTeamLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos igrača";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayersAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayersPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestPlayersAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestPlayersPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTeamLabel;
        private System.Windows.Forms.Label lblGuestTeamLabel;
        private System.Windows.Forms.Label lblHomeTeamName;
        private System.Windows.Forms.Label lblGuestTeamName;
        private System.Windows.Forms.DataGridView dgvHomePlayersAll;
        private System.Windows.Forms.Button btnHomePlayerAdd;
        private System.Windows.Forms.Button btnHomePlayerRemove;
        private System.Windows.Forms.DataGridView dgvHomePlayersPlay;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblHomeCurrentPlayerNumber;
        private System.Windows.Forms.Label lblGuestCurrentPlayerNumber;
        private System.Windows.Forms.DataGridView dgvGuestPlayersAll;
        private System.Windows.Forms.DataGridView dgvGuestPlayersPlay;
        private System.Windows.Forms.Button btnGuestPlayerAdd;
        private System.Windows.Forms.Button btnGuestPlayerRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn playDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIdDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn playDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}