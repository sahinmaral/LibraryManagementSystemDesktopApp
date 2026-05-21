using LibraryManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.PersonQuery
{
    

    public partial class SearchPersonByTurkishId : UserControl
    {
        public event EventHandler<SearchPersonByTurkishIdEventArgs> SearchButtonClicked;

        public SearchPersonByTurkishId()
        {
            InitializeComponent();
        }

        public string PersonTurkishId
        {
            get { return txtBoxPersonTurkishId.Text; }
            set { txtBoxPersonTurkishId.Text = value; }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchButtonClicked?.Invoke(this, new SearchPersonByTurkishIdEventArgs
            {
                TurkishId = PersonTurkishId
            });
        }
    }
}
