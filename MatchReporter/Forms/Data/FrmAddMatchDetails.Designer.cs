namespace MatchReporter.Forms.Data.Add
{
    partial class FrmAddMatchDetails
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblLeague = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHall = new System.Windows.Forms.Label();
            this.lblRefereePair = new System.Windows.Forms.Label();
            this.lblScorer = new System.Windows.Forms.Label();
            this.lblSpectators = new System.Windows.Forms.Label();
            this.lblDelegate = new System.Windows.Forms.Label();
            this.lblTimeKeeper = new System.Windows.Forms.Label();
            this.cbxLeague = new System.Windows.Forms.ComboBox();
            this.leagueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxHall = new System.Windows.Forms.ComboBox();
            this.hallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxRefereePair = new System.Windows.Forms.ComboBox();
            this.refereePairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxDelegate = new System.Windows.Forms.ComboBox();
            this.delegateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.txtScorer = new System.Windows.Forms.TextBox();
            this.txtTimeKeeper = new System.Windows.Forms.TextBox();
            this.txtSpectators = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.leagueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refereePairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delegateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpectators)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(438, 198);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblLeague
            // 
            this.lblLeague.AutoSize = true;
            this.lblLeague.Location = new System.Drawing.Point(54, 32);
            this.lblLeague.Name = "lblLeague";
            this.lblLeague.Size = new System.Drawing.Size(30, 13);
            this.lblLeague.TabIndex = 2;
            this.lblLeague.Text = "Liga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum i vrijeme:";
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.Location = new System.Drawing.Point(33, 72);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(51, 13);
            this.lblHall.TabIndex = 4;
            this.lblHall.Text = "Dvorana:";
            // 
            // lblRefereePair
            // 
            this.lblRefereePair.AutoSize = true;
            this.lblRefereePair.Location = new System.Drawing.Point(17, 111);
            this.lblRefereePair.Name = "lblRefereePair";
            this.lblRefereePair.Size = new System.Drawing.Size(67, 13);
            this.lblRefereePair.TabIndex = 5;
            this.lblRefereePair.Text = "Sudački par:";
            // 
            // lblScorer
            // 
            this.lblScorer.AutoSize = true;
            this.lblScorer.Location = new System.Drawing.Point(27, 151);
            this.lblScorer.Name = "lblScorer";
            this.lblScorer.Size = new System.Drawing.Size(56, 13);
            this.lblScorer.TabIndex = 6;
            this.lblScorer.Text = "Zapisničar";
            // 
            // lblSpectators
            // 
            this.lblSpectators.AutoSize = true;
            this.lblSpectators.Location = new System.Drawing.Point(278, 72);
            this.lblSpectators.Name = "lblSpectators";
            this.lblSpectators.Size = new System.Drawing.Size(76, 13);
            this.lblSpectators.TabIndex = 9;
            this.lblSpectators.Text = "Broj gledatelja:";
            // 
            // lblDelegate
            // 
            this.lblDelegate.AutoSize = true;
            this.lblDelegate.Location = new System.Drawing.Point(296, 112);
            this.lblDelegate.Name = "lblDelegate";
            this.lblDelegate.Size = new System.Drawing.Size(58, 13);
            this.lblDelegate.TabIndex = 10;
            this.lblDelegate.Text = "Nadzornik:";
            // 
            // lblTimeKeeper
            // 
            this.lblTimeKeeper.AutoSize = true;
            this.lblTimeKeeper.Location = new System.Drawing.Point(265, 151);
            this.lblTimeKeeper.Name = "lblTimeKeeper";
            this.lblTimeKeeper.Size = new System.Drawing.Size(89, 13);
            this.lblTimeKeeper.TabIndex = 11;
            this.lblTimeKeeper.Text = "Mjeritelj vremena:";
            // 
            // cbxLeague
            // 
            this.cbxLeague.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.leagueBindingSource, "LeagueId", true));
            this.cbxLeague.DataSource = this.leagueBindingSource;
            this.cbxLeague.DisplayMember = "Name";
            this.cbxLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLeague.FormattingEnabled = true;
            this.cbxLeague.Location = new System.Drawing.Point(89, 28);
            this.cbxLeague.Name = "cbxLeague";
            this.cbxLeague.Size = new System.Drawing.Size(153, 21);
            this.cbxLeague.TabIndex = 12;
            this.cbxLeague.ValueMember = "LeagueId";
            // 
            // leagueBindingSource
            // 
            this.leagueBindingSource.DataSource = typeof(MatchReporter.League);
            // 
            // cbxHall
            // 
            this.cbxHall.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hallBindingSource, "HallId", true));
            this.cbxHall.DataSource = this.hallBindingSource;
            this.cbxHall.DisplayMember = "Name";
            this.cbxHall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHall.FormattingEnabled = true;
            this.cbxHall.Location = new System.Drawing.Point(89, 68);
            this.cbxHall.Name = "cbxHall";
            this.cbxHall.Size = new System.Drawing.Size(154, 21);
            this.cbxHall.TabIndex = 13;
            this.cbxHall.ValueMember = "HallId";
            // 
            // hallBindingSource
            // 
            this.hallBindingSource.DataSource = typeof(MatchReporter.Hall);
            // 
            // cbxRefereePair
            // 
            this.cbxRefereePair.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.refereePairBindingSource, "RefereePairId", true));
            this.cbxRefereePair.DataSource = this.refereePairBindingSource;
            this.cbxRefereePair.DisplayMember = "RefereePairName";
            this.cbxRefereePair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRefereePair.FormattingEnabled = true;
            this.cbxRefereePair.Location = new System.Drawing.Point(89, 108);
            this.cbxRefereePair.Name = "cbxRefereePair";
            this.cbxRefereePair.Size = new System.Drawing.Size(153, 21);
            this.cbxRefereePair.TabIndex = 14;
            this.cbxRefereePair.ValueMember = "RefereePairId";
            // 
            // refereePairBindingSource
            // 
            this.refereePairBindingSource.DataSource = typeof(MatchReporter.RefereePair);
            // 
            // cbxDelegate
            // 
            this.cbxDelegate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.delegateBindingSource, "DelegateId", true));
            this.cbxDelegate.DataSource = this.delegateBindingSource;
            this.cbxDelegate.DisplayMember = "FullName";
            this.cbxDelegate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDelegate.FormattingEnabled = true;
            this.cbxDelegate.Location = new System.Drawing.Point(360, 109);
            this.cbxDelegate.Name = "cbxDelegate";
            this.cbxDelegate.Size = new System.Drawing.Size(153, 21);
            this.cbxDelegate.TabIndex = 15;
            this.cbxDelegate.ValueMember = "DelegateId";
            // 
            // delegateBindingSource
            // 
            this.delegateBindingSource.DataSource = typeof(MatchReporter.Delegate);
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "dd.MM.yyyy., HH:mm";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(360, 29);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(153, 20);
            this.dtpDateTime.TabIndex = 16;
            // 
            // txtScorer
            // 
            this.txtScorer.Location = new System.Drawing.Point(89, 148);
            this.txtScorer.Name = "txtScorer";
            this.txtScorer.Size = new System.Drawing.Size(154, 20);
            this.txtScorer.TabIndex = 17;
            // 
            // txtTimeKeeper
            // 
            this.txtTimeKeeper.Location = new System.Drawing.Point(360, 148);
            this.txtTimeKeeper.Name = "txtTimeKeeper";
            this.txtTimeKeeper.Size = new System.Drawing.Size(153, 20);
            this.txtTimeKeeper.TabIndex = 18;
            // 
            // txtSpectators
            // 
            this.txtSpectators.Location = new System.Drawing.Point(360, 69);
            this.txtSpectators.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.txtSpectators.Name = "txtSpectators";
            this.txtSpectators.Size = new System.Drawing.Size(153, 20);
            this.txtSpectators.TabIndex = 19;
            // 
            // FrmAddMatchDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 244);
            this.Controls.Add(this.txtSpectators);
            this.Controls.Add(this.txtTimeKeeper);
            this.Controls.Add(this.txtScorer);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.cbxDelegate);
            this.Controls.Add(this.cbxRefereePair);
            this.Controls.Add(this.cbxHall);
            this.Controls.Add(this.cbxLeague);
            this.Controls.Add(this.lblTimeKeeper);
            this.Controls.Add(this.lblDelegate);
            this.Controls.Add(this.lblSpectators);
            this.Controls.Add(this.lblScorer);
            this.Controls.Add(this.lblRefereePair);
            this.Controls.Add(this.lblHall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLeague);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddMatchDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Podaci o utakmici";
            ((System.ComponentModel.ISupportInitialize)(this.leagueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refereePairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delegateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpectators)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblLeague;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Label lblRefereePair;
        private System.Windows.Forms.Label lblScorer;
        private System.Windows.Forms.Label lblSpectators;
        private System.Windows.Forms.Label lblDelegate;
        private System.Windows.Forms.Label lblTimeKeeper;
        private System.Windows.Forms.ComboBox cbxLeague;
        private System.Windows.Forms.ComboBox cbxHall;
        private System.Windows.Forms.ComboBox cbxRefereePair;
        private System.Windows.Forms.ComboBox cbxDelegate;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.TextBox txtScorer;
        private System.Windows.Forms.TextBox txtTimeKeeper;
        private System.Windows.Forms.NumericUpDown txtSpectators;
        private System.Windows.Forms.BindingSource leagueBindingSource;
        private System.Windows.Forms.BindingSource hallBindingSource;
        private System.Windows.Forms.BindingSource delegateBindingSource;
        private System.Windows.Forms.BindingSource refereePairBindingSource;
    }
}