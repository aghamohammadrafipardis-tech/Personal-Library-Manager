using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace uni_project
{
    public partial class frmSearch : Form
    {

        private List<Book> _books;
        private Action<Book, string, string, string, int, string, int, string, string> _EditBook;
        public frmSearch(Action<Book, string, string, string, int, string, int, string, string> EditBook ,List<Book> books)
        {
            InitializeComponent();
            _books = books;
            _EditBook = EditBook;
        }
        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            cmbGenre.Text = "";
            cmbStatus.Text = "";
            txtYearFrom.Text = "";
            txtYearTo.Text = "";
            lstResults.Items.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            lstResults.Items.Clear();
            foreach (var book in _books)
            {
                bool match = true;

                if (!string.IsNullOrEmpty(txtTitle.Text) && !book.Title.Contains(txtTitle.Text))
                    match = false;

                if (!string.IsNullOrEmpty(txtAuthor.Text) && !book.Author.Contains(txtAuthor.Text))
                    match = false;

                if (cmbGenre.SelectedIndex != -1 && book.Genre != cmbGenre.SelectedItem.ToString())
                    match = false;

                if (cmbStatus.SelectedIndex != -1 && book.Status != cmbStatus.SelectedItem.ToString())
                    match = false;

                if (int.TryParse(txtYearFrom.Text, out int yearFrom) && book.Year < yearFrom)
                    match = false;

                if (int.TryParse(txtYearTo.Text, out int yearTo) && book.Year > yearTo)
                    match = false;

                if (match)
                    lstResults.Items.Add(book.ID + "-" + book.Title + "-" + book.Author);
            }
        }

        private void lstResults_DoubleClick(object sender, EventArgs e)
        {
            if (lstResults.SelectedItem != null)
            {
                string selected = lstResults.SelectedItem.ToString();
                int bookId = int.Parse(selected.Split('-')[0]);
                Book bookToEdit = _books.FirstOrDefault(b => b.ID == bookId);

                frmCreateOrUpdateBook editForm = new frmCreateOrUpdateBook(_EditBook, bookToEdit);
                editForm.ShowDialog();
                this.Hide();
            }
        }
    }
}
