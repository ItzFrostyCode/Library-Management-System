namespace Library_Management_System
{
    partial class AdminLoginForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.LineAdmin = new System.Windows.Forms.Panel();
            this.ContainerPassword = new System.Windows.Forms.Panel();
            this.TextBoxGroupPassword = new System.Windows.Forms.Panel();
            this.TextBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.Label();
            this.ContainerLogin = new System.Windows.Forms.Panel();
            this.TextBoxGroupAdmin = new System.Windows.Forms.Panel();
            this.TextBoxAdmin = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.Label();
            this.TextAdmin = new System.Windows.Forms.Label();
            this.ContainerOutsideTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ContainerPassword.SuspendLayout();
            this.TextBoxGroupPassword.SuspendLayout();
            this.ContainerLogin.SuspendLayout();
            this.TextBoxGroupAdmin.SuspendLayout();
            this.ContainerOutsideTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(392, 530);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(480, 64);
            this.LoginButton.TabIndex = 15;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginButton_Paint);
            // 
            // LineAdmin
            // 
            this.LineAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.LineAdmin.Location = new System.Drawing.Point(392, 505);
            this.LineAdmin.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.LineAdmin.Name = "LineAdmin";
            this.LineAdmin.Size = new System.Drawing.Size(480, 2);
            this.LineAdmin.TabIndex = 14;
            // 
            // ContainerPassword
            // 
            this.ContainerPassword.BackColor = System.Drawing.Color.Transparent;
            this.ContainerPassword.Controls.Add(this.TextBoxGroupPassword);
            this.ContainerPassword.Controls.Add(this.PasswordText);
            this.ContainerPassword.Location = new System.Drawing.Point(392, 382);
            this.ContainerPassword.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.ContainerPassword.Name = "ContainerPassword";
            this.ContainerPassword.Size = new System.Drawing.Size(480, 100);
            this.ContainerPassword.TabIndex = 13;
            // 
            // TextBoxGroupPassword
            // 
            this.TextBoxGroupPassword.Controls.Add(this.TextBoxAdminPassword);
            this.TextBoxGroupPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxGroupPassword.Location = new System.Drawing.Point(0, 36);
            this.TextBoxGroupPassword.Name = "TextBoxGroupPassword";
            this.TextBoxGroupPassword.Size = new System.Drawing.Size(480, 64);
            this.TextBoxGroupPassword.TabIndex = 1;
            this.TextBoxGroupPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBoxGroupPassword_Paint);
            // 
            // TextBoxAdminPassword
            // 
            this.TextBoxAdminPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.TextBoxAdminPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAdminPassword.Font = new System.Drawing.Font("Calibri", 18F);
            this.TextBoxAdminPassword.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxAdminPassword.Location = new System.Drawing.Point(24, 17);
            this.TextBoxAdminPassword.Margin = new System.Windows.Forms.Padding(24, 17, 24, 17);
            this.TextBoxAdminPassword.Name = "TextBoxAdminPassword";
            this.TextBoxAdminPassword.Size = new System.Drawing.Size(432, 30);
            this.TextBoxAdminPassword.TabIndex = 0;
            this.TextBoxAdminPassword.Text = "Enter Password";
            this.TextBoxAdminPassword.TextChanged += new System.EventHandler(this.TextBoxAdminPassword_TextChanged);
            this.TextBoxAdminPassword.Enter += new System.EventHandler(this.TextBoxAdminPassword_Enter);
            this.TextBoxAdminPassword.Leave += new System.EventHandler(this.TextBoxAdminPassword_Leave);
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasswordText.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PasswordText.Location = new System.Drawing.Point(0, 0);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(119, 33);
            this.PasswordText.TabIndex = 0;
            this.PasswordText.Text = "Password";
            // 
            // ContainerLogin
            // 
            this.ContainerLogin.BackColor = System.Drawing.Color.Transparent;
            this.ContainerLogin.Controls.Add(this.TextBoxGroupAdmin);
            this.ContainerLogin.Controls.Add(this.LoginText);
            this.ContainerLogin.Location = new System.Drawing.Point(392, 259);
            this.ContainerLogin.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.ContainerLogin.Name = "ContainerLogin";
            this.ContainerLogin.Size = new System.Drawing.Size(480, 100);
            this.ContainerLogin.TabIndex = 12;
            // 
            // TextBoxGroupAdmin
            // 
            this.TextBoxGroupAdmin.Controls.Add(this.TextBoxAdmin);
            this.TextBoxGroupAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxGroupAdmin.Location = new System.Drawing.Point(0, 36);
            this.TextBoxGroupAdmin.Name = "TextBoxGroupAdmin";
            this.TextBoxGroupAdmin.Size = new System.Drawing.Size(480, 64);
            this.TextBoxGroupAdmin.TabIndex = 2;
            // 
            // TextBoxAdmin
            // 
            this.TextBoxAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.TextBoxAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAdmin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAdmin.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxAdmin.Location = new System.Drawing.Point(24, 17);
            this.TextBoxAdmin.Margin = new System.Windows.Forms.Padding(24, 17, 24, 17);
            this.TextBoxAdmin.Name = "TextBoxAdmin";
            this.TextBoxAdmin.Size = new System.Drawing.Size(432, 30);
            this.TextBoxAdmin.TabIndex = 0;
            this.TextBoxAdmin.Text = "Enter Admin";
            this.TextBoxAdmin.Enter += new System.EventHandler(this.TextBoxAdmin_Enter);
            this.TextBoxAdmin.Leave += new System.EventHandler(this.TextBoxAdmin_Leave);
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginText.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.LoginText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.LoginText.Location = new System.Drawing.Point(0, 0);
            this.LoginText.Margin = new System.Windows.Forms.Padding(0);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(73, 33);
            this.LoginText.TabIndex = 0;
            this.LoginText.Text = "Login";
            // 
            // TextAdmin
            // 
            this.TextAdmin.AutoSize = true;
            this.TextAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextAdmin.Location = new System.Drawing.Point(501, 189);
            this.TextAdmin.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.TextAdmin.Name = "TextAdmin";
            this.TextAdmin.Size = new System.Drawing.Size(262, 40);
            this.TextAdmin.TabIndex = 11;
            this.TextAdmin.Text = "Admin Login Form";
            // 
            // ContainerOutsideTitle
            // 
            this.ContainerOutsideTitle.BackColor = System.Drawing.Color.White;
            this.ContainerOutsideTitle.Controls.Add(this.label1);
            this.ContainerOutsideTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainerOutsideTitle.Location = new System.Drawing.Point(0, 0);
            this.ContainerOutsideTitle.Name = "ContainerOutsideTitle";
            this.ContainerOutsideTitle.Size = new System.Drawing.Size(1264, 78);
            this.ContainerOutsideTitle.TabIndex = 16;
            this.ContainerOutsideTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.ContainerOutsideTitle_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(401, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRARY SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.ContainerOutsideTitle);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LineAdmin);
            this.Controls.Add(this.ContainerPassword);
            this.Controls.Add(this.ContainerLogin);
            this.Controls.Add(this.TextAdmin);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            this.Enter += new System.EventHandler(this.AdminLoginForm_Enter);
            this.Leave += new System.EventHandler(this.AdminLoginForm_Leave);
            this.ContainerPassword.ResumeLayout(false);
            this.ContainerPassword.PerformLayout();
            this.TextBoxGroupPassword.ResumeLayout(false);
            this.TextBoxGroupPassword.PerformLayout();
            this.ContainerLogin.ResumeLayout(false);
            this.ContainerLogin.PerformLayout();
            this.TextBoxGroupAdmin.ResumeLayout(false);
            this.TextBoxGroupAdmin.PerformLayout();
            this.ContainerOutsideTitle.ResumeLayout(false);
            this.ContainerOutsideTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel LineAdmin;
        private System.Windows.Forms.Panel ContainerPassword;
        private System.Windows.Forms.Panel TextBoxGroupPassword;
        private System.Windows.Forms.TextBox TextBoxAdminPassword;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.Panel ContainerLogin;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.Label TextAdmin;
        private System.Windows.Forms.Panel ContainerOutsideTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TextBoxGroupAdmin;
        private System.Windows.Forms.TextBox TextBoxAdmin;
    }
}

