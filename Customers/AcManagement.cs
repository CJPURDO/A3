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

        protected BindingSource accBinding = new BindingSource();

        string pattern = @"^\-?[0-9]+(?:\.[0-9]{1,2})?$";
        public AcManagement()
        {
            InitializeComponent();

            control2.CreateAccount("E", 100, 10, 2.55, 0);
            control2.CreateAccount("I", 122.33, 10, 2.55, 2);
            control2.CreateAccount("O", 1400.32, 10, 2.55, 5);

            accBinding.DataSource = Controller2.accounts;
            listSelectAcc.DataSource = accBinding;
            listSelectAcc.DisplayMember = "IdTypeBalance";
            listSelectAcc.ValueMember = "Id";
            searchAccTextBox.SelectionStart = 0;
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
                control2.SetSelected(listSelectAcc.SelectedItem as Account);
                listAccInfo.Items.Insert(0, "\n");
                listAccInfo.Items.Insert(0, control2.AccInfo(control2.GetSelected()));
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
                control2.SetSelected(listSelectAcc.SelectedItem as Account);
                listAccInfo.Items.Insert(0, "\n");
                listAccInfo.Items.Insert(0, control2.AccBal(control2.GetSelected()));


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
                    control2.SetSelected(listSelectAcc.SelectedItem as Account);
                    control2.AccDeposit(control2.GetSelected(), Convert.ToDouble(amountInputBox.Text));

                    listAccInfo.Items.Insert(0, "\n");
                    listAccInfo.Items.Insert(0, control2.AccInfo(control2.GetSelected()));
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
                        control2.SetSelected(listSelectAcc.SelectedItem as Account);
                        control2.AccWithdraw(control2.GetSelected(), Convert.ToDouble(amountInputBox.Text));

                        listAccInfo.Items.Insert(0, "\n");
                        listAccInfo.Items.Insert(0, control2.AccInfo(control2.GetSelected()));
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
            control2.SetSelected(listSelectAcc.SelectedItem as Account);
            control2.AccCalcInt(control2.GetSelected());

            listAccInfo.Items.Insert(0, "\n");
            listAccInfo.Items.Insert(0, "Interest: $" + control2.GetSelected().CalcInterest());
        }

        private void addInterestBtn_Click(object sender, EventArgs e)
        {
            control2.SetSelected(listSelectAcc.SelectedItem as Account);
            control2.AccAddInt(control2.GetSelected());

            listAccInfo.Items.Insert(0, "\n");
            listAccInfo.Items.Insert(0, control2.AccInfo(control2.GetSelected()));
            updateReset();
        }







        private void clearInfoBtn_Click(object sender, EventArgs e)
        {
            listAccInfo.Items.Clear();
            updateReset();
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            control2.SetSelected(listSelectAcc.SelectedItem as Account);
            control2.DeleteAccount(control2.GetSelected());
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
                var output = control2.SearchAccount(input);
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

            Main_Menu MM = new Main_Menu();
            MM.Show();
            this.Close();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateAccount CA = new CreateAccount();
            CA.Show();

        }

        
    }
}
