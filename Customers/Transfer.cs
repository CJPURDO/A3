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

        private void Reset()
        {
            accBinding.ResetBindings(false);
            accBinding2.ResetBindings(false);
            transferAmount.Text = "0.00";
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string pattern = @"^\-?[0-9]+(?:\.[0-9]{1,2})?$";

            if (System.Text.RegularExpressions.Regex.IsMatch(transferAmount.Text, pattern))
            {
                double amount = Convert.ToDouble(transferAmount.Text);
                if (amount <= 0)
                {
                    MessageBox.Show("Please enter valid amount $");
                    Reset();
                }
                else
                {
                    try
                    {
                        control2.SetSelected(listFrom.SelectedItem as Account);
                        control2.SetSelected2(listTo.SelectedItem as Account);

                        control2.AccTransfer(control2.GetSelected(), control2.GetSelected2(), amount);
                        Reset(); ;
                    }
                    //if withdraw fails catch with exception and show message in listbox
                    catch (FailedWithdrawalException a)
                    {

                        MessageBox.Show(a.Message);
                        Reset();
                    }
                }
            }

            else
            {
                MessageBox.Show("Please enter valid amount $");
                Reset();
            }
        }

    }






}
