using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class View_Customer : Customers.BaseForm
    {
        public View_Customer()
        {
            InitializeComponent();
            SetCustInfo();
        }

        public void SetCustInfo()
        {
            Customer selectedCust = control.GetSelected();
            viewLabel.Text = control.CustInfo(selectedCust);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainManage mm = new MainManage();
            mm.ShowDialog();         
        }


    }
}
