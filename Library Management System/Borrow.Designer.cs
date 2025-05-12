namespace Library_Management_System
{
    partial class Borrow
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
            this.textBoxBooksSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFullName = new System.Windows.Forms.Panel();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUserDetails = new System.Windows.Forms.Panel();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelBookID = new System.Windows.Forms.Panel();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelQtyBorrow = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddBooksBorrow = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonBooksBorrowConfirmation = new System.Windows.Forms.Button();
            this.buttonClearBooksBorrowList = new System.Windows.Forms.Button();
            this.listBoxBorrowBooks = new System.Windows.Forms.ListBox();
            this.buttonDeleteBooksBorrow = new System.Windows.Forms.Button();
            this.buttonDecrementQty = new System.Windows.Forms.Button();
            this.buttonIncrementQty = new System.Windows.Forms.Button();
            this.pictureBoxBooks = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelFullName.SuspendLayout();
            this.panelUserDetails.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelBookID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooks)).BeginInit();
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
            this.panelMain.TabIndex = 54;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
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
            // textBoxBooksSearch
            // 
            this.textBoxBooksSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxBooksSearch.Location = new System.Drawing.Point(12, 126);
            this.textBoxBooksSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxBooksSearch.Name = "textBoxBooksSearch";
            this.textBoxBooksSearch.Size = new System.Drawing.Size(164, 29);
            this.textBoxBooksSearch.TabIndex = 57;
            this.textBoxBooksSearch.Text = "Search";
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.Title,
            this.Author,
            this.Genre,
            this.Quantity});
            this.dataGridViewBooks.Location = new System.Drawing.Point(11, 250);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(733, 446);
            this.dataGridViewBooks.TabIndex = 59;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 70;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 200;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 120;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panelFullName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(753, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 63);
            this.panel1.TabIndex = 60;
            // 
            // panelFullName
            // 
            this.panelFullName.Controls.Add(this.textBoxFullName);
            this.panelFullName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFullName.Location = new System.Drawing.Point(0, 24);
            this.panelFullName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panelFullName.Name = "panelFullName";
            this.panelFullName.Size = new System.Drawing.Size(500, 39);
            this.panelFullName.TabIndex = 1;
            this.panelFullName.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFullName_Paint);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.textBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFullName.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.textBoxFullName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFullName.Location = new System.Drawing.Point(15, 9);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(15, 9, 15, 3);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(445, 21);
            this.textBoxFullName.TabIndex = 0;
            this.textBoxFullName.Text = "First Name / Middle Initial / Last Name";
            this.textBoxFullName.Enter += new System.EventHandler(this.textBoxFullName_Enter);
            this.textBoxFullName.Leave += new System.EventHandler(this.textBoxFullName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Borrower Name*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 61;
            this.label1.Text = "Books List";
            // 
            // panelUserDetails
            // 
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
            this.panelUserDetails.Location = new System.Drawing.Point(753, 192);
            this.panelUserDetails.Name = "panelUserDetails";
            this.panelUserDetails.Size = new System.Drawing.Size(500, 145);
            this.panelUserDetails.TabIndex = 62;
            this.panelUserDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUserDetails_Paint);
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
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.panelBookID);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(753, 345);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(218, 63);
            this.panel7.TabIndex = 70;
            // 
            // panelBookID
            // 
            this.panelBookID.Controls.Add(this.textBoxBookID);
            this.panelBookID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBookID.Location = new System.Drawing.Point(0, 24);
            this.panelBookID.Name = "panelBookID";
            this.panelBookID.Size = new System.Drawing.Size(218, 39);
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
            this.textBoxBookID.Size = new System.Drawing.Size(188, 21);
            this.textBoxBookID.TabIndex = 0;
            this.textBoxBookID.Text = "Enter Book ID";
            this.textBoxBookID.Enter += new System.EventHandler(this.textBoxBookID_Enter);
            this.textBoxBookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBookID_KeyPress);
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
            // labelQtyBorrow
            // 
            this.labelQtyBorrow.AutoSize = true;
            this.labelQtyBorrow.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtyBorrow.Location = new System.Drawing.Point(1035, 375);
            this.labelQtyBorrow.Name = "labelQtyBorrow";
            this.labelQtyBorrow.Size = new System.Drawing.Size(32, 37);
            this.labelQtyBorrow.TabIndex = 73;
            this.labelQtyBorrow.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(979, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 17);
            this.label9.TabIndex = 74;
            this.label9.Text = "Only 3 QTY for 1 Book";
            // 
            // buttonAddBooksBorrow
            // 
            this.buttonAddBooksBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBooksBorrow.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBooksBorrow.Location = new System.Drawing.Point(1158, 350);
            this.buttonAddBooksBorrow.Margin = new System.Windows.Forms.Padding(3, 10, 0, 3);
            this.buttonAddBooksBorrow.Name = "buttonAddBooksBorrow";
            this.buttonAddBooksBorrow.Size = new System.Drawing.Size(95, 35);
            this.buttonAddBooksBorrow.TabIndex = 75;
            this.buttonAddBooksBorrow.Text = "Add";
            this.buttonAddBooksBorrow.UseVisualStyleBackColor = true;
            this.buttonAddBooksBorrow.Click += new System.EventHandler(this.buttonAddBooksBorrow_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(752, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 25);
            this.label10.TabIndex = 76;
            this.label10.Text = "Borrowed Books List";
            // 
            // buttonBooksBorrowConfirmation
            // 
            this.buttonBooksBorrowConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonBooksBorrowConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooksBorrowConfirmation.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooksBorrowConfirmation.ForeColor = System.Drawing.Color.White;
            this.buttonBooksBorrowConfirmation.Location = new System.Drawing.Point(1158, 661);
            this.buttonBooksBorrowConfirmation.Margin = new System.Windows.Forms.Padding(3, 10, 0, 3);
            this.buttonBooksBorrowConfirmation.Name = "buttonBooksBorrowConfirmation";
            this.buttonBooksBorrowConfirmation.Size = new System.Drawing.Size(95, 35);
            this.buttonBooksBorrowConfirmation.TabIndex = 77;
            this.buttonBooksBorrowConfirmation.Text = "Borrow";
            this.buttonBooksBorrowConfirmation.UseVisualStyleBackColor = false;
            this.buttonBooksBorrowConfirmation.Click += new System.EventHandler(this.buttonBooksBorrowConfirmation_Click);
            // 
            // buttonClearBooksBorrowList
            // 
            this.buttonClearBooksBorrowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearBooksBorrowList.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearBooksBorrowList.Location = new System.Drawing.Point(1058, 661);
            this.buttonClearBooksBorrowList.Margin = new System.Windows.Forms.Padding(3, 10, 0, 3);
            this.buttonClearBooksBorrowList.Name = "buttonClearBooksBorrowList";
            this.buttonClearBooksBorrowList.Size = new System.Drawing.Size(95, 35);
            this.buttonClearBooksBorrowList.TabIndex = 78;
            this.buttonClearBooksBorrowList.Text = "Clear";
            this.buttonClearBooksBorrowList.UseVisualStyleBackColor = true;
            this.buttonClearBooksBorrowList.Click += new System.EventHandler(this.buttonClearBooksBorrowList_Click);
            // 
            // listBoxBorrowBooks
            // 
            this.listBoxBorrowBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBorrowBooks.FormattingEnabled = true;
            this.listBoxBorrowBooks.ItemHeight = 21;
            this.listBoxBorrowBooks.Location = new System.Drawing.Point(753, 471);
            this.listBoxBorrowBooks.Name = "listBoxBorrowBooks";
            this.listBoxBorrowBooks.Size = new System.Drawing.Size(500, 172);
            this.listBoxBorrowBooks.TabIndex = 81;
            // 
            // buttonDeleteBooksBorrow
            // 
            this.buttonDeleteBooksBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteBooksBorrow.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteBooksBorrow.Location = new System.Drawing.Point(1158, 398);
            this.buttonDeleteBooksBorrow.Margin = new System.Windows.Forms.Padding(3, 10, 0, 3);
            this.buttonDeleteBooksBorrow.Name = "buttonDeleteBooksBorrow";
            this.buttonDeleteBooksBorrow.Size = new System.Drawing.Size(95, 35);
            this.buttonDeleteBooksBorrow.TabIndex = 82;
            this.buttonDeleteBooksBorrow.Text = "Delete";
            this.buttonDeleteBooksBorrow.UseVisualStyleBackColor = true;
            this.buttonDeleteBooksBorrow.Click += new System.EventHandler(this.buttonDeleteBooksBorrow_Click);
            // 
            // buttonDecrementQty
            // 
            this.buttonDecrementQty.BackgroundImage = global::Library_Management_System.Properties.Resources.decrement;
            this.buttonDecrementQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDecrementQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecrementQty.Location = new System.Drawing.Point(1076, 378);
            this.buttonDecrementQty.Name = "buttonDecrementQty";
            this.buttonDecrementQty.Size = new System.Drawing.Size(29, 30);
            this.buttonDecrementQty.TabIndex = 72;
            this.buttonDecrementQty.UseVisualStyleBackColor = true;
            this.buttonDecrementQty.Click += new System.EventHandler(this.buttonDecrementQty_Click);
            // 
            // buttonIncrementQty
            // 
            this.buttonIncrementQty.BackgroundImage = global::Library_Management_System.Properties.Resources.increment;
            this.buttonIncrementQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonIncrementQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncrementQty.Location = new System.Drawing.Point(997, 378);
            this.buttonIncrementQty.Name = "buttonIncrementQty";
            this.buttonIncrementQty.Size = new System.Drawing.Size(29, 30);
            this.buttonIncrementQty.TabIndex = 71;
            this.buttonIncrementQty.UseVisualStyleBackColor = true;
            this.buttonIncrementQty.Click += new System.EventHandler(this.buttonIncrementQty_Click);
            // 
            // pictureBoxBooks
            // 
            this.pictureBoxBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxBooks.Location = new System.Drawing.Point(633, 126);
            this.pictureBoxBooks.Name = "pictureBoxBooks";
            this.pictureBoxBooks.Size = new System.Drawing.Size(111, 111);
            this.pictureBoxBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBooks.TabIndex = 68;
            this.pictureBoxBooks.TabStop = false;
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
            this.buttonSearch.Location = new System.Drawing.Point(182, 126);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(29, 30);
            this.buttonSearch.TabIndex = 56;
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Library_Management_System.Properties.Resources.PageBorrow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(480, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 36);
            this.pictureBox1.TabIndex = 55;
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
            this.buttonBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonBorrow.BackgroundImage = global::Library_Management_System.Properties.Resources.ButtonBorrowActive;
            this.buttonBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrow.Location = new System.Drawing.Point(261, 0);
            this.buttonBorrow.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(67, 50);
            this.buttonBorrow.TabIndex = 5;
            this.buttonBorrow.UseVisualStyleBackColor = false;
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
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.buttonDeleteBooksBorrow);
            this.Controls.Add(this.listBoxBorrowBooks);
            this.Controls.Add(this.buttonClearBooksBorrowList);
            this.Controls.Add(this.buttonBooksBorrowConfirmation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonAddBooksBorrow);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelQtyBorrow);
            this.Controls.Add(this.buttonDecrementQty);
            this.Controls.Add(this.buttonIncrementQty);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBoxBooks);
            this.Controls.Add(this.panelUserDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxBooksSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMain);
            this.Name = "Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.Borrow_Load);
            this.panelMain.ResumeLayout(false);
            this.panelGroup2.ResumeLayout(false);
            this.panelGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFullName.ResumeLayout(false);
            this.panelFullName.PerformLayout();
            this.panelUserDetails.ResumeLayout(false);
            this.panelUserDetails.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelBookID.ResumeLayout(false);
            this.panelBookID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
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
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxBooksSearch;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFullName;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUserDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxBooks;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelBookID;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonIncrementQty;
        private System.Windows.Forms.Button buttonDecrementQty;
        private System.Windows.Forms.Label labelQtyBorrow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddBooksBorrow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonBooksBorrowConfirmation;
        private System.Windows.Forms.Button buttonClearBooksBorrowList;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.ListBox listBoxBorrowBooks;
        private System.Windows.Forms.Button buttonDeleteBooksBorrow;
        private System.Windows.Forms.Button buttonTransactionForm;
    }
}