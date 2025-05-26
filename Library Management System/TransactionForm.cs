using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
            StyleDataGridViewTransactions();
            ConfigureDataGridViewTransactions();
            LoadDataGridViewTransactions();
            StyleAllButtons();
        }

        // Method to add a transaction to the DataGridView
        public void AddTransaction(long borrowerBookID, string userID, string fullName, string dateTimeBorrow, string dueDateTimeReturn, string status, decimal fines)
        {
            if (dataGridViewTransactions.DataSource is DataTable dataTable)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["BorrowerBookID"] = borrowerBookID;
                newRow["UserID"] = userID;
                newRow["FullName"] = fullName;
                newRow["DateTimeBorrow"] = dateTimeBorrow;
                newRow["DueDateTimeReturn"] = dueDateTimeReturn;
                newRow["Status"] = status;
                newRow["Fines"] = fines;
                dataTable.Rows.Add(newRow);
            }
        }


        private void StyleDataGridViewTransactions()
        {
            dataGridViewTransactions.EnableHeadersVisualStyles = false;
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            dataGridViewTransactions.DefaultCellStyle.BackColor = Color.White;
            dataGridViewTransactions.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(228, 228, 228);
            dataGridViewTransactions.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewTransactions.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            dataGridViewTransactions.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewTransactions.BorderStyle = BorderStyle.None;
            dataGridViewTransactions.BackgroundColor = Color.White;
            dataGridViewTransactions.GridColor = Color.White;

            // Add stroke
            dataGridViewTransactions.Paint += DataGridViewTransactions_BorderPaint;
            dataGridViewTransactions.Scroll += DataGridViewTransactions_Scroll;
        }
        private void DataGridViewTransactions_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridViewTransactions.Invalidate();
        }

        private void DataGridViewTransactions_BorderPaint(object sender, PaintEventArgs e)
        {
            int strokeWidth = 2;
            Color borderColor = Color.FromArgb(218, 218, 218);
            Rectangle bounds = dataGridViewTransactions.ClientRectangle;

            bounds.Width -= 1;
            bounds.Height -= 1;

            using (Pen borderPen = new Pen(borderColor, strokeWidth))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(borderPen, bounds);
            }
        }
        private void ConfigureDataGridViewTransactions()
        {
            dataGridViewTransactions.Columns.Clear();

            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BorrowerBookID",
                HeaderText = "BorrowerBookID",
                DataPropertyName = "BorrowerBookID",
                ReadOnly = true,
                Width = 80
            });

            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UserID",
                HeaderText = "User ID",
                DataPropertyName = "UserID",
                ReadOnly = true,
                Width = 70
            });

            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "Full Name",
                DataPropertyName = "FullName",
                ReadOnly = true,
                Width = 180
            });

            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DateTimeBorrow",
                HeaderText = "Borrowed On",
                DataPropertyName = "DateTimeBorrow",
                ReadOnly = true,
                Width = 140
            });

            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DueDateTimeReturn",
                HeaderText = "Due Date",
                DataPropertyName = "DueDateTimeReturn",
                ReadOnly = true,
                Width = 140
            });

            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                ReadOnly = true,
                Width = 100
            });

            // Add Fines column
            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fines",
                HeaderText = "Fines",
                DataPropertyName = "Fines",
                ReadOnly = true,
                Width = 80
            });

            dataGridViewTransactions.AutoGenerateColumns = false;
            dataGridViewTransactions.AllowUserToAddRows = false;
            dataGridViewTransactions.AllowUserToDeleteRows = false;
            dataGridViewTransactions.ReadOnly = true;
        }


        private void LoadDataGridViewTransactions()
        {
            try
            {
                using (MySqlConnector.MySqlConnection conn = new MySqlConnector.MySqlConnection("Server=127.0.0.1;Database=sys;User ID=root;Password=0430;SslMode=None;"))
                {
                    conn.Open();
                    string query = "SELECT BorrowerBookID, UserID, FullName, DateTimeBorrow, DueDateTimeReturn, Status, Fines FROM BorrowerTable";
                    MySqlConnector.MySqlDataAdapter adapter = new MySqlConnector.MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewTransactions.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading transactions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonHome_Click(object sender, EventArgs e)
        {
            DashboardsForm dashboard = new DashboardsForm();
            dashboard.Show();
            this.Hide();
        }

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

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            AdminLoginForm loginForm = new AdminLoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelMain.ClientRectangle, 12);
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


        private void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            // Round corners
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
    }
}
