using LibraryManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.PersonQuery
{
    
    public partial class SearchBookByName : UserControl
    {
        public event EventHandler<SearchBookByNameEventArgs> SearchButtonClicked;

        public SearchBookByName()
        {
            InitializeComponent();
        }

        public string BookName
        {
            get { return txtBoxBookName.Text; }
            set { txtBoxBookName.Text = value; }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchButtonClicked?.Invoke(this, new SearchBookByNameEventArgs
            {
                Name = BookName
            });
        }
    }
}
