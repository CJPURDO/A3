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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Customers
{
    public partial class BaseForm : Form
    {

        protected string pattern = @"^\-?[0-9]+(?:\.[0-9]{1,2})?$";

        public static Controller control = Controller.GetControlInstance();

        public static SingletonData instance = SingletonData.getInstance();



        
        

        public BaseForm()
        {
            InitializeComponent();
            //control.ReadBinaryData();
            //control.setIDinstance();


            //if the customer list is null after reading the file (first time)
            //create a few test customers and write them to the file
            //if (Controller.AllCust.Count == 0)
            //{
            //    //create customers
            //    InitCustomers();
            //    //write them to file
            //    controller.WriteBinaryData();
            //    //update stored ID
            //    controller.WriteID();

            //}


            //create a few customers to test -- how these are added here does not comply entirely with MVC, but they are just for testing
            //public void InitCustomers()
            //{
            //    //if the customer list is empty, create test customers and thier accounts
            //    if (Controller.AllCust.Count == 0)
            //    {
            //        // pre-pop with customers
            //        controller.CreateCustomer(115, "Ryan", "Wilson", 022351764, 1.0);
            //        controller.CreateCustomer(116, "Michelle", "Simons", 027999784, 1.0);
            //        controller.CreateCustomer(117, "Alpharius", "Omegon", 02900997, 0.5);

            //        // create a few test accounts
            //        Account a = new Everyday(10.00, 1.00, 4.00);
            //        Account b = new Investment(20.00, 4, 10);
            //        Account c = new Omni(35.50, 4, 10, -200);
            //        Account d = new Everyday(55.00, 1, 2);
            //        Account e = new Omni(400.00, 4, 10, -1000);
            //        Account f = new Investment(235.60, 4, 10);
            //        Account g = new Omni(10000.00, 4, 10, -20000);
            //        Account h = new Everyday(95.00, 1, 5);

            //        // give each test customer some accounts

            //        control.CreateAccount(Controller.customers[0], a);
            //        controller.AddAccount(Controller.customers[0], b);
            //        controller.AddAccount(Controller.customers[0], c);
            //        controller.AddAccount(Controller.customers[1], d);
            //        controller.AddAccount(Controller.customers[1], e);
            //        controller.AddAccount(Controller.customers[2], f);
            //        controller.AddAccount(Controller.customers[2], g);
            //        controller.AddAccount(Controller.customers[2], h);

            //    }

            //}


            //if (!File.Exists(@"C: \Users\camronjon\Documents\Cam_Personal\IT_Course\BIT706_Programming iii\BIT706_A2_5030521\Customers\Customers\bin\objects.bin"))
            //{

            //    control.WriteBinaryData();
            //    accBinding.DataSource = null;
            //    accBinding2.DataSource = null;
            //}
            //else
            //{
            //    control.ReadBinaryData();
            //    control.setIDinstance();

            //}

            //control.WriteBinaryData();
            //accBinding.DataSource = null;
            //accBinding2.DataSource = null;



        }








    }
}
