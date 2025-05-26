using MySqlConnector;
using System;
using System.Collections.Generic;
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
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            AdminLoginForm loginForm = new AdminLoginForm();
            loginForm.Show();
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



        private void textBoxBookID_Enter_1(object sender, EventArgs e)
        {
            if (textBoxBookID.Text == "Enter Book ID")
            {
                textBoxBookID.Text = "";
                textBoxBookID.ForeColor = Color.Black; // Change text color to black when editing
            }
        }

        private void textBoxBookID_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBookID.Text))
            {
                textBoxBookID.Text = "Enter Book ID";
                textBoxBookID.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }

        private void textBoxBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        private void buttonIncrementQty_Click(object sender, EventArgs e)
        {
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

        private void buttonDeleteBooksBorrow_Click_1(object sender, EventArgs e)
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

        private void buttonBooksBorrowConfirmation_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Borrow Confirmation Button Clicked"); // Keep this for your debugging if you like

            // Validate User Details
            if (string.IsNullOrWhiteSpace(labelUserID.Text) || labelUserID.Text == "N/A") // Assuming "N/A" is a placeholder
            {
                MessageBox.Show("Please select a user first by entering their name and pressing Enter.", "User Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(labelFullName.Text) || labelFullName.Text == "N/A") // Assuming "N/A" is a placeholder
            {
                MessageBox.Show("User's full name is missing. Please select a user.", "User Details Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long userID;
            if (!long.TryParse(labelUserID.Text, out userID))
            {
                MessageBox.Show("Invalid User ID format in user details.", "User Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fullName = labelFullName.Text;

            // Validate Borrow List
            if (listBoxBorrowBooks.Items.Count == 0)
            {
                MessageBox.Show("Please add books to the borrow list first.", "No Books to Borrow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prepare list of books to borrow
            List<LibraryService.BookToBorrow> booksToBorrowList = new List<LibraryService.BookToBorrow>(); // booksToBorrowList = []
            foreach (var item in listBoxBorrowBooks.Items)
            {
                string itemString = item.ToString();
                string[] parts = itemString.Split(new[] { ',' }, 3); // Split into max 3 parts: ID, Title, Qty

                if (parts.Length == 3)
                {
                    if (long.TryParse(parts[0].Trim(), out long bookId) &&
                        int.TryParse(parts[2].Trim(), out int qtyToBorrow))
                    {
                        string title = parts[1].Trim();
                        if (qtyToBorrow <= 0)
                        {
                            MessageBox.Show($"Invalid quantity ({qtyToBorrow}) for book '{title}' (ID: {bookId}) in the borrow list. Quantity must be positive.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Stop processing
                        }
                        booksToBorrowList.Add(new LibraryService.BookToBorrow
                        {
                            BookID = bookId,
                            Title = title,
                            QuantityToBorrow = qtyToBorrow
                        });
                    }
                    else
                    {
                        MessageBox.Show($"Could not parse data for list item: '{itemString}'. Please check the format (BookID, Title, Quantity).", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop processing if data is malformed
                    }
                }
                else
                {
                    MessageBox.Show($"Invalid format for list item: '{itemString}'. Expected 'BookID, Title, Quantity'.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop processing if data is malformed
                }
            }

            if (booksToBorrowList.Count == 0) // Should be caught earlier, but as a safeguard
            {
                MessageBox.Show("Failed to prepare the list of books for borrowing.", "Process Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Process Borrowing ---
            // You already have 'connectionString' as a private member in your Borrow class
            LibraryService libraryService = new LibraryService(this.connectionString); // Pass your form's connection string

            bool success = libraryService.ProcessBorrowing(userID, fullName, booksToBorrowList);

            if (success)
            {
                // Clear UI elements
                textBoxFullName.Text = "First Name / Middle Initial / Last Name";
                textBoxFullName.ForeColor = Color.Gray;
                labelUserID.Text = "N/A"; // Or your default placeholder
                labelFullName.Text = "N/A";
                labelEmailAddress.Text = "N/A";
                labelContactNumber.Text = "N/A";
                pictureBoxUser.Image = null;

                listBoxBorrowBooks.Items.Clear();
                textBoxBookID.Text = "Enter Book ID";
                textBoxBookID.ForeColor = Color.Gray;
                labelQtyBorrow.Text = "1"; // Reset quantity selector
                pictureBoxBooks.Image = null;


                // Refresh the main books DataGridView
                LoadDataGridView(); // You already have this method
            }
            // Else, LibraryService.ProcessBorrowing would have shown an error message.
        }


    }

    public class LibraryService
    {
        private string _connectionString;

        // Constructor to accept the connection string
        public LibraryService(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString), "Connection string cannot be null or empty.");
            }
            this._connectionString = connectionString;
        }

        // Helper class to hold book details for borrowing
        public class BookToBorrow
        {
            public long BookID { get; set; }
            public string Title { get; set; } // As per your BorrowedBooks table
            public int QuantityToBorrow { get; set; }
        }

        /// <summary>
        /// Handles the overall book borrowing process.
        /// </summary>
        /// <param name="userID">The ID of the user borrowing the books.</param>
        /// <param name="fullName">The full name of the user borrowing the books.</param>
        /// <param name="booksToBorrowList">A list of books to be borrowed.</param>
        /// <returns>True if borrowing was successful, false otherwise.</returns>
        public bool ProcessBorrowing(long userID, string fullName, List<BookToBorrow> booksToBorrowList)
        {
            if (booksToBorrowList == null || booksToBorrowList.Count == 0)
            {
                MessageBox.Show("No books selected for borrowing.", "Borrowing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction(); // Start a transaction

                try
                {
                    // Step 1: Check book availability and quantity before proceeding
                    foreach (var book in booksToBorrowList)
                    {
                        // Validate QuantityToBorrow again, as it might come from various sources
                        if (book.QuantityToBorrow <= 0)
                        {
                            transaction.Rollback(); // No need to close reader as it's not open yet
                            MessageBox.Show($"Quantity to borrow for Book ID {book.BookID} ('{book.Title}') must be greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        string checkQtyQuery = "SELECT Qty, Status FROM Books WHERE BookID = @BookID FOR UPDATE;"; // Add FOR UPDATE for locking
                        using (MySqlCommand checkCmd = new MySqlCommand(checkQtyQuery, connection, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@BookID", book.BookID);
                            using (MySqlDataReader reader = checkCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int availableQty = reader.GetInt32("Qty");
                                    // string bookStatus = reader.GetString("Status"); // Not strictly needed here

                                    if (availableQty < book.QuantityToBorrow)
                                    {
                                        reader.Close();
                                        transaction.Rollback();
                                        MessageBox.Show($"Not enough stock for Book ID {book.BookID} ('{book.Title}'). Available: {availableQty}, Requested: {book.QuantityToBorrow}.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return false;
                                    }
                                }
                                else
                                {
                                    reader.Close();
                                    transaction.Rollback();
                                    MessageBox.Show($"Book ID {book.BookID} ('{book.Title}') not found.", "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            } // Reader is disposed here
                        }
                    }

                    // Step 2: Insert into BorrowerTable
                    string insertBorrowerQuery = @"
                        INSERT INTO BorrowerTable (UserID, FullName, DateTimeBorrow, DueDateTimeReturn, Status)
                        VALUES (@UserID, @FullName, @DateTimeBorrow, @DueDateTimeReturn, @Status);
                        SELECT LAST_INSERT_ID();"; // Get the auto-generated BorrowerBookID

                    long borrowerBookID;
                    DateTime dateTimeBorrow = DateTime.Now;
                    // Example: Due date is 7 days from now. Adjust as per your library's policy.
                    DateTime dueDateTimeReturn = dateTimeBorrow.AddDays(7);

                    using (MySqlCommand borrowerCmd = new MySqlCommand(insertBorrowerQuery, connection, transaction))
                    {
                        borrowerCmd.Parameters.AddWithValue("@UserID", userID);
                        borrowerCmd.Parameters.AddWithValue("@FullName", fullName);
                        borrowerCmd.Parameters.AddWithValue("@DateTimeBorrow", dateTimeBorrow);
                        borrowerCmd.Parameters.AddWithValue("@DueDateTimeReturn", dueDateTimeReturn);
                        borrowerCmd.Parameters.AddWithValue("@Status", "Borrowed"); // Enum 'Borrowed'

                        borrowerBookID = Convert.ToInt64(borrowerCmd.ExecuteScalar());
                    }

                    if (borrowerBookID <= 0)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Failed to create a borrower record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Step 3: Insert into BorrowedBooks and Update Books table for each book
                    string insertBorrowedBookQuery = @"
                        INSERT INTO BorrowedBooks (BorrowerBookID, BookID, Title, Qty)
                        VALUES (@BorrowerBookID, @BookID, @Title, @Qty);";

                    string updateBookQtyQuery = @"
                        UPDATE Books
                        SET Qty = Qty - @BorrowedQty,
                            Status = CASE
                                         WHEN (Qty - @BorrowedQty) > 0 THEN 'Available'
                                         ELSE 'NotAvailable'
                                     END
                        WHERE BookID = @BookID AND Qty >= @BorrowedQty;";

                    foreach (var book in booksToBorrowList)
                    {
                        // Insert into BorrowedBooks
                        using (MySqlCommand borrowedBookCmd = new MySqlCommand(insertBorrowedBookQuery, connection, transaction))
                        {
                            borrowedBookCmd.Parameters.AddWithValue("@BorrowerBookID", borrowerBookID);
                            borrowedBookCmd.Parameters.AddWithValue("@BookID", book.BookID);
                            borrowedBookCmd.Parameters.AddWithValue("@Title", book.Title);
                            borrowedBookCmd.Parameters.AddWithValue("@Qty", book.QuantityToBorrow);
                            borrowedBookCmd.ExecuteNonQuery();
                        }

                        // Update Books table quantity and status
                        using (MySqlCommand updateBookCmd = new MySqlCommand(updateBookQtyQuery, connection, transaction))
                        {
                            updateBookCmd.Parameters.AddWithValue("@BorrowedQty", book.QuantityToBorrow);
                            updateBookCmd.Parameters.AddWithValue("@BookID", book.BookID);
                            int rowsAffected = updateBookCmd.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"Failed to update stock for Book ID {book.BookID} ('{book.Title}'). The quantity might have changed or book is no longer available. Borrowing cancelled.", "Concurrency Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Books borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (MySqlException ex)
                {
                    try { transaction.Rollback(); } catch (Exception rbEx) { Console.WriteLine($"Rollback failed: {rbEx.Message}"); }
                    MessageBox.Show($"A database error occurred: {ex.Message}\nError Code: {ex.Number}\nSQL State: {ex.SqlState}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    try { transaction.Rollback(); } catch (Exception rbEx) { Console.WriteLine($"Rollback failed: {rbEx.Message}"); }
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
