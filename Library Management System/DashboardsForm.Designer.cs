namespace Library_Management_System
{
    partial class DashboardsForm
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
            this.panelUsers = new System.Windows.Forms.Panel();
            this.labelTotalUsers = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelBooks = new System.Windows.Forms.Panel();
            this.labelTotalBooks = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBorrow = new System.Windows.Forms.Panel();
            this.panelReturn = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelGroup2.SuspendLayout();
            this.panelGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsers
            // 
            this.panelUsers.Controls.Add(this.labelTotalUsers);
            this.panelUsers.Controls.Add(this.pictureBox2);
            this.panelUsers.Controls.Add(this.label3);
            this.panelUsers.Location = new System.Drawing.Point(17, 191);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(220, 102);
            this.panelUsers.TabIndex = 2;
            this.panelUsers.Click += new System.EventHandler(this.panelUsers_Click);
            this.panelUsers.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUsers_Paint);
            // 
            // labelTotalUsers
            // 
            this.labelTotalUsers.AutoSize = true;
            this.labelTotalUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalUsers.Location = new System.Drawing.Point(23, 53);
            this.labelTotalUsers.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.labelTotalUsers.Name = "labelTotalUsers";
            this.labelTotalUsers.Size = new System.Drawing.Size(23, 25);
            this.labelTotalUsers.TabIndex = 12;
            this.labelTotalUsers.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Library_Management_System.Properties.Resources.UserIcon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(164, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 24, 24, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(24, 24, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboards";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.panel4.Location = new System.Drawing.Point(17, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(103, 2);
            this.panel4.TabIndex = 4;
            // 
            // panelBooks
            // 
            this.panelBooks.Controls.Add(this.labelTotalBooks);
            this.panelBooks.Controls.Add(this.pictureBox3);
            this.panelBooks.Controls.Add(this.label4);
            this.panelBooks.Location = new System.Drawing.Point(260, 191);
            this.panelBooks.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.Size = new System.Drawing.Size(220, 102);
            this.panelBooks.TabIndex = 3;
            this.panelBooks.Click += new System.EventHandler(this.panelBooks_Click);
            this.panelBooks.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBooks_Paint);
            // 
            // labelTotalBooks
            // 
            this.labelTotalBooks.AutoSize = true;
            this.labelTotalBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBooks.Location = new System.Drawing.Point(23, 53);
            this.labelTotalBooks.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.labelTotalBooks.Name = "labelTotalBooks";
            this.labelTotalBooks.Size = new System.Drawing.Size(23, 25);
            this.labelTotalBooks.TabIndex = 15;
            this.labelTotalBooks.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Library_Management_System.Properties.Resources.BooksIcon;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(164, 24);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 24, 24, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(24, 24, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Books";
            // 
            // panelBorrow
            // 
            this.panelBorrow.Location = new System.Drawing.Point(503, 191);
            this.panelBorrow.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panelBorrow.Name = "panelBorrow";
            this.panelBorrow.Size = new System.Drawing.Size(220, 102);
            this.panelBorrow.TabIndex = 4;
            this.panelBorrow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBorrow_Paint);
            // 
            // panelReturn
            // 
            this.panelReturn.Location = new System.Drawing.Point(746, 191);
            this.panelReturn.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panelReturn.Name = "panelReturn";
            this.panelReturn.Size = new System.Drawing.Size(220, 102);
            this.panelReturn.TabIndex = 5;
            this.panelReturn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReturn_Paint);
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(746, 316);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(220, 102);
            this.panel8.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(503, 316);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(220, 102);
            this.panel9.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(260, 316);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(220, 102);
            this.panel10.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(17, 316);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(220, 102);
            this.panel11.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Library_Management_System.Properties.Resources.PageHome;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(488, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 36);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // buttonTransactionForm
            // 
            this.buttonTransactionForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionForm.Image = global::Library_Management_System.Properties.Resources.TransactionIconDefault;
            this.buttonTransactionForm.Location = new System.Drawing.Point(457, 11);
            this.buttonTransactionForm.Name = "buttonTransactionForm";
            this.buttonTransactionForm.Size = new System.Drawing.Size(67, 50);
            this.buttonTransactionForm.TabIndex = 12;
            this.buttonTransactionForm.UseVisualStyleBackColor = true;
            this.buttonTransactionForm.Click += new System.EventHandler(this.buttonTransactionForm_Click);
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
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonHome.BackgroundImage = global::Library_Management_System.Properties.Resources.HomeIconActive;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(67, 50);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.UseVisualStyleBackColor = false;
            // 
            // DashboardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panelReturn);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panelBorrow);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panelBooks);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DashboardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboards";
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBooks.ResumeLayout(false);
            this.panelBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelGroup2.ResumeLayout(false);
            this.panelGroup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelBooks;
        private System.Windows.Forms.Panel panelBorrow;
        private System.Windows.Forms.Panel panelReturn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTotalUsers;
        private System.Windows.Forms.Label labelTotalBooks;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Button buttonTransactionForm;
    }
}