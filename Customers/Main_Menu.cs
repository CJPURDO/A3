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
    public  partial class Main_Menu : Customers.BaseForm
    {
        public Main_Menu()
        {
            InitializeComponent();
            //Controller.GetControlInstance();
        }

        private void mangeCustBtn_Click(object sender, EventArgs e)
        {
            MainManage mm = new MainManage();
            mm.Show();
            this.Hide();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void custAcBtn_Click(object sender, EventArgs e)
        //{

        //}

        private void custAccBtn_Click(object sender, EventArgs e)
        {
            CustomerAccount CA = new CustomerAccount();
            CA.Show();
            this.Hide();
        }

        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            control.SaveAll();
        }
    }
}
