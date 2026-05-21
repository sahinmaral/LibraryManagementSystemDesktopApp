using LibraryManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.PersonQuery
{
    

    public partial class SearchPersonByTakenBook : UserControl
    {
        public event EventHandler<SearchPersonByTakenBookEventArgs> SearchButtonClicked;

        public SearchPersonByTakenBook()
        {
            InitializeComponent();
        }

        public string PersonTakenBook
        {
            get { return txtBoxPersonTakenBook.Text; }
            set { txtBoxPersonTakenBook.Text = value; }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchButtonClicked?.Invoke(this, new SearchPersonByTakenBookEventArgs
            {
                TakenBookName = PersonTakenBook
            });
        }
    }
}
