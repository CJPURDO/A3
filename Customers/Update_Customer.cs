using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class Update_Customer : BaseForm
    {
        public Update_Customer()
        {
            InitializeComponent();
            SetCustInfo();
            fName.SelectionStart = 0;
        }

        public void SetCustInfo()
        {
            Customer c = control.GetCustomer();
            fName.Text = c.FirstName;
            lName.Text = c.LastName;
            phoneInput.Text = c.Phone;

            if (c.Charge == 1.0)
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
            Customer c = control.GetCustomer();

            if (fName.Text == "" || lName.Text == "" || phoneInput.Text == "")
            {
                MessageBox.Show("Please input valid values");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(phoneInput.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please input valid phone number");
            }
            else
            {
                control.UpdateCustomer(c, fName.Text, lName.Text, phoneInput.Text, GetCharge());
                this.Hide();
                Manage_Customers mm = new Manage_Customers();
                mm.ShowDialog();
                this.Close();
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
            this.Hide();
            Manage_Customers mm = new Manage_Customers();
            mm.ShowDialog();
            this.Close();
        }

        private void updateCustFormClosing(object sender, FormClosingEventArgs e)
        {
            control.Save();
        }
    }
}
