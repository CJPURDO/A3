using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class Create_Customer : Customers.BaseForm
    {
        public Create_Customer()
        {
            InitializeComponent();
            comboType.SelectedIndex = 0;
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
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
                try
                {
                    control.CreateCustomer(fName.Text, lName.Text, phoneInput.Text, GetCharge());
                    this.Close();
                    Manage_Customers mm = new Manage_Customers();
                    mm.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("error");
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Customers mm = new Manage_Customers();
            mm.ShowDialog();
            this.Close();
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

        private void Create_Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            control.Save();
        }
    }
}
