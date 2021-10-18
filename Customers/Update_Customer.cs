using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class Update_Customer : Customers.BaseForm
    {
        public Update_Customer()
        {
            InitializeComponent();
            SetCustInfo();
            fName.SelectionStart = 0;
        }

        public void SetCustInfo()
        {
            Customer selectedCust = control.GetCustomer();
            fName.Text = selectedCust.FirstName;
            lName.Text = selectedCust.LastName;
            phoneInput.Text = selectedCust.Phone;

            if (selectedCust.Charge == 1.0)
            {
                comboType.SelectedIndex = 0;
            }
            else
            {
                comboType.SelectedIndex = 1;
            }
        }


        private void btn_saveClose_Click(object sender, EventArgs e)
        {
            Customer selectedCust = control.GetCustomer();

            if (fName.Text == "" || lName.Text == "" || phoneInput.Text == "")
            {
                MessageBox.Show("Please input valid values");
            }
            else
            {
                control.UpdateCustomer(selectedCust, fName.Text, lName.Text, phoneInput.Text, GetCharge());
                this.Close();
                Manage_Customers mm = new Manage_Customers();
                mm.ShowDialog();              
            }
        }

        private double GetCharge()
        {
            if (comboType.SelectedIndex == 0)
            {
                return 1.0;
            }
            else
            {
                return 0.5;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_Customers mm = new Manage_Customers();
            mm.ShowDialog();   
        }
    }
}
