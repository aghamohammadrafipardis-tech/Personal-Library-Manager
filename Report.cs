using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uni_project
{
    public partial class frmReport : Form
    {
        private List<Book> books;
        public frmReport(List<Book> bookList)
        {
            InitializeComponent();
            books = bookList;

            int total = books.Count;
            lblTotalValue.Text = total.ToString();
            lblReadingValue.Text = books.Count(b => b.Status?.Trim() == "در حال خواندن").ToString();
            lblReadedValue.Text = books.Count(b => b.Status?.Trim() == "خوانده شده").ToString();
            lblUnreadValue.Text = books.Count(b => b.Status?.Trim() == "خوانده نشده").ToString();

            CalcAndShowAvg();
            CalcAndShowRepeatedGenre();
            CalcAndShowRepeatedAuthor();
            CalcAndShowReadedbooks();
        }


        private void CalcAndShowAvg()
        {
            double sum = 0;
            int count = 0;

            foreach (Book book in books)
            {
                if (book.Rating > 0)
                {
                    sum += book.Rating;
                    count++;
                }
            }

            if (count > 0)
            {
                double avg = sum / count;
                lblAvgValue.Text = avg.ToString("F2");
            }

        }

        private void CalcAndShowRepeatedGenre() {
            string mostRepeatedGenre = null;
            int maxCount = 0;

            foreach (Book book in books)
            {
                if (string.IsNullOrEmpty(book.Genre))
                    continue;

                int currentCount = 0;

                foreach (Book book2 in books)
                {
                    if (book.Genre == book2.Genre)
                        currentCount++;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    mostRepeatedGenre = book.Genre;
                }
            }

            if (mostRepeatedGenre != null) lblGenreValue.Text = mostRepeatedGenre;
        }

        

        private void CalcAndShowRepeatedAuthor() {
            string topAuthor = null;
            int maxAuthor = 0;

            foreach (Book book1 in books)
            {
                if (string.IsNullOrEmpty(book1.Author))
                    continue;

                int count = 0;

                foreach (Book book2 in books)
                {
                    if (book1.Author == book2.Author)
                        count++;
                }

                if (count > maxAuthor)
                {
                    maxAuthor = count;
                    topAuthor = book1.Author;
                }
            }

            if (topAuthor != null) lblAuthorValue.Text = topAuthor;
        }

        private void CalcAndShowReadedbooks() {
            if (books == null || books.Count == 0)
            {
                progressBooks.Value = 0;
                lblPercent.Text = "0%";
                return;
            }

            int readedCount = 0;

            foreach (Book book in books)
            {
                if (book.Status?.Trim()  == "خوانده شده")
                {
                    readedCount ++;
                }
            }

            
            double result = ((double)readedCount / books.Count) * 100;
            progressBooks.Value = (int)result;
            lblPercent.Text = $"{result:F1}%";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
