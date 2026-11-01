namespace uni_project
{
     partial class frmSearch
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
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            cmbGenre = new ComboBox();
            cmbStatus = new ComboBox();
            txtYearFrom = new TextBox();
            txtYearTo = new TextBox();
            lblTitle = new Label();
            label2 = new Label();
            lblAuthor = new Label();
            lblGenre = new Label();
            lblStatus = new Label();
            lblYearFrom = new Label();
            lblYearTo = new Label();
            btnSearch = new Button();
            btnClearFilters = new Button();
            lstResults = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 62);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(271, 34);
            txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(12, 168);
            txtAuthor.Margin = new Padding(3, 4, 3, 4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(271, 34);
            txtAuthor.TabIndex = 1;
            // 
            // cmbGenre
            // 
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Items.AddRange(new object[] { "رمان", "علمی", "تاریخی", "فلسفی", "فناوری", "سایر" });
            cmbGenre.Location = new Point(12, 276);
            cmbGenre.Margin = new Padding(3, 4, 3, 4);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(271, 37);
            cmbGenre.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "خوانده نشده", "در حال خواندن", "خوانده شده" });
            cmbStatus.Location = new Point(424, 62);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(271, 37);
            cmbStatus.TabIndex = 3;
            // 
            // txtYearFrom
            // 
            txtYearFrom.Location = new Point(424, 168);
            txtYearFrom.Margin = new Padding(3, 4, 3, 4);
            txtYearFrom.Name = "txtYearFrom";
            txtYearFrom.Size = new Size(124, 34);
            txtYearFrom.TabIndex = 4;
            // 
            // txtYearTo
            // 
            txtYearTo.Location = new Point(568, 168);
            txtYearTo.Margin = new Padding(3, 4, 3, 4);
            txtYearTo.Name = "txtYearTo";
            txtYearTo.Size = new Size(127, 34);
            txtYearTo.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(52, 29);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "عنوان";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 145);
            label2.Name = "label2";
            label2.Size = new Size(0, 29);
            label2.TabIndex = 7;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(13, 138);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(68, 29);
            lblAuthor.TabIndex = 8;
            lblAuthor.Text = "نویسنده";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(12, 248);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(34, 29);
            lblGenre.TabIndex = 9;
            lblGenre.Text = "ژانر";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(426, 33);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 29);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "وضعیت";
            // 
            // lblYearFrom
            // 
            lblYearFrom.AutoSize = true;
            lblYearFrom.Location = new Point(420, 138);
            lblYearFrom.Name = "lblYearFrom";
            lblYearFrom.Size = new Size(56, 29);
            lblYearFrom.TabIndex = 11;
            lblYearFrom.Text = "از سال";
            // 
            // lblYearTo
            // 
            lblYearTo.AutoSize = true;
            lblYearTo.Location = new Point(564, 138);
            lblYearTo.Name = "lblYearTo";
            lblYearTo.Size = new Size(61, 29);
            lblYearTo.TabIndex = 12;
            lblYearTo.Text = "تا سال ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.CornflowerBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(424, 274);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 34);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClearFilters
            // 
            btnClearFilters.BackColor = Color.Salmon;
            btnClearFilters.FlatStyle = FlatStyle.Flat;
            btnClearFilters.Location = new Point(568, 276);
            btnClearFilters.Margin = new Padding(3, 4, 3, 4);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(127, 34);
            btnClearFilters.TabIndex = 14;
            btnClearFilters.Text = "پاک کردن فیلترها";
            btnClearFilters.UseVisualStyleBackColor = false;
            btnClearFilters.Click += btnClearFilters_Click;
            // 
            // lstResults
            // 
            lstResults.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            lstResults.FormattingEnabled = true;
            lstResults.ItemHeight = 29;
            lstResults.Location = new Point(12, 379);
            lstResults.Margin = new Padding(3, 4, 3, 4);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(683, 178);
            lstResults.TabIndex = 15;
            lstResults.DoubleClick += lstResults_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 352);
            label1.Name = "label1";
            label1.Size = new Size(47, 29);
            label1.TabIndex = 16;
            label1.Text = "نتایج";
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(825, 622);
            Controls.Add(label1);
            Controls.Add(lstResults);
            Controls.Add(btnClearFilters);
            Controls.Add(btnSearch);
            Controls.Add(lblYearTo);
            Controls.Add(lblYearFrom);
            Controls.Add(lblStatus);
            Controls.Add(lblGenre);
            Controls.Add(lblAuthor);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(txtYearTo);
            Controls.Add(txtYearFrom);
            Controls.Add(cmbStatus);
            Controls.Add(cmbGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Font = new Font("Vazirmatn", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Margin = new Padding(4, 6, 4, 6);
            Name = "frmSearch";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "جستجوی پیشرفته کتاب";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtYearFrom;
        private System.Windows.Forms.TextBox txtYearTo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblYearFrom;
        private System.Windows.Forms.Label lblYearTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label label1;
    }
}