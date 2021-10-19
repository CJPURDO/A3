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
    public  partial class Main_Menu : BaseForm
    {

        public Main_Menu()
        {
            InitializeComponent();
            //Controller.GetControlInstance();

            control.ReadBinaryData();
            control.setIDinstance();


            //if the customer list is null after reading the file(first time)
            //create a few test customers and write them to the file
            if (Controller.customers.Count == 0)
            {
                //create customers
                InitCustomers();
                //write them to file
                control.WriteBinaryData();
                //update stored ID
                control.WriteID();

            }

        }


        public void InitCustomers()
        {
            //if the customer list is empty, create test customers and thier accounts
            if (Controller.customers.Count == 0)
            {
                // pre-pop with customers
                control.CreateCustomer("Bob", "Jones", "0227530238", 1.0);
                control.CreateCustomer("Jane", "Doe", "022740238", 1.0);
                control.CreateCustomer("David", "Smith", "0290650997", 0.5);


                // give each test customer some accounts

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





            private void mangeCustBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Customers mm = new Manage_Customers();
            mm.Show();
            this.Close();
        }


        private void custAccBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select_Customer CA = new Select_Customer();
            CA.Show();
            this.Close();
        }

        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            control.Save();
        }
    }
}
