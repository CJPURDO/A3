using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class CreateAccount : Customers.BaseForm
    {
        public CreateAccount()
        {
            InitializeComponent();
            comAcc.SelectedIndex = 0;
            //MessageBox.Show(Controller.selectedCust.FirstName);
            //inputBal.Text = Controller.selectedCust.FirstName;
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            
            //control.SetSelected(selectedCust);
            

            control.CreateAccount(Controller.selectedCust, GetAccountType(), 
                                    Convert.ToDouble(inputBal.Text),
                                    Convert.ToDouble(inputInt.Text),
                                    Convert.ToDouble(inputFee.Text),
                                    Convert.ToDouble(inputOver.Text));

            
            this.Close();
            AcManagement mm = new AcManagement();
            mm.ShowDialog();

            //
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
