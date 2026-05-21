using LibraryManagementSystem.UI.Reports;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.Mainpage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void ShowFormInPanel(Form form)
        {
            contentPanel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(form);
            form.Show();
        }

        private void QueryBookByAuthorMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowFormInPanel(new BookQuery.BookQuery());
        }

        private void MenuItemBookQuery_Click(object sender, System.EventArgs e)
        {
            ShowFormInPanel(new BookQuery.BookQuery());
        }

        private void AboutMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("https://github.com/sahinmaral tarafından hazırlanmıştır.", 
                "Hakkında", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void HomeMenuItem_Click(object sender, System.EventArgs e)
        {
            contentPanel.Controls.Clear();
        }

        private void MenuItemPersonQuery_Click(object sender, System.EventArgs e)
        {
            ShowFormInPanel(new PersonQuery.PersonQuery());
        }

        private void adminOluşturToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowFormInPanel(new CreateAdmin());
        }

        private void özetİstatistiklerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowFormInPanel(new DashboardStatistics());
        }

        private void enToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowFormInPanel(new MostBorrowedBooks());
        }

        private void iadesiGecikmişKitaplarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowFormInPanel(new OverdueBooks());
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}