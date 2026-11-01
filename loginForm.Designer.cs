namespace uni_project
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnEyeOpen = new Button();
            btnSubmit = new Button();
            btnEyeClose = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtUsername.Font = new Font("Vazirmatn", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(242, 146);
            txtUsername.Margin = new Padding(6, 7, 6, 7);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(307, 43);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtPassword.Font = new Font("Vazirmatn", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(242, 237);
            txtPassword.Margin = new Padding(0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 43);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(242, 105);
            lblUsername.Margin = new Padding(6, 0, 6, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 34);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "نام کاربری";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(242, 203);
            lblPassword.Margin = new Padding(6, 0, 6, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 34);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "رمز عبور";
            // 
            // btnEyeOpen
            // 
            btnEyeOpen.Anchor = AnchorStyles.Top;
            btnEyeOpen.BackColor = SystemColors.Control;
            btnEyeOpen.BackgroundImage = (Image)resources.GetObject("btnEyeOpen.BackgroundImage");
            btnEyeOpen.BackgroundImageLayout = ImageLayout.Zoom;
            btnEyeOpen.Location = new Point(506, 238);
            btnEyeOpen.Name = "btnEyeOpen";
            btnEyeOpen.Size = new Size(43, 43);
            btnEyeOpen.TabIndex = 2;
            btnEyeOpen.UseVisualStyleBackColor = false;
            btnEyeOpen.Visible = false;
            btnEyeOpen.Click += btnEyeOpen_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top;
            btnSubmit.BackColor = Color.White;
            btnSubmit.ForeColor = Color.FromArgb(0, 150, 74);
            btnSubmit.Location = new Point(242, 333);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(307, 50);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "ورود";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnEyeClose
            // 
            btnEyeClose.Anchor = AnchorStyles.Top;
            btnEyeClose.BackgroundImage = (Image)resources.GetObject("btnEyeClose.BackgroundImage");
            btnEyeClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnEyeClose.Location = new Point(506, 238);
            btnEyeClose.Name = "btnEyeClose";
            btnEyeClose.Size = new Size(43, 43);
            btnEyeClose.TabIndex = 4;
            btnEyeClose.UseVisualStyleBackColor = true;
            btnEyeClose.Click += btnEyeClose_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(242, 403);
            label1.Name = "label1";
            label1.Size = new Size(119, 34);
            label1.TabIndex = 5;
            label1.Text = "اکانت ندارید؟";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(474, 403);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 34);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ثبت نام";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmLogin
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(15F, 46F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(771, 472);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(btnEyeClose);
            Controls.Add(btnSubmit);
            Controls.Add(btnEyeOpen);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Font = new Font("Vazirmatn", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 150, 74);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            Name = "frmLogin";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnEyeOpen;
        private Button btnSubmit;
        private Button btnEyeClose;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
