namespace Library_Management_System
{
    partial class Return
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGroup2 = new System.Windows.Forms.Panel();
            this.panelGroup1 = new System.Windows.Forms.Panel();
            this.dataGridViewBorrower = new System.Windows.Forms.DataGridView();
            this.BorrowerBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeBorrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDateTimeReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBorrowerID = new System.Windows.Forms.TextBox();
            this.panelUserDetails = new System.Windows.Forms.Panel();
            this.labelQtyBorrow = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelBookID = new System.Windows.Forms.Panel();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxBorrowBooks = new System.Windows.Forms.ListBox();
            this.buttonReturnBooks = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDecrementQty = new System.Windows.Forms.Button();
            this.buttonIncrementQty = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTransactionForm = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelGroup2.SuspendLayout();
            this.panelGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrower)).BeginInit();
            this.panelUserDetails.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelBookID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint_1);
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
            // dataGridViewBorrower
            // 
            this.dataGridViewBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorrowerBookID,
            this.UserID,
            this.FullName,
            this.DateTimeBorrow,
            this.DueDateTimeReturn,
            this.Status});
            this.dataGridViewBorrower.Location = new System.Drawing.Point(11, 196);
            this.dataGridViewBorrower.Name = "dataGridViewBorrower";
            this.dataGridViewBorrower.Size = new System.Drawing.Size(733, 446);
            this.dataGridViewBorrower.TabIndex = 57;
            this.dataGridViewBorrower.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBorrower_CellClick);
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
            // 
            // DateTimeBorrow
            // 
            this.DateTimeBorrow.HeaderText = "DateTimeBorrow";
            this.DateTimeBorrow.Name = "DateTimeBorrow";
            this.DateTimeBorrow.ReadOnly = true;
            // 
            // DueDateTimeReturn
            // 
            this.DueDateTimeReturn.HeaderText = "DueDateTimeReturn";
            this.DueDateTimeReturn.Name = "DueDateTimeReturn";
            this.DueDateTimeReturn.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // textBoxBorrowerID
            // 
            this.textBoxBorrowerID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxBorrowerID.Location = new System.Drawing.Point(11, 147);
            this.textBoxBorrowerID.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxBorrowerID.Name = "textBoxBorrowerID";
            this.textBoxBorrowerID.Size = new System.Drawing.Size(164, 29);
            this.textBoxBorrowerID.TabIndex = 59;
            this.textBoxBorrowerID.Text = "Search";
            // 
            // panelUserDetails
            // 
            this.panelUserDetails.Controls.Add(this.labelQtyBorrow);
            this.panelUserDetails.Controls.Add(this.buttonDecrementQty);
            this.panelUserDetails.Controls.Add(this.buttonIncrementQty);
            this.panelUserDetails.Controls.Add(this.panel7);
            this.panelUserDetails.Controls.Add(this.listBoxBorrowBooks);
            this.panelUserDetails.Controls.Add(this.buttonReturnBooks);
            this.panelUserDetails.Controls.Add(this.label10);
            this.panelUserDetails.Controls.Add(this.labelContactNumber);
            this.panelUserDetails.Controls.Add(this.labelEmailAddress);
            this.panelUserDetails.Controls.Add(this.labelFullName);
            this.panelUserDetails.Controls.Add(this.labelUserID);
            this.panelUserDetails.Controls.Add(this.pictureBoxUser);
            this.panelUserDetails.Controls.Add(this.label7);
            this.panelUserDetails.Controls.Add(this.label6);
            this.panelUserDetails.Controls.Add(this.label5);
            this.panelUserDetails.Controls.Add(this.label4);
            this.panelUserDetails.Controls.Add(this.label3);
            this.panelUserDetails.Location = new System.Drawing.Point(750, 196);
            this.panelUserDetails.Name = "panelUserDetails";
            this.panelUserDetails.Size = new System.Drawing.Size(500, 446);
            this.panelUserDetails.TabIndex = 63;
            this.panelUserDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUserDetails_Paint);
            // 
            // labelQtyBorrow
            // 
            this.labelQtyBorrow.AutoSize = true;
            this.labelQtyBorrow.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtyBorrow.Location = new System.Drawing.Point(296, 387);
            this.labelQtyBorrow.Name = "labelQtyBorrow";
            this.labelQtyBorrow.Size = new System.Drawing.Size(32, 37);
            this.labelQtyBorrow.TabIndex = 96;
            this.labelQtyBorrow.Text = "1";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.panelBookID);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(14, 361);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(214, 63);
            this.panel7.TabIndex = 93;
            // 
            // panelBookID
            // 
            this.panelBookID.Controls.Add(this.textBoxBookID);
            this.panelBookID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBookID.Location = new System.Drawing.Point(0, 24);
            this.panelBookID.Name = "panelBookID";
            this.panelBookID.Size = new System.Drawing.Size(214, 39);
            this.panelBookID.TabIndex = 1;
            this.panelBookID.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBookID_Paint);
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.textBoxBookID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBookID.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookID.ForeColor = System.Drawing.Color.Gray;
            this.textBoxBookID.Location = new System.Drawing.Point(15, 9);
            this.textBoxBookID.Margin = new System.Windows.Forms.Padding(15, 9, 15, 3);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(184, 21);
            this.textBoxBookID.TabIndex = 0;
            this.textBoxBookID.Text = "Enter Book ID to Return";
            this.textBoxBookID.Enter += new System.EventHandler(this.textBoxBookID_Enter);
            this.textBoxBookID.Leave += new System.EventHandler(this.textBoxBookID_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "BookID*";
            // 
            // listBoxBorrowBooks
            // 
            this.listBoxBorrowBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBorrowBooks.FormattingEnabled = true;
            this.listBoxBorrowBooks.ItemHeight = 21;
            this.listBoxBorrowBooks.Location = new System.Drawing.Point(14, 176);
            this.listBoxBorrowBooks.Name = "listBoxBorrowBooks";
            this.listBoxBorrowBooks.Size = new System.Drawing.Size(468, 172);
            this.listBoxBorrowBooks.TabIndex = 92;
            // 
            // buttonReturnBooks
            // 
            this.buttonReturnBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonReturnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnBooks.ForeColor = System.Drawing.Color.White;
            this.buttonReturnBooks.Location = new System.Drawing.Point(387, 385);
            this.buttonReturnBooks.Margin = new System.Windows.Forms.Padding(3, 10, 0, 3);
            this.buttonReturnBooks.Name = "buttonReturnBooks";
            this.buttonReturnBooks.Size = new System.Drawing.Size(95, 35);
            this.buttonReturnBooks.TabIndex = 90;
            this.buttonReturnBooks.Text = "Return";
            this.buttonReturnBooks.UseVisualStyleBackColor = false;
            this.buttonReturnBooks.Click += new System.EventHandler(this.buttonReturnBooks_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 25);
            this.label10.TabIndex = 89;
            this.label10.Text = "Borrowed Books List";
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactNumber.Location = new System.Drawing.Point(152, 108);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(0, 21);
            this.labelContactNumber.TabIndex = 73;
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailAddress.Location = new System.Drawing.Point(68, 83);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(0, 21);
            this.labelEmailAddress.TabIndex = 72;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(106, 58);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(0, 21);
            this.labelFullName.TabIndex = 71;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(46, 33);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(0, 21);
            this.labelUserID.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 67;
            this.label7.Text = "Contact Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 66;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 65;
            this.label5.Text = "Full Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "User Details";
            // 
            // buttonDecrementQty
            // 
            this.buttonDecrementQty.BackgroundImage = global::Library_Management_System.Properties.Resources.decrement;
            this.buttonDecrementQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDecrementQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecrementQty.Location = new System.Drawing.Point(261, 390);
            this.buttonDecrementQty.Name = "buttonDecrementQty";
            this.buttonDecrementQty.Size = new System.Drawing.Size(29, 30);
            this.buttonDecrementQty.TabIndex = 95;
            this.buttonDecrementQty.UseVisualStyleBackColor = true;
            this.buttonDecrementQty.Click += new System.EventHandler(this.buttonDecrementQty_Click);
            // 
            // buttonIncrementQty
            // 
            this.buttonIncrementQty.BackgroundImage = global::Library_Management_System.Properties.Resources.increment;
            this.buttonIncrementQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonIncrementQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncrementQty.Location = new System.Drawing.Point(334, 390);
            this.buttonIncrementQty.Name = "buttonIncrementQty";
            this.buttonIncrementQty.Size = new System.Drawing.Size(29, 30);
            this.buttonIncrementQty.TabIndex = 94;
            this.buttonIncrementQty.UseVisualStyleBackColor = true;
            this.buttonIncrementQty.Click += new System.EventHandler(this.buttonIncrementQty_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxUser.Location = new System.Drawing.Point(431, 10);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(61, 61);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUser.TabIndex = 69;
            this.pictureBoxUser.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::Library_Management_System.Properties.Resources.Search__24x24_;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(181, 147);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(29, 30);
            this.buttonSearch.TabIndex = 58;
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Library_Management_System.Properties.Resources.PageReturn;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(480, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 36);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTransactionForm
            // 
            this.buttonTransactionForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionForm.Image = global::Library_Management_System.Properties.Resources.TransactionIconDefault;
            this.buttonTransactionForm.Location = new System.Drawing.Point(457, 11);
            this.buttonTransactionForm.Name = "buttonTransactionForm";
            this.buttonTransactionForm.Size = new System.Drawing.Size(67, 50);
            this.buttonTransactionForm.TabIndex = 11;
            this.buttonTransactionForm.UseVisualStyleBackColor = true;
            this.buttonTransactionForm.Click += new System.EventHandler(this.buttonTransactionForm_Click);
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
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonReturn.BackgroundImage = global::Library_Management_System.Properties.Resources.ButtonReturnActive;
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Location = new System.Drawing.Point(348, 0);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(67, 50);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.UseVisualStyleBackColor = false;
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
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.panelUserDetails);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxBorrowerID);
            this.Controls.Add(this.dataGridViewBorrower);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMain);
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.panelMain.ResumeLayout(false);
            this.panelGroup2.ResumeLayout(false);
            this.panelGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrower)).EndInit();
            this.panelUserDetails.ResumeLayout(false);
            this.panelUserDetails.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelBookID.ResumeLayout(false);
            this.panelBookID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dataGridViewBorrower;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxBorrowerID;
        private System.Windows.Forms.Panel panelUserDetails;
        private System.Windows.Forms.ListBox listBoxBorrowBooks;
        private System.Windows.Forms.Button buttonReturnBooks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowerBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDateTimeReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label labelQtyBorrow;
        private System.Windows.Forms.Button buttonDecrementQty;
        private System.Windows.Forms.Button buttonIncrementQty;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelBookID;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.Label label8;
    }
}