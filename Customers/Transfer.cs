using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class Transfer : BaseForm
    {

        public Transfer()
        {
            InitializeComponent();
            SetAccounts();
        }


        public void SetAccounts()
        {
            Customer c = control.GetCustomer();
            listFrom.Items.Clear();
            listTo.Items.Clear();
            List<Account> ca = control.GetAccountsList();
            textCustName2.Text = c.FirstName + " " + c.LastName;

            if (ca.Count == 0)
            {
                listFrom.Items.Add("No Accounts to Show");
                listTo.Items.Add("No Accounts to Show");
            }
            else
            {
                foreach (Account a in ca)
                {
                    listFrom.Items.Add(a.Id + " " + a.AccountType + " $" + a.Balance);
                    listTo.Items.Add(a.Id + " " + a.AccountType + " $" + a.Balance);
                }
                listFrom.SelectedIndex = 0;
                listTo.SelectedIndex = 0;
                transferAmount.Text = "0.00";

            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_Accounts AM = new Manage_Accounts();
            AM.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //string pattern = @"^\-?[0-9]+(?:\.[0-9]{1,2})?$";
            List<Account> ca = control.GetAccountsList();
            //Customer c = control.GetCustomer();

            if (System.Text.RegularExpressions.Regex.IsMatch(transferAmount.Text, pattern))
            {
                double amount = Convert.ToDouble(transferAmount.Text);
                if (amount <= 0)
                {
                    MessageBox.Show("Please enter valid amount $");
                    SetAccounts();

                }
                else
                {
                    try
                    {
                        Account from = ca[listFrom.SelectedIndex];
                        Account to = ca[listTo.SelectedIndex];
                        control.AccTransfer(from, to, amount);
                        SetAccounts();
                    }
                    //if withdraw fails catch with exception and show message in listbox
                    catch (FailedWithdrawalException a)
                    {
                        MessageBox.Show(a.Message);
                        SetAccounts();
                    }
                }
            }

            else
            {
                MessageBox.Show("Please enter valid amount $");
                SetAccounts();
            }
        }

        private void Transfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            control.SaveAll();
        }
    }






}
