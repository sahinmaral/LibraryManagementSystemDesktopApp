using LibraryManagementSystem.Models;
using LibraryManagementSystem.Properties;
using LibraryManagementSystem.UI.PersonQuery;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.BookQuery
{
    public partial class BookQuery : Form
    {
        private readonly ConnectionClass _connectionClass = new ConnectionClass();

        private Action _lastSearch;

        public BookQuery()
        { 
            InitializeComponent();

            cboSelectSearchOption.SelectedIndex = 0;

            nmrUpDownBookPageCount.DecimalPlaces = 0;
            nmrUpDownBookPageCount.Maximum = int.MaxValue;
            nmrUpDownBookPageCount.KeyPress += (s, e) =>
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                    e.Handled = true;
            };

            RenderWriterNamesAtCombobox();
            RenderCategoryNamesAtCombobox();
        }

        private void RenderSearchBookByWriterNameSurname()
        {
            var searchControl = new SearchBookByWriterNameSurname
            {
                Dock = DockStyle.Fill,
            };
            searchControl.SearchButtonClicked += SearchBookByWriterNameSurnameButton_Click;
            this.panelSearchFilters.Controls.Add(searchControl);
        }

        private void RenderSearchBookByName()
        {
            var searchControl = new SearchBookByName
            {
                Dock = DockStyle.Fill,
            };
            searchControl.SearchButtonClicked += SearchBookByNameButton_Click;
            this.panelSearchFilters.Controls.Add(searchControl);
        }

        private void SearchBookByNameButton_Click(object sender, SearchBookByNameEventArgs e)
        {
            string bookName = e.Name;

            _lastSearch = () => LoadBooksByName(bookName);
            _lastSearch();
        }

        private void LoadBooksByName(string bookName)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                string query = "BRING_BOOK_BYNAME @BOOKNAME=@BookName";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, dbConnection))
                    {
                        command.Parameters.AddWithValue("@BookName", bookName);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtGridViewBooks.DataSource = dataTable;
                        HideFixedColumns();
                        ApplyColumnDisplayOptions();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchBookByWriterNameSurnameButton_Click(object sender, SearchBookByWriterNameSurnameEventArgs e)
        {
            int writerId = e.WriterId;

            _lastSearch = () => LoadBooksByWriterId(writerId);
            _lastSearch();
        }

        private void RenderWriterNamesAtCombobox()
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                dbConnection.Open();

                using (SqlCommand command = new SqlCommand("BRING_AUTHOR", dbConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    cboBookWriter.ValueMember = "ID";
                    cboBookWriter.DisplayMember = "Adı";
                    cboBookWriter.DataSource = dataTable;

                    cboBookWriter.SelectedIndex = 0;
                }
            }
        }

        private void RenderCategoryNamesAtCombobox()
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                dbConnection.Open();

                using (SqlCommand command = new SqlCommand("BRING_CATEGORY", dbConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    cboBookCategory.ValueMember = "ID";
                    cboBookCategory.DisplayMember = "Adı";
                    cboBookCategory.DataSource = dataTable;

                    cboBookCategory.SelectedIndex = 0;
                }
            }
        }

        private void RenderSearchBookByIsbnNo()
        {
            var searchControl = new SearchBookByIsbnNo
            {
                Dock = DockStyle.Fill,
            };
            searchControl.SearchButtonClicked += SearchBookByIsbnNoButton_Click;
            this.panelSearchFilters.Controls.Add(searchControl);
        }

        private void SearchBookByIsbnNoButton_Click(object sender, SearchBookByIsbnNoEventArgs e)
        {
            string isbnNo = e.IsbnNo;

            _lastSearch = () => LoadBooksByIsbnNo(isbnNo);
            _lastSearch();
        }

        private void LoadBooksByWriterId(int writerId)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                string query = "BRING_BOOK_BYAUTHORID @AUTHORID=@AuthorId";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, dbConnection))
                    {
                        command.Parameters.AddWithValue("@AuthorId", writerId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtGridViewBooks.DataSource = dataTable;
                        HideFixedColumns();
                        ApplyColumnDisplayOptions();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadBooksByIsbnNo(string isbnNo)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                string query = "BRING_BOOK_BYISBNNO @ISBNNO=@IsbnNo";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, dbConnection))
                    {
                        command.Parameters.AddWithValue("@IsbnNo", isbnNo);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtGridViewBooks.DataSource = dataTable;
                        HideFixedColumns();
                        ApplyColumnDisplayOptions();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HideFixedColumns()
        {
            dtGridViewBooks.Columns[0].Visible = false;
            dtGridViewBooks.Columns[4].Visible = false;
            dtGridViewBooks.Columns[6].Visible = false;
            dtGridViewBooks.Columns[8].Visible = false;
            dtGridViewBooks.Columns[9].Visible = false;
            dtGridViewBooks.Columns[10].Visible = false;
            dtGridViewBooks.Columns[11].Visible = false;
            dtGridViewBooks.Columns[12].Visible = false;
            dtGridViewBooks.Columns[13].Visible = false;
            dtGridViewBooks.Columns[14].Visible = false;
        }

        private void ApplyColumnDisplayOptions()
        {
            bool isNameVisible = choName.Checked;
            bool isIsbnNoVisible = choIsbnNo.Checked;
            bool isWriterNameSurnameVisible = choWriterNameSurname.Checked;
            bool isCategoryNameVisible = choCategoryName.Checked;
            bool isPageCountVisible = choPageCount.Checked;

            dtGridViewBooks.Columns[1].Visible = isIsbnNoVisible;
            dtGridViewBooks.Columns[2].Visible = isNameVisible;
            dtGridViewBooks.Columns[3].Visible = isWriterNameSurnameVisible;
            dtGridViewBooks.Columns[5].Visible = isCategoryNameVisible;
            dtGridViewBooks.Columns[7].Visible = isPageCountVisible;
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(personNameTextBox.Text) || string.IsNullOrWhiteSpace(personSurnameTextBox.Text))
            //{
            //    MessageBox.Show("Kitabı iade etmek için kişinin adını ve soyadını yazmanız gerekir", 
            //        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            
            //if (string.IsNullOrWhiteSpace(personIdNumberTextBox.Text))
            //{
            //    MessageBox.Show("Kitabı iade etmek için kişinin TC kimlik numarasını yazmanız gerekir", 
            //        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            
            //if (string.IsNullOrWhiteSpace(bookNameTextBox.Text))
            //{
            //    MessageBox.Show("Kitabı tablodan seçmeniz gerekir", 
            //        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            //{
            //    dbConnection.Open();
            //    try
            //    {
            //        using (SqlCommand sqlCommand = new SqlCommand("DEORDER_BOOK", dbConnection))
            //        {
            //            sqlCommand.Parameters.AddWithValue("@P_PERSONID", _personId);
            //            sqlCommand.Parameters.AddWithValue("@BOOKID", _bookId);
            //            sqlCommand.CommandType = CommandType.StoredProcedure;
            //            sqlCommand.ExecuteNonQuery();
            //        }
                    
            //        MessageBox.Show("Kitap iade edilmiştir", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void cboSelectSearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cboSelectSearchOption = sender as ComboBox;
            int selectedIndex = cboSelectSearchOption.SelectedIndex;

            this.panelSearchFilters.Controls.Clear();

            switch (selectedIndex)
            {
                case 0:
                    RenderSearchBookByName();
                    break;
                case 1:
                    RenderSearchBookByWriterNameSurname();
                    break;
                case 2:
                    RenderSearchBookByIsbnNo();
                    break;
                default:
                    break;
            }
        }

        private void dtGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dtGridViewBooks.CurrentRow != null && dtGridViewBooks.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dtGridViewBooks.CurrentRow;

                lblBookId.Text = row.Cells[0].Value?.ToString() ?? "";
                txtBoxBookIsbnNo.Text = row.Cells[1].Value?.ToString() ?? "";
                txtBoxBookName.Text = row.Cells[2].Value?.ToString() ?? "";
                nmrUpDownBookPageCount.Value = Convert.ToInt32(row.Cells[7].Value);

                cboBookWriter.SelectedValue = row.Cells[4].Value.ToString() ?? "";
                cboBookCategory.SelectedValue = row.Cells[6].Value.ToString() ?? "";
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            lblBookId.Text = "";
            txtBoxBookIsbnNo.Clear();
            txtBoxBookName.Clear();
            nmrUpDownBookPageCount.Value = 1;

            lblPersonId.Text = "";
            txtBoxSelectedPersonName.Clear();
            txtBoxSelectedPersonSurname.Clear();
            txtBoxSelectedPersonTurkishId.Clear();

            cboBookWriter.SelectedIndex = 0;
            cboBookCategory.SelectedIndex = 0;

            lblPersonPenaltyDate.Visible = true;
            dtPickerPersonPenaltyDate.Value = DateTime.Now;
            dtPickerPersonPenaltyDate.Visible = true;
            choPersonPenaltyStatus.Checked = false;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                try
                {
                    if (lblBookId.Text.Length == 0)
                        throw new InvalidOperationException("Lütfen bir kitap seçiniz");

                    dbConnection.Open();

                    using (SqlCommand command = new SqlCommand("DELETE_BOOK", dbConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BOOKID", int.Parse(lblBookId.Text));

                        command.ExecuteNonQuery();

                        MessageBox.Show("Başarılı bir şekilde kitap silindi.",
                            "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dbConnection.Close();

                        ClearForm();

                        _lastSearch?.Invoke();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Veritabanı hatası: {ex.Message}",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                try
                {
                    CheckInputsValidation();

                    string name = txtBoxBookName.Text;
                    string isbnNo = txtBoxBookIsbnNo.Text;
                    int pageCount = (int)nmrUpDownBookPageCount.Value;
                    int writerId = (int)cboBookWriter.SelectedValue;
                    int categoryId = (int)cboBookCategory.SelectedValue;

                    dbConnection.Open();

                    using (SqlCommand command = new SqlCommand("CREATE_BOOK", dbConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TITLE", name);
                        command.Parameters.AddWithValue("@ISBNNO", isbnNo);
                        command.Parameters.AddWithValue("@AUTHORID", writerId);
                        command.Parameters.AddWithValue("@CATEGORYID", categoryId);
                        command.Parameters.AddWithValue("@PAGECOUNT", pageCount);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Başarılı bir şekilde kitap eklendi.",
                            "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dbConnection.Close();

                        ClearForm();

                        _lastSearch?.Invoke();

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Veritabanı hatası: {ex.Message}",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                try
                {
                    if (lblBookId.Text.Length == 0)
                        throw new InvalidOperationException("Lütfen bir kitap seçiniz");

                    CheckInputsValidation();

                    string name = txtBoxBookName.Text;
                    string isbnNo = txtBoxBookIsbnNo.Text;
                    int pageCount = (int)nmrUpDownBookPageCount.Value;
                    int writerId = (int)cboBookWriter.SelectedValue;
                    int categoryId = (int)cboBookCategory.SelectedValue;

                    dbConnection.Open();

                    using (SqlCommand command = new SqlCommand("UPDATE_BOOK", dbConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BOOKID", lblBookId.Text);
                        command.Parameters.AddWithValue("@TITLE", name);
                        command.Parameters.AddWithValue("@ISBNNO", isbnNo);
                        command.Parameters.AddWithValue("@AUTHORID", writerId);
                        command.Parameters.AddWithValue("@CATEGORYID", categoryId);
                        command.Parameters.AddWithValue("@PAGECOUNT", pageCount);

                        command.ExecuteNonQuery();


                        MessageBox.Show("Başarılı bir şekilde kitap güncellendi.",
                            "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dbConnection.Close();

                        ClearForm();

                        _lastSearch?.Invoke();

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Veritabanı hatası: {ex.Message}",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckInputsValidation()
        {
            if (txtBoxBookName.Text.Length == 0)
                throw new InvalidOperationException("Lütfen kitap adı giriniz");
            if (txtBoxBookIsbnNo.Text.Length == 0)
                throw new InvalidOperationException("Lütfen ISBN numarası giriniz");
            if (cboBookCategory.SelectedItem == null)
                throw new InvalidOperationException("Lütfen kategori seçiniz");
            if (cboBookWriter.SelectedItem == null)
                throw new InvalidOperationException("Lütfen yazar seçiniz");
            if (nmrUpDownBookPageCount.Value == 0)
                throw new InvalidOperationException("Lütfen sayfa numarasını sıfırdan büyük giriniz");
            if(dtPickerPersonPenaltyDate.Value <= DateTime.Now)
                throw new InvalidOperationException("Lütfen kitap iade tarihini, bugünden büyük giriniz");

        }

        private void btnGetPersonAllForms_Click(object sender, EventArgs e)
        {
            lblPersonId.Text = Person.Id;
            txtBoxSelectedPersonName.Text = Person.Name;
            txtBoxSelectedPersonSurname.Text = Person.Surname;
            txtBoxSelectedPersonTurkishId.Text = Person.TurkishId;
            choPersonPenaltyStatus.Checked = Person.IsPenalty;
            if (Person.IsPenalty)
            {
                dtPickerPersonPenaltyDate.Value = Person.PenaltyEndDate;
                dtPickerPersonPenaltyDate.Visible = true;
                lblPersonPenaltyDate.Visible = true;
            }
            else
            {
                dtPickerPersonPenaltyDate.Visible = false;
                lblPersonPenaltyDate.Visible = false;
            }
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                try
                {
                    if (lblBookId.Text.Length == 0)
                        throw new InvalidOperationException("Lütfen bir kitap seçiniz");

                    if (lblPersonId.Text.Length == 0)
                        throw new InvalidOperationException("Herhangi bir kişi seçilmedi. Lütfen herhangi bir kişi seçiniz");

                    CheckInputsValidation();

                    int studentId = int.Parse(lblPersonId.Text);
                    int bookId = int.Parse(lblBookId.Text);

                    dbConnection.Open();

                    using (SqlCommand command = new SqlCommand("BORROW_BOOK", dbConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Input parameters
                        command.Parameters.AddWithValue("@PERSONID", studentId);
                        command.Parameters.AddWithValue("@BOOKID", bookId);

                        // Execute and read the result set (Message and DueDate)
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string message = reader["Message"].ToString();
                                DateTime dueDate = Convert.ToDateTime(reader["DueDate"]);

                                MessageBox.Show($"{message}\n\nİade Tarihi: {dueDate:dd.MM.yyyy}",
                                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        dbConnection.Close();

                        ClearForm();

                        _lastSearch?.Invoke();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Veritabanı hatası: {ex.Message}",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                try
                {
                    if (lblBookId.Text.Length == 0)
                        throw new InvalidOperationException("Lütfen bir kitap seçiniz");

                    if (lblPersonId.Text.Length == 0)
                        throw new InvalidOperationException("Herhangi bir kişi seçilmedi. Lütfen herhangi bir kişi seçiniz");

                    int studentId = int.Parse(lblPersonId.Text);
                    int bookId = int.Parse(lblBookId.Text);

                    dbConnection.Open();

                    using (SqlCommand command = new SqlCommand("RETURN_BOOK", dbConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PERSONID", studentId);
                        command.Parameters.AddWithValue("@BOOKID", bookId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string message = reader["Message"].ToString();
                                DateTime returnDate = Convert.ToDateTime(reader["ReturnDate"]);
                                DateTime dueDate = Convert.ToDateTime(reader["DueDate"]);
                                int daysLate = Convert.ToInt32(reader["DaysLate"]);
                                bool wasLate = Convert.ToBoolean(reader["WasLate"]);

                                if (wasLate)
                                {
                                    MessageBox.Show(
                                        message,
                                        "Geç İade - Ceza Verildi",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show(
                                        $"{message}\n\n" +
                                        $"İade Tarihi: {returnDate:dd.MM.yyyy}\n" +
                                        $"Son Teslim Tarihi: {dueDate:dd.MM.yyyy}",
                                        "Başarılı",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                            }
                        }

                        dbConnection.Close();

                        ClearForm();

                        _lastSearch?.Invoke();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Veritabanı hatası: {ex.Message}",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}