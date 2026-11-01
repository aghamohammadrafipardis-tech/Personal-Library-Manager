using System.Diagnostics;
using System.Globalization;
using System.Text;


namespace uni_project
{
    public partial class frmMain : Form
    {
        private int _userId;
        private string _filePath = "library.csv";
        List<Book> books = new List<Book>();

        public frmMain(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private List<Book> GetCurrentUserBooks()
        {
            return books.Where(b => b.UserID == _userId).ToList();
        }

        private int GetCurrentUserBookCount()
        {
            return books.Count(b => b.UserID == _userId);
        }

        private int GetNextBookId()
        {
            if (!File.Exists(_filePath))
                return 1;

            string[] lines = File.ReadAllLines(_filePath);
            if (lines.Length == 0) return 1;

            string[] headers = lines[0].Split(',');
            int idIdx = Array.FindIndex(headers, h => h.Equals("ID"));

            int maxId = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;
                string[] fields = lines[i].Split(',');
                if (fields.Length > 0 && int.TryParse(fields[idIdx], out int id))
                {
                    if (id > maxId)
                        maxId = id;
                }
            }
            return maxId + 1;
        }


        private void LoadBooksFromCsv()
        {

            if (!File.Exists(_filePath))
                return;

            string[] lines = File.ReadAllLines(_filePath, Encoding.UTF8);
            if (lines.Length == 0) return;


            string[] headers = lines[0].Split(',');

            int userIdIdx = Array.FindIndex(headers, h => h.Equals("UserID"));
            int idIdx = Array.FindIndex(headers, h => h.Equals("ID"));
            int titleIdx = Array.FindIndex(headers, h => h.Equals("Title"));
            int authorIdx = Array.FindIndex(headers, h => h.Equals("Author"));
            int genreIdx = Array.FindIndex(headers, h => h.Equals("Genre"));
            int yearIdx = Array.FindIndex(headers, h => h.Equals("Year"));
            int statusIdx = Array.FindIndex(headers, h => h.Equals("Status"));
            int ratingIdx = Array.FindIndex(headers, h => h.Equals("Rating"));
            int notesIdx = Array.FindIndex(headers, h => h.Equals("Notes"));
            int coverPathIdx = Array.FindIndex(headers, h => h.Equals("CoverPath"));

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;
                string[] fields = lines[i].Split(',');
                // Ensure at least enough fields (pad with empty string if needed)
                if (fields.Length < headers.Length)
                    Array.Resize(ref fields, headers.Length);

                if (string.IsNullOrWhiteSpace(fields[userIdIdx])) continue;

                var book = new Book
                {
                    ID = int.Parse(fields[idIdx]),
                    UserID = int.Parse(fields[userIdIdx]),
                    Title = fields[titleIdx],
                    Author = fields[authorIdx],
                    Genre = fields[genreIdx],
                    Year = int.Parse(fields[yearIdx]),
                    Status = fields[statusIdx],
                    Rating = int.Parse(fields[ratingIdx]),
                    Notes = fields[notesIdx],
                    CoverPath = fields[coverPathIdx],
                };
                books.Add(book);
            }
        }

        private void SaveAllBooksToCsv()
        {
            StreamWriter writer = new StreamWriter(_filePath, false, Encoding.UTF8);

            try
            {
                {
                    // Write header
                    writer.WriteLine("UserID,ID,Title,Author,Genre,Year,Status,Rating,Notes,CoverPath");

                    // Write every book (all users)
                    foreach (Book book in books)
                    {
                        string line = $"{book.UserID},{book.ID},{book.Title},{book.Author},{book.Genre},{book.Year},{book.Status},{book.Rating},{book.Notes},{book.CoverPath}";
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving CSV: {ex.Message}");
            }
            finally
            {
                writer.Close();
            }
        }

        private void CreateNewBook(string Title, string Author, string Genre, int Year, string Status, int Rating, string Notes, string CoverPath)
        {
            Book newItem = new Book
            {
                ID = GetNextBookId(),
                UserID = _userId,
                Title = Title,
                Author = Author,
                Genre = Genre,
                Year = Year,
                Status = Status,
                Rating = Rating,
                Notes = Notes,
                CoverPath = CoverPath,
            };
            books.Insert(0, newItem);

            SaveAllBooksToCsv();

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = GetCurrentUserBooks();
            lblBookCount.Text = $"تعداد کل کتاب ها : {GetCurrentUserBookCount()}";
        }

        private void EditBook(Book bookToEdit, string Title, string Author, string Genre, int Year, string Status, int Rating, string Notes, string CoverPath)
        {
            bookToEdit.Title = Title;
            bookToEdit.Author = Author;
            bookToEdit.Genre = Genre;
            bookToEdit.Year = Year;
            bookToEdit.Status = Status;
            bookToEdit.Rating = Rating;
            bookToEdit.Notes = Notes;
            bookToEdit.CoverPath = CoverPath;


            SaveAllBooksToCsv();

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = GetCurrentUserBooks();
        }

        private void ImportBooksFromCsv(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            // Skip header row
            foreach (string line in lines.Skip(1))
            {
                string[] parts = line.Split(',');

                if (parts.Length < 8)
                    continue;

                Book book = new Book
                {
                    ID = GetNextBookId(),
                    UserID = _userId,
                    Title = parts[0],
                    Author = parts[1],
                    Genre = parts[2],
                    Year = int.Parse(parts[3]),
                    Status = parts[4],
                    Rating = int.Parse(parts[5]),
                    Notes = parts[6],
                    CoverPath = parts[7]
                };

                books.Insert(0, book);
            }

            SaveAllBooksToCsv();

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = GetCurrentUserBooks();
            lblBookCount.Text = $"تعداد کل کتاب ها : {GetCurrentUserBookCount()}";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadBooksFromCsv();
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = GetCurrentUserBooks();
            lblBookCount.Text = $"تعداد کل کتاب ها : {GetCurrentUserBookCount()} ";
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string dataTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss", new CultureInfo("fa-IR"));
            lblDateTime.Text = $"تاریخ و ساعت جاری : {dataTime}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCreateOrUpdateBook CreateOrUpdateBookForm = new frmCreateOrUpdateBook(CreateNewBook);
            CreateOrUpdateBookForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفا ردیفی را برای حذف انتخاب کنید", "خطا",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("ایا از حذف این کتاب(ها) اطمینان دارید؟",
                                       "تایید حذف", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            var selectedBooks = new List<Book>();

            foreach (DataGridViewRow row in dgvBooks.SelectedRows)
            {

                Book book = (Book)row.DataBoundItem;
                if (book != null)
                    selectedBooks.Add(book);
            }

            if (selectedBooks.Count == 0)
            {
                MessageBox.Show("هیچ کتاب مجازی برای حذف انتخاب نشده");
                return;
            }

            foreach (Book book in selectedBooks)
            {
                books.Remove(book);
            }
            SaveAllBooksToCsv();

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = GetCurrentUserBooks();
            lblBookCount.Text = $"تعداد کل کتاب ها : {GetCurrentUserBookCount()}";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفا ردیفی را برای ویرایش انتخاب کنید", "خطا",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvBooks.SelectedRows.Count > 1)
            {
                MessageBox.Show("لطفا فقط یک ردیف را برای ویرایش انتخاب کنید", "خطا",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];
            Book bookToEdit = (Book)selectedRow.DataBoundItem;

            frmCreateOrUpdateBook CreateOrUpdateBookForm = new frmCreateOrUpdateBook(EditBook, bookToEdit);
            CreateOrUpdateBookForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch SearchForm = new frmSearch(EditBook, GetCurrentUserBooks());
            SearchForm.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("این کار تمامی کتاب های شمارا پاک میکند ایا از این کار اطمینان دارید؟",
                                       "تایید حذف", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            books.RemoveAll(book => book.UserID == _userId);
            SaveAllBooksToCsv();

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = GetCurrentUserBooks();
            lblBookCount.Text = $"تعداد کل کتاب ها : {GetCurrentUserBookCount()}";
            btnOpenFile.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8);

                    writer.WriteLine("Title,Author,Genre,Year,Status,Rating,Notes,CoverPath");

                    List<Book> userBooks = GetCurrentUserBooks();

                    foreach (Book book in userBooks)
                    {
                        writer.WriteLine($"{book.Title},{book.Author},{book.Genre},{book.Year},{book.Status},{book.Rating},{book.Notes},{book.CoverPath}");
                    }
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportBooksFromCsv(ofd.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving CSV: {ex.Message}");
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ساخته شده توسط علی اکیبر فرمان آرا و پردیس آقا محمد رفیع");
        }

        private void btnOpenReport_Click(object sender, EventArgs e)
        {
            frmReport ReportForm = new frmReport(GetCurrentUserBooks());
            ReportForm.ShowDialog();
        }

        private void btnreadedbooksCOun_Click(object sender, EventArgs e)
        {
            List<Book> currentUserBooks = GetCurrentUserBooks();
            int readedBookCount = currentUserBooks.Count(b => b.Status?.Trim() == "خوانده شده");
            MessageBox.Show($"تعداد کتاب های خوانده شده = {readedBookCount}");
        }

        private void btnReadingBookCount_Click(object sender, EventArgs e)
        {
            List<Book> currentUserBooks = GetCurrentUserBooks();
            int readingBookCount = currentUserBooks.Count(b => b.Status?.Trim() == "در حال خواندن");
            MessageBox.Show($"تعداد کتاب های در حال خواندن = {readingBookCount}");
        }
    }


}
