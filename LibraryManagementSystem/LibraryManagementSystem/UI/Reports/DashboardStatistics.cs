using LibraryManagementSystem.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.Reports
{
    public partial class DashboardStatistics : Form
    {

        private readonly ConnectionClass _connectionClass = new ConnectionClass();
        public DashboardStatistics()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                try
                {
                    dbConnection.Open();

                    using (SqlCommand command = new SqlCommand("GET_DASHBOARD_STATISTICS", dbConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtBoxTotalBooks.Text = reader["Toplam Kitap"].ToString();
                                txtBoxAvailableBooks.Text = reader["Müsait Kitap"].ToString();
                                txtBoxBorrowedBooks.Text = reader["Ödünç Verilmiş"].ToString();
                                txtBoxOverdueBooks.Text = reader["Gecikmiş İade"].ToString();
                                txtBoxTotalStudents.Text = reader["Toplam Öğrenci"].ToString();
                                txtBoxActiveBorrowers.Text = reader["Aktif Ödünç Alan"].ToString();
                                txtBoxPenalizedStudents.Text = reader["Cezalı Öğrenci"].ToString();
                                txtBoxTotalAuthors.Text = reader["Toplam Yazar"].ToString();
                                txtBoxTotalCategories.Text = reader["Toplam Kategori"].ToString();
                                txtBoxBookAvailability.Text = reader["Müsaitlik Oranı %"].ToString() + "%";
                            }
                        }

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
    }
}
