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
    public partial class MainManage : Customers.BaseForm
    {

        protected BindingSource custBinding = new BindingSource();
        public MainManage()
        {
            InitializeComponent();
            
            custBinding.DataSource = Controller.customers;
            listCustomers.DataSource = custBinding;
            listCustomers.DisplayMember = "IdFullName";
            listCustomers.ValueMember = "ID";
            searchCustTextBox.SelectionStart = 0;

            

        }

        private void btnCreateCust_Click(object sender, EventArgs e)
        {
            this.Close();
            Create_Customer CC = new Create_Customer();
            CC.Show();
        }

        
        private void btnView_Click(object sender, EventArgs e)
        {
            if (listCustomers.Items.Count < 1)
            {
                MessageBox.Show("Error: No Customer Selected");
            }
            else
            {
                control.SetSelected(listCustomers.SelectedItem as Customer);
                control.GetSelected();
                this.Close();
                View_Customer CC = new View_Customer();
                CC.Show();
            }

        }

        
        private void editCustomerBtn_Click(object sender, EventArgs e)
        {
            if (listCustomers.Items.Count < 1)
            {
                MessageBox.Show("Error: No Customer Selected");
            }
            else
            {
                control.SetSelected(listCustomers.SelectedItem as Customer);
                control.GetSelected();
                this.Close();
                Update_Customer UC = new Update_Customer();
                UC.Show();
            }

        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {

            if (listCustomers.Items.Count < 1)
            {
                MessageBox.Show("Error: No Customer Selected");
            }
            else
            {
                control.SetSelected(listCustomers.SelectedItem as Customer);
                control.GetSelected();
                this.Close();
                Delete_Customer DC = new Delete_Customer();
                DC.Show();
            }

        }




        private void btn_SearchCustomer_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(searchCustTextBox.Text, "[^0-9]"))
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
            this.Close();
            Main_Menu M_M = new Main_Menu();
            M_M.Show();
        }

        private void ManageCust_FormClosing(object sender, FormClosingEventArgs e)
        {
            control.SaveAll();
        }
    }
}
