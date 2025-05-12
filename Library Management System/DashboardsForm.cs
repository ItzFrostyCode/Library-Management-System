using MySqlConnector;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class DashboardsForm : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=sys;User ID=root;Password=0430;";

        public DashboardsForm()
        {
            InitializeComponent();
            this.Load += DashboardsForm_Load;

            StyleAllButtons();
        }

        private void DashboardsForm_Load(object sender, EventArgs e)
        {
            UpdateDashboardCounts();
        }

        private void UpdateDashboardCounts()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to count total users
                    string userCountQuery = "SELECT COUNT(*) FROM Users";
                    MySqlCommand userCmd = new MySqlCommand(userCountQuery, conn);
                    int totalUsers = Convert.ToInt32(userCmd.ExecuteScalar());
                    labelTotalUsers.Text = totalUsers.ToString();

                    // Query to count total books
                    string bookCountQuery = "SELECT COUNT(*) FROM Books";
                    MySqlCommand bookCmd = new MySqlCommand(bookCountQuery, conn);
                    int totalBooks = Convert.ToInt32(bookCmd.ExecuteScalar());
                    labelTotalBooks.Text = totalBooks.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating dashboard counts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------- Navigation buttons -------- \\

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm();
            booksForm.Show();
            this.Hide();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            Borrow borrowForm = new Borrow();
            borrowForm.Show();
            this.Hide();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Return returnForm = new Return();
            returnForm.Show();
            this.Hide();
        }
        private void buttonTransactionForm_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
            this.Hide();
        }

        // -------- Navigation buttons end -------- \\


        private void DrawRoundedRectangle(Graphics graphics, Rectangle bounds, int cornerRadius)
        {
            Color borderColor = Color.FromArgb(218, 218, 218);

            int penWidth = 2;


            Rectangle adjustedBounds = new Rectangle(
                bounds.X + penWidth / 2,
                bounds.Y + penWidth / 2,
                bounds.Width - penWidth,
                bounds.Height - penWidth
            );

            using (GraphicsPath path = CreateRoundedRectanglePath(adjustedBounds, cornerRadius))
            {
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

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);

            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);

            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);

            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelMain.ClientRectangle, 12);
        }

        private void panelUsers_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelUsers.ClientRectangle, 12);

        }

        private void panelBooks_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelBooks.ClientRectangle, 12);

        }

        private void panelBorrow_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelBorrow.ClientRectangle, 12);
        }
        private void panelReturn_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelReturn.ClientRectangle, 12);
        }


        // --------- Button styles --------- \\
        private void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;


            GraphicsPath path = new GraphicsPath();
            int radius = 8;
            Rectangle rect = new Rectangle(0, 0, button.Width, button.Height);
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }
        private void StyleAllButtons()
        {
            StyleButton(buttonHome);
            StyleButton(buttonUsers);
            StyleButton(buttonBooks);
            StyleButton(buttonBorrow);
            StyleButton(buttonReturn);
            StyleButton(buttonTransactionForm);


            StyleButton(buttonSettings);
            StyleButton(buttonLogout);
        }
        // --------- Button styles end --------- \\

        // --------- Miss Click --------- \\
        private void panelUsers_Click(object sender, EventArgs e)
        {

        }
        private void panelBooks_Click(object sender, EventArgs e)
        {

        }


    }

}

