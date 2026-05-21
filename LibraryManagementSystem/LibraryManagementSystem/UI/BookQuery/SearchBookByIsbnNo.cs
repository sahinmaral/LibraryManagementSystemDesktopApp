using LibraryManagementSystem.Models;
using LibraryManagementSystem.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.PersonQuery
{
    public partial class SearchBookByIsbnNo : UserControl
    {
        private readonly ConnectionClass _connectionClass = new ConnectionClass();

        public event EventHandler<SearchBookByIsbnNoEventArgs> SearchButtonClicked;

        public SearchBookByIsbnNo()
        {
            InitializeComponent();
        }


        public string BookIsbnNo
        {
            get { return txtBoxBookIsbnNo.Text; }
            set { txtBoxBookIsbnNo.Text = value; }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchButtonClicked?.Invoke(this, new SearchBookByIsbnNoEventArgs
            {
                IsbnNo = BookIsbnNo
            });
        }
    }
}
