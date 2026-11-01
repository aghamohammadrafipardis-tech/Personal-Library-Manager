namespace uni_project
{
    partial class frmsignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsignup));
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            lblPasswoed = new Label();
            lblUsername = new Label();
            txtUserName = new TextBox();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            btnEyeCloseConfirm = new Button();
            btnEyeClosePass = new Button();
            btnEyeOpenPass = new Button();
            btnEyeOpenConfirm = new Button();
            btnSubmit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Vazirmatn", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(124, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 43);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Vazirmatn", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(124, 292);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(254, 43);
            txtConfirmPassword.TabIndex = 4;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.FromArgb(0, 150, 74);
            lblConfirmPassword.Location = new Point(260, 255);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(118, 34);
            lblConfirmPassword.TabIndex = 3;
            lblConfirmPassword.Text = "تکرار رمز عبور";
            // 
            // lblPasswoed
            // 
            lblPasswoed.AutoSize = true;
            lblPasswoed.Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasswoed.ForeColor = Color.FromArgb(0, 150, 74);
            lblPasswoed.Location = new Point(301, 136);
            lblPasswoed.Name = "lblPasswoed";
            lblPasswoed.Size = new Size(77, 34);
            lblPasswoed.TabIndex = 2;
            lblPasswoed.Text = "رمز عبور";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(0, 150, 74);
            lblUsername.Location = new Point(286, 21);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 34);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "نام کاربری";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Vazirmatn", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(71, 58);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(307, 43);
            txtUserName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEyeCloseConfirm);
            panel1.Controls.Add(btnEyeClosePass);
            panel1.Controls.Add(btnEyeOpenPass);
            panel1.Controls.Add(btnEyeOpenConfirm);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(lblConfirmPassword);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblPasswoed);
            panel1.Location = new Point(207, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 508);
            panel1.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(71, 445);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 34);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ورود";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 445);
            label1.Name = "label1";
            label1.Size = new Size(201, 34);
            label1.TabIndex = 11;
            label1.Text = "از قبل ثبت نام کرده اید؟";
            // 
            // btnEyeCloseConfirm
            // 
            btnEyeCloseConfirm.Anchor = AnchorStyles.Top;
            btnEyeCloseConfirm.BackgroundImage = (Image)resources.GetObject("btnEyeCloseConfirm.BackgroundImage");
            btnEyeCloseConfirm.BackgroundImageLayout = ImageLayout.Zoom;
            btnEyeCloseConfirm.Location = new Point(71, 292);
            btnEyeCloseConfirm.Name = "btnEyeCloseConfirm";
            btnEyeCloseConfirm.Size = new Size(43, 43);
            btnEyeCloseConfirm.TabIndex = 10;
            btnEyeCloseConfirm.UseVisualStyleBackColor = true;
            btnEyeCloseConfirm.Click += btnEyeCloseConfirm_Click;
            // 
            // btnEyeClosePass
            // 
            btnEyeClosePass.Anchor = AnchorStyles.Top;
            btnEyeClosePass.BackgroundImage = (Image)resources.GetObject("btnEyeClosePass.BackgroundImage");
            btnEyeClosePass.BackgroundImageLayout = ImageLayout.Zoom;
            btnEyeClosePass.Location = new Point(71, 174);
            btnEyeClosePass.Name = "btnEyeClosePass";
            btnEyeClosePass.Size = new Size(43, 43);
            btnEyeClosePass.TabIndex = 7;
            btnEyeClosePass.UseVisualStyleBackColor = true;
            btnEyeClosePass.Click += btnEyeClosePass_Click;
            // 
            // btnEyeOpenPass
            // 
            btnEyeOpenPass.Anchor = AnchorStyles.Top;
            btnEyeOpenPass.BackColor = SystemColors.Control;
            btnEyeOpenPass.BackgroundImage = (Image)resources.GetObject("btnEyeOpenPass.BackgroundImage");
            btnEyeOpenPass.BackgroundImageLayout = ImageLayout.Zoom;
            btnEyeOpenPass.Location = new Point(71, 174);
            btnEyeOpenPass.Name = "btnEyeOpenPass";
            btnEyeOpenPass.Size = new Size(43, 43);
            btnEyeOpenPass.TabIndex = 9;
            btnEyeOpenPass.UseVisualStyleBackColor = false;
            btnEyeOpenPass.Visible = false;
            btnEyeOpenPass.Click += btnEyeOpenPass_Click;
            // 
            // btnEyeOpenConfirm
            // 
            btnEyeOpenConfirm.Anchor = AnchorStyles.Top;
            btnEyeOpenConfirm.BackColor = SystemColors.Control;
            btnEyeOpenConfirm.BackgroundImage = (Image)resources.GetObject("btnEyeOpenConfirm.BackgroundImage");
            btnEyeOpenConfirm.BackgroundImageLayout = ImageLayout.Zoom;
            btnEyeOpenConfirm.Location = new Point(71, 292);
            btnEyeOpenConfirm.Name = "btnEyeOpenConfirm";
            btnEyeOpenConfirm.Size = new Size(43, 43);
            btnEyeOpenConfirm.TabIndex = 8;
            btnEyeOpenConfirm.UseVisualStyleBackColor = false;
            btnEyeOpenConfirm.Visible = false;
            btnEyeOpenConfirm.Click += btnEyeOpenConfirm_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.ForeColor = Color.FromArgb(0, 150, 74);
            btnSubmit.Location = new Point(71, 375);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(307, 43);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "ثبت  نام";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // frmsignup
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(15F, 46F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(809, 564);
            Controls.Add(panel1);
            Font = new Font("Vazirmatn", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            Name = "frmsignup";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ثبت نام";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private Label lblPasswoed;
        private Label lblUsername;
        private TextBox txtUserName;
        private Panel panel1;
        private Button btnSubmit;
        private Button btnEyeClosePass;
        private Button btnEyeOpenConfirm;
        private Button btnEyeCloseConfirm;
        private Button btnEyeOpenPass;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}