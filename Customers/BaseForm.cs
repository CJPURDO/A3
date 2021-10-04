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
    public partial class BaseForm : Form
    {

        //static public Controller control;
        //Controller controller = Controller.control;
        //control.GetControlInstance();

        public static Controller control = Controller.GetControlInstance();
        


        static protected Customer basecustomer = new Customer();

        
        public BindingSource accBinding = new BindingSource();
        protected BindingSource accBinding2 = new BindingSource();

        

        public BaseForm()
        {
            InitializeComponent();

            

            //accBinding.DataSource = selectedCust.myAccounts;
            // accBinding2.DataSource = selectedCust.myAccounts;


        }


        




        
    }
}
