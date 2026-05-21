using LibraryManagementSystem.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.Reports
{
    public partial class OverdueBooks : Form
    {
        private readonly ConnectionClass _connectionClass = new ConnectionClass();

        public OverdueBooks()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection dbConnection = new SqlConnection(_connectionClass.Address))
            {
                string query = "REPORT_OVERDUE_BOOKS";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, dbConnection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
