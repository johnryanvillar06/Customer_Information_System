using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustomerInformationSystem
{
    public partial class LoginForm : Form
    {
        public bool IsAuthenticated { get; private set; } = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string passwordHash = CustomerRepository.ComputeSha256Hash(password);

            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@Username AND PasswordHash=@PasswordHash", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    IsAuthenticated = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            using (var signUpForm = new SignUpForm())
            {
                signUpForm.ShowDialog();
            }
        }

        private void linkSignUp_LinkClicked(object sender, EventArgs e)
        {
            using (var signUpForm = new SignUpForm())
            {
                signUpForm.ShowDialog();
            }
        }
    }
}
