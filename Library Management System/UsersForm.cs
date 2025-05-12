using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Library_Management_System
{
    public partial class UsersForm : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=sys;User ID=root;Password=0430;";
        private object resizedImage;
        private object originalImage;

        public UsersForm()
        {
            InitializeComponent();
            this.Load += UsersForm_Load;
            InitializeUserTypeComboBox();
            InitializeCategoryUsersComboBox();
            ConfigureDataGridView();
            StyleAllButtons();
            LoadDataGridView();
            StyleDataGridViewUsers();
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
        }

        // -------------------- Form Load -------------------- //
        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            textBoxUserID.Text = GetNextAvailableUserID().ToString();
        }

        private long GetNextAvailableUserID()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IFNULL(MAX(UserID), 0) + 1 FROM Users";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    return Convert.ToInt64(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while fetching the next available UserID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1; // Default to 1 if an error occurs
                }
            }
        }

        // -------------------- Initialization -------------------- //
        private void InitializeUserTypeComboBox()
        {
            comboBoxUserType.Items.Clear();
            comboBoxUserType.Items.Add("Student");
            comboBoxUserType.Items.Add("Teacher");
        }

        private void InitializeCategoryUsersComboBox()
        {
            comboBoxCategoryUsers.Items.Add("SchoolID");
            comboBoxCategoryUsers.Items.Add("FullName");
            comboBoxCategoryUsers.Items.Add("ContactNumber");
            comboBoxCategoryUsers.Items.Add("UserType");
            comboBoxCategoryUsers.Items.Add("RegisteredDate");
            comboBoxCategoryUsers.SelectedIndex = 0;
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
        // -------- Navigation buttons end -------- \\

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row and column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the clicked column is the UserID column
                if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "UserID")
                {
                    // Get the UserID value from the clicked cell
                    var userIdValue = dataGridViewUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (userIdValue != null)
                    {
                        // Retrieve the corresponding image for the selected UserID
                        var userImgValue = dataGridViewUsers.Rows[e.RowIndex].Cells["UserIMG"].Value;
                        if (userImgValue != null && userImgValue is byte[] imageBytes)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                // Convert byte[] to Image
                                using (Image originalImage = Image.FromStream(ms))
                                {
                                    // Resize the image to 111x111 for the PictureBox
                                    Image resizedImage = ResizeImage(originalImage, 111, 111);
                                    pictureBoxUser.Image = resizedImage;
                                }
                            }
                        }
                        else
                        {
                            // Clear the PictureBox if no image is available
                            pictureBoxUser.Image = null;
                        }
                    }
                }
                // Check if the clicked column is the UserIMG column
                else if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "UserIMG")
                {
                    // Get the UserID value from the same row
                    var userIdValue = dataGridViewUsers.Rows[e.RowIndex].Cells["UserID"].Value;
                    if (userIdValue != null)
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
                                        string query = "UPDATE Users SET UserIMG = @UserIMG WHERE UserID = @UserID";
                                        MySqlCommand cmd = new MySqlCommand(query, conn);
                                        cmd.Parameters.AddWithValue("@UserIMG", imageBytes);
                                        cmd.Parameters.AddWithValue("@UserID", userIdValue);
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



        private void LoadDataGridView()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT UserID, FullName, UserType, SchoolID, ContactNumber, EmailAddress, RegisteredDate, UserIMG FROM Users";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Resize images to match font size
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["UserIMG"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])row["UserIMG"];
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                using (Image originalImage = Image.FromStream(ms))
                                {
                                    Image resizedImage = ResizeImage(originalImage, 25, 25);
                                    using (MemoryStream resizedStream = new MemoryStream())
                                    {
                                        resizedImage.Save(resizedStream, originalImage.RawFormat);
                                        row["UserIMG"] = resizedStream.ToArray();
                                    }
                                }
                            }
                        }
                    }

                    dataGridViewUsers.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Helper method to resize the image
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







        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            // Validate all fields
            if (string.IsNullOrWhiteSpace(textBoxUserID.Text) || textBoxUserID.Text == "Enter User ID" ||
                string.IsNullOrWhiteSpace(textBoxSchoolID.Text) || string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxContactNumber.Text) || string.IsNullOrWhiteSpace(textBoxEmailAddress.Text) ||
                string.IsNullOrWhiteSpace(comboBoxUserType.Text))
            {
                MessageBox.Show("Please fill in all required fields before adding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate UserID (must be numeric)
            if (!long.TryParse(textBoxUserID.Text, out long userId))
            {
                MessageBox.Show("User ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Contact Number (must be 11 digits and start with "09")
            if (textBoxContactNumber.Text.Length != 11 || !textBoxContactNumber.Text.StartsWith("09") || !long.TryParse(textBoxContactNumber.Text, out _))
            {
                MessageBox.Show("Contact Number must be 11 digits and start with '09'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if Full Name, SchoolID, Contact Number, or Email Address already exists
                    string checkQuery = @"
                SELECT COUNT(*) 
                FROM Users 
                WHERE FullName = @FullName 
                   OR SchoolID = @SchoolID 
                   OR ContactNumber = @ContactNumber 
                   OR EmailAddress = @EmailAddress";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@FullName", textBoxFullName.Text);
                    checkCmd.Parameters.AddWithValue("@SchoolID", textBoxSchoolID.Text);
                    checkCmd.Parameters.AddWithValue("@ContactNumber", textBoxContactNumber.Text);
                    checkCmd.Parameters.AddWithValue("@EmailAddress", textBoxEmailAddress.Text);

                    int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (existingCount > 0)
                    {
                        MessageBox.Show("A user with the same Full Name, School ID, Contact Number, or Email Address already exists. Please use unique values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert the new user into the database
                    string query = "INSERT INTO Users (UserID, SchoolID, FullName, ContactNumber, EmailAddress, UserType, RegisteredDate) " +
                                   "VALUES (@UserID, @SchoolID, @FullName, @ContactNumber, @EmailAddress, @UserType, @RegisteredDate)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@SchoolID", textBoxSchoolID.Text);
                    cmd.Parameters.AddWithValue("@FullName", textBoxFullName.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", textBoxContactNumber.Text);
                    cmd.Parameters.AddWithValue("@EmailAddress", textBoxEmailAddress.Text);
                    cmd.Parameters.AddWithValue("@UserType", comboBoxUserType.Text);
                    cmd.Parameters.AddWithValue("@RegisteredDate", DateTime.Now.Date);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();

                    // Refresh the next available UserID
                    textBoxUserID.Text = GetNextAvailableUserID().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            textBoxSchoolID.Clear();
            textBoxFullName.Clear();
            textBoxContactNumber.Clear();
            textBoxEmailAddress.Clear();
            textBoxUsersSearch.Clear();

            // Reset combo boxes
            comboBoxUserType.SelectedIndex = -1;
            comboBoxCategoryUsers.SelectedIndex = -1;
        }





        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            // Validate that UserID is provided
            if (string.IsNullOrWhiteSpace(textBoxUserID.Text))
            {
                MessageBox.Show("User ID is required to update a user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that UserID is numeric
            if (!long.TryParse(textBoxUserID.Text, out long userId))
            {
                MessageBox.Show("User ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the UserID exists in the database
                    string checkUserIdQuery = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID";
                    MySqlCommand checkUserIdCmd = new MySqlCommand(checkUserIdQuery, conn);
                    checkUserIdCmd.Parameters.AddWithValue("@UserID", userId);

                    int userIdCount = Convert.ToInt32(checkUserIdCmd.ExecuteScalar());

                    if (userIdCount == 0)
                    {
                        MessageBox.Show("The specified User ID does not exist. Please enter a valid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the email already exists for a different user
                    if (!string.IsNullOrWhiteSpace(textBoxEmailAddress.Text))
                    {
                        string checkEmailQuery = "SELECT COUNT(*) FROM Users WHERE EmailAddress = @EmailAddress AND UserID != @UserID";
                        MySqlCommand checkEmailCmd = new MySqlCommand(checkEmailQuery, conn);
                        checkEmailCmd.Parameters.AddWithValue("@EmailAddress", textBoxEmailAddress.Text);
                        checkEmailCmd.Parameters.AddWithValue("@UserID", userId);
                        int emailCount = Convert.ToInt32(checkEmailCmd.ExecuteScalar());

                        if (emailCount > 0)
                        {
                            MessageBox.Show("This email address is already in use by another user. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Build the update query dynamically to allow incomplete fields
                    string query = "UPDATE Users SET ";
                    var parameters = new List<MySqlParameter>();

                    if (!string.IsNullOrWhiteSpace(textBoxSchoolID.Text))
                    {
                        query += "SchoolID = @SchoolID, ";
                        parameters.Add(new MySqlParameter("@SchoolID", textBoxSchoolID.Text));
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxFullName.Text))
                    {
                        query += "FullName = @FullName, ";
                        parameters.Add(new MySqlParameter("@FullName", textBoxFullName.Text));
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxContactNumber.Text))
                    {
                        query += "ContactNumber = @ContactNumber, ";
                        parameters.Add(new MySqlParameter("@ContactNumber", textBoxContactNumber.Text));
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxEmailAddress.Text))
                    {
                        query += "EmailAddress = @EmailAddress, ";
                        parameters.Add(new MySqlParameter("@EmailAddress", textBoxEmailAddress.Text));
                    }

                    if (!string.IsNullOrWhiteSpace(comboBoxUserType.Text))
                    {
                        query += "UserType = @UserType, ";
                        parameters.Add(new MySqlParameter("@UserType", comboBoxUserType.Text));
                    }

                    // Remove the trailing comma and space
                    query = query.TrimEnd(',', ' ');

                    // Add the WHERE clause
                    query += " WHERE UserID = @UserID";
                    parameters.Add(new MySqlParameter("@UserID", userId));

                    // Execute the query
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddRange(parameters.ToArray());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User information updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            textBoxUserID.Clear();
            textBoxSchoolID.Clear();
            textBoxFullName.Clear();
            textBoxContactNumber.Clear();
            textBoxEmailAddress.Clear();
            textBoxUsersSearch.Clear();

            // Reset combo boxes
            comboBoxUserType.SelectedIndex = -1;
            comboBoxCategoryUsers.SelectedIndex = -1;
        }





        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserID.Text) || textBoxUserID.Text == "Enter User ID")
            {
                MessageBox.Show("Please enter a valid User ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that UserID is numeric
            if (!long.TryParse(textBoxUserID.Text, out long userId))
            {
                MessageBox.Show("User ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the UserID exists in the database
                    string checkUserIdQuery = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID";
                    MySqlCommand checkUserIdCmd = new MySqlCommand(checkUserIdQuery, conn);
                    checkUserIdCmd.Parameters.AddWithValue("@UserID", userId);

                    int userIdCount = Convert.ToInt32(checkUserIdCmd.ExecuteScalar());

                    if (userIdCount == 0)
                    {
                        MessageBox.Show("The specified User ID does not exist. Please enter a valid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result != DialogResult.Yes)
                    {
                        return;
                    }

                    // Delete the user
                    string query = "DELETE FROM Users WHERE UserID = @UserID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            textBoxUserID.Clear();
            textBoxSchoolID.Clear();
            textBoxFullName.Clear();
            textBoxContactNumber.Clear();
            textBoxEmailAddress.Clear();
            textBoxUsersSearch.Clear();

            // Reset combo boxes
            comboBoxUserType.SelectedIndex = -1;
            comboBoxCategoryUsers.SelectedIndex = -1;
        }


        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            dataGridViewUsers.ReadOnly = true;
        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUserType.Items.Count == 0)
            {
                InitializeUserTypeComboBox();
            }
        }

        private void comboBoxCategoryUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBoxUsersSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            if (comboBoxCategoryUsers.SelectedItem == null || string.IsNullOrWhiteSpace(textBoxUsersSearch.Text))
            {
                MessageBox.Show("Please select a category and enter a search resizedImageObject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCategory = comboBoxCategoryUsers.SelectedItem.ToString();
            string searchValue = textBoxUsersSearch.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = $"SELECT UserID, SchoolID, FullName, ContactNumber, EmailAddress, UserType, RegisteredDate " +
                                   $"FROM Users WHERE {selectedCategory} LIKE @SearchValue";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchValue", $"%{searchValue}%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewUsers.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            // Clear existing columns
            dataGridViewUsers.Columns.Clear();

            // Add UserID column
            var userIdColumn = new DataGridViewTextBoxColumn
            {
                Name = "UserID",
                HeaderText = "User ID",
                DataPropertyName = "UserID",
                ReadOnly = true,
                Width = 80
            };
            dataGridViewUsers.Columns.Add(userIdColumn);

            // Add FullName column
            var fullNameColumn = new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "Full Name",
                DataPropertyName = "FullName",
                ReadOnly = true,
                Width = 200
            };
            dataGridViewUsers.Columns.Add(fullNameColumn);

            // Add UserType column
            var userTypeColumn = new DataGridViewTextBoxColumn
            {
                Name = "UserType",
                HeaderText = "User Type",
                DataPropertyName = "UserType",
                ReadOnly = true,
                Width = 120
            };
            dataGridViewUsers.Columns.Add(userTypeColumn);

            // Add SchoolID column
            var schoolIdColumn = new DataGridViewTextBoxColumn
            {
                Name = "SchoolID",
                HeaderText = "School ID",
                DataPropertyName = "SchoolID",
                ReadOnly = true,
                Width = 120
            };
            dataGridViewUsers.Columns.Add(schoolIdColumn);

            // Add ContactNumber column
            var contactNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "ContactNumber",
                HeaderText = "Contact Number",
                DataPropertyName = "ContactNumber",
                ReadOnly = true,
                Width = 120
            };
            dataGridViewUsers.Columns.Add(contactNumberColumn);

            // Add EmailAddress column
            var emailAddressColumn = new DataGridViewTextBoxColumn
            {
                Name = "EmailAddress",
                HeaderText = "Email Address",
                DataPropertyName = "EmailAddress",
                ReadOnly = true,
                Width = 250
            };
            dataGridViewUsers.Columns.Add(emailAddressColumn);

            // Add RegisteredDate column
            var registeredDateColumn = new DataGridViewTextBoxColumn
            {
                Name = "RegisteredDate",
                HeaderText = "Registered Date",
                DataPropertyName = "RegisteredDate",
                ReadOnly = true,
                Width = 120
            };
            dataGridViewUsers.Columns.Add(registeredDateColumn);

            // Add UserIMG column (as an image column)
            var userImgColumn = new DataGridViewImageColumn
            {
                Name = "UserIMG",
                HeaderText = "User Image",
                DataPropertyName = "UserIMG",
                ReadOnly = true,
                Width = 100
            };
            dataGridViewUsers.Columns.Add(userImgColumn);

            // Set additional properties
            dataGridViewUsers.AutoGenerateColumns = false;
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.ReadOnly = true;
        }


        // ---------- Panels Form Design ---------- \\
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelMain.ClientRectangle, 12);
        }

        private void panelUserID_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelUserID.ClientRectangle, 12);
        }

        private void panelStudentID_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelStudentID.ClientRectangle, 12);
        }

        private void panelFullName_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelFullName.ClientRectangle, 12);
        }

        private void panelConactNumber_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelConactNumber.ClientRectangle, 12);
        }

        private void panelEmailAddress_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelEmailAddress.ClientRectangle, 12);
        }

        private void panelCourse_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, panelCourse.ClientRectangle, 12);
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

            StyleButton(buttonAddUser);
            StyleButton(buttonUpdateUser);
            StyleButton(buttonDeleteUser);
        }
        private void textBoxUserID_Enter_1(object sender, EventArgs e)
        {
            if (textBoxUserID.Text == "Enter User ID")
            {
                textBoxUserID.Text = "";
                textBoxUserID.ForeColor = Color.Black; // Change text color to black when editing
            }
        }

        private void textBoxUserID_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserID.Text))
            {
                textBoxUserID.Text = GetNextAvailableUserID().ToString();
                textBoxUserID.ForeColor = Color.Black; // Ensure the text color is black
            }
        }


        private void textBoxSchoolID_Enter(object sender, EventArgs e)
        {
            if (textBoxSchoolID.Text == "Enter School ID")
            {
                textBoxSchoolID.Text = "";
                textBoxSchoolID.ForeColor = Color.Black;
            }
        }

        private void textBoxSchoolID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSchoolID.Text))
            {
                textBoxSchoolID.Text = "Enter School ID";
                textBoxSchoolID.ForeColor = Color.Gray;
            }
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

        private void textBoxContactNumber_Enter(object sender, EventArgs e)
        {
            if (textBoxContactNumber.Text == "Enter Contact Number")
            {
                textBoxContactNumber.Text = "";
                textBoxContactNumber.ForeColor = Color.Black;
            }
        }

        private void textBoxContactNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxContactNumber.Text))
            {
                textBoxContactNumber.Text = "Enter Contact Number";
                textBoxContactNumber.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmailAddress_Enter(object sender, EventArgs e)
        {
            if (textBoxEmailAddress.Text == "Enter Email Address")
            {
                textBoxEmailAddress.Text = "";
                textBoxEmailAddress.ForeColor = Color.Black;
            }
        }

        private void textBoxEmailAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmailAddress.Text))
            {
                textBoxEmailAddress.Text = "Enter Email Address";
                textBoxEmailAddress.ForeColor = Color.Gray;
            }
        }



        private void textBoxSchoolID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxUserType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void StyleDataGridViewUsers()
        {
            dataGridViewUsers.EnableHeadersVisualStyles = false;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            dataGridViewUsers.DefaultCellStyle.BackColor = Color.White;
            dataGridViewUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(228, 228, 228);
            dataGridViewUsers.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewUsers.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            dataGridViewUsers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewUsers.BorderStyle = BorderStyle.None;
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.GridColor = Color.White;

            // Add stroke
            dataGridViewUsers.Paint += DataGridViewUsers_BorderPaint;
            dataGridViewUsers.Scroll += DataGridViewUsers_Scroll; // Ensure redraw on scroll
        }

        private void DataGridViewUsers_BorderPaint(object sender, PaintEventArgs e)
        {
            int strokeWidth = 2;
            Color borderColor = Color.FromArgb(218, 218, 218);
            Rectangle bounds = dataGridViewUsers.ClientRectangle;

            bounds.Width -= 1; // Avoid cutoff
            bounds.Height -= 1;

            using (Pen borderPen = new Pen(borderColor, strokeWidth))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Smooth edges
                e.Graphics.DrawRectangle(borderPen, bounds);
            }
        }

        private void DataGridViewUsers_Scroll(object sender, ScrollEventArgs e)
        {
            // Force repaint to ensure the border is redrawn correctly during scrolling
            dataGridViewUsers.Invalidate();
        }

        // Update the ExcelPackage type to use the correct Workbook property type
        private void buttonImportdataGridViewUsers_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Excel Sheet (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                string filepath = op.FileName;
                string con = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES;'";
                con = string.Format(con, filepath);

                try
                {
                    using (OleDbConnection excelConnection = new OleDbConnection(con))
                    {
                        excelConnection.Open();

                        // Get the first sheet name
                        DataTable dtExcelSchema = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        if (dtExcelSchema == null || dtExcelSchema.Rows.Count == 0)
                        {
                            MessageBox.Show("No sheets found in the Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string excelSheet = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();

                        // Read data from the first sheet
                        string query = $"SELECT * FROM [{excelSheet}]";
                        using (OleDbCommand cmd = new OleDbCommand(query, excelConnection))
                        using (OleDbDataAdapter oda = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            oda.Fill(dt);

                            // Insert data into the database
                            using (MySqlConnection conn = new MySqlConnection(connectionString))
                            {
                                conn.Open();
                                foreach (DataRow row in dt.Rows)
                                {
                                    // Validate required fields
                                    if (row["FullName"] == DBNull.Value || row["EmailAddress"] == DBNull.Value || row["UserType"] == DBNull.Value)
                                    {
                                        MessageBox.Show("Some rows have missing required fields. Skipping those rows.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        continue;
                                    }

                                    string insertQuery = "INSERT INTO Users (SchoolID, FullName, ContactNumber, EmailAddress, UserType, RegisteredDate) " +
                                                         "VALUES (@SchoolID, @FullName, @ContactNumber, @EmailAddress, @UserType, @RegisteredDate)";
                                    using (MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn))
                                    {
                                        cmdInsert.Parameters.AddWithValue("@SchoolID", row["SchoolID"] ?? DBNull.Value);
                                        cmdInsert.Parameters.AddWithValue("@FullName", row["FullName"]);
                                        cmdInsert.Parameters.AddWithValue("@ContactNumber", row["ContactNumber"] ?? DBNull.Value);
                                        cmdInsert.Parameters.AddWithValue("@EmailAddress", row["EmailAddress"]);
                                        cmdInsert.Parameters.AddWithValue("@UserType", row["UserType"]);
                                        cmdInsert.Parameters.AddWithValue("@RegisteredDate", row["RegisteredDate"] != DBNull.Value ? Convert.ToDateTime(row["RegisteredDate"]) : DateTime.Now);

                                        cmdInsert.ExecuteNonQuery();
                                    }
                                }
                            }

                            MessageBox.Show("Data imported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataGridView();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while importing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonExportdataGridViewUsers_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.Rows.Count == 0)
            {
                MessageBox.Show("There is no data to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            save.Title = "Save Excel File";
            save.FileName = "ExportedUsers.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = null;
                Excel.Worksheet worksheet = null;

                try
                {
                    workbook = excelApp.Workbooks.Add(Type.Missing);
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Users";

                    // Add headers
                    for (int i = 1; i <= dataGridViewUsers.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i] = dataGridViewUsers.Columns[i - 1].HeaderText;
                    }

                    // Add data
                    for (int i = 0; i < dataGridViewUsers.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewUsers.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridViewUsers.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    workbook.SaveAs(save.FileName);
                    MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    workbook?.Close(false);
                    excelApp.Quit();

                    // Release COM objects to avoid Excel process hanging
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }
            }
        }


    }
}
