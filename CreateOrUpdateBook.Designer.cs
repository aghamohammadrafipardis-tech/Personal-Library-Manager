namespace uni_project
{
    partial class frmCreateOrUpdateBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateOrUpdateBook));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblRating = new Label();
            txtAuthor = new TextBox();
            label5 = new Label();
            cmbGenre = new ComboBox();
            nudYear = new NumericUpDown();
            txtTitle = new TextBox();
            cmbStatus = new ComboBox();
            trbRating = new TrackBar();
            label7 = new Label();
            lblCoverPath = new Label();
            rtxtNotes = new RichTextBox();
            btnOpenfile = new Button();
            ofdCoverPath = new OpenFileDialog();
            btnSubmit = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbRating).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(lblRating, 1, 4);
            tableLayoutPanel1.Controls.Add(txtAuthor, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(cmbGenre, 0, 3);
            tableLayoutPanel1.Controls.Add(nudYear, 1, 3);
            tableLayoutPanel1.Controls.Add(txtTitle, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbStatus, 0, 5);
            tableLayoutPanel1.Controls.Add(trbRating, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(lblCoverPath, 1, 6);
            tableLayoutPanel1.Controls.Add(rtxtNotes, 0, 7);
            tableLayoutPanel1.Controls.Add(btnOpenfile, 1, 7);
            tableLayoutPanel1.Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(707, 368);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(357, 12);
            label1.Name = "label1";
            label1.Size = new Size(347, 34);
            label1.TabIndex = 0;
            label1.Text = "عنوان کتاب";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(348, 34);
            label2.TabIndex = 1;
            label2.Text = "نام نویسنده";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Location = new Point(357, 104);
            label3.Name = "label3";
            label3.Size = new Size(347, 34);
            label3.TabIndex = 2;
            label3.Text = "ژانر";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Location = new Point(3, 104);
            label4.Name = "label4";
            label4.Size = new Size(348, 34);
            label4.TabIndex = 3;
            label4.Text = "سال انتشار";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Dock = DockStyle.Bottom;
            lblRating.Location = new Point(3, 196);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(348, 34);
            lblRating.TabIndex = 5;
            lblRating.Text = "امتیاز";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(18, 49);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(333, 39);
            txtAuthor.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Location = new Point(357, 196);
            label5.Name = "label5";
            label5.Size = new Size(347, 34);
            label5.TabIndex = 4;
            label5.Text = "وضعیت";
            // 
            // cmbGenre
            // 
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Items.AddRange(new object[] { "رمان", "علمی", "تاریخی", "فلسفی", "فناوری", "سایر" });
            cmbGenre.Location = new Point(370, 141);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(334, 42);
            cmbGenre.TabIndex = 8;
            // 
            // nudYear
            // 
            nudYear.Location = new Point(18, 141);
            nudYear.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(333, 39);
            nudYear.TabIndex = 9;
            nudYear.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(370, 49);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(334, 39);
            txtTitle.TabIndex = 6;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "خوانده نشده", "در حال خواندن", "خوانده شده" });
            cmbStatus.Location = new Point(370, 233);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(334, 42);
            cmbStatus.TabIndex = 10;
            // 
            // trbRating
            // 
            trbRating.Location = new Point(18, 233);
            trbRating.Maximum = 5;
            trbRating.Minimum = 1;
            trbRating.Name = "trbRating";
            trbRating.Size = new Size(333, 40);
            trbRating.TabIndex = 11;
            trbRating.Value = 1;
            trbRating.ValueChanged += trbRating_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Bottom;
            label7.Location = new Point(357, 288);
            label7.Name = "label7";
            label7.Size = new Size(347, 34);
            label7.TabIndex = 12;
            label7.Text = "یادداشت شخصی";
            // 
            // lblCoverPath
            // 
            lblCoverPath.AutoSize = true;
            lblCoverPath.Dock = DockStyle.Bottom;
            lblCoverPath.Location = new Point(3, 288);
            lblCoverPath.Name = "lblCoverPath";
            lblCoverPath.Size = new Size(348, 34);
            lblCoverPath.TabIndex = 13;
            lblCoverPath.Text = " تصویر جلد کتاب";
            // 
            // rtxtNotes
            // 
            rtxtNotes.Location = new Point(370, 325);
            rtxtNotes.Name = "rtxtNotes";
            rtxtNotes.Size = new Size(334, 40);
            rtxtNotes.TabIndex = 14;
            rtxtNotes.Text = "";
            // 
            // btnOpenfile
            // 
            btnOpenfile.Location = new Point(18, 325);
            btnOpenfile.Name = "btnOpenfile";
            btnOpenfile.Size = new Size(333, 40);
            btnOpenfile.TabIndex = 15;
            btnOpenfile.Text = "انتخاب فایل";
            btnOpenfile.UseVisualStyleBackColor = true;
            btnOpenfile.Click += btnOpenfile_Click;
            // 
            // ofdCoverPath
            // 
            ofdCoverPath.FileName = "openFileDialog1";
            ofdCoverPath.Filter = "Image Files | *.jpg;*.png;*.jpeg";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(307, 399);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(126, 55);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "ثبت";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // frmCreateOrUpdateBook
            // 
            AutoScaleDimensions = new SizeF(15F, 46F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 476);
            Controls.Add(btnSubmit);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Vazirmatn", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            Name = "frmCreateOrUpdateBook";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "حذف و ویرایش کتاب";
            FormClosing += frmCreateOrUpdateBook_FormClosing;
            Load += frmCreateOrUpdateBook_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbRating).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblRating;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label label5;
        private ComboBox cmbGenre;
        private NumericUpDown nudYear;
        private ComboBox cmbStatus;
        private TrackBar trbRating;
        private Label label7;
        private Label lblCoverPath;
        private RichTextBox rtxtNotes;
        private OpenFileDialog openFileDialog1;
        private Button btnOpen;
        private Button btnSubmit;
        private OpenFileDialog ofdCoverPath;
        private Button btnOpenfile;
    }
}