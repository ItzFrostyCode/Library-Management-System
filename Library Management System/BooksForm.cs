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
    public partial class BooksForm : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=sys;User ID=root;Password=0430;";

        public BooksForm()
        {
            InitializeComponent();
            this.Load += BooksForm_Load;
            InitializeGenreComboBox();
            InitializeYearComboBox();
            InitializeCategoryBooksComboBox();
            StyleAllButtons();
            StyleDataGridViewBooks();

            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;


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
                        var bookImgValue = dataGridViewBooks.Rows[e.RowIndex].Cells["BookIMG"].Value;
                        if (bookImgValue != null && bookImgValue is byte[] imageBytes)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                // Convert byte[] to Image
                                using (Image originalImage = Image.FromStream(ms))
                                {
                                    // Resize the image to 111x111 for the PictureBox
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
                }
                // Check if the clicked column is the BookIMG column
                else if (dataGridViewBooks.Columns[e.ColumnIndex].Name == "BookIMG")
                {
                    // Get the BookID value from the same row
                    var bookIdValue = dataGridViewBooks.Rows[e.RowIndex].Cells["BookID"].Value;
                    if (bookIdValue != null)
                    {
                        // Open a file dialog to select an image
                        using (OpenFileDialog openFileDialog = new OpenFileDialog())
                        {
                            openFileDialog.Filter = "Image Files|*.jpg;*.png";
                            if (openFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string filePath = openFileDialog.FileName;
                                byte[] imageBytes = File.ReadAllBytes(filePath);

                                // Update the image in the database
                                using (MySqlConnection conn = new MySqlConnection(connectionString))
                                {
                                    try
                                    {
                                        conn.Open();
                                        string query = "UPDATE Books SET BookIMG = @BookIMG WHERE BookID = @BookID";
                                        MySqlCommand cmd = new MySqlCommand(query, conn);
                                        cmd.Parameters.AddWithValue("@BookIMG", imageBytes);
                                        cmd.Parameters.AddWithValue("@BookID", bookIdValue);
                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Image updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Refresh the DataGridView to show the updated image
                                        LoadDataGridView();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"An error occurred while updating the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
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


        private void InitializeGenreComboBox()
        {
            comboBoxGenre.Items.Add("Generalities (000)");
            comboBoxGenre.Items.Add("Philosophy & Psychology (100)");
            comboBoxGenre.Items.Add("Religion (200)");
            comboBoxGenre.Items.Add("Social Sciences (300)");
            comboBoxGenre.Items.Add("Language (400)");
            comboBoxGenre.Items.Add("Natural Sciences (500)");
            comboBoxGenre.Items.Add("Technology / Programming / IT (600)");
            comboBoxGenre.Items.Add("Engineering & Electronics");
            comboBoxGenre.Items.Add("The Arts (700)");
            comboBoxGenre.Items.Add("Literature & Rhetoric (800)");
            comboBoxGenre.Items.Add("Geography & History (900)");
            comboBoxGenre.Items.Add("Filipiniana");
            comboBoxGenre.Items.Add("Reference");
            comboBoxGenre.Items.Add("Reserve");
            comboBoxGenre.Items.Add("Fiction");
            comboBoxGenre.Items.Add("Periodicals");
            comboBoxGenre.Items.Add("Graduate Study Theses");
            comboBoxGenre.Items.Add("Asiana Collection");
            comboBoxGenre.Items.Add("Audio-Visual Materials");
            comboBoxGenre.Items.Add("Negrosiana Collections");
            comboBoxGenre.Items.Add("Christian Books");
            comboBoxGenre.Items.Add("Japanese Learning Materials");
            comboBoxGenre.Items.Add("Vertical Files");
            comboBoxGenre.Items.Add("Practical Research");
            comboBoxGenre.Items.Add("Cooking & Culinary Arts");
            comboBoxGenre.Items.Add("Health & Wellness");
            comboBoxGenre.Items.Add("Business & Entrepreneurship");
            comboBoxGenre.Items.Add("Mathematics");
            comboBoxGenre.Items.Add("Science Projects & Investigatory");
            comboBoxGenre.Items.Add("Computer Science");
            comboBoxGenre.Items.Add("Mobile & Web Development");
            comboBoxGenre.Items.Add("Education & Teaching");

        }

        private void InitializeYearComboBox()
        {
            comboBoxYear.Items.Clear();
            for (int year = DateTime.Now.Year; year >= 1900; year--)
            {
                comboBoxYear.Items.Add(year.ToString());
            }
        }

        private void InitializeCategoryBooksComboBox()
        {
            comboBoxCategoryBooks.Items.Add("BookID");
            comboBoxCategoryBooks.Items.Add("Title");
            comboBoxCategoryBooks.Items.Add("Author");
            comboBoxCategoryBooks.Items.Add("Genre");
            comboBoxCategoryBooks.Items.Add("Publisher");
            comboBoxCategoryBooks.Items.Add("Year");
            comboBoxCategoryBooks.Items.Add("ISBN");
            comboBoxCategoryBooks.Items.Add("Status");
            comboBoxCategoryBooks.SelectedIndex = 0;
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
                Name = "Publisher",
                HeaderText = "Publisher",
                DataPropertyName = "Publisher",
                ReadOnly = true,
                Width = 150
            });

            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Year",
                HeaderText = "Year",
                DataPropertyName = "Year",
                ReadOnly = true,
                Width = 80
            });

            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ISBN",
                HeaderText = "ISBN",
                DataPropertyName = "ISBN",
                ReadOnly = true,
                Width = 120
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

            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                ReadOnly = true,
                Width = 100
            });

            dataGridViewBooks.Columns.Add(new DataGridViewImageColumn
            {
                Name = "BookIMG",
                HeaderText = "Book Image",
                DataPropertyName = "BookIMG",
                ReadOnly = true,
                Width = 100
            });


            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.ReadOnly = true;
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT BookID, Title, Author, Genre, Publisher, Year, ISBN, Qty, Status, Price, BookIMG FROM Books";
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


        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            // Validate all required fields
            if (string.IsNullOrWhiteSpace(textBoxBookID.Text) || textBoxBookID.Text == "Enter Book ID" ||
                string.IsNullOrWhiteSpace(textBoxTitleBook.Text) || string.IsNullOrWhiteSpace(textBoxAuthorBook.Text) ||
                string.IsNullOrWhiteSpace(textBoxPublisher.Text) || string.IsNullOrWhiteSpace(textBoxISBN.Text) ||
                string.IsNullOrWhiteSpace(textBoxQuantity.Text) || string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
                comboBoxGenre.SelectedItem == null || comboBoxYear.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields before adding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate BookID (must be numeric)
            if (!int.TryParse(textBoxBookID.Text, out int bookId))
            {
                MessageBox.Show("Book ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate ISBN (must be 13 digits and numeric)
            if (textBoxISBN.Text.Length != 13 || !long.TryParse(textBoxISBN.Text, out _))
            {
                MessageBox.Show("ISBN must be exactly 13 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Quantity and Price (must be numeric)
            if (!int.TryParse(textBoxQuantity.Text, out int quantity) || !decimal.TryParse(textBoxPrice.Text, out decimal price))
            {
                MessageBox.Show("Quantity and Price must be valid numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if BookID, Title, Author, Publisher, or ISBN already exists
                    string checkQuery = @"
                SELECT COUNT(*) 
                FROM Books 
                WHERE BookID = @BookID 
                   OR Title = @Title 
                   OR Author = @Author 
                   OR Publisher = @Publisher 
                   OR ISBN = @ISBN";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@BookID", bookId);
                    checkCmd.Parameters.AddWithValue("@Title", textBoxTitleBook.Text);
                    checkCmd.Parameters.AddWithValue("@Author", textBoxAuthorBook.Text);
                    checkCmd.Parameters.AddWithValue("@Publisher", textBoxPublisher.Text);
                    checkCmd.Parameters.AddWithValue("@ISBN", textBoxISBN.Text);

                    int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (existingCount > 0)
                    {
                        MessageBox.Show("A book with the same Book ID, Title, Author, Publisher, or ISBN already exists. Please use unique values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert the new book into the database
                    string query = "INSERT INTO Books (BookID, Title, Author, Genre, Publisher, Year, ISBN, Qty, Status, Price) " +
                                   "VALUES (@BookID, @Title, @Author, @Genre, @Publisher, @Year, @ISBN, @Qty, @Status, @Price)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BookID", bookId);
                    cmd.Parameters.AddWithValue("@Title", textBoxTitleBook.Text);
                    cmd.Parameters.AddWithValue("@Author", textBoxAuthorBook.Text);
                    cmd.Parameters.AddWithValue("@Genre", comboBoxGenre.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Publisher", textBoxPublisher.Text);
                    cmd.Parameters.AddWithValue("@Year", comboBoxYear.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ISBN", textBoxISBN.Text);
                    cmd.Parameters.AddWithValue("@Qty", quantity);
                    cmd.Parameters.AddWithValue("@Status", quantity > 0 ? "Available" : "NotAvailable");
                    cmd.Parameters.AddWithValue("@Price", price);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Clear text fields
            textBoxBookID.Clear();
            textBoxTitleBook.Clear();
            textBoxAuthorBook.Clear();
            textBoxISBN.Clear();
            textBoxPublisher.Clear();
            textBoxQuantity.Clear();
            textBoxPrice.Clear();
            textBoxBooksSearch.Clear();

            // Reset combo boxes
            comboBoxGenre.SelectedIndex = -1;
            comboBoxYear.SelectedIndex = -1;
            comboBoxCategoryBooks.SelectedIndex = -1;
        }




        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            // Validate that BookID is provided
            if (string.IsNullOrWhiteSpace(textBoxBookID.Text))
            {
                MessageBox.Show("Book ID is required to update a book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that BookID is numeric
            if (!int.TryParse(textBoxBookID.Text, out int bookId))
            {
                MessageBox.Show("Book ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the BookID exists in the database
                    string checkBookIdQuery = "SELECT COUNT(*) FROM Books WHERE BookID = @BookID";
                    MySqlCommand checkBookIdCmd = new MySqlCommand(checkBookIdQuery, conn);
                    checkBookIdCmd.Parameters.AddWithValue("@BookID", bookId);

                    int bookIdCount = Convert.ToInt32(checkBookIdCmd.ExecuteScalar());

                    if (bookIdCount == 0)
                    {
                        MessageBox.Show("The specified Book ID does not exist. Please enter a valid Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Build the update query dynamically to allow incomplete fields
                    string query = "UPDATE Books SET ";
                    var parameters = new List<MySqlParameter>();

                    if (!string.IsNullOrWhiteSpace(textBoxTitleBook.Text))
                    {
                        query += "Title = @Title, ";
                        parameters.Add(new MySqlParameter("@Title", textBoxTitleBook.Text));
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxAuthorBook.Text))
                    {
                        query += "Author = @Author, ";
                        parameters.Add(new MySqlParameter("@Author", textBoxAuthorBook.Text));
                    }

                    if (comboBoxGenre.SelectedItem != null)
                    {
                        query += "Genre = @Genre, ";
                        parameters.Add(new MySqlParameter("@Genre", comboBoxGenre.SelectedItem.ToString()));
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxPublisher.Text))
                    {
                        query += "Publisher = @Publisher, ";
                        parameters.Add(new MySqlParameter("@Publisher", textBoxPublisher.Text));
                    }

                    if (comboBoxYear.SelectedItem != null)
                    {
                        query += "Year = @Year, ";
                        parameters.Add(new MySqlParameter("@Year", comboBoxYear.SelectedItem.ToString()));
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxISBN.Text))
                    {
                        query += "ISBN = @ISBN, ";
                        parameters.Add(new MySqlParameter("@ISBN", textBoxISBN.Text));
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxQuantity.Text) && int.TryParse(textBoxQuantity.Text, out int quantity))
                    {
                        query += "Qty = @Qty, ";
                        parameters.Add(new MySqlParameter("@Qty", quantity));

                        // Update the status based on quantity
                        string status = quantity > 0 ? "Available" : "NotAvailable";
                        query += "Status = @Status, ";
                        parameters.Add(new MySqlParameter("@Status", status));
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxPrice.Text) && decimal.TryParse(textBoxPrice.Text, out decimal price))
                    {
                        query += "Price = @Price, ";
                        parameters.Add(new MySqlParameter("@Price", price));
                    }

                    // Remove the trailing comma and space
                    query = query.TrimEnd(',', ' ');

                    // Add the WHERE clause
                    query += " WHERE BookID = @BookID";
                    parameters.Add(new MySqlParameter("@BookID", bookId));

                    // Execute the query
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddRange(parameters.ToArray());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book information updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Clear text fields
            textBoxBookID.Clear();
            textBoxTitleBook.Clear();
            textBoxAuthorBook.Clear();
            textBoxISBN.Clear();
            textBoxPublisher.Clear();
            textBoxQuantity.Clear();
            textBoxPrice.Clear();
            textBoxBooksSearch.Clear();

            // Reset combo boxes
            comboBoxGenre.SelectedIndex = -1;
            comboBoxYear.SelectedIndex = -1;
            comboBoxCategoryBooks.SelectedIndex = -1;
        }


        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            // Validate BookID
            if (string.IsNullOrWhiteSpace(textBoxBookID.Text) || textBoxBookID.Text == "Enter Book ID")
            {
                MessageBox.Show("Please enter a valid Book ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxBookID.Text, out int bookId))
            {
                MessageBox.Show("Book ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the BookID exists
                    string checkQuery = "SELECT COUNT(*) FROM Books WHERE BookID = @BookID";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@BookID", bookId);
                    int bookCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (bookCount == 0)
                    {
                        MessageBox.Show("Book ID not found. Please check the ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result != DialogResult.Yes)
                    {
                        return;
                    }

                    // Delete the book
                    string query = "DELETE FROM Books WHERE BookID = @BookID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BookID", bookId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Clear text fields
            textBoxBookID.Clear();
            textBoxTitleBook.Clear();
            textBoxAuthorBook.Clear();
            textBoxISBN.Clear();
            textBoxPublisher.Clear();
            textBoxQuantity.Clear();
            textBoxPrice.Clear();
            textBoxBooksSearch.Clear();

            // Reset combo boxes
            comboBoxGenre.SelectedIndex = -1;
            comboBoxYear.SelectedIndex = -1;
            comboBoxCategoryBooks.SelectedIndex = -1;
        }



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            if (comboBoxCategoryBooks.SelectedItem == null || string.IsNullOrWhiteSpace(textBoxBooksSearch.Text))
            {
                MessageBox.Show("Please select a category and enter a search value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCategory = comboBoxCategoryBooks.SelectedItem.ToString();
            string searchValue = textBoxBooksSearch.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = $"SELECT BookID, Title, Author, Genre, Publisher, Year, ISBN, Qty, Status, Price " +
                                   $"FROM Books WHERE {selectedCategory} LIKE @SearchValue";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchValue", $"%{searchValue}%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewBooks.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void textBoxBooksSearch_TextChanged(object sender, EventArgs e)
        {

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

        // ---------- Panels Form Design ---------- \\

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelMain.ClientRectangle, 12);
        }

        private void panelBookID_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelBookID.ClientRectangle, 12);
        }

        private void panelTitleBook_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelTitleBook.ClientRectangle, 12);
        }

        private void panelAuthorBook_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelAuthorBook.ClientRectangle, 12);
        }

        private void panelPublisher_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelPublisher.ClientRectangle, 12);
        }
        private void panelISBN_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelISBN.ClientRectangle, 12);
        }
        private void panelQuantity_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelQuantity.ClientRectangle, 12);
        }


        private void panelPrice_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelPrice.ClientRectangle, 12);
        }


        private void panelGenre_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelGenre.ClientRectangle, 12);
        }

        private void panelYear_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelYear.ClientRectangle, 12);
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

            StyleButton(buttonAddBook);
            StyleButton(buttonUpdateBook);
            StyleButton(buttonDeleteBook);
        }



        private void textBoxUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void textBoxUserID_Enter(object sender, EventArgs e)
        {
            if (textBoxBookID.Text == "Enter Book ID")
            {
                textBoxBookID.Text = "";
                textBoxBookID.ForeColor = Color.Black; // Change text color to black when editing
            }
        }

        private void textBoxUserID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBookID.Text))
            {
                textBoxBookID.Text = "Enter Book ID";
                textBoxBookID.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }

        private void textBoxTitleBook_Enter(object sender, EventArgs e)
        {
            if (textBoxTitleBook.Text == "Enter Book Title")
            {
                textBoxTitleBook.Text = "";
                textBoxTitleBook.ForeColor = Color.Black;
            }
        }

        private void textBoxTitleBook_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitleBook.Text))
            {
                textBoxTitleBook.Text = "Enter Book Title";
                textBoxTitleBook.ForeColor = Color.Gray;
            }
        }

        private void textBoxAuthorBook_Enter(object sender, EventArgs e)
        {
            if (textBoxAuthorBook.Text == "Enter Author Name")
            {
                textBoxAuthorBook.Text = "";
                textBoxAuthorBook.ForeColor = Color.Black;
            }
        }

        private void textBoxAuthorBook_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAuthorBook.Text))
            {
                textBoxAuthorBook.Text = "Enter Author Name";
                textBoxAuthorBook.ForeColor = Color.Gray;
            }
        }

        private void textBoxISBN_Enter(object sender, EventArgs e)
        {
            if (textBoxISBN.Text == "Enter ISBN")
            {
                textBoxISBN.Text = "";
                textBoxISBN.ForeColor = Color.Black;
            }
        }

        private void textBoxISBN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxISBN.Text))
            {
                textBoxISBN.Text = "Enter ISBN";
                textBoxISBN.ForeColor = Color.Gray;
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPublisher_Enter(object sender, EventArgs e)
        {

            if (textBoxPublisher.Text == "Enter Publisher")
            {
                textBoxPublisher.Text = "";
                textBoxPublisher.ForeColor = Color.Black;
            }
        }

        private void textBoxPublisher_Leave(object sender, EventArgs e)
        {
            // Restore placeholder text and set text color to gray if the text box is empty
            if (string.IsNullOrWhiteSpace(textBoxPublisher.Text))
            {
                textBoxPublisher.Text = "Enter Publisher";
                textBoxPublisher.ForeColor = Color.Gray;
            }
        }


        private void textBoxQuantity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxQuantity.Text))
            {
                textBoxQuantity.Text = "Enter Quantity";
                textBoxQuantity.ForeColor = Color.Gray;
            }
        }

        private void textBoxPrice_Enter(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "Enter Price")
            {
                textBoxPrice.Text = "";
                textBoxPrice.ForeColor = Color.Black;
            }
        }

        private void textBoxPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                textBoxPrice.Text = "Enter Price";
                textBoxPrice.ForeColor = Color.Gray;
            }
        }

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



        private void textBoxQuantity_Enter(object sender, EventArgs e)
        {
            if (textBoxQuantity.Text == "Enter Quantity")
            {
                textBoxQuantity.Text = "";
                textBoxQuantity.ForeColor = Color.Black;
            }
        }




        private void textBoxBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGenre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
    }
}

