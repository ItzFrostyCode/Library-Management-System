namespace Library_Management_System
{
    partial class TransactionForm
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
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.BorrowerBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeBorrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDateTimeReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonTransactionForm = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGroup2 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelGroup1 = new System.Windows.Forms.Panel();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelGroup2.SuspendLayout();
            this.panelGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorrowerBookID,
            this.UserID,
            this.FullName,
            this.DateTimeBorrow,
            this.DueDateTimeReturn});
            this.dataGridViewTransactions.Location = new System.Drawing.Point(211, 164);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.Size = new System.Drawing.Size(842, 412);
            this.dataGridViewTransactions.TabIndex = 0;
            // 
            // BorrowerBookID
            // 
            this.BorrowerBookID.HeaderText = "BorrowerBookID";
            this.BorrowerBookID.Name = "BorrowerBookID";
            this.BorrowerBookID.ReadOnly = true;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 200;
            // 
            // DateTimeBorrow
            // 
            this.DateTimeBorrow.HeaderText = "DateTimeBorrow";
            this.DateTimeBorrow.Name = "DateTimeBorrow";
            this.DateTimeBorrow.ReadOnly = true;
            this.DateTimeBorrow.Width = 200;
            // 
            // DueDateTimeReturn
            // 
            this.DueDateTimeReturn.HeaderText = "DueDateTimeReturn";
            this.DueDateTimeReturn.Name = "DueDateTimeReturn";
            this.DueDateTimeReturn.ReadOnly = true;
            this.DueDateTimeReturn.Width = 200;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.buttonTransactionForm);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panelGroup2);
            this.panelMain.Controls.Add(this.panelGroup1);
            this.panelMain.Location = new System.Drawing.Point(11, 45);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1242, 68);
            this.panelMain.TabIndex = 55;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // buttonTransactionForm
            // 
            this.buttonTransactionForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonTransactionForm.BackgroundImage = global::Library_Management_System.Properties.Resources.buttonTransactionActive;
            this.buttonTransactionForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonTransactionForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionForm.Location = new System.Drawing.Point(457, 11);
            this.buttonTransactionForm.Name = "buttonTransactionForm";
            this.buttonTransactionForm.Size = new System.Drawing.Size(67, 50);
            this.buttonTransactionForm.TabIndex = 11;
            this.buttonTransactionForm.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.panel3.Location = new System.Drawing.Point(1032, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 50);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.panel2.Location = new System.Drawing.Point(449, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 50);
            this.panel2.TabIndex = 2;
            // 
            // panelGroup2
            // 
            this.panelGroup2.Controls.Add(this.buttonLogout);
            this.panelGroup2.Controls.Add(this.buttonSettings);
            this.panelGroup2.Location = new System.Drawing.Point(1042, 11);
            this.panelGroup2.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.panelGroup2.Name = "panelGroup2";
            this.panelGroup2.Size = new System.Drawing.Size(182, 50);
            this.panelGroup2.TabIndex = 10;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.BackgroundImage = global::Library_Management_System.Properties.Resources.LogoutIconDefault;
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(110, 0);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(67, 50);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BackgroundImage = global::Library_Management_System.Properties.Resources.SettingsIconDefault;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(23, 0);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(67, 50);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.UseVisualStyleBackColor = false;
            // 
            // panelGroup1
            // 
            this.panelGroup1.Controls.Add(this.buttonReturn);
            this.panelGroup1.Controls.Add(this.buttonBorrow);
            this.panelGroup1.Controls.Add(this.buttonBooks);
            this.panelGroup1.Controls.Add(this.buttonUsers);
            this.panelGroup1.Controls.Add(this.buttonHome);
            this.panelGroup1.Location = new System.Drawing.Point(25, 11);
            this.panelGroup1.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.panelGroup1.Name = "panelGroup1";
            this.panelGroup1.Size = new System.Drawing.Size(416, 50);
            this.panelGroup1.TabIndex = 1;
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.BackgroundImage = global::Library_Management_System.Properties.Resources.ReturnIconDefault;
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Location = new System.Drawing.Point(348, 0);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(67, 50);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.BackColor = System.Drawing.Color.Transparent;
            this.buttonBorrow.BackgroundImage = global::Library_Management_System.Properties.Resources.ButtonBorrowDefault;
            this.buttonBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrow.Location = new System.Drawing.Point(261, 0);
            this.buttonBorrow.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(67, 50);
            this.buttonBorrow.TabIndex = 5;
            this.buttonBorrow.UseVisualStyleBackColor = false;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackColor = System.Drawing.Color.Transparent;
            this.buttonBooks.BackgroundImage = global::Library_Management_System.Properties.Resources.BooksIconDefault;
            this.buttonBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooks.Location = new System.Drawing.Point(174, 0);
            this.buttonBooks.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(67, 50);
            this.buttonBooks.TabIndex = 4;
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.Transparent;
            this.buttonUsers.BackgroundImage = global::Library_Management_System.Properties.Resources.UserIconDefault;
            this.buttonUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Location = new System.Drawing.Point(87, 0);
            this.buttonUsers.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(67, 50);
            this.buttonUsers.TabIndex = 3;
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.BackgroundImage = global::Library_Management_System.Properties.Resources.HomeIconDefault;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(67, 50);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Library_Management_System.Properties.Resources.PageTransaction;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(480, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 36);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.dataGridViewTransactions);
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelGroup2.ResumeLayout(false);
            this.panelGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowerBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDateTimeReturn;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonTransactionForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelGroup2;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelGroup1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}