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

        

        string pattern = @"^\-?[0-9]+(?:\.[0-9]{1,2})?$";
        public AcManagement()
        {
            InitializeComponent();

            accBinding.DataSource = Controller.selectedCust.myAccounts;
            accBinding2.DataSource = Controller.selectedCust.myAccounts;

            listSelectAcc.DataSource = accBinding;
            listSelectAcc.DisplayMember = "IdTypeBalance";
            listSelectAcc.ValueMember = "Id";

            //Controller.selectedCust.myAccounts.Add(new Everyday(100));
            //Controller.selectedCust.myAccounts.Add(new Investment(22.22, 5, 1));
            //Controller.selectedCust.myAccounts.Add(new Omni(234, 2, 2, -290));
            //DisplayMyAccount();
            updateReset();
        }

        public void updateReset()
        {
            accBinding.ResetBindings(false);
            amountInputBox.Text = "0.00";
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
                control.SetAccount(listSelectAcc.SelectedItem as Account);
                listAccInfo.Items.Insert(0, "\n");
                listAccInfo.Items.Insert(0, control.AccInfo(control.GetAccount()));
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
                control.SetAccount(listSelectAcc.SelectedItem as Account);
                listAccInfo.Items.Insert(0, "\n");
                listAccInfo.Items.Insert(0, control.AccBal(control.GetAccount()));
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
                    control.SetAccount(listSelectAcc.SelectedItem as Account);
                    control.AccDeposit(control.GetAccount(), Convert.ToDouble(amountInputBox.Text));

                    listAccInfo.Items.Insert(0, "\n");
                    listAccInfo.Items.Insert(0, control.AccInfo(control.GetAccount()));
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
                        control.SetAccount(listSelectAcc.SelectedItem as Account);
                        control.AccWithdraw(control.GetAccount(), Convert.ToDouble(amountInputBox.Text));

                        listAccInfo.Items.Insert(0, "\n");
                        listAccInfo.Items.Insert(0, control.AccInfo(control.GetAccount()));
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
            control.SetAccount(listSelectAcc.SelectedItem as Account);
            control.AccCalcInt(control.GetAccount());

            listAccInfo.Items.Insert(0, "\n");
            listAccInfo.Items.Insert(0, "Interest: $" + control.GetAccount().CalcInterest());
        }

        private void addInterestBtn_Click(object sender, EventArgs e)
        {
            control.SetAccount(listSelectAcc.SelectedItem as Account);
            control.AccAddInt(control.GetAccount());

            listAccInfo.Items.Insert(0, "\n");
            listAccInfo.Items.Insert(0, control.AccInfo(control.GetAccount()));
            updateReset();
        }


        private void clearInfoBtn_Click(object sender, EventArgs e)
        {
            listAccInfo.Items.Clear();
            updateReset();
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            control.SetAccount(listSelectAcc.SelectedItem as Account);
            control.DeleteAccount(control.GetAccount());
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
            CustomerAccount CA = new CustomerAccount();
            CA.Show();
            this.Close();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            //control.SetSelected(control.GetSelected());
            this.Close();
            CreateAccount CA = new CreateAccount();
            CA.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            this.Close();
            Transfer T = new Transfer();
            T.Show();
        }
    }
}
