namespace MatchReporter.Forms.Data.Add
{
    partial class FrmAddOfficials
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
            this.lblHomeTeamName = new System.Windows.Forms.Label();
            this.lblGuestTeamLabel = new System.Windows.Forms.Label();
            this.lblGuestTeamName = new System.Windows.Forms.Label();
            this.lblHomeOfficialsCount = new System.Windows.Forms.Label();
            this.lblGuestOfficialsCount = new System.Windows.Forms.Label();
            this.dgvHomeOfficialsAll = new System.Windows.Forms.DataGridView();
            this.dgvGuestOfficialsAll = new System.Windows.Forms.DataGridView();
            this.dgvHomeOfficialsManage = new System.Windows.Forms.DataGridView();
            this.dgvGuestOfficialsManage = new System.Windows.Forms.DataGridView();
            this.btnHomeOfficialsAdd = new System.Windows.Forms.Button();
            this.btnHomeOfficialsRemove = new System.Windows.Forms.Button();
            this.btnGuestOfficialsAdd = new System.Windows.Forms.Button();
            this.btnGuestOfficialsRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.clubOfficialIdDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIdDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubOfficialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubOfficialIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubOfficialIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubOfficialIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeOfficialsAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestOfficialsAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeOfficialsManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestOfficialsManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubOfficialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomeTeamLabel
            // 
            this.lblHomeTeamLabel.AutoSize = true;
            this.lblHomeTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHomeTeamLabel.Location = new System.Drawing.Point(23, 24);
            this.lblHomeTeamLabel.Name = "lblHomeTeamLabel";
            this.lblHomeTeamLabel.Size = new System.Drawing.Size(64, 16);
            this.lblHomeTeamLabel.TabIndex = 0;
            this.lblHomeTeamLabel.Text = "Momčad:";
            // 
            // lblHomeTeamName
            // 
            this.lblHomeTeamName.AutoSize = true;
            this.lblHomeTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHomeTeamName.Location = new System.Drawing.Point(93, 24);
            this.lblHomeTeamName.Name = "lblHomeTeamName";
            this.lblHomeTeamName.Size = new System.Drawing.Size(62, 16);
            this.lblHomeTeamName.TabIndex = 1;
            this.lblHomeTeamName.Text = "Team A";
            // 
            // lblGuestTeamLabel
            // 
            this.lblGuestTeamLabel.AutoSize = true;
            this.lblGuestTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGuestTeamLabel.Location = new System.Drawing.Point(314, 24);
            this.lblGuestTeamLabel.Name = "lblGuestTeamLabel";
            this.lblGuestTeamLabel.Size = new System.Drawing.Size(64, 16);
            this.lblGuestTeamLabel.TabIndex = 2;
            this.lblGuestTeamLabel.Text = "Momčad:";
            // 
            // lblGuestTeamName
            // 
            this.lblGuestTeamName.AutoSize = true;
            this.lblGuestTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGuestTeamName.Location = new System.Drawing.Point(384, 24);
            this.lblGuestTeamName.Name = "lblGuestTeamName";
            this.lblGuestTeamName.Size = new System.Drawing.Size(62, 16);
            this.lblGuestTeamName.TabIndex = 3;
            this.lblGuestTeamName.Text = "Team B";
            // 
            // lblHomeOfficialsCount
            // 
            this.lblHomeOfficialsCount.AutoSize = true;
            this.lblHomeOfficialsCount.Location = new System.Drawing.Point(140, 196);
            this.lblHomeOfficialsCount.Name = "lblHomeOfficialsCount";
            this.lblHomeOfficialsCount.Size = new System.Drawing.Size(24, 13);
            this.lblHomeOfficialsCount.TabIndex = 4;
            this.lblHomeOfficialsCount.Text = "0/4";
            // 
            // lblGuestOfficialsCount
            // 
            this.lblGuestOfficialsCount.AutoSize = true;
            this.lblGuestOfficialsCount.Location = new System.Drawing.Point(432, 196);
            this.lblGuestOfficialsCount.Name = "lblGuestOfficialsCount";
            this.lblGuestOfficialsCount.Size = new System.Drawing.Size(24, 13);
            this.lblGuestOfficialsCount.TabIndex = 5;
            this.lblGuestOfficialsCount.Text = "0/4";
            // 
            // dgvHomeOfficialsAll
            // 
            this.dgvHomeOfficialsAll.AllowUserToAddRows = false;
            this.dgvHomeOfficialsAll.AllowUserToDeleteRows = false;
            this.dgvHomeOfficialsAll.AutoGenerateColumns = false;
            this.dgvHomeOfficialsAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeOfficialsAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubOfficialIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.clubIdDataGridViewTextBoxColumn,
            this.clubDataGridViewTextBoxColumn,
            this.manageDataGridViewTextBoxColumn});
            this.dgvHomeOfficialsAll.DataSource = this.clubOfficialBindingSource;
            this.dgvHomeOfficialsAll.Location = new System.Drawing.Point(26, 52);
            this.dgvHomeOfficialsAll.Name = "dgvHomeOfficialsAll";
            this.dgvHomeOfficialsAll.ReadOnly = true;
            this.dgvHomeOfficialsAll.Size = new System.Drawing.Size(249, 133);
            this.dgvHomeOfficialsAll.TabIndex = 6;
            // 
            // dgvGuestOfficialsAll
            // 
            this.dgvGuestOfficialsAll.AllowUserToAddRows = false;
            this.dgvGuestOfficialsAll.AllowUserToDeleteRows = false;
            this.dgvGuestOfficialsAll.AutoGenerateColumns = false;
            this.dgvGuestOfficialsAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestOfficialsAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubOfficialIdDataGridViewTextBoxColumn2,
            this.firstNameDataGridViewTextBoxColumn2,
            this.lastNameDataGridViewTextBoxColumn2,
            this.clubIdDataGridViewTextBoxColumn2,
            this.clubDataGridViewTextBoxColumn2,
            this.manageDataGridViewTextBoxColumn2});
            this.dgvGuestOfficialsAll.DataSource = this.clubOfficialBindingSource;
            this.dgvGuestOfficialsAll.Location = new System.Drawing.Point(317, 52);
            this.dgvGuestOfficialsAll.Name = "dgvGuestOfficialsAll";
            this.dgvGuestOfficialsAll.ReadOnly = true;
            this.dgvGuestOfficialsAll.Size = new System.Drawing.Size(249, 133);
            this.dgvGuestOfficialsAll.TabIndex = 7;
            // 
            // dgvHomeOfficialsManage
            // 
            this.dgvHomeOfficialsManage.AllowUserToAddRows = false;
            this.dgvHomeOfficialsManage.AllowUserToDeleteRows = false;
            this.dgvHomeOfficialsManage.AutoGenerateColumns = false;
            this.dgvHomeOfficialsManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeOfficialsManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubOfficialIdDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.clubIdDataGridViewTextBoxColumn1,
            this.clubDataGridViewTextBoxColumn1,
            this.manageDataGridViewTextBoxColumn1});
            this.dgvHomeOfficialsManage.DataSource = this.clubOfficialBindingSource;
            this.dgvHomeOfficialsManage.Location = new System.Drawing.Point(26, 220);
            this.dgvHomeOfficialsManage.Name = "dgvHomeOfficialsManage";
            this.dgvHomeOfficialsManage.ReadOnly = true;
            this.dgvHomeOfficialsManage.Size = new System.Drawing.Size(249, 133);
            this.dgvHomeOfficialsManage.TabIndex = 8;
            // 
            // dgvGuestOfficialsManage
            // 
            this.dgvGuestOfficialsManage.AllowUserToAddRows = false;
            this.dgvGuestOfficialsManage.AllowUserToDeleteRows = false;
            this.dgvGuestOfficialsManage.AutoGenerateColumns = false;
            this.dgvGuestOfficialsManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestOfficialsManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubOfficialIdDataGridViewTextBoxColumn3,
            this.firstNameDataGridViewTextBoxColumn3,
            this.lastNameDataGridViewTextBoxColumn3,
            this.clubIdDataGridViewTextBoxColumn3,
            this.clubDataGridViewTextBoxColumn3,
            this.manageDataGridViewTextBoxColumn3});
            this.dgvGuestOfficialsManage.DataSource = this.clubOfficialBindingSource;
            this.dgvGuestOfficialsManage.Location = new System.Drawing.Point(317, 220);
            this.dgvGuestOfficialsManage.Name = "dgvGuestOfficialsManage";
            this.dgvGuestOfficialsManage.ReadOnly = true;
            this.dgvGuestOfficialsManage.Size = new System.Drawing.Size(249, 133);
            this.dgvGuestOfficialsManage.TabIndex = 9;
            // 
            // btnHomeOfficialsAdd
            // 
            this.btnHomeOfficialsAdd.Location = new System.Drawing.Point(26, 191);
            this.btnHomeOfficialsAdd.Name = "btnHomeOfficialsAdd";
            this.btnHomeOfficialsAdd.Size = new System.Drawing.Size(75, 23);
            this.btnHomeOfficialsAdd.TabIndex = 10;
            this.btnHomeOfficialsAdd.Text = "Dodaj";
            this.btnHomeOfficialsAdd.UseVisualStyleBackColor = true;
            this.btnHomeOfficialsAdd.Click += new System.EventHandler(this.btnHomeOfficialsAdd_Click);
            // 
            // btnHomeOfficialsRemove
            // 
            this.btnHomeOfficialsRemove.Location = new System.Drawing.Point(200, 191);
            this.btnHomeOfficialsRemove.Name = "btnHomeOfficialsRemove";
            this.btnHomeOfficialsRemove.Size = new System.Drawing.Size(75, 23);
            this.btnHomeOfficialsRemove.TabIndex = 11;
            this.btnHomeOfficialsRemove.Text = "Ukloni";
            this.btnHomeOfficialsRemove.UseVisualStyleBackColor = true;
            this.btnHomeOfficialsRemove.Click += new System.EventHandler(this.btnHomeOfficialsRemove_Click);
            // 
            // btnGuestOfficialsAdd
            // 
            this.btnGuestOfficialsAdd.Location = new System.Drawing.Point(317, 191);
            this.btnGuestOfficialsAdd.Name = "btnGuestOfficialsAdd";
            this.btnGuestOfficialsAdd.Size = new System.Drawing.Size(75, 23);
            this.btnGuestOfficialsAdd.TabIndex = 12;
            this.btnGuestOfficialsAdd.Text = "Dodaj";
            this.btnGuestOfficialsAdd.UseVisualStyleBackColor = true;
            this.btnGuestOfficialsAdd.Click += new System.EventHandler(this.btnGuestOfficialsAdd_Click);
            // 
            // btnGuestOfficialsRemove
            // 
            this.btnGuestOfficialsRemove.Location = new System.Drawing.Point(491, 191);
            this.btnGuestOfficialsRemove.Name = "btnGuestOfficialsRemove";
            this.btnGuestOfficialsRemove.Size = new System.Drawing.Size(75, 23);
            this.btnGuestOfficialsRemove.TabIndex = 13;
            this.btnGuestOfficialsRemove.Text = "Ukloni";
            this.btnGuestOfficialsRemove.UseVisualStyleBackColor = true;
            this.btnGuestOfficialsRemove.Click += new System.EventHandler(this.btnGuestOfficialsRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(410, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(491, 369);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // clubOfficialIdDataGridViewTextBoxColumn3
            // 
            this.clubOfficialIdDataGridViewTextBoxColumn3.DataPropertyName = "ClubOfficialId";
            this.clubOfficialIdDataGridViewTextBoxColumn3.HeaderText = "Matični broj";
            this.clubOfficialIdDataGridViewTextBoxColumn3.Name = "clubOfficialIdDataGridViewTextBoxColumn3";
            this.clubOfficialIdDataGridViewTextBoxColumn3.ReadOnly = true;
            this.clubOfficialIdDataGridViewTextBoxColumn3.Width = 85;
            // 
            // firstNameDataGridViewTextBoxColumn3
            // 
            this.firstNameDataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn3.HeaderText = "Ime";
            this.firstNameDataGridViewTextBoxColumn3.Name = "firstNameDataGridViewTextBoxColumn3";
            this.firstNameDataGridViewTextBoxColumn3.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn3.Width = 60;
            // 
            // lastNameDataGridViewTextBoxColumn3
            // 
            this.lastNameDataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.lastNameDataGridViewTextBoxColumn3.Name = "lastNameDataGridViewTextBoxColumn3";
            this.lastNameDataGridViewTextBoxColumn3.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn3.Width = 60;
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
            // manageDataGridViewTextBoxColumn3
            // 
            this.manageDataGridViewTextBoxColumn3.DataPropertyName = "Manage";
            this.manageDataGridViewTextBoxColumn3.HeaderText = "Manage";
            this.manageDataGridViewTextBoxColumn3.Name = "manageDataGridViewTextBoxColumn3";
            this.manageDataGridViewTextBoxColumn3.ReadOnly = true;
            this.manageDataGridViewTextBoxColumn3.Visible = false;
            // 
            // clubOfficialBindingSource
            // 
            this.clubOfficialBindingSource.DataSource = typeof(MatchReporter.ClubOfficial);
            // 
            // clubOfficialIdDataGridViewTextBoxColumn1
            // 
            this.clubOfficialIdDataGridViewTextBoxColumn1.DataPropertyName = "ClubOfficialId";
            this.clubOfficialIdDataGridViewTextBoxColumn1.HeaderText = "Matični broj";
            this.clubOfficialIdDataGridViewTextBoxColumn1.Name = "clubOfficialIdDataGridViewTextBoxColumn1";
            this.clubOfficialIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.clubOfficialIdDataGridViewTextBoxColumn1.Width = 85;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn1.Width = 60;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Prezime";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn1.Width = 60;
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
            // manageDataGridViewTextBoxColumn1
            // 
            this.manageDataGridViewTextBoxColumn1.DataPropertyName = "Manage";
            this.manageDataGridViewTextBoxColumn1.HeaderText = "Manage";
            this.manageDataGridViewTextBoxColumn1.Name = "manageDataGridViewTextBoxColumn1";
            this.manageDataGridViewTextBoxColumn1.ReadOnly = true;
            this.manageDataGridViewTextBoxColumn1.Visible = false;
            // 
            // clubOfficialIdDataGridViewTextBoxColumn2
            // 
            this.clubOfficialIdDataGridViewTextBoxColumn2.DataPropertyName = "ClubOfficialId";
            this.clubOfficialIdDataGridViewTextBoxColumn2.HeaderText = "Matični broj";
            this.clubOfficialIdDataGridViewTextBoxColumn2.Name = "clubOfficialIdDataGridViewTextBoxColumn2";
            this.clubOfficialIdDataGridViewTextBoxColumn2.ReadOnly = true;
            this.clubOfficialIdDataGridViewTextBoxColumn2.Width = 85;
            // 
            // firstNameDataGridViewTextBoxColumn2
            // 
            this.firstNameDataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.firstNameDataGridViewTextBoxColumn2.Name = "firstNameDataGridViewTextBoxColumn2";
            this.firstNameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn2.Width = 60;
            // 
            // lastNameDataGridViewTextBoxColumn2
            // 
            this.lastNameDataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn2.HeaderText = "Prezime";
            this.lastNameDataGridViewTextBoxColumn2.Name = "lastNameDataGridViewTextBoxColumn2";
            this.lastNameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn2.Width = 60;
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
            // manageDataGridViewTextBoxColumn2
            // 
            this.manageDataGridViewTextBoxColumn2.DataPropertyName = "Manage";
            this.manageDataGridViewTextBoxColumn2.HeaderText = "Manage";
            this.manageDataGridViewTextBoxColumn2.Name = "manageDataGridViewTextBoxColumn2";
            this.manageDataGridViewTextBoxColumn2.ReadOnly = true;
            this.manageDataGridViewTextBoxColumn2.Visible = false;
            // 
            // clubOfficialIdDataGridViewTextBoxColumn
            // 
            this.clubOfficialIdDataGridViewTextBoxColumn.DataPropertyName = "ClubOfficialId";
            this.clubOfficialIdDataGridViewTextBoxColumn.HeaderText = "Matični broj";
            this.clubOfficialIdDataGridViewTextBoxColumn.Name = "clubOfficialIdDataGridViewTextBoxColumn";
            this.clubOfficialIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clubOfficialIdDataGridViewTextBoxColumn.Width = 85;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 60;
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
            // manageDataGridViewTextBoxColumn
            // 
            this.manageDataGridViewTextBoxColumn.DataPropertyName = "Manage";
            this.manageDataGridViewTextBoxColumn.HeaderText = "Manage";
            this.manageDataGridViewTextBoxColumn.Name = "manageDataGridViewTextBoxColumn";
            this.manageDataGridViewTextBoxColumn.ReadOnly = true;
            this.manageDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmAddOfficials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 409);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGuestOfficialsRemove);
            this.Controls.Add(this.btnGuestOfficialsAdd);
            this.Controls.Add(this.btnHomeOfficialsRemove);
            this.Controls.Add(this.btnHomeOfficialsAdd);
            this.Controls.Add(this.dgvGuestOfficialsManage);
            this.Controls.Add(this.dgvHomeOfficialsManage);
            this.Controls.Add(this.dgvGuestOfficialsAll);
            this.Controls.Add(this.dgvHomeOfficialsAll);
            this.Controls.Add(this.lblGuestOfficialsCount);
            this.Controls.Add(this.lblHomeOfficialsCount);
            this.Controls.Add(this.lblGuestTeamName);
            this.Controls.Add(this.lblGuestTeamLabel);
            this.Controls.Add(this.lblHomeTeamName);
            this.Controls.Add(this.lblHomeTeamLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddOfficials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos službenih osoba";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeOfficialsAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestOfficialsAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeOfficialsManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestOfficialsManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubOfficialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTeamLabel;
        private System.Windows.Forms.Label lblHomeTeamName;
        private System.Windows.Forms.Label lblGuestTeamLabel;
        private System.Windows.Forms.Label lblGuestTeamName;
        private System.Windows.Forms.Label lblHomeOfficialsCount;
        private System.Windows.Forms.Label lblGuestOfficialsCount;
        private System.Windows.Forms.DataGridView dgvHomeOfficialsAll;
        private System.Windows.Forms.DataGridView dgvGuestOfficialsAll;
        private System.Windows.Forms.DataGridView dgvHomeOfficialsManage;
        private System.Windows.Forms.DataGridView dgvGuestOfficialsManage;
        private System.Windows.Forms.Button btnHomeOfficialsAdd;
        private System.Windows.Forms.Button btnHomeOfficialsRemove;
        private System.Windows.Forms.Button btnGuestOfficialsAdd;
        private System.Windows.Forms.Button btnGuestOfficialsRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubOfficialIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clubOfficialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubOfficialIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubOfficialIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn manageDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubOfficialIdDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIdDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn manageDataGridViewTextBoxColumn3;
    }
}