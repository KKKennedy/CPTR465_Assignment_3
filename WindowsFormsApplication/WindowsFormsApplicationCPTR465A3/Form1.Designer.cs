namespace WindowsFormsApplicationCPTR465A3
{
    partial class baseForm
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.TabPageAddClient = new System.Windows.Forms.TabPage();
            this.ButtonAddRecord = new System.Windows.Forms.Button();
            this.ComboBoxAccount = new System.Windows.Forms.ComboBox();
            this.TextBoxBalance = new System.Windows.Forms.TextBox();
            this.TextBoxBranch = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.TextBoxTRN = new System.Windows.Forms.TextBox();
            this.LabelBalance = new System.Windows.Forms.Label();
            this.LabelAccountType = new System.Windows.Forms.Label();
            this.LabelBranch = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelTRN = new System.Windows.Forms.Label();
            this.tabPageGetSingleClient = new System.Windows.Forms.TabPage();
            this.DataGridViewSingleRecord = new System.Windows.Forms.DataGridView();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxTRNSearch = new System.Windows.Forms.TextBox();
            this.LabelTRNSearch = new System.Windows.Forms.Label();
            this.TabPageGetAllClients = new System.Windows.Forms.TabPage();
            this.DataGridViewAllRecords = new System.Windows.Forms.DataGridView();
            this.ButtonShowAllClients = new System.Windows.Forms.Button();
            this.TabPageDeleteClient = new System.Windows.Forms.TabPage();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxTRNDelete = new System.Windows.Forms.TextBox();
            this.LabelDeleteTRN = new System.Windows.Forms.Label();
            this.LabelDeleteTitle = new System.Windows.Forms.Label();
            this.TRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMain.SuspendLayout();
            this.TabPageAddClient.SuspendLayout();
            this.tabPageGetSingleClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSingleRecord)).BeginInit();
            this.TabPageGetAllClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAllRecords)).BeginInit();
            this.TabPageDeleteClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.TabPageAddClient);
            this.tabControlMain.Controls.Add(this.tabPageGetSingleClient);
            this.tabControlMain.Controls.Add(this.TabPageGetAllClients);
            this.tabControlMain.Controls.Add(this.TabPageDeleteClient);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(980, 618);
            this.tabControlMain.TabIndex = 0;
            // 
            // TabPageAddClient
            // 
            this.TabPageAddClient.Controls.Add(this.ButtonAddRecord);
            this.TabPageAddClient.Controls.Add(this.ComboBoxAccount);
            this.TabPageAddClient.Controls.Add(this.TextBoxBalance);
            this.TabPageAddClient.Controls.Add(this.TextBoxBranch);
            this.TabPageAddClient.Controls.Add(this.TextBoxLastName);
            this.TabPageAddClient.Controls.Add(this.TextBoxFirstName);
            this.TabPageAddClient.Controls.Add(this.TextBoxTRN);
            this.TabPageAddClient.Controls.Add(this.LabelBalance);
            this.TabPageAddClient.Controls.Add(this.LabelAccountType);
            this.TabPageAddClient.Controls.Add(this.LabelBranch);
            this.TabPageAddClient.Controls.Add(this.LabelLastName);
            this.TabPageAddClient.Controls.Add(this.LabelFirstName);
            this.TabPageAddClient.Controls.Add(this.LabelTRN);
            this.TabPageAddClient.Location = new System.Drawing.Point(4, 22);
            this.TabPageAddClient.Name = "TabPageAddClient";
            this.TabPageAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAddClient.Size = new System.Drawing.Size(972, 592);
            this.TabPageAddClient.TabIndex = 0;
            this.TabPageAddClient.Text = "Add Client";
            this.TabPageAddClient.UseVisualStyleBackColor = true;
            // 
            // ButtonAddRecord
            // 
            this.ButtonAddRecord.Location = new System.Drawing.Point(304, 446);
            this.ButtonAddRecord.Name = "ButtonAddRecord";
            this.ButtonAddRecord.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddRecord.TabIndex = 13;
            this.ButtonAddRecord.Text = "Add Record";
            this.ButtonAddRecord.UseVisualStyleBackColor = true;
            this.ButtonAddRecord.Click += new System.EventHandler(this.ButtonAddRecord_Click);
            // 
            // ComboBoxAccount
            // 
            this.ComboBoxAccount.FormattingEnabled = true;
            this.ComboBoxAccount.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.ComboBoxAccount.Location = new System.Drawing.Point(272, 311);
            this.ComboBoxAccount.Name = "ComboBoxAccount";
            this.ComboBoxAccount.Size = new System.Drawing.Size(137, 21);
            this.ComboBoxAccount.TabIndex = 12;
            this.ComboBoxAccount.Text = "Select Account Type:";
            // 
            // TextBoxBalance
            // 
            this.TextBoxBalance.Location = new System.Drawing.Point(274, 374);
            this.TextBoxBalance.Name = "TextBoxBalance";
            this.TextBoxBalance.Size = new System.Drawing.Size(135, 20);
            this.TextBoxBalance.TabIndex = 11;
            // 
            // TextBoxBranch
            // 
            this.TextBoxBranch.Location = new System.Drawing.Point(272, 253);
            this.TextBoxBranch.Name = "TextBoxBranch";
            this.TextBoxBranch.Size = new System.Drawing.Size(137, 20);
            this.TextBoxBranch.TabIndex = 9;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(272, 186);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(137, 20);
            this.TextBoxLastName.TabIndex = 8;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(272, 126);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(137, 20);
            this.TextBoxFirstName.TabIndex = 7;
            // 
            // TextBoxTRN
            // 
            this.TextBoxTRN.Location = new System.Drawing.Point(274, 78);
            this.TextBoxTRN.Name = "TextBoxTRN";
            this.TextBoxTRN.Size = new System.Drawing.Size(135, 20);
            this.TextBoxTRN.TabIndex = 6;
            // 
            // LabelBalance
            // 
            this.LabelBalance.AutoSize = true;
            this.LabelBalance.Location = new System.Drawing.Point(190, 377);
            this.LabelBalance.Name = "LabelBalance";
            this.LabelBalance.Size = new System.Drawing.Size(49, 13);
            this.LabelBalance.TabIndex = 5;
            this.LabelBalance.Text = "Balance:";
            // 
            // LabelAccountType
            // 
            this.LabelAccountType.AutoSize = true;
            this.LabelAccountType.Location = new System.Drawing.Point(190, 314);
            this.LabelAccountType.Name = "LabelAccountType";
            this.LabelAccountType.Size = new System.Drawing.Size(50, 13);
            this.LabelAccountType.TabIndex = 4;
            this.LabelAccountType.Text = "Account:";
            // 
            // LabelBranch
            // 
            this.LabelBranch.AutoSize = true;
            this.LabelBranch.Location = new System.Drawing.Point(190, 256);
            this.LabelBranch.Name = "LabelBranch";
            this.LabelBranch.Size = new System.Drawing.Size(47, 13);
            this.LabelBranch.TabIndex = 3;
            this.LabelBranch.Text = "Branch: ";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(190, 189);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(61, 13);
            this.LabelLastName.TabIndex = 2;
            this.LabelLastName.Text = "Last Name:";
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(190, 129);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(60, 13);
            this.LabelFirstName.TabIndex = 1;
            this.LabelFirstName.Text = "First Name:";
            // 
            // LabelTRN
            // 
            this.LabelTRN.AutoSize = true;
            this.LabelTRN.Location = new System.Drawing.Point(190, 78);
            this.LabelTRN.Name = "LabelTRN";
            this.LabelTRN.Size = new System.Drawing.Size(43, 13);
            this.LabelTRN.TabIndex = 0;
            this.LabelTRN.Text = "TRN #:";
            // 
            // tabPageGetSingleClient
            // 
            this.tabPageGetSingleClient.Controls.Add(this.DataGridViewSingleRecord);
            this.tabPageGetSingleClient.Controls.Add(this.ButtonSearch);
            this.tabPageGetSingleClient.Controls.Add(this.TextBoxTRNSearch);
            this.tabPageGetSingleClient.Controls.Add(this.LabelTRNSearch);
            this.tabPageGetSingleClient.Location = new System.Drawing.Point(4, 22);
            this.tabPageGetSingleClient.Name = "tabPageGetSingleClient";
            this.tabPageGetSingleClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGetSingleClient.Size = new System.Drawing.Size(972, 592);
            this.tabPageGetSingleClient.TabIndex = 1;
            this.tabPageGetSingleClient.Text = "Get Single Client";
            this.tabPageGetSingleClient.UseVisualStyleBackColor = true;
            // 
            // DataGridViewSingleRecord
            // 
            this.DataGridViewSingleRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSingleRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TRN,
            this.FirstName,
            this.LastName,
            this.Branch,
            this.AccountType,
            this.CurrentBalance});
            this.DataGridViewSingleRecord.Location = new System.Drawing.Point(158, 148);
            this.DataGridViewSingleRecord.Name = "DataGridViewSingleRecord";
            this.DataGridViewSingleRecord.Size = new System.Drawing.Size(644, 165);
            this.DataGridViewSingleRecord.TabIndex = 3;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(710, 86);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxTRNSearch
            // 
            this.TextBoxTRNSearch.Location = new System.Drawing.Point(217, 86);
            this.TextBoxTRNSearch.Name = "TextBoxTRNSearch";
            this.TextBoxTRNSearch.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTRNSearch.TabIndex = 1;
            // 
            // LabelTRNSearch
            // 
            this.LabelTRNSearch.AutoSize = true;
            this.LabelTRNSearch.Location = new System.Drawing.Point(168, 88);
            this.LabelTRNSearch.Name = "LabelTRNSearch";
            this.LabelTRNSearch.Size = new System.Drawing.Size(43, 13);
            this.LabelTRNSearch.TabIndex = 0;
            this.LabelTRNSearch.Text = "TRN #:";
            // 
            // TabPageGetAllClients
            // 
            this.TabPageGetAllClients.Controls.Add(this.DataGridViewAllRecords);
            this.TabPageGetAllClients.Controls.Add(this.ButtonShowAllClients);
            this.TabPageGetAllClients.Location = new System.Drawing.Point(4, 22);
            this.TabPageGetAllClients.Name = "TabPageGetAllClients";
            this.TabPageGetAllClients.Size = new System.Drawing.Size(972, 592);
            this.TabPageGetAllClients.TabIndex = 2;
            this.TabPageGetAllClients.Text = "Get All Clients";
            this.TabPageGetAllClients.UseVisualStyleBackColor = true;
            // 
            // DataGridViewAllRecords
            // 
            this.DataGridViewAllRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAllRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.DataGridViewAllRecords.Location = new System.Drawing.Point(156, 137);
            this.DataGridViewAllRecords.Name = "DataGridViewAllRecords";
            this.DataGridViewAllRecords.Size = new System.Drawing.Size(644, 209);
            this.DataGridViewAllRecords.TabIndex = 1;
            // 
            // ButtonShowAllClients
            // 
            this.ButtonShowAllClients.Location = new System.Drawing.Point(156, 82);
            this.ButtonShowAllClients.Name = "ButtonShowAllClients";
            this.ButtonShowAllClients.Size = new System.Drawing.Size(99, 23);
            this.ButtonShowAllClients.TabIndex = 0;
            this.ButtonShowAllClients.Text = "Show All Clients";
            this.ButtonShowAllClients.UseVisualStyleBackColor = true;
            this.ButtonShowAllClients.Click += new System.EventHandler(this.ButtonShowAllClients_Click);
            // 
            // TabPageDeleteClient
            // 
            this.TabPageDeleteClient.Controls.Add(this.ButtonDelete);
            this.TabPageDeleteClient.Controls.Add(this.TextBoxTRNDelete);
            this.TabPageDeleteClient.Controls.Add(this.LabelDeleteTRN);
            this.TabPageDeleteClient.Controls.Add(this.LabelDeleteTitle);
            this.TabPageDeleteClient.Location = new System.Drawing.Point(4, 22);
            this.TabPageDeleteClient.Name = "TabPageDeleteClient";
            this.TabPageDeleteClient.Size = new System.Drawing.Size(972, 592);
            this.TabPageDeleteClient.TabIndex = 3;
            this.TabPageDeleteClient.Text = "Delete Client";
            this.TabPageDeleteClient.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(288, 82);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxTRNDelete
            // 
            this.TextBoxTRNDelete.Location = new System.Drawing.Point(151, 82);
            this.TextBoxTRNDelete.Name = "TextBoxTRNDelete";
            this.TextBoxTRNDelete.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTRNDelete.TabIndex = 2;
            // 
            // LabelDeleteTRN
            // 
            this.LabelDeleteTRN.AutoSize = true;
            this.LabelDeleteTRN.Location = new System.Drawing.Point(85, 82);
            this.LabelDeleteTRN.Name = "LabelDeleteTRN";
            this.LabelDeleteTRN.Size = new System.Drawing.Size(43, 13);
            this.LabelDeleteTRN.TabIndex = 1;
            this.LabelDeleteTRN.Text = "TRN #:";
            // 
            // LabelDeleteTitle
            // 
            this.LabelDeleteTitle.AutoSize = true;
            this.LabelDeleteTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeleteTitle.Location = new System.Drawing.Point(147, 38);
            this.LabelDeleteTitle.Name = "LabelDeleteTitle";
            this.LabelDeleteTitle.Size = new System.Drawing.Size(261, 19);
            this.LabelDeleteTitle.TabIndex = 0;
            this.LabelDeleteTitle.Text = "SELECT CLIENT TO BE DELETED";
            // 
            // TRN
            // 
            this.TRN.HeaderText = "TRN #";
            this.TRN.Name = "TRN";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // Branch
            // 
            this.Branch.HeaderText = "Branch";
            this.Branch.Name = "Branch";
            // 
            // AccountType
            // 
            this.AccountType.HeaderText = "Account Type";
            this.AccountType.Name = "AccountType";
            // 
            // CurrentBalance
            // 
            this.CurrentBalance.HeaderText = "Current Balance";
            this.CurrentBalance.Name = "CurrentBalance";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "TRN #";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Branch";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Account Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Current Balance";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // baseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 642);
            this.Controls.Add(this.tabControlMain);
            this.Name = "baseForm";
            this.Text = "Mitchell \'s Commercial Bank";
            this.tabControlMain.ResumeLayout(false);
            this.TabPageAddClient.ResumeLayout(false);
            this.TabPageAddClient.PerformLayout();
            this.tabPageGetSingleClient.ResumeLayout(false);
            this.tabPageGetSingleClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSingleRecord)).EndInit();
            this.TabPageGetAllClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAllRecords)).EndInit();
            this.TabPageDeleteClient.ResumeLayout(false);
            this.TabPageDeleteClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage TabPageAddClient;
        private System.Windows.Forms.Button ButtonAddRecord;
        private System.Windows.Forms.ComboBox ComboBoxAccount;
        private System.Windows.Forms.TextBox TextBoxBalance;
        private System.Windows.Forms.TextBox TextBoxBranch;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.TextBox TextBoxTRN;
        private System.Windows.Forms.Label LabelBalance;
        private System.Windows.Forms.Label LabelAccountType;
        private System.Windows.Forms.Label LabelBranch;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelTRN;
        private System.Windows.Forms.TabPage tabPageGetSingleClient;
        private System.Windows.Forms.DataGridView DataGridViewSingleRecord;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxTRNSearch;
        private System.Windows.Forms.Label LabelTRNSearch;
        private System.Windows.Forms.TabPage TabPageGetAllClients;
        private System.Windows.Forms.DataGridView DataGridViewAllRecords;
        private System.Windows.Forms.Button ButtonShowAllClients;
        private System.Windows.Forms.TabPage TabPageDeleteClient;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TextBoxTRNDelete;
        private System.Windows.Forms.Label LabelDeleteTRN;
        private System.Windows.Forms.Label LabelDeleteTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

