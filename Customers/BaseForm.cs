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

        //public static Controller control = Controller.GetControlInstance();

        public static SingletonData instance = SingletonData.getInstance();

        public static Controller control = Controller.GetControlInstance();




        public BaseForm()
        {
            InitializeComponent();
            //control.ReadBinaryData();
            //control.setIDinstance();


            


        //create a few customers to test -- how these are added here does not comply entirely with MVC, but they are just for testing
        

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
