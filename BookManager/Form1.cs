using System;
using System.Windows.Forms;

namespace DigitalBookViewer
{
    public partial class Form1 : Form
    {
        private BookManager bookManager = new BookManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = txtBookName.Text;
                bookManager.LoadBook(folderPath);
                txtPageContent.Text = bookManager.GetCurrentPage();
                lblTotalPages.Text = $"Pages : 1 / {bookManager.GetTotalPages()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtPageContent.Text = bookManager.NextPage();
            UpdatePageNumber();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            txtPageContent.Text = bookManager.PreviousPage();
            UpdatePageNumber();
        }

        private void btnGoToPage_Click(object sender, EventArgs e)
        {
            try
            {
                int pageNumber = int.Parse(txtPageNumber.Text);
                txtPageContent.Text = bookManager.GoToPage(pageNumber);
                UpdatePageNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void UpdatePageNumber()
        {
            lblTotalPages.Text = $"Pages : {bookManager.GetCurrentPage()} / {bookManager.GetTotalPages()}";
        }
    }
}
