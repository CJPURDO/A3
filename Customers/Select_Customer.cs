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
        protected BindingSource custBinding2 = new BindingSource();
        public Select_Customer()
        {
            InitializeComponent();
            DisplayCust();
            GetCustomerObject();

            custBinding2.DataSource = Controller.customers;
            listCustomers2.DataSource = custBinding2;
            listCustomers2.DisplayMember = "IdFullName";
            listCustomers2.ValueMember = "ID";
            searchCustTextBox2.SelectionStart = 0;
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

        private void searchEnter2(object sender, EventArgs e)
        {
            searchCustTextBox2.Clear();
        }

        private void searchLeave2(object sender, EventArgs e)
        {
            if (searchCustTextBox2.Text == "")
                searchCustTextBox2.Text = "Enter Customer ID...";
        }

        private void btn_SearchCustomer2_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(searchCustTextBox2.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please enter valid Customer ID.");
                searchCustTextBox2.Text = searchCustTextBox2.Text.Remove(searchCustTextBox2.Text.Length - 1);
            }
            else
            {
                //listCustomers.Items.Clear();
                int input = Convert.ToInt32(searchCustTextBox2.Text);
                var output = control.SearchCustomer(input);
                listCustomers2.SelectedItem = output;
                searchCustTextBox2.Text = "Enter Customer ID...";

            }
        }
    }
}
