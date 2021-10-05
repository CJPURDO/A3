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
        public static Controller control = Controller.GetControlInstance();

        public static SingletonData instance = SingletonData.getInstance();

        static protected Customer basecustomer = new Customer();

        
        public BindingSource accBinding = new BindingSource();
        public BindingSource accBinding2 = new BindingSource();

        
        

        public BaseForm()
        {
            InitializeComponent();

            control.ReadBinaryData();


            accBinding.DataSource = null;
            accBinding2.DataSource = null;


        }


        




        
    }
}
