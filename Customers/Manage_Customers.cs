using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;

namespace Customers
{
    public partial class Manage_Customers : Customers.BaseForm
    {

        protected BindingSource custBinding = new BindingSource();
        public Manage_Customers()
        {
            InitializeComponent();
            DisplayCust();




            custBinding.DataSource = Controller.customers;
            listCustomers.DataSource = custBinding;
            listCustomers.DisplayMember = "IdFullName";
            listCustomers.ValueMember = "ID";
            searchCustTextBox.SelectionStart = 0;



        }

        public void DisplayCust()
        {
            listCustomers.Items.Clear();
            if (Controller.customers.Count == 0)
            {
                listCustomers.Items.Add("No Customers to Show");
            }
            else
            {
                foreach (Customer c in Controller.customers)
                {
                    listCustomers.Items.Add(c.ID + " " + c.FirstName + " " + c.LastName);
                }
                listCustomers.SelectedIndex = 0;
            }
        }

        //retrieve customer object
        public void GetCustomerObject()
        {
            if (Controller.customers.Count != 0)
            {
                Customer c = Controller.customers[listCustomers.SelectedIndex];
                control.SetCustomer(c);
            }
        }

        private void btnCreateCust_Click(object sender, EventArgs e)
        {
            this.Close();
            Create_Customer CC = new Create_Customer();
            CC.Show();
        }



        private void btnView_Click(object sender, EventArgs e)
        {
            GetCustomerObject();
            this.Hide();
            View_Customer CC = new View_Customer();
            CC.Show();
            this.Close();
        }


        private void editCustomerBtn_Click(object sender, EventArgs e)
        {
            GetCustomerObject();
            this.Hide();
            Update_Customer UC = new Update_Customer();
            UC.Show();
            this.Close();
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            GetCustomerObject();
            this.Hide();
            Delete_Customer DC = new Delete_Customer();
            DC.Show();
            this.Close();
        }




        private void btn_SearchCustomer_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(searchCustTextBox.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please enter valid Customer ID.");
                searchCustTextBox.Text = searchCustTextBox.Text.Remove(searchCustTextBox.Text.Length - 1);
            }
            else
            {
                int input = Convert.ToInt32(searchCustTextBox.Text);
                var output = control.SearchCustomer(input);
                listCustomers.SelectedItem = output;
                searchCustTextBox.Text = "Enter Customer ID...";
            }
        }


        private void searchEnter(object sender, EventArgs e)
        {
            searchCustTextBox.Clear();
        }

        private void searchLeave(object sender, EventArgs e)
        {
            if (searchCustTextBox.Text == "")
                searchCustTextBox.Text = "Enter Customer ID...";
        }


        private void btn_backmm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu M_M = new Main_Menu();
            M_M.Show();
            this.Close();
        }

        private void ManageCust_FormClosing(object sender, FormClosingEventArgs e)
        {
            control.Save();
        }

        private void custTextChange(object sender, EventArgs e)
        {

        }
    }
}
