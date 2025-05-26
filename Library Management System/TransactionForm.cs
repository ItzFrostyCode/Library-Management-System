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
        }

        // Method to add a transaction to the DataGridView
        public void AddTransaction(long borrowerBookID, string userID, string fullName, string dateTimeBorrow, string dueDateTimeReturn, string status)
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

            dataGridViewTransactions.AutoGenerateColumns = false;
            dataGridViewTransactions.AllowUserToAddRows = false;
            dataGridViewTransactions.AllowUserToDeleteRows = false;
            dataGridViewTransactions.ReadOnly = true;
        }

        private void LoadDataGridViewTransactions()
        {
            try
            {
                // If you want to load from a database, use similar logic as in Borrow/Return.
                // Example (adjust connectionString as needed):
                using (MySqlConnector.MySqlConnection conn = new MySqlConnector.MySqlConnection("Server=127.0.0.1;Database=sys;User ID=root;Password=0430;SslMode=None;"))
                {
                    conn.Open();
                    string query = "SELECT BorrowerBookID, UserID, FullName, DateTimeBorrow, DueDateTimeReturn, Status FROM BorrowerTable";
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




    }
}
