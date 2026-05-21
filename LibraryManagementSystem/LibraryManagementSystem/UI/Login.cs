using LibraryManagementSystem.Properties;

using LibraryManagementSystem.UI.Mainpage;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI
{
    public partial class Login : Form
    {
        private readonly ConnectionClass _connectionClass = new ConnectionClass();

        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                dbConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("CHECK_ADMIN", dbConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@USERNAME", usernameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@PASSWORD", passwordTextBox.Text);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    try
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            if (sqlDataReader.Read())
                            {
                                MessageBox.Show("Hoşgeldiniz", "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm mainPageForm = new MainForm();
                                mainPageForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adınızı veya şifrenizi kontrol ediniz", "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}