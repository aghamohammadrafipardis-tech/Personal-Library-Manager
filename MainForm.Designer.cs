namespace uni_project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            فایلToolStripMenuItem = new ToolStripMenuItem();
            btnNew = new ToolStripMenuItem();
            btnOpenFile = new ToolStripMenuItem();
            btnSave = new ToolStripMenuItem();
            خروجToolStripMenuItem = new ToolStripMenuItem();
            کتابToolStripMenuItem = new ToolStripMenuItem();
            btnAdd = new ToolStripMenuItem();
            btnEdit = new ToolStripMenuItem();
            btnDelete = new ToolStripMenuItem();
            btnSearch = new ToolStripMenuItem();
            گزارشToolStripMenuItem = new ToolStripMenuItem();
            btnOpenReport = new ToolStripMenuItem();
            btnreadedbooksCOun = new ToolStripMenuItem();
            btnReadingBookCount = new ToolStripMenuItem();
            btnAbout = new ToolStripMenuItem();
            dgvBooks = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colGenre = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colRating = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            lblBookCount = new ToolStripStatusLabel();
            lblDateTime = new ToolStripStatusLabel();
            timer = new System.Windows.Forms.Timer(components);
            sfd = new SaveFileDialog();
            ofd = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { فایلToolStripMenuItem, کتابToolStripMenuItem, گزارشToolStripMenuItem, btnAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1022, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // فایلToolStripMenuItem
            // 
            فایلToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnNew, btnOpenFile, btnSave, خروجToolStripMenuItem });
            فایلToolStripMenuItem.Name = "فایلToolStripMenuItem";
            فایلToolStripMenuItem.Size = new Size(50, 24);
            فایلToolStripMenuItem.Text = "فایل";
            // 
            // btnNew
            // 
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(142, 26);
            btnNew.Text = "جدید";
            btnNew.Click += btnNew_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(142, 26);
            btnOpenFile.Text = "باز کردن";
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSave
            // 
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 26);
            btnSave.Text = "ذخیره";
            btnSave.Click += btnSave_Click;
            // 
            // خروجToolStripMenuItem
            // 
            خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            خروجToolStripMenuItem.Size = new Size(142, 26);
            خروجToolStripMenuItem.Text = "خروج";
            // 
            // کتابToolStripMenuItem
            // 
            کتابToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnDelete, btnSearch });
            کتابToolStripMenuItem.Name = "کتابToolStripMenuItem";
            کتابToolStripMenuItem.Size = new Size(54, 24);
            کتابToolStripMenuItem.Text = "کتاب";
            // 
            // btnAdd
            // 
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 26);
            btnAdd.Text = "افزودن";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(138, 26);
            btnEdit.Text = "ویرایش";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 26);
            btnDelete.Text = "حدف ";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(138, 26);
            btnSearch.Text = "جستجو";
            btnSearch.Click += btnSearch_Click;
            // 
            // گزارشToolStripMenuItem
            // 
            گزارشToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnOpenReport, btnreadedbooksCOun, btnReadingBookCount });
            گزارشToolStripMenuItem.Name = "گزارشToolStripMenuItem";
            گزارشToolStripMenuItem.Size = new Size(63, 24);
            گزارشToolStripMenuItem.Text = "گزارش";
            // 
            // btnOpenReport
            // 
            btnOpenReport.Name = "btnOpenReport";
            btnOpenReport.Size = new Size(245, 26);
            btnOpenReport.Text = "آمار کلی";
            btnOpenReport.Click += btnOpenReport_Click;
            // 
            // btnreadedbooksCOun
            // 
            btnreadedbooksCOun.Name = "btnreadedbooksCOun";
            btnreadedbooksCOun.Size = new Size(245, 26);
            btnreadedbooksCOun.Text = "کتاب های خوانده نشده";
            btnreadedbooksCOun.Click += btnreadedbooksCOun_Click;
            // 
            // btnReadingBookCount
            // 
            btnReadingBookCount.Name = "btnReadingBookCount";
            btnReadingBookCount.Size = new Size(245, 26);
            btnReadingBookCount.Text = "کتاب های در حال خواندن";
            btnReadingBookCount.Click += btnReadingBookCount_Click;
            // 
            // btnAbout
            // 
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(59, 24);
            btnAbout.Text = "درباره";
            btnAbout.Click += btnAbout_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = SystemColors.Control;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { colID, colTitle, colAuthor, colGenre, colYear, colStatus, colRating });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Vazirmatn", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.Location = new Point(0, 28);
            dgvBooks.Margin = new Padding(2);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersWidth = 80;
            dgvBooks.Size = new Size(1022, 329);
            dgvBooks.TabIndex = 2;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "شناسه";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.DataPropertyName = "Title";
            colTitle.HeaderText = "عنوان";
            colTitle.MinimumWidth = 6;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colAuthor
            // 
            colAuthor.DataPropertyName = "Author";
            colAuthor.HeaderText = "نویسنده";
            colAuthor.MinimumWidth = 6;
            colAuthor.Name = "colAuthor";
            colAuthor.ReadOnly = true;
            // 
            // colGenre
            // 
            colGenre.DataPropertyName = "Genre";
            colGenre.HeaderText = "ژانر";
            colGenre.MinimumWidth = 6;
            colGenre.Name = "colGenre";
            colGenre.ReadOnly = true;
            // 
            // colYear
            // 
            colYear.DataPropertyName = "Year";
            colYear.HeaderText = "سال انتشار";
            colYear.MinimumWidth = 6;
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "وضعیت خواندن";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colRating
            // 
            colRating.DataPropertyName = "Rating";
            colRating.HeaderText = "امتیاز";
            colRating.MinimumWidth = 6;
            colRating.Name = "colRating";
            colRating.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblBookCount, lblDateTime });
            statusStrip1.Location = new Point(0, 359);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1022, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblBookCount
            // 
            lblBookCount.Name = "lblBookCount";
            lblBookCount.Size = new Size(122, 20);
            lblBookCount.Text = "تعداد کل کتاب ها ";
            // 
            // lblDateTime
            // 
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(128, 20);
            lblDateTime.Text = "تاریخ و ساعت جاری";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // sfd
            // 
            sfd.Filter = "CSV Files (*.csv)|*.csv";
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            ofd.Filter = "CSV Files (*.csv)|*.csv";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 385);
            Controls.Add(statusStrip1);
            Controls.Add(dgvBooks);
            Controls.Add(menuStrip1);
            Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "صفحه اصلی";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem فایلToolStripMenuItem;
        private ToolStripMenuItem btnNew;
        private ToolStripMenuItem btnOpenFile;
        private ToolStripMenuItem btnSave;
        private ToolStripMenuItem خروجToolStripMenuItem;
        private ToolStripMenuItem کتابToolStripMenuItem;
        private ToolStripMenuItem btnAdd;
        private ToolStripMenuItem btnEdit;
        private ToolStripMenuItem btnDelete;
        private ToolStripMenuItem btnSearch;
        private ToolStripMenuItem گزارشToolStripMenuItem;
        private ToolStripMenuItem btnOpenReport;
        private ToolStripMenuItem btnreadedbooksCOun;
        private ToolStripMenuItem btnReadingBookCount;
        private ToolStripMenuItem btnAbout;
        private DataGridView dgvBooks;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colGenre;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colRating;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblBookCount;
        private ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.Timer timer;
        private SaveFileDialog sfd;
        private OpenFileDialog ofd;
    }
}