using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customers
{
    public  partial class Main_Menu : Customers.BaseForm
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void mangeCustBtn_Click(object sender, EventArgs e)
        {
            MainManage mm = new MainManage();
            mm.Show();
            this.Hide();
        }
    }
}
