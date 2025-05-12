using MySqlConnector;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AdminLoginForm : Form
    {
        private const float DefaultCornerRadius = 14.4f;
        private static readonly Color DefaultBorderColor = Color.FromArgb(25, Color.White);
        public AdminLoginForm()
        {
            InitializeComponent();
            StyleLoginButton();
            TextBoxGroupAdmin.Paint += TextBoxGroupAdmin_Paint;
            TextBoxGroupPassword.Paint += TextBoxGroupPassword_Paint;

            LoginButton.Paint += LoginButton_Paint;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.FlatAppearance.BorderSize = 0;


        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = TextBoxAdmin.Text.Trim();
            string password = TextBoxAdminPassword.Text.Trim();

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both the username and password fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connection = "Server=127.0.0.1;Database=sys;User ID=root;Password=0430;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();

                    string query = "SELECT * FROM admin_accounts WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DashboardsForm dashboard = new DashboardsForm();
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database connection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void LoginButton_Paint(object sender, PaintEventArgs e)
        {

        }
        private void StyleLoginButton()
        {
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.FlatAppearance.BorderSize = 0;

            // Round corners
            GraphicsPath path = new GraphicsPath();
            int radius = 12;
            Rectangle rect = new Rectangle(0, 0, LoginButton.Width, LoginButton.Height);
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            LoginButton.Region = new Region(path);
        }


        private void TextBoxGroupAdmin_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, TextBoxGroupAdmin.ClientRectangle, 12);
        }

        private void TextBoxGroupPassword_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, TextBoxGroupPassword.ClientRectangle, 12);
        }

        private void DrawRoundedRectangle(Graphics graphics, Rectangle bounds, int cornerRadius)
        {
            Color borderColor = Color.FromArgb(218, 218, 218);

            int penWidth = 2;

            // Adjust bounds to account for the pen's width
            Rectangle adjustedBounds = new Rectangle(
                bounds.X + penWidth / 2,
                bounds.Y + penWidth / 2,
                bounds.Width - penWidth,
                bounds.Height - penWidth
            );

            using (GraphicsPath path = CreateRoundedRectanglePath(adjustedBounds, cornerRadius))
            {


                // Draw the border
                using (Pen borderPen = new Pen(borderColor, penWidth))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias; // Ensure smooth edges
                    graphics.DrawPath(borderPen, path);
                }
            }
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle bounds, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = cornerRadius * 2;

            // Top-left corner
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);

            // Top-right corner
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);

            // Bottom-right corner
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);

            // Bottom-left corner
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }



        private void AdminLoginForm_Enter(object sender, System.EventArgs e)
        {

        }

        private void AdminLoginForm_Leave(object sender, System.EventArgs e)
        {

        }

        private void TextBoxAdminPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxAdminPassword.Text == "Enter Password")
            {
                TextBoxAdminPassword.Text = "";
                TextBoxAdminPassword.ForeColor = Color.Black;
                TextBoxAdminPassword.UseSystemPasswordChar = true;
            }
        }

        private void TextBoxAdminPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxAdminPassword.Text))
            {
                TextBoxAdminPassword.Text = "Enter Password";
                TextBoxAdminPassword.ForeColor = Color.Gray;
                TextBoxAdminPassword.UseSystemPasswordChar = false;
            }
        }

        private void ContainerOutsideTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxAdminPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxAdmin_Enter(object sender, EventArgs e)
        {
            if (TextBoxAdmin.Text == "Enter Admin")
            {
                TextBoxAdmin.Text = "";
                TextBoxAdmin.ForeColor = Color.Black;
            }
        }

        private void TextBoxAdmin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxAdmin.Text))
            {
                TextBoxAdmin.Text = "Enter Admin";
                TextBoxAdmin.ForeColor = Color.Gray;
            }
        }
    }
}
