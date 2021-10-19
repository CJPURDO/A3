using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class Select_Customer : Customers.BaseForm
    {

        public Select_Customer()
        {
            InitializeComponent();
            DisplayCust();
            GetCustomerObject();
        }


        public void DisplayCust()
        {
            listCustomers2.Items.Clear();
            if (Controller.customers.Count == 0)
            {
                listCustomers2.Items.Add("No Customers to Show");
            }
            else
            {
                foreach (Customer c in Controller.customers)
                {
                    listCustomers2.Items.Add(c.ID + " " + c.FirstName + "  " + c.LastName);
                }
                listCustomers2.SelectedIndex = 0;
            }
        }


        //select customer object
        public void GetCustomerObject()
        {
            if (Controller.customers.Count != 0)
            {
                Customer c = Controller.customers[listCustomers2.SelectedIndex];
                control.SetCustomer(c);
            }
        }


        private void btnManageCustAcc_Click(object sender, EventArgs e)
        {
            GetCustomerObject();
            this.Hide();
            Manage_Accounts AM = new Manage_Accounts();
            AM.Show();
            this.Close();
        }




        private void btn_backmm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu M_M = new Main_Menu();
            M_M.Show();
            this.Close();
        }
    }
}
