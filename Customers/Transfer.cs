using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class Transfer : Customers.BaseForm
    {
        public Transfer()
        {
            InitializeComponent();

            listFrom.DataSource = accBinding;
            listFrom.DisplayMember = "IdTypeBalance";
            listFrom.ValueMember = "Id";

            listTo.DataSource = accBinding2;
            listTo.DisplayMember = "IdTypeBalance";
            listTo.ValueMember = "Id";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            AcManagement AM = new AcManagement();
            AM.Show();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            Account from = listFrom.SelectedItem as Account;
            Account to = listTo.SelectedItem as Account;

            //control2.SetSelected();
            control2.AccTransfer(from, to, Convert.ToDouble(transferAmount.Text));


            control2.SetSelected(listFrom.SelectedItem as Account);
            control2.SetSelected2(listTo.SelectedItem as Account);

            control2.AccTransfer(control2.GetSelected(), control2.GetSelected2(), Convert.ToDouble(amountInputBox.Text));

            accBinding.ResetBindings(false);
            accBinding2.ResetBindings(false);
            transferAmount.Text = "0.00";
        }
    }
}
