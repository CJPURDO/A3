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
    //Parent form class provides bank logo for all other forms within application
    public partial class BaseForm : Form
    {
        
        

        //Static controller instance for program-wide access
        public static Controller control = Controller.GetControlInstance();

        //ID data instance
        public static SingletonData instance = SingletonData.getInstance();

        //regex pattern for text box amount, available to all forms
        protected string pattern = @"^\-?[0-9]+(?:\.[0-9]{1,2})?$";

        public BaseForm()
        {
            InitializeComponent();
        }

    }
}
