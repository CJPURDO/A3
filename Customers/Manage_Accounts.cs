using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class Manage_Accounts : BaseForm
    {
        protected BindingSource accBinding = new BindingSource();
        public Manage_Accounts()
        {
            InitializeComponent();
            DisplayAccounts();

            Customer c = control.GetCustomer();
            accBinding.DataSource = Controller.c.myAccounts;
            listSelectAcc.DataSource = accBinding;
            listSelectAcc.DisplayMember = "IdTypeBalance";
            listSelectAcc.ValueMember = "Id";

        }

        public void updateReset()
        {

            accBinding.ResetBindings(false);
            amountInputBox.Text = "0.00";
        }

        public void DisplayAccounts()
        {
            listSelectAcc.Items.Clear();
            
            Customer c = control.GetCustomer();
            List<Account> ca = control.GetAccountsList();
            
            textCustName.Text = c.FirstName + " " + c.LastName;
            if (ca.Count == 0)
            {
                listSelectAcc.Items.Add("No Accounts to Show");
            }
            else
            {
                foreach (Account a in ca)
                {
                    listSelectAcc.Items.Add(a.Id + " " + a.AccountType + "  " + "$" + a.Balance);
                }
                listSelectAcc.SelectedIndex = 0;
            }
        }



        private void accountInfoBtn_Click(object sender, EventArgs e)
        {
            if (listSelectAcc.Items.Count < 1)
            {
                listAccInfo.Items.Insert(0, "\n");
                listAccInfo.Items.Insert(0, "Error: No Account Selected");
            }
            else
            {
                List<Account> ca = control.GetAccountsList();
                Account acc = ca[listSelectAcc.SelectedIndex];
                listAccInfo.Items.Insert(0, "\n");
                listAccInfo.Items.Insert(0, control.AccInfo(acc));
            }
        }

        private void btnChkBal_Click(object sender, EventArgs e)
        {
            if (listSelectAcc.Items.Count < 1)
            {
                listAccInfo.Items.Insert(0, "\n");
                listAccInfo.Items.Insert(0, "Error: No Account Selected");
            }
            else
            {
                List<Account> ca = control.GetAccountsList();
                Account acc = ca[listSelectAcc.SelectedIndex];
                listAccInfo.Items.Insert(0, "\n");
                listAccInfo.Items.Insert(0, control.AccBal(acc));
            }
        }



        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(amountInputBox.Text, pattern))
            {
                double amount = Convert.ToDouble(amountInputBox.Text);

                if (amount <= 0)
                {
                    listAccInfo.Items.Insert(0, "\n");
                    listAccInfo.Items.Insert(0, "Please enter valid amount $");
                    updateReset();
                }
                else
                {
                    List<Account> ca = control.GetAccountsList();
                    Account acc = ca[listSelectAcc.SelectedIndex];
                    control.AccDeposit(acc, Convert.ToDouble(amountInputBox.Text));
                    listAccInfo.Items.Insert(0, "\n");
                    listAccInfo.Items.Insert(0, control.AccInfo(acc));
                    updateReset();
                }
            }

            else
            {
                listAccInfo.Items.Insert(0, "\n");
                listAccInfo.Items.Insert(0, "Please enter valid amount $");
                updateReset();
            }
        }



        private void withdrawBtn_Click(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(amountInputBox.Text, pattern))
            {
                double amount = Convert.ToDouble(amountInputBox.Text);

                if (amount <= 0)
                {
                    listAccInfo.Items.Insert(0, "\n");
                    listAccInfo.Items.Insert(0, "Please enter valid amount $");
                    updateReset();
                }
                else
                {
                    try
                    {
                        Customer c = control.GetCustomer();
                        List<Account> ca = control.GetAccountsList();
                        Account acc = ca[listSelectAcc.SelectedIndex];               
                        control.AccWithdraw(acc, Convert.ToDouble(amountInputBox.Text), c.Charge);

                        listAccInfo.Items.Insert(0, "\n");
                        listAccInfo.Items.Insert(0, control.AccInfo(acc));
                        updateReset();
                    }
                    //if withdraw fails catch with exception and show message in listbox
                    catch (FailedWithdrawalException a)
                    {
                        listAccInfo.Items.Insert(0, "\n");
                        listAccInfo.Items.Insert(0, a.Message);
                        updateReset();
                    }
                }
            }

            else
            {
                listAccInfo.Items.Insert(0, "\n");
                listAccInfo.Items.Insert(0, "Please enter valid amount $");
                updateReset();
            }

        }

        private void btnCalcInt_Click(object sender, EventArgs e)
        {
            List<Account> ca = control.GetAccountsList();
            Account acc = ca[listSelectAcc.SelectedIndex];
            control.AccCalcInt(acc);

            listAccInfo.Items.Insert(0, "\n");
            listAccInfo.Items.Insert(0, "Interest: $" + acc.CalcInterest());
        }

        private void addInterestBtn_Click(object sender, EventArgs e)
        {
            List<Account> ca = control.GetAccountsList();
            Account acc = ca[listSelectAcc.SelectedIndex];
            control.AccAddInt(acc);

            listAccInfo.Items.Insert(0, "\n");
            listAccInfo.Items.Insert(0, control.AccInfo(acc));
            updateReset();
        }


        private void clearInfoBtn_Click(object sender, EventArgs e)
        {
            listAccInfo.Items.Clear();
            updateReset();
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {

            List<Account> ca = control.GetAccountsList();
            Account acc = ca[listSelectAcc.SelectedIndex];
            
            control.DeleteAccount(acc);
            updateReset();
        }

        private void btn_SearchAccount_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(searchAccTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter valid Account ID.");
                searchAccTextBox.Text = searchAccTextBox.Text.Remove(searchAccTextBox.Text.Length - 1);
            }
            else
            {
                int input = Convert.ToInt32(searchAccTextBox.Text);
                var output = control.SearchAccount(input);
                listSelectAcc.SelectedItem = output;
                searchAccTextBox.Text = "Enter Account ID...";
            }
        }

        private void searchAccEnter(object sender, EventArgs e)
        {
            searchAccTextBox.Clear();
        }

        private void btn_backCustAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select_Customer CA = new Select_Customer();
            CA.Show();
            this.Close();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Account CA = new Create_Account();
            CA.Show();
            this.Close();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            this.Close();
            Transfer T = new Transfer();
            T.Show();
        }

        private void AccManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            control.Save();
        }
    }
}
