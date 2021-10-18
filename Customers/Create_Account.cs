using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class Create_Account : Customers.BaseForm
    {
        public Create_Account()
        {
            InitializeComponent();
            comAcc.SelectedIndex = 0;
            inputBal.Text = "0.00";
            inputInt.Text = "0.00";
            inputFee.Text = "0.00";
            inputOver.Text = "0.00";

            
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {



            if (inputBal.Text == "" || inputInt.Text == "" || inputFee.Text == "" || inputOver.Text == "")
            {
                MessageBox.Show("Please input valid values");
            }
            else
            {
                control.CreateAccount(Controller.selectedCust, GetAccountType(),
                                    Convert.ToDouble(inputBal.Text),
                                    Convert.ToDouble(inputInt.Text),
                                    Convert.ToDouble(inputFee.Text),
                                    Convert.ToDouble(inputOver.Text));
                this.Close();
                Manage_Accounts mm = new Manage_Accounts();
                mm.ShowDialog();
            }
            

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
