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

        static protected Controller control = new Controller();
        static protected Controller2 control2 = new Controller2();
        protected BindingSource accBinding = new BindingSource();
        protected BindingSource accBinding2 = new BindingSource();
        public BaseForm()
        {
            InitializeComponent();


            accBinding.DataSource = Controller2.accounts;
            accBinding2.DataSource = Controller2.accounts;


        }


        




        
    }
}
