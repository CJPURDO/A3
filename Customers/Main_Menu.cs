using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Customers
{
    public partial class Main_Menu : BaseForm
    {

        public Main_Menu()
        {
            InitializeComponent();

            //Read serialised data
            control.ReadBinaryData();
            control.setIDinstance();


            //If customer list is null
            if (Controller.customers.Count == 0)
            {
                //create dummy customers
                DummyCustomers();

                //write to file
                control.WriteBinaryData();

                //write ID
                control.WriteID();

            }

        }


        public void DummyCustomers()
        {
            //if customer list is empty, create dummy customers and accounts of customers
            if (Controller.customers.Count == 0)
            {
                
                control.CreateCustomer("Bob", "Jones", "0227530238", 1.0);
                control.CreateCustomer("Jane", "Doe", "022740238", 1.0);
                control.CreateCustomer("David", "Smith", "0290650997", 0.5);

                control.CreateAccount(Controller.customers[0], "E", 10.00, 1.00, 4.00, 0);
                control.CreateAccount(Controller.customers[0], "I", 20.00, 4, 10, 0);
                control.CreateAccount(Controller.customers[0], "O", 20.00, 4, 10, 500);
                control.CreateAccount(Controller.customers[1], "E", 10.00, 1.00, 4.00, 0);
                control.CreateAccount(Controller.customers[1], "I", 20.00, 4, 10, 0);
                control.CreateAccount(Controller.customers[1], "O", 20.00, 4, 10, 500);
                control.CreateAccount(Controller.customers[2], "E", 10.00, 1.00, 4.00, 0);
                control.CreateAccount(Controller.customers[2], "I", 20.00, 4, 10, 0);
                control.CreateAccount(Controller.customers[2], "O", 20.00, 4, 10, 500);

            }
        }

        // go to Manage customers 
        private void mangeCustBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Customers mm = new Manage_Customers();
            mm.Show();
        }

        // go to customer selection
        private void custAccBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select_Customer CA = new Select_Customer();
            CA.Show();

        }

        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            control.Save();
        }
    }
}
