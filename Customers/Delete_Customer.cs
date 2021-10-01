using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class Delete_Customer : Customers.BaseForm
    {
        public Delete_Customer()
        {
            InitializeComponent();
            SetCustInfo();
        }


        public void SetCustInfo()
        {
            Customer selectedCust = control.GetSelected(); 
            infoLabel.Text = control.CustInfo(selectedCust);
        }

        private void yesDelete_Click(object sender, EventArgs e)
        {
            Customer selectedCust = control.GetSelected();
            control.DeleteCustomer(selectedCust);
            this.Close();
            MainManage mm = new MainManage();
            mm.ShowDialog();
            
        }

        private void noDelete_Click(object sender, EventArgs e)
        {
            this.Close();
            MainManage mm = new MainManage();
            mm.ShowDialog();    
        }
    }
}
