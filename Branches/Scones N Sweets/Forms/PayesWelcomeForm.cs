using OliveBranchBakes.Forms;
using OliveBranchBakes.Forms.Login;
using OliveBranchBakes.Objects.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OliveBranchBakes
{
    public partial class PayesWelcomeForm : Form
    {
        public static PayesWelcomeForm? Current;
        
        public PayesWelcomeForm()
        {
            InitializeComponent();
            Current = this;
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            new PayesOrderForm().Show();
            this.Hide();
        }

        private void btnLoginGo_Click(object sender, EventArgs e)
        {
            PayesLoginForm loginForm = new();
            Account account = loginForm.Login();

            if (account != null)
            {
                if (account.Type == AccountType.Admin)
                {
                    new PayesAdminConsoleForm().Show();
                    this.Hide();
                }
                else if (account.Type == AccountType.Customer)
                {
                    new PayesCustomerHomeForm(account).Show();
                    this.Hide();
                }
            }
        }
    }
}
