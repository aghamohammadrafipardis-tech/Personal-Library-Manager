using System.Security.Cryptography;
using System.Text;

namespace uni_project
{
    public partial class frmsignup : Form
    {
        private Encoding _encoding = new UTF8Encoding();
        public frmsignup()
        {
            InitializeComponent();
        }

        private void ShowLogin() {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }

        private static bool UsernameExists(string filePath, string usernameToCheck)
        {
            if (!File.Exists(filePath))
                return false;

            string[] users = File.ReadAllLines(filePath);

            foreach (string user in users)
            {
                string[] parts = user.Split('|');
                // parts[0] = id, parts[1] = username, parts[2] = password
                if (parts.Length >= 2 && parts[1] == usernameToCheck) return true;
            }

            return false;

        }

        private static int GetNextUserId(string filePath)
        {
            if (!File.Exists(filePath))
                return 1;

            string[] users = File.ReadAllLines(filePath);
            int maxId = 0;
            foreach (string user in users)
            {
                string[] parts = user.Split('|');
                if (parts.Length > 0 && int.TryParse(parts[0], out int id))
                {
                    if (id > maxId)
                        maxId = id;
                }
            }
            return maxId + 1;
        }


        private void btnEyeOpenPass_Click(object sender, EventArgs e)
        {
            btnEyeOpenPass.Visible = false;
            btnEyeClosePass.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnEyeClosePass_Click(object sender, EventArgs e)
        {
            btnEyeClosePass.Visible = false;
            btnEyeOpenPass.Visible = true;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnEyeOpenConfirm_Click(object sender, EventArgs e)
        {
            btnEyeOpenConfirm.Visible = false;
            btnEyeCloseConfirm.Visible = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnEyeCloseConfirm_Click(object sender, EventArgs e)
        {
            btnEyeCloseConfirm.Visible = false;
            btnEyeOpenConfirm.Visible = true;
            txtConfirmPassword.UseSystemPasswordChar = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLogin();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("نام کاربری خود را وارد کنید");
                return;
            }

            if (password != confirmPassword) {
                MessageBox.Show("رمز عبور و تکرار آن یکی نیستند", "خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("رمز عبور باید حداقل 6 کارکتر باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filePath = "users.txt";

            if (UsernameExists(filePath, userName))
            {
                MessageBox.Show("نام کاربری موجود میباشد نام کاربری دیگری را امتحان کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int newId = GetNextUserId(filePath);

            string hashedPassword = Utils.ComputeMD5(password);

            string userData = $"{newId}|{userName}|{hashedPassword}";

            File.AppendAllText(filePath, userData + Environment.NewLine, _encoding);

            MessageBox.Show("کاربر با موفقیت اضافه شد", "موفق",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ShowLogin();
        }
    }
}
