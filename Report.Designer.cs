namespace uni_project
{
    partial class frmReport
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
            lblTitle = new Label();
            lblTotalCount = new Label();
            lblTotalValue = new Label();
            lblReadCount = new Label();
            lblReadedValue = new Label();
            lblReadingCount = new Label();
            lblReadingValue = new Label();
            lblUnreadCount = new Label();
            lblUnreadValue = new Label();
            lblAvgRating = new Label();
            lblAvgValue = new Label();
            lblGenre = new Label();
            lblGenreValue = new Label();
            lblAuthor = new Label();
            lblAuthorValue = new Label();
            progressBooks = new ProgressBar();
            lblPercent = new Label();
            lblProgressTitle = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Window;
            lblTitle.Font = new Font("B Nazanin", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 192);
            lblTitle.Location = new Point(284, 10);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(127, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "گزارش آماری";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("B Nazanin", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblTotalCount.Location = new Point(15, 84);
            lblTotalCount.Margin = new Padding(5, 0, 5, 0);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(167, 35);
            lblTotalCount.TabIndex = 1;
            lblTotalCount.Text = "تعداد کل کتاب ها:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.BorderStyle = BorderStyle.FixedSingle;
            lblTotalValue.Font = new Font("B Nazanin", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblTotalValue.Location = new Point(184, 82);
            lblTotalValue.Margin = new Padding(5, 0, 5, 0);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(27, 37);
            lblTotalValue.TabIndex = 2;
            lblTotalValue.Text = "-";
            lblTotalValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReadCount
            // 
            lblReadCount.AutoSize = true;
            lblReadCount.Location = new Point(401, 84);
            lblReadCount.Margin = new Padding(4, 0, 4, 0);
            lblReadCount.Name = "lblReadCount";
            lblReadCount.Size = new Size(115, 35);
            lblReadCount.TabIndex = 3;
            lblReadCount.Text = "خوانده شده:";
            // 
            // lblReadedValue
            // 
            lblReadedValue.AutoSize = true;
            lblReadedValue.BorderStyle = BorderStyle.FixedSingle;
            lblReadedValue.Location = new Point(524, 82);
            lblReadedValue.Margin = new Padding(4, 0, 4, 0);
            lblReadedValue.Name = "lblReadedValue";
            lblReadedValue.Size = new Size(27, 37);
            lblReadedValue.TabIndex = 4;
            lblReadedValue.Text = "-";
            lblReadedValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReadingCount
            // 
            lblReadingCount.AutoSize = true;
            lblReadingCount.Location = new Point(15, 138);
            lblReadingCount.Margin = new Padding(4, 0, 4, 0);
            lblReadingCount.Name = "lblReadingCount";
            lblReadingCount.Size = new Size(146, 35);
            lblReadingCount.TabIndex = 5;
            lblReadingCount.Text = "در حال خواندن:";
            // 
            // lblReadingValue
            // 
            lblReadingValue.AutoSize = true;
            lblReadingValue.BorderStyle = BorderStyle.FixedSingle;
            lblReadingValue.Location = new Point(165, 138);
            lblReadingValue.Margin = new Padding(4, 0, 4, 0);
            lblReadingValue.Name = "lblReadingValue";
            lblReadingValue.Size = new Size(27, 37);
            lblReadingValue.TabIndex = 6;
            lblReadingValue.Text = "-";
            lblReadingValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUnreadCount
            // 
            lblUnreadCount.AutoSize = true;
            lblUnreadCount.Location = new Point(401, 138);
            lblUnreadCount.Margin = new Padding(4, 0, 4, 0);
            lblUnreadCount.Name = "lblUnreadCount";
            lblUnreadCount.Size = new Size(122, 35);
            lblUnreadCount.TabIndex = 7;
            lblUnreadCount.Text = "خوانده نشده:";
            // 
            // lblUnreadValue
            // 
            lblUnreadValue.AutoSize = true;
            lblUnreadValue.BorderStyle = BorderStyle.FixedSingle;
            lblUnreadValue.Location = new Point(530, 136);
            lblUnreadValue.Margin = new Padding(4, 0, 4, 0);
            lblUnreadValue.Name = "lblUnreadValue";
            lblUnreadValue.Size = new Size(27, 37);
            lblUnreadValue.TabIndex = 8;
            lblUnreadValue.Text = "-";
            lblUnreadValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAvgRating
            // 
            lblAvgRating.AutoSize = true;
            lblAvgRating.ForeColor = Color.Navy;
            lblAvgRating.Location = new Point(15, 194);
            lblAvgRating.Margin = new Padding(4, 0, 4, 0);
            lblAvgRating.Name = "lblAvgRating";
            lblAvgRating.Size = new Size(137, 35);
            lblAvgRating.TabIndex = 9;
            lblAvgRating.Text = "میانگین امتیاز:";
            // 
            // lblAvgValue
            // 
            lblAvgValue.AutoSize = true;
            lblAvgValue.BorderStyle = BorderStyle.FixedSingle;
            lblAvgValue.Location = new Point(155, 194);
            lblAvgValue.Margin = new Padding(4, 0, 4, 0);
            lblAvgValue.Name = "lblAvgValue";
            lblAvgValue.Size = new Size(27, 37);
            lblAvgValue.TabIndex = 10;
            lblAvgValue.Text = "-";
            lblAvgValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.ForeColor = Color.Navy;
            lblGenre.Location = new Point(401, 194);
            lblGenre.Margin = new Padding(4, 0, 4, 0);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(158, 35);
            lblGenre.TabIndex = 11;
            lblGenre.Text = "پرتکرار ترین ژانر:";
            // 
            // lblGenreValue
            // 
            lblGenreValue.AutoSize = true;
            lblGenreValue.BorderStyle = BorderStyle.FixedSingle;
            lblGenreValue.Location = new Point(567, 192);
            lblGenreValue.Margin = new Padding(4, 0, 4, 0);
            lblGenreValue.Name = "lblGenreValue";
            lblGenreValue.Size = new Size(27, 37);
            lblGenreValue.TabIndex = 12;
            lblGenreValue.Text = "-";
            lblGenreValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.ForeColor = Color.Navy;
            lblAuthor.Location = new Point(14, 255);
            lblAuthor.Margin = new Padding(4, 0, 4, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(328, 35);
            lblAuthor.TabIndex = 13;
            lblAuthor.Text = "نویسنده ای که بیشترین کتاب را دارد:";
            // 
            // lblAuthorValue
            // 
            lblAuthorValue.AutoSize = true;
            lblAuthorValue.BorderStyle = BorderStyle.FixedSingle;
            lblAuthorValue.Location = new Point(341, 253);
            lblAuthorValue.Margin = new Padding(4, 0, 4, 0);
            lblAuthorValue.Name = "lblAuthorValue";
            lblAuthorValue.Size = new Size(27, 37);
            lblAuthorValue.TabIndex = 14;
            lblAuthorValue.Text = "-";
            lblAuthorValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBooks
            // 
            progressBooks.ForeColor = Color.Lime;
            progressBooks.Location = new Point(275, 328);
            progressBooks.Margin = new Padding(4, 3, 4, 3);
            progressBooks.Name = "progressBooks";
            progressBooks.Size = new Size(248, 25);
            progressBooks.Style = ProgressBarStyle.Continuous;
            progressBooks.TabIndex = 15;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.BorderStyle = BorderStyle.FixedSingle;
            lblPercent.ForeColor = Color.Black;
            lblPercent.Location = new Point(184, 328);
            lblPercent.Margin = new Padding(4, 0, 4, 0);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(27, 37);
            lblPercent.TabIndex = 16;
            lblPercent.Text = "-";
            lblPercent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProgressTitle
            // 
            lblProgressTitle.AutoSize = true;
            lblProgressTitle.ForeColor = Color.Green;
            lblProgressTitle.Location = new Point(15, 328);
            lblProgressTitle.Margin = new Padding(4, 0, 4, 0);
            lblProgressTitle.Name = "lblProgressTitle";
            lblProgressTitle.Size = new Size(167, 35);
            lblProgressTitle.TabIndex = 17;
            lblProgressTitle.Text = "درصد خوانده شده:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(300, 400);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 41);
            btnClose.TabIndex = 18;
            btnClose.Text = "بستن";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(16F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(694, 453);
            Controls.Add(btnClose);
            Controls.Add(lblProgressTitle);
            Controls.Add(lblPercent);
            Controls.Add(progressBooks);
            Controls.Add(lblAuthorValue);
            Controls.Add(lblAuthor);
            Controls.Add(lblGenreValue);
            Controls.Add(lblGenre);
            Controls.Add(lblAvgValue);
            Controls.Add(lblAvgRating);
            Controls.Add(lblUnreadValue);
            Controls.Add(lblUnreadCount);
            Controls.Add(lblReadingValue);
            Controls.Add(lblReadingCount);
            Controls.Add(lblReadedValue);
            Controls.Add(lblReadCount);
            Controls.Add(lblTotalValue);
            Controls.Add(lblTotalCount);
            Controls.Add(lblTitle);
            Font = new Font("B Nazanin", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmReport";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "گزارش آماری";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblReadCount;
        private System.Windows.Forms.Label lblReadedValue;
        private System.Windows.Forms.Label lblReadingCount;
        private System.Windows.Forms.Label lblReadingValue;
        private System.Windows.Forms.Label lblUnreadCount;
        private System.Windows.Forms.Label lblUnreadValue;
        private System.Windows.Forms.Label lblAvgRating;
        private System.Windows.Forms.Label lblAvgValue;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblGenreValue;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblAuthorValue;
        private System.Windows.Forms.ProgressBar progressBooks;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblProgressTitle;
        private System.Windows.Forms.Button btnClose;
    }
}