using LibraryManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.PersonQuery
{
    

    public partial class SearchPersonByNameSurname : UserControl
    {
        public event EventHandler<SearchPersonByNameEventArgs> SearchButtonClicked;

        public SearchPersonByNameSurname()
        {
            InitializeComponent();

            cboPersonGender.SelectedIndex = 0;
        }

        public string PersonName
        {
            get { return txtBoxPersonName.Text; }
            set { txtBoxPersonName.Text = value; }
        }

        public string PersonSurname
        {
            get { return txtBoxPersonSurname.Text; }
            set { txtBoxPersonSurname.Text = value; }
        }

        public string PersonGender
        {
            get { return cboPersonGender.SelectedItem.ToString(); }
            set { txtBoxPersonSurname.Text = value; }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchButtonClicked?.Invoke(this, new SearchPersonByNameEventArgs
            {
                Name = PersonName,
                Surname = PersonSurname,
                Gender = PersonGender
            });
        }
    }
}
