using LibraryManagementSystem.Models;
using LibraryManagementSystem.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.PersonQuery
{
    public partial class PersonQuery : Form
    {
        private readonly ConnectionClass _connectionClass = new ConnectionClass();
        private Action _lastSearch;

        public PersonQuery()
        {
            InitializeComponent();

            cboSelectSearchOption.SelectedIndex = 0;
            cboPersonGender.SelectedItem = 0;

            RenderSearchPersonByNameSurname();
        }

        private void RenderSearchPersonByNameSurname()
        {
            var searchControl = new SearchPersonByNameSurname
            {
                Dock = DockStyle.Fill,
            };
            searchControl.SearchButtonClicked += SearchPersonByNameSurnameButton_Click;
            this.panelSearchFilters.Controls.Add(searchControl);
        }

        private void RenderSearchPersonByTurkishId()
        {
            var searchControl = new SearchPersonByTurkishId
            {
                Dock = DockStyle.Fill,
            };
            searchControl.SearchButtonClicked += SearchPersonByTurkishIdButton_Click;
            this.panelSearchFilters.Controls.Add(searchControl);
        }

        private void RenderSearchPersonByTakenBook()
        {
            var searchControl = new SearchPersonByTakenBook
            {
                Dock = DockStyle.Fill,
            };
            searchControl.SearchButtonClicked += SearchPersonByTurkishIdButton_Click;
            this.panelSearchFilters.Controls.Add(searchControl);
        }

        private void SearchPersonByNameSurnameButton_Click(object sender, SearchPersonByNameEventArgs e)
        {
            string name = e.Name;
            string surname = e.Surname;
            string gender = e.Gender;

            _lastSearch = () => LoadPeopleByNameSurname(name, surname, gender);
            _lastSearch();
        }

        private void LoadPeopleByNameSurname(string name, string surname, string gender)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                string query = "BRING_PERSON_BYNAMESURNAME @PERSONNAME=@Name, @PERSONSURNAME=@Surname, @PERSONGENDER=@Gender";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, dbConnection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Surname", surname);

                        if (gender == "(Bütün)" || string.IsNullOrEmpty(gender))
                            command.Parameters.AddWithValue("@Gender", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Gender", gender == "Erkek" ? "E" : "K");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtGridViewPerson.DataSource = dataTable;
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

        private void SearchPersonByTurkishIdButton_Click(object sender, SearchPersonByTurkishIdEventArgs e)
        {
            string turkishId = e.TurkishId;

            _lastSearch = () => LoadPeopleByTurkishId(turkishId);
            _lastSearch();
        }

        private void LoadPeopleByTurkishId(string turkishId)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                string query = "BRING_PERSON_BYTURKISHID @PERSONTURKISHID=@TurkishId";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, dbConnection))
                    {
                        command.Parameters.AddWithValue("@TurkishId", turkishId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtGridViewPerson.DataSource = dataTable;
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

        private void SearchPersonByTurkishIdButton_Click(object sender, SearchPersonByTakenBookEventArgs e)
        {
            string takenBookName = e.TakenBookName;

            _lastSearch = () => LoadPeopleByTakenBook(takenBookName);
            _lastSearch();
        }

        private void LoadPeopleByTakenBook(string takenBookName)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                string query = "BRING_PERSON_BYTAKENBOOK @PERSONTAKENBOOK=@BookName";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, dbConnection))
                    {
                        command.Parameters.AddWithValue("@BookName", takenBookName);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtGridViewPerson.DataSource = dataTable;
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
            dtGridViewPerson.Columns[0].Visible = false;
            dtGridViewPerson.Columns[5].Visible = false;
            dtGridViewPerson.Columns[6].Visible = false;
        }

        private void ApplyColumnDisplayOptions()
        {
            bool isNameVisible = choName.Checked;
            bool isSurnameVisible = choSurname.Checked;
            bool isGenderVisible = choGender.Checked;
            bool isTurkishIdVisible = choTurkishId.Checked;

            dtGridViewPerson.Columns[1].Visible = isNameVisible;
            dtGridViewPerson.Columns[2].Visible = isSurnameVisible;
            dtGridViewPerson.Columns[3].Visible = isGenderVisible;
            dtGridViewPerson.Columns[4].Visible = isTurkishIdVisible;
        }

        private string ConvertGenderValueToComboboxOption(string gender)
        {
            switch (gender)
            {
                case "E": return "Erkek";
                case "K": return "Kadın";
                default:
                    return "";
            }
        }

        private void cboSelectSearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cboSelectSearchOption = sender as ComboBox;
            int selectedIndex = cboSelectSearchOption.SelectedIndex;

            this.panelSearchFilters.Controls.Clear();

            switch (selectedIndex)
            {
                case 0:
                    RenderSearchPersonByNameSurname();
                    break;
                case 1:
                    RenderSearchPersonByTurkishId();
                    break;
                case 2:
                    RenderSearchPersonByTakenBook();
                    break;
                default:
                    break;
            }
        }

        private void btnSavePersonAllForms_Click(object sender, EventArgs e)
        {
            Person.Id = lblPersonId.Text;
            Person.Name = txtBoxPersonName.Text;
            Person.Surname = txtBoxPersonSurname.Text;
            Person.TurkishId = txtBoxPersonTurkishId.Text;
            Person.IsPenalty = choPersonPenaltyStatus.Checked;
            Person.PenaltyEndDate = dtPickerPersonPenaltyDate.Value;

            MessageBox.Show("Kişi bilgileri kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            lblPersonId.Text = "";
            txtBoxPersonName.Clear();
            txtBoxPersonSurname.Clear();
            cboPersonGender.SelectedItem = 0;
            txtBoxPersonTurkishId.Clear();
        }

        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                try
                {
                    CheckInputsValidation();

                    string name = txtBoxPersonName.Text;
                    string surname = txtBoxPersonSurname.Text;
                    string turkishId = txtBoxPersonTurkishId.Text;
                    string gender = cboPersonGender.SelectedItem.ToString() == "Erkek" ? "E" : "K";

                    dbConnection.Open();

                    using (SqlCommand command = new SqlCommand("CREATE_PERSON", dbConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PERSONNAME", name);
                        command.Parameters.AddWithValue("@PERSONSURNAME", surname);
                        command.Parameters.AddWithValue("@PERSONTURKISHID", turkishId);
                        command.Parameters.AddWithValue("@PERSONGENDER", gender);

                        command.ExecuteNonQuery();

                        dbConnection.Close();

                        ClearForm();

                        _lastSearch?.Invoke();

                        MessageBox.Show("Başarılı bir şekilde kullanıcı eklendi.",
                            "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtBoxPersonName.Text.Length == 0)
                throw new InvalidOperationException("Lütfen ad giriniz");
            if (txtBoxPersonSurname.Text.Length == 0)
                throw new InvalidOperationException("Lütfen soyad giriniz");
            if (cboPersonGender.SelectedItem == null)
                throw new InvalidOperationException("Lütfen cinsiyet seçiniz");
            if (txtBoxPersonTurkishId.Text.Length == 0)
                throw new InvalidOperationException("Lütfen TC kimlik numarası giriniz");
            if (txtBoxPersonTurkishId.Text.Length != 11)
                throw new InvalidOperationException("Lütfen TC kimlik numarasını doğru giriniz");
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                try
                {
                    if (lblPersonId.Text.Length == 0)
                        throw new InvalidOperationException("Lütfen bir kişi seçiniz");

                    dbConnection.Open();

                    using (SqlCommand command = new SqlCommand("DELETE_PERSON", dbConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PERSONID", int.Parse(lblPersonId.Text));

                        command.ExecuteNonQuery();

                        MessageBox.Show("Başarılı bir şekilde kullanıcı silindi.",
                            "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _lastSearch?.Invoke();

                        ClearForm();

                        dbConnection.Close();
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

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                try
                {
                    if (lblPersonId.Text.Length == 0)
                        throw new InvalidOperationException("Lütfen bir kişi seçiniz");

                    CheckInputsValidation();

                    string name = txtBoxPersonName.Text;
                    string surname = txtBoxPersonSurname.Text;
                    string turkishId = txtBoxPersonTurkishId.Text;
                    string gender = cboPersonGender.SelectedItem.ToString() == "Erkek" ? "E" : "K";

                    dbConnection.Open();

                    using (SqlCommand command = new SqlCommand("UPDATE_PERSON", dbConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PERSONID", lblPersonId.Text);
                        command.Parameters.AddWithValue("@PERSONNAME", name);
                        command.Parameters.AddWithValue("@PERSONSURNAME", surname);
                        command.Parameters.AddWithValue("@PERSONTURKISHID", turkishId);
                        command.Parameters.AddWithValue("@PERSONGENDER", gender);

                        command.ExecuteNonQuery();

                        dbConnection.Close();

                        ClearForm();

                        _lastSearch?.Invoke();

                        MessageBox.Show("Başarılı bir şekilde kullanıcı güncellendi.",
                            "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dtGridViewPerson_SelectionChanged(object sender, EventArgs e)
        {
            if (dtGridViewPerson.CurrentRow != null && dtGridViewPerson.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dtGridViewPerson.CurrentRow;

                lblPersonId.Text = row.Cells[0].Value?.ToString() ?? "";
                txtBoxPersonName.Text = row.Cells[1].Value?.ToString() ?? "";
                txtBoxPersonSurname.Text = row.Cells[2].Value?.ToString() ?? "";
                cboPersonGender.SelectedItem = ConvertGenderValueToComboboxOption(row.Cells[3].Value?.ToString()) ?? "Erkek";
                txtBoxPersonTurkishId.Text = row.Cells[4].Value?.ToString() ?? "";
                object penaltyStatus = row.Cells[5].Value;
                choPersonPenaltyStatus.Checked = penaltyStatus != null && penaltyStatus != DBNull.Value && Convert.ToBoolean(penaltyStatus);

                object penaltyDate = row.Cells[6].Value;
                dtPickerPersonPenaltyDate.Value = penaltyDate != null && penaltyDate != DBNull.Value
                    ? Convert.ToDateTime(penaltyDate)
                    : DateTime.Today;
            }
        }
    }
}