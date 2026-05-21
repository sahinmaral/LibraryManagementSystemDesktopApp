using LibraryManagementSystem.Models;
using LibraryManagementSystem.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.PersonQuery
{
    public partial class SearchBookByWriterNameSurname : UserControl
    {
        private readonly ConnectionClass _connectionClass = new ConnectionClass();

        public event EventHandler<SearchBookByWriterNameSurnameEventArgs> SearchButtonClicked;

        public SearchBookByWriterNameSurname()
        {
            InitializeComponent();
            RenderWriterNamesAtCombobox();
        }

        public int BookWriterId { get; set; }

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

                    cboWriterName.ValueMember = "ID";
                    cboWriterName.DisplayMember = "Adı";
                    cboWriterName.DataSource = dataTable;

                    cboWriterName.SelectedIndex = 0;
                }
            }
        }

        private void cboWriterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboWriterName.SelectedValue != null)
                BookWriterId = (int)cboWriterName.SelectedValue;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchButtonClicked?.Invoke(this, new SearchBookByWriterNameSurnameEventArgs
            {
                WriterId = BookWriterId
            });
        }
    }
}
