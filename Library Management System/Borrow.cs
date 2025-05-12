using MySqlConnector;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Borrow : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=sys;User ID=root;Password=0430;SslMode=None;";

        public Borrow()
        {
            InitializeComponent();
            StyleDataGridViewBooks();
            this.Load += Borrow_Load;
            StyleAllButtons();
            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;
            PopulateAutoComplete();
            textBoxFullName.KeyDown += textBoxFullName_KeyDown;


        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadDataGridView();

            // Resize pictureBoxUser to 61x61
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
        // ---------- Panels Form Design ---------- \\
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelMain.ClientRectangle, 12);
        }
        private void panelFullName_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelFullName.ClientRectangle, 12);
        }

        private void panelUserDetails_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelUserDetails.ClientRectangle, 12);
        }
        private void panelBookID_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelBookID.ClientRectangle, 12);
        }

        // ---------- Panels Form Design End ---------- \\

        //  ---------- DataGridView Design ---------- \\
        private void StyleDataGridViewBooks()
        {
            dataGridViewBooks.EnableHeadersVisualStyles = false;
            dataGridViewBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            dataGridViewBooks.DefaultCellStyle.BackColor = Color.White;
            dataGridViewBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(228, 228, 228);
            dataGridViewBooks.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewBooks.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            dataGridViewBooks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewBooks.BorderStyle = BorderStyle.None;
            dataGridViewBooks.BackgroundColor = Color.White;
            dataGridViewBooks.GridColor = Color.White;

            // Add stroke
            dataGridViewBooks.Paint += DataGridViewBooks_BorderPaint;
            dataGridViewBooks.Scroll += DataGridViewBooks_Scroll; // Ensure redraw on scroll
        }

        private void DataGridViewBooks_Scroll(object sender, ScrollEventArgs e)
        {
            // Force repaint to ensure the border is redrawn correctly during scrolling
            dataGridViewBooks.Invalidate();
        }

        private void DataGridViewBooks_BorderPaint(object sender, PaintEventArgs e)
        {
            int strokeWidth = 2;
            Color borderColor = Color.FromArgb(218, 218, 218);
            Rectangle bounds = dataGridViewBooks.ClientRectangle;

            bounds.Width -= 1; // Avoid cutoff
            bounds.Height -= 1;

            using (Pen borderPen = new Pen(borderColor, strokeWidth))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Smooth edges
                e.Graphics.DrawRectangle(borderPen, bounds);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridViewBooks.Columns.Clear();

            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BookID",
                HeaderText = "Book ID",
                DataPropertyName = "BookID",
                ReadOnly = true,
                Width = 70
            });

            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Title",
                DataPropertyName = "Title",
                ReadOnly = true,
                Width = 200
            });

            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Author",
                HeaderText = "Author",
                DataPropertyName = "Author",
                ReadOnly = true,
                Width = 150
            });

            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Genre",
                HeaderText = "Genre",
                DataPropertyName = "Genre",
                ReadOnly = true,
                Width = 100
            });

            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Qty",
                HeaderText = "Quantity",
                DataPropertyName = "Qty",
                ReadOnly = true,
                Width = 80
            });

            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                ReadOnly = true,
                Width = 100
            });

            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.ReadOnly = true;
        }

        private void LoadDataGridView()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT BookID, Title, Author, Genre, Qty, Status FROM Books"; // Fixed query
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewBooks.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row and column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the clicked column is the BookID column
                if (dataGridViewBooks.Columns[e.ColumnIndex].Name == "BookID")
                {
                    // Get the BookID value from the clicked cell
                    var bookIdValue = dataGridViewBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (bookIdValue != null)
                    {
                        // Retrieve the corresponding image for the selected BookID
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            try
                            {
                                conn.Open();
                                string query = "SELECT BookIMG FROM Books WHERE BookID = @BookID";
                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@BookID", bookIdValue);

                                object result = cmd.ExecuteScalar();
                                if (result != null && result is byte[] imageBytes)
                                {
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        // Convert byte[] to Image
                                        using (Image originalImage = Image.FromStream(ms))
                                        {
                                            // Resize the image to fit the PictureBox
                                            Image resizedImage = ResizeImage(originalImage, 111, 111);
                                            pictureBoxBooks.Image = resizedImage;
                                        }
                                    }
                                }
                                else
                                {
                                    // Clear the PictureBox if no image is available
                                    pictureBoxBooks.Image = null;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred while retrieving the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                g.DrawImage(image, new Rectangle(0, 0, width, height));
            }
            return resizedImage;
        }


        private void textBoxFullName_Enter(object sender, EventArgs e)
        {
            if (textBoxFullName.Text == "First Name / Middle Initial / Last Name")
            {
                textBoxFullName.Text = "";
                textBoxFullName.ForeColor = Color.Black;
            }
        }

        private void textBoxFullName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                textBoxFullName.Text = "First Name / Middle Initial / Last Name";
                textBoxFullName.ForeColor = Color.Gray;
            }
        }

        private void PopulateAutoComplete()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT FullName FROM Users";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                    while (reader.Read())
                    {
                        autoCompleteCollection.Add(reader["FullName"].ToString());
                    }

                    textBoxFullName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    textBoxFullName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    textBoxFullName.AutoCompleteCustomSource = autoCompleteCollection;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating autocomplete: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayUserDetails(string fullName)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT UserID, FullName, EmailAddress, ContactNumber, UserIMG FROM Users WHERE FullName = @FullName";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FullName", fullName);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Update labels
                            labelUserID.Text = reader["UserID"].ToString();
                            labelFullName.Text = reader["FullName"].ToString();
                            labelEmailAddress.Text = reader["EmailAddress"].ToString();
                            labelContactNumber.Text = reader["ContactNumber"].ToString();

                            // Update pictureBoxUser
                            if (reader["UserIMG"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["UserIMG"];
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    using (Image originalImage = Image.FromStream(ms))
                                    {
                                        // Resize the image to 61x61
                                        Image resizedImage = ResizeImage(originalImage, 61, 61);
                                        pictureBoxUser.Image = resizedImage;
                                    }
                                }
                            }
                            else
                            {
                                pictureBoxUser.Image = null; // Clear the PictureBox if no image is available
                            }
                        }
                        else
                        {
                            MessageBox.Show("No user found with the specified name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching user details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBoxFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string fullName = textBoxFullName.Text.Trim();
                if (!string.IsNullOrEmpty(fullName))
                {
                    DisplayUserDetails(fullName);
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

        private void textBoxBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and delete keys
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        private void buttonIncrementQty_Click(object sender, EventArgs e)
        {
            // Parse the current quantity from the label
            int currentQty = int.Parse(labelQtyBorrow.Text);

            // Increment the quantity if it's less than 3
            if (currentQty < 3)
            {
                currentQty++;
                labelQtyBorrow.Text = currentQty.ToString();
            }
        }

        private void buttonDecrementQty_Click(object sender, EventArgs e)
        {
            // Parse the current quantity from the label
            int currentQty = int.Parse(labelQtyBorrow.Text);

            // Decrement the quantity if it's greater than 1
            if (currentQty > 1)
            {
                currentQty--;
                labelQtyBorrow.Text = currentQty.ToString();
            }
        }

        private void buttonAddBooksBorrow_Click(object sender, EventArgs e)
        {
            // Validate that a BookID is entered
            if (string.IsNullOrWhiteSpace(textBoxBookID.Text) || textBoxBookID.Text == "Enter Book ID")
            {
                MessageBox.Show("Please enter a valid Book ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse the BookID and quantity
            string bookId = textBoxBookID.Text.Trim();
            int borrowQty = int.Parse(labelQtyBorrow.Text);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the BookID exists and get its available quantity and title
                    string query = "SELECT Title, Qty FROM Books WHERE BookID = @BookID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BookID", bookId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string title = reader["Title"].ToString();
                            int availableQty = Convert.ToInt32(reader["Qty"]);

                            // Validate the borrow quantity against the available quantity
                            if (borrowQty > availableQty)
                            {
                                MessageBox.Show($"Cannot borrow {borrowQty} copies. Only {availableQty} copies are available for BookID {bookId}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Check if the book is already in the borrow list
                            bool bookExistsInList = false;
                            for (int i = 0; i < listBoxBorrowBooks.Items.Count; i++)
                            {
                                string[] parts = listBoxBorrowBooks.Items[i].ToString().Split(',');
                                if (parts[0].Trim() == bookId)
                                {
                                    bookExistsInList = true;

                                    // Update the quantity for the existing book
                                    int existingQty = int.Parse(parts[2].Trim());
                                    if (existingQty + borrowQty > 3)
                                    {
                                        MessageBox.Show($"Cannot borrow more than 3 copies of BookID {bookId}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    listBoxBorrowBooks.Items[i] = $"{bookId}, {title}, {existingQty + borrowQty}";
                                    MessageBox.Show($"Successfully updated the quantity to {existingQty + borrowQty} for BookID {bookId}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }

                            // Add the book to the listBoxBorrowBooks if it doesn't already exist
                            if (!bookExistsInList)
                            {
                                if (borrowQty > 3)
                                {
                                    MessageBox.Show($"Cannot borrow more than 3 copies of BookID {bookId}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                listBoxBorrowBooks.Items.Add($"{bookId}, {title}, {borrowQty}");
                                MessageBox.Show($"Successfully added {borrowQty} copies of '{title}' (BookID: {bookId}) to the borrow list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"BookID {bookId} does not exist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void buttonDeleteBooksBorrow_Click(object sender, EventArgs e)
        {
            // Validate that a BookID is entered
            if (string.IsNullOrWhiteSpace(textBoxBookID.Text) || textBoxBookID.Text == "Enter Book ID")
            {
                MessageBox.Show("Please enter a valid Book ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse the BookID
            string bookId = textBoxBookID.Text.Trim();

            // Check if the BookID exists in the listBoxBorrowBooks
            bool bookExistsInList = false;
            int selectedIndex = -1;

            for (int i = 0; i < listBoxBorrowBooks.Items.Count; i++)
            {
                string[] parts = listBoxBorrowBooks.Items[i].ToString().Split(',');
                if (parts[0].Trim() == bookId)
                {
                    bookExistsInList = true;
                    selectedIndex = i;
                    break;
                }
            }

            if (!bookExistsInList)
            {
                MessageBox.Show($"BookID {bookId} does not exist in the borrow list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Remove the item from the listBox
            listBoxBorrowBooks.Items.RemoveAt(selectedIndex);
            MessageBox.Show($"Successfully removed BookID {bookId} from the borrow list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClearBooksBorrowList_Click(object sender, EventArgs e)
        {
            // Clear all items from the listBox
            listBoxBorrowBooks.Items.Clear();
            MessageBox.Show("All items have been removed from the borrow list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBooksBorrowConfirmation_Click(object sender, EventArgs e)
        {

        }
    }
}
