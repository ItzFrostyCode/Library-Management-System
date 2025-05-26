using MySqlConnector;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Return : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=sys;User ID=root;Password=0430;SslMode=None;";
        // Fix for CS1061: Ensure that listBoxBorrowedBooks is properly defined as a ListBox instead of an object.

        private ListBox listBoxBorrowedBooks; // Update the type from 'object' to 'ListBox'

        public Return()
        {
            InitializeComponent();
            this.Load += Return_Load;

            StyleAllButtons();
            // ... your existing code ...
            StyleDataGridViewBorrower();
            ConfigureDataGridViewBorrower();
            LoadDataGridViewBorrower();
            dataGridViewBorrower.CellClick += dataGridViewBorrower_CellClick;
            textBoxBookID.TextChanged += textBoxBookID_TextChanged;



        }


        private void Return_Load(object sender, EventArgs e)
        {
            pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUser.AutoSize = false;
            pictureBoxUser.Width = 61;
            pictureBoxUser.Height = 61;
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
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            AdminLoginForm loginForm = new AdminLoginForm();
            loginForm.Show();
            this.Hide();
        }

        // -------- Navigation buttons end -------- \\

        // -------- DataGridViewBorrower Design -------- \\

        private void StyleDataGridViewBorrower()
        {
            dataGridViewBorrower.EnableHeadersVisualStyles = false;
            dataGridViewBorrower.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewBorrower.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewBorrower.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            dataGridViewBorrower.DefaultCellStyle.BackColor = Color.White;
            dataGridViewBorrower.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(228, 228, 228);
            dataGridViewBorrower.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewBorrower.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            dataGridViewBorrower.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewBorrower.BorderStyle = BorderStyle.None;
            dataGridViewBorrower.BackgroundColor = Color.White;
            dataGridViewBorrower.GridColor = Color.White;

            // Add stroke
            dataGridViewBorrower.Paint += DataGridViewBorrower_BorderPaint;
            dataGridViewBorrower.Scroll += DataGridViewBorrower_Scroll;
        }

        private void DataGridViewBorrower_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridViewBorrower.Invalidate();
        }

        private void DataGridViewBorrower_BorderPaint(object sender, PaintEventArgs e)
        {
            int strokeWidth = 2;
            Color borderColor = Color.FromArgb(218, 218, 218);
            Rectangle bounds = dataGridViewBorrower.ClientRectangle;

            bounds.Width -= 1;
            bounds.Height -= 1;

            using (Pen borderPen = new Pen(borderColor, strokeWidth))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(borderPen, bounds);
            }
        }

        private void ConfigureDataGridViewBorrower()
        {
            dataGridViewBorrower.Columns.Clear();

            dataGridViewBorrower.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BorrowerBookID",
                HeaderText = "BorrowerBookID",
                DataPropertyName = "BorrowerBookID",
                ReadOnly = true,
                Width = 80
            });

            dataGridViewBorrower.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UserID",
                HeaderText = "User ID",
                DataPropertyName = "UserID",
                ReadOnly = true,
                Width = 70
            });

            dataGridViewBorrower.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "Full Name",
                DataPropertyName = "FullName",
                ReadOnly = true,
                Width = 180
            });

            dataGridViewBorrower.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DateTimeBorrow",
                HeaderText = "Borrowed On",
                DataPropertyName = "DateTimeBorrow",
                ReadOnly = true,
                Width = 140
            });

            dataGridViewBorrower.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DueDateTimeReturn",
                HeaderText = "Due Date",
                DataPropertyName = "DueDateTimeReturn",
                ReadOnly = true,
                Width = 140
            });

            dataGridViewBorrower.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                ReadOnly = true,
                Width = 100
            });

            dataGridViewBorrower.AutoGenerateColumns = false;
            dataGridViewBorrower.AllowUserToAddRows = false;
            dataGridViewBorrower.AllowUserToDeleteRows = false;
            dataGridViewBorrower.ReadOnly = true;
        }

        private void LoadDataGridViewBorrower()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT BorrowerBookID, UserID, FullName, DateTimeBorrow, DueDateTimeReturn, Status FROM BorrowerTable WHERE Status = 'Borrowed'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewBorrower.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading borrower data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fix for CS0121: Remove the duplicate method definition for dataGridViewBorrower_CellClick.
        // The duplicate method is removed, leaving only one definition.




        private void dataGridViewBorrower_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row and the BorrowerBookID column
            if (e.RowIndex >= 0)
                dataGridViewBorrower.Rows[e.RowIndex].Selected = true;
            {
                var grid = (DataGridView)sender;
                var columnName = grid.Columns[e.ColumnIndex].Name;

                if (columnName == "BorrowerBookID")
                {
                    // Get BorrowerBookID from the clicked cell
                    var borrowerBookIDObj = grid.Rows[e.RowIndex].Cells["BorrowerBookID"].Value;
                    if (borrowerBookIDObj == null) return;
                    long borrowerBookID = Convert.ToInt64(borrowerBookIDObj);

                    // --- Display borrowed books in listBoxBorrowBooks ---
                    listBoxBorrowBooks.Items.Clear();
                    using (var conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        var booksCmd = new MySqlCommand("SELECT BookID, Title, Qty FROM BorrowedBooks WHERE BorrowerBookID = @BorrowerBookID", conn);
                        booksCmd.Parameters.AddWithValue("@BorrowerBookID", borrowerBookID);
                        using (var reader = booksCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string bookInfo = $"{reader["BookID"]}, {reader["Title"]}, {reader["Qty"]}";
                                listBoxBorrowBooks.Items.Add(bookInfo);
                            }
                        }
                    }

                    // --- Optionally, display user details and image as before ---
                    var userIDObj = grid.Rows[e.RowIndex].Cells["UserID"].Value;
                    if (userIDObj != null)
                    {
                        long userID = Convert.ToInt64(userIDObj);
                        using (var conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            var userCmd = new MySqlCommand("SELECT FullName, EmailAddress, ContactNumber, UserIMG FROM Users WHERE UserID = @UserID", conn);
                            userCmd.Parameters.AddWithValue("@UserID", userID);
                            using (var reader = userCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    labelUserID.Text = userID.ToString();
                                    labelFullName.Text = reader["FullName"].ToString();
                                    labelEmailAddress.Text = reader["EmailAddress"].ToString();
                                    labelContactNumber.Text = reader["ContactNumber"].ToString();

                                    if (reader["UserIMG"] != DBNull.Value)
                                    {
                                        byte[] imageBytes = (byte[])reader["UserIMG"];
                                        using (var ms = new System.IO.MemoryStream(imageBytes))
                                        {
                                            pictureBoxUser.Image = Image.FromStream(ms);
                                        }
                                    }
                                    else
                                    {
                                        pictureBoxUser.Image = null;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void textBoxBookID_TextChanged(object sender, EventArgs e)
        {
            string bookId = textBoxBookID.Text.Trim();
            int foundQty = -1;
            foreach (var item in listBoxBorrowBooks.Items)
            {
                string[] parts = item.ToString().Split(',');
                if (parts[0].Trim() == bookId)
                {
                    foundQty = int.Parse(parts[2].Trim());
                    break;
                }
            }

            if (foundQty > 0)
            {
                labelQtyBorrow.Text = foundQty.ToString();
                buttonDecrementQty.Enabled = foundQty > 1;
                buttonIncrementQty.Enabled = false; // Can't increment above borrowed qty
            }
            else
            {
                labelQtyBorrow.Text = "1";
                buttonDecrementQty.Enabled = false;
                buttonIncrementQty.Enabled = false;
            }
        }

        private void buttonDecrementQty_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(labelQtyBorrow.Text);
            if (qty > 1)
            {
                qty--;
                labelQtyBorrow.Text = qty.ToString();
                buttonDecrementQty.Enabled = qty > 1;
            }
        }

        private void buttonIncrementQty_Click(object sender, EventArgs e)
        {
            // Refresh the listBoxBorrowBooks for the current borrower before incrementing
            if (dataGridViewBorrower.SelectedRows.Count > 0)
            {
                long borrowerBookID = Convert.ToInt64(dataGridViewBorrower.SelectedRows[0].Cells["BorrowerBookID"].Value);
                listBoxBorrowBooks.Items.Clear();
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var booksCmd = new MySqlCommand("SELECT BookID, Title, Qty FROM BorrowedBooks WHERE BorrowerBookID = @BorrowerBookID", conn);
                    booksCmd.Parameters.AddWithValue("@BorrowerBookID", borrowerBookID);
                    using (var reader = booksCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bookInfo = $"{reader["BookID"]}, {reader["Title"]}, {reader["Qty"]}";
                            listBoxBorrowBooks.Items.Add(bookInfo);
                        }
                    }
                }
            }

            // Now perform the increment logic
            int maxQty = 1;
            string bookId = textBoxBookID.Text.Trim();
            foreach (var item in listBoxBorrowBooks.Items)
            {
                string[] parts = item.ToString().Split(',');
                if (parts[0].Trim() == bookId)
                {
                    maxQty = int.Parse(parts[2].Trim());
                    break;
                }
            }
            int qty = int.Parse(labelQtyBorrow.Text);
            if (qty < maxQty)
            {
                qty++;
                labelQtyBorrow.Text = qty.ToString();
                buttonIncrementQty.Enabled = qty < maxQty;
                buttonDecrementQty.Enabled = qty > 1;
            }
        }


        private void buttonReturnBooks_Click(object sender, EventArgs e)
        {
            // 1. Validate user selection
            if (string.IsNullOrWhiteSpace(labelUserID.Text) || labelUserID.Text == "N/A")
            {
                MessageBox.Show("Please select a borrower first.", "No Borrower Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxBookID.Text))
            {
                MessageBox.Show("Please enter/select a Book ID to return.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Check if BookID is in listBoxBorrowBooks
            bool found = false;
            int currentQty = 0;
            foreach (var item in listBoxBorrowBooks.Items)
            {
                string[] parts = item.ToString().Split(',');
                if (parts[0].Trim() == textBoxBookID.Text.Trim())
                {
                    currentQty = int.Parse(parts[2].Trim());
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("You can only return books that are in the borrow list.", "Invalid Book ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (currentQty == 0)
            {
                MessageBox.Show("This book has already been fully returned.", "Already Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. Confirm return
            var result = MessageBox.Show("Are you sure you want to return this book?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            // 4. Get BorrowerBookID from selected row or current row
            long borrowerBookID = 0;
            if (dataGridViewBorrower.SelectedRows.Count > 0)
            {
                borrowerBookID = Convert.ToInt64(dataGridViewBorrower.SelectedRows[0].Cells["BorrowerBookID"].Value);
            }
            else if (dataGridViewBorrower.CurrentRow != null)
            {
                borrowerBookID = Convert.ToInt64(dataGridViewBorrower.CurrentRow.Cells["BorrowerBookID"].Value);
            }
            else
            {
                MessageBox.Show("No borrower selected in the grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string bookId = textBoxBookID.Text.Trim();
            int qtyToReturn = int.Parse(labelQtyBorrow.Text);

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // 5. Get current borrowed qty
                int borrowedQty = 0;
                using (var cmd = new MySqlCommand("SELECT Qty FROM BorrowedBooks WHERE BorrowerBookID = @BorrowerBookID AND BookID = @BookID", conn))
                {
                    cmd.Parameters.AddWithValue("@BorrowerBookID", borrowerBookID);
                    cmd.Parameters.AddWithValue("@BookID", bookId);
                    var resultQty = cmd.ExecuteScalar();
                    if (resultQty != null)
                        borrowedQty = Convert.ToInt32(resultQty);
                }

                if (borrowedQty == 0)
                {
                    MessageBox.Show("This book has already been fully returned.", "Already Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int newQty = borrowedQty - qtyToReturn;
                if (newQty < 0)
                {
                    MessageBox.Show("You cannot return more than you borrowed.", "Invalid Return", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 6. Update BorrowedBooks Qty
                using (var cmd = new MySqlCommand("UPDATE BorrowedBooks SET Qty = @NewQty WHERE BorrowerBookID = @BorrowerBookID AND BookID = @BookID", conn))
                {
                    cmd.Parameters.AddWithValue("@NewQty", newQty);
                    cmd.Parameters.AddWithValue("@BorrowerBookID", borrowerBookID);
                    cmd.Parameters.AddWithValue("@BookID", bookId);
                    cmd.ExecuteNonQuery();
                }

                // 6b. Update Books table to increase available quantity
                using (var cmd = new MySqlCommand("UPDATE Books SET Qty = Qty + @QtyReturned WHERE BookID = @BookID", conn))
                {
                    cmd.Parameters.AddWithValue("@QtyReturned", qtyToReturn);
                    cmd.Parameters.AddWithValue("@BookID", bookId);
                    cmd.ExecuteNonQuery();
                }

                // 6c. Update Books status to 'Available' if Qty > 0 and status is not already 'Available'
                using (var cmd = new MySqlCommand("UPDATE Books SET Status = 'Available' WHERE BookID = @BookID AND Qty > 0 AND Status <> 'Available'", conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookId);
                    cmd.ExecuteNonQuery();
                }


                // 7. If all books for this BorrowerBookID are returned, update status to Returned
                bool allReturned = true;
                using (var cmd = new MySqlCommand("SELECT SUM(Qty) FROM BorrowedBooks WHERE BorrowerBookID = @BorrowerBookID", conn))
                {
                    cmd.Parameters.AddWithValue("@BorrowerBookID", borrowerBookID);
                    var sumQty = cmd.ExecuteScalar();
                    int totalQty = sumQty != DBNull.Value ? Convert.ToInt32(sumQty) : 0;
                    allReturned = (totalQty == 0);
                }

                if (allReturned)
                {
                    using (var cmd = new MySqlCommand("UPDATE BorrowerTable SET Status = 'Returned' WHERE BorrowerBookID = @BorrowerBookID", conn))
                    {
                        cmd.Parameters.AddWithValue("@BorrowerBookID", borrowerBookID);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (var cmd = new MySqlCommand("UPDATE BorrowerTable SET Status = 'Borrowed' WHERE BorrowerBookID = @BorrowerBookID", conn))
                    {
                        cmd.Parameters.AddWithValue("@BorrowerBookID", borrowerBookID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Book return processed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 8. Refresh the borrow list and UI
            LoadDataGridViewBorrower();

            // 9. Remove from dataGridViewBorrower if all books returned, and update TransactionForm if open
            RemoveReturnedBorrowerFromGrid(borrowerBookID);
            UpdateTransactionFormStatus(borrowerBookID);

            // Optionally, clear or update listBoxBorrowBooks and other UI elements as needed
        }

        private void RemoveReturnedBorrowerFromGrid(long borrowerBookID)
        {
            if (dataGridViewBorrower.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewBorrower.Rows)
                {
                    if (row.Cells["BorrowerBookID"].Value != null && Convert.ToInt64(row.Cells["BorrowerBookID"].Value) == borrowerBookID)
                    {
                        if (row.Cells["Status"].Value != null && row.Cells["Status"].Value.ToString() == "Returned")
                        {
                            dataGridViewBorrower.Rows.Remove(row);
                            break;
                        }
                    }
                }
            }
        }

        private void UpdateTransactionFormStatus(long borrowerBookID)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is TransactionForm transactionForm)
                {
                    var dgv = transactionForm.Controls["dataGridViewTransactions"] as DataGridView;
                    if (dgv != null)
                    {
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (row.Cells["BorrowerBookID"].Value != null && Convert.ToInt64(row.Cells["BorrowerBookID"].Value) == borrowerBookID)
                            {
                                row.Cells["Status"].Value = "Returned";
                                row.Cells["Status"].Style.ForeColor = Color.Green;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void textBoxBookID_Enter(object sender, EventArgs e)
        {
            if (textBoxBookID.Text == "Enter Book ID")
            {
                textBoxBookID.Text = "";
                textBoxBookID.ForeColor = Color.Black; // Change text color to black when editing
            }
        }

        private void textBoxBookID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBookID.Text))
            {
                textBoxBookID.Text = "Enter Book ID";
                textBoxBookID.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }

        private void panelUserDetails_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelUserDetails.ClientRectangle, 12);
        }

        private void panelBookID_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelBookID.ClientRectangle, 12);
        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelMain.ClientRectangle, 12);
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
