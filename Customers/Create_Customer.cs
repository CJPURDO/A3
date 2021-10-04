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
            //GetControlInstance();
            comboType.SelectedIndex = 0;
            //Controller.GetControlInstance();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            if (fName.Text == "" || lName.Text == "" || phoneInput.Text == "")
            {
                MessageBox.Show("Please input valid values");
            }
            else
            {
                control.CreateCustomer(fName.Text, lName.Text, phoneInput.Text, GetCharge());
                this.Close();
                MainManage mm = new MainManage();
                mm.ShowDialog();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainManage mm = new MainManage();
            mm.ShowDialog();

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

    }
}
