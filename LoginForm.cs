
namespace uni_project
{
    public partial class frmLogin : Form
    {
        int _failedAttempts = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private int? AuthenticateUser(string username, string password)
        {
            string filePath = "users.txt";

            if (!File.Exists(filePath))
                return null;

            string[] users = File.ReadAllLines(filePath);
            string hashedInput = Utils.ComputeMD5(password);

            foreach (string line in users)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3) 
                {
                    string storedUser = parts[1];
                    string storedHash = parts[2];

                    if (storedUser == username && storedHash == hashedInput)
                    {
                        if (int.TryParse(parts[0], out int userId))
                            return userId;
                    }
                }
            }
            return null;
        }


        private void btnEyeClose_Click(object sender, EventArgs e)
        {
            btnEyeClose.Visible = false;
            btnEyeOpen.Visible = true;
            txtPassword.UseSystemPasswordChar = false;

        }

        private void btnEyeOpen_Click(object sender, EventArgs e)
        {
            btnEyeOpen.Visible = false;
            btnEyeClose.Visible = true;
            txtPassword.UseSystemPasswordChar = true;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmsignup signupForm = new frmsignup();
            signupForm.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("لطفاً نام کاربری را وارد کنید.", "خطا",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("لطفاً رمز عبور را وارد کنید.", "خطا",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            int? userId = AuthenticateUser(username, password);
            if (userId.HasValue)
            {
                _failedAttempts = 0;
                
                frmMain mainForm = new frmMain(userId.Value);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                _failedAttempts++;

                if (_failedAttempts >= 3)
                {
                    MessageBox.Show("سه بار تلاش ناموفق. برنامه بسته می‌شود.",
                                "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else 
                {
                    MessageBox.Show($"نام کاربری یا رمز عبور اشتباه است. (تعداد تلاش‌های ناموفق: {_failedAttempts})",
                                    "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
