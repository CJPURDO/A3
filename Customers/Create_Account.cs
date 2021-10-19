using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class Create_Account : BaseForm
    {

        
        public Create_Account()
        {
            InitializeComponent();
            comAcc.SelectedIndex = 0;
            SetName();
        }


        public void SetName()
        {
            Customer c = control.GetCustomer();
            textCustName.Text = c.FirstName + " " + c.LastName;
            inputOver.Text = "0.00";

        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {

            Customer c = control.GetCustomer();
            control.CreateAccount(c, GetAccountType(), 0.00, 4, 10, Convert.ToDouble(inputOver.Text));

            this.Hide();
            Manage_Accounts mm = new Manage_Accounts();
            mm.ShowDialog();
            this.Close();


        }


        private string GetAccountType()
        {
            if (comAcc.SelectedIndex == 0)
            {
                return "E";
            }
            else if (comAcc.SelectedIndex == 1)
            {
                return "I";
            }
            else
            {
                return "O";
            }
        }
    }
}
