using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class AcManagement : BaseForm
    {

        protected BindingSource custBinding = new BindingSource();
        public AcManagement()
        {
            InitializeComponent();
            //SetAccInfo();


            custBinding.DataSource = Controller2.accounts;
            listSelectAcc.DataSource = custBinding;
            listSelectAcc.DisplayMember = "AccountType";
            listSelectAcc.ValueMember = "Id";
            //searchCustTextBox2.SelectionStart = 0;
        }


        public void SetAccInfo()
        {
            Account selectedAcc = control2.GetSelected();
            listAccInfo.Text = control2.AccInfo(selectedAcc);
        }





        private void btn_backCustAcc_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu MM = new Main_Menu();
            MM.Show();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateAccount CA = new CreateAccount();
            CA.Show();
        }
    }
}
