using MySqlConnector; // Add this for MySQL access
using System;
using System.Data;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Return : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=sys;User ID=root;Password=0430;SslMode=None;";

        public Return()
        {
            InitializeComponent();
            LoadReturnData();
            dataGridViewBorrowerTable.CellClick += dataGridViewBorrowerTable_CellClick;
        }

        private void LoadReturnData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT BorrowerBookID, UserID, FullName, DateTimeBorrow, DueDateTimeReturn, Status
                                     FROM BorrowerTable";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewBorrowerTable.DataSource = dt;

                    // Add action buttons if not already present
                    if (!dataGridViewBorrowerTable.Columns.Contains("View"))
                    {
                        DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn();
                        viewBtn.Name = "View";
                        viewBtn.HeaderText = "Action";
                        viewBtn.Text = "View";
                        viewBtn.UseColumnTextForButtonValue = true;
                        dataGridViewBorrowerTable.Columns.Add(viewBtn);
                    }
                    if (!dataGridViewBorrowerTable.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn delBtn = new DataGridViewButtonColumn();
                        delBtn.Name = "Delete";
                        delBtn.HeaderText = "";
                        delBtn.Text = "Delete";
                        delBtn.UseColumnTextForButtonValue = true;
                        dataGridViewBorrowerTable.Columns.Add(delBtn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading return data: " + ex.Message);
            }
        }

        private void dataGridViewBorrowerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewBorrowerTable.Columns[e.ColumnIndex].Name == "View")
                {
                    long borrowerBookId = Convert.ToInt64(dataGridViewBorrowerTable.Rows[e.RowIndex].Cells["BorrowerBookID"].Value);
                    // Open a new form to show details
                    BorrowerDetailsForm detailsForm = new BorrowerDetailsForm(borrowerBookId, connectionString);

                }
                else if (dataGridViewBorrowerTable.Columns[e.ColumnIndex].Name == "Delete")
                {
                    long borrowerBookId = Convert.ToInt64(dataGridViewBorrowerTable.Rows[e.RowIndex].Cells["BorrowerBookID"].Value);
                    if (MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DeleteBorrowerRecord(borrowerBookId);
                        LoadReturnData();
                    }
                }
            }
        }

        private void DeleteBorrowerRecord(long borrowerBookId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // Delete borrowed books first due to FK constraint
                    string delBooks = "DELETE FROM BorrowedBooks WHERE BorrowerBookID = @BorrowerBookID";
                    using (MySqlCommand cmd = new MySqlCommand(delBooks, conn))
                    {
                        cmd.Parameters.AddWithValue("@BorrowerBookID", borrowerBookId);
                        cmd.ExecuteNonQuery();
                    }
                    string delBorrower = "DELETE FROM BorrowerTable WHERE BorrowerBookID = @BorrowerBookID";
                    using (MySqlCommand cmd = new MySqlCommand(delBorrower, conn))
                    {
                        cmd.Parameters.AddWithValue("@BorrowerBookID", borrowerBookId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }
        }

        // -------- Navigation buttons -------- \\
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

        private void buttonTransactionForm_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
            this.Hide();
        }
        // -------- Navigation buttons end -------- \\
    }
}
