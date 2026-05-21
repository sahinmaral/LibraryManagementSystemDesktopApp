using LibraryManagementSystem.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI
{
    public partial class CreateAdmin : Form
    {
        private readonly ConnectionClass _connectionClass = new ConnectionClass();

        public CreateAdmin()
        {
            InitializeComponent();
        }

        private void btnSaveAdmin_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                try
                {
                    CheckInputsValidation();

                    string username = txtBoxAdminUsername.Text;
                    string password = txtBoxAdminPassword.Text;

                    dbConnection.Open();

                    using (SqlCommand command = new SqlCommand("CREATE_ADMIN", dbConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@USERNAME", username);
                        command.Parameters.AddWithValue("@PASSWORD", password);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Başarılı bir şekilde admin eklendi.",
                            "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dbConnection.Close();

                        ClearForm();
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

        private void ClearForm()
        {
            txtBoxAdminUsername.Clear();
            txtBoxAdminPassword.Clear();
            txtBoxAdminPasswordRepeat.Clear();
        }

        private void CheckInputsValidation()
        {
            if (txtBoxAdminUsername.Text.Length == 0)
                throw new InvalidOperationException("Lütfen kullanıcı adı giriniz");
            if (txtBoxAdminPassword.Text.Length == 0)
                throw new InvalidOperationException("Lütfen şifre giriniz");
            if (txtBoxAdminPassword.Text != txtBoxAdminPasswordRepeat.Text)
                throw new InvalidOperationException("Lütfen şifre ve şifre tekrarını kontrol ediniz");
        }
    }
}
