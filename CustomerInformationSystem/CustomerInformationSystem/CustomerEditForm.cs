using System;
using System.Windows.Forms;

namespace CustomerInformationSystem
{
    public partial class CustomerEditForm : Form
    {
        public Customer Customer { get; private set; }

        public CustomerEditForm(Customer customer = null)
        {
            InitializeComponent();
            if (customer != null)
            {
                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                txtEmail.Text = customer.Email;
                txtPhone.Text = customer.Phone;
                txtAddress.Text = customer.Address;
                Customer = customer;
            }
            else
            {
                Customer = new Customer();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer.FirstName = txtFirstName.Text;
            Customer.LastName = txtLastName.Text;
            Customer.Email = txtEmail.Text;
            Customer.Phone = txtPhone.Text;
            Customer.Address = txtAddress.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
