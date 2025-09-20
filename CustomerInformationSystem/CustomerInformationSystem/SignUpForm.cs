using System;
using System.Windows.Forms;

namespace CustomerInformationSystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;

            var repo = new CustomerRepository(Program.ConnectionString); // Use your connection string
            try
            {
                repo.AddUser(username, password, fullName, email);
                MessageBox.Show("User account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
