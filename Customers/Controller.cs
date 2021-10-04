using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    public class Controller
    {
        //Static list of customers for program-wide storage
        public static List<Customer> customers = new List<Customer>();

        public static Customer selectedCust;

        public static Account selectedAcc;
        public static Account selectedAcc2;


   

        
        public static Controller control = new Controller();
        private Controller() { }

        public static Controller GetControlInstance()
        {
            if (control == null)
            {
                control = new Controller();
            }

            return control;
        }



        //Create account
        public void CreateAccount(Customer c, string accType, double openBalance, double intRate, double fees, double overdraft)
        {
            if (accType == "E") { c.myAccounts.Add(new Everyday(openBalance)); }
            else if (accType == "I") { c.myAccounts.Add(new Investment(openBalance, intRate, fees)); }
            else if (accType == "O") { c.myAccounts.Add(new Omni(openBalance, intRate, fees, overdraft)); }
        }



        //Set selected account
        public void SetAccount(Account acc)
        {
            selectedAcc = acc;
        }

        public void SetAccount2(Account acc)
        {
            selectedAcc2 = acc;
        }

        //Return selected account
        public Account GetAccount()
        {
            return selectedAcc;
        }

        public Account GetAccount2()
        {
            return selectedAcc2;
        }

        //Account information
        public string AccInfo(Account selectedAcc)
        {
            return selectedAcc.Info();
        }

        //Account Balance
        public string AccBal(Account selectedAcc)
        {
            return "Balance $" + selectedAcc.Balance + " ;";
        }

        //Deposit
        public void AccDeposit(Account selectedAcc, double amount)
        {
            selectedAcc.Deposit(amount);
        }

        //Transfer
        public void AccTransfer(Account selectedAcc, Account selectedAcc2, double amount)
        {
            selectedAcc.Withdraw(amount);
            selectedAcc2.Deposit(amount);
        }

        //Withdraw
        public void AccWithdraw(Account selectedAcc, double amount)
        {
            selectedAcc.Withdraw(amount);
        }

        //Calculate Interest
        public void AccCalcInt(Account selectedAcc)
        {
            selectedAcc.CalcInterest();
        }

        //Add Interest
        public void AccAddInt(Account selectedAcc)
        {
            selectedAcc.AddInterest();
        }

        

        //Delete account
        public void DeleteAccount(Account a)
        {
            selectedCust.myAccounts.Remove(a);
        }

        //Search account by ID
        public Account SearchAccount(int accID)
        {
            foreach (Account a in selectedCust.myAccounts)
            {
                if (a.Id == accID)
                {
                    return a;
                }
            }
            return null;
        }










        //Set selected customer
        public void SetSelected(Customer cust)
        {
            selectedCust = cust;
        }

        //Return selected customer
        public Customer GetSelected()
        {
            return selectedCust;
        }

        //Customer information
        public string CustInfo(Customer selectedCust)
        {
            return selectedCust.ID + " " + selectedCust.FirstName + " " + selectedCust.LastName +
                "\n" + selectedCust.Phone +
                "\n" + selectedCust.ChargePercent + ";";
        }

        //Create customer
        public void CreateCustomer(string firstna, string lastna, string phone, double charge)
        {
            customers.Add(new Customer(firstna, lastna, phone, charge));
        }

        //Update customer
        public void UpdateCustomer(Customer obj, string firstna, string lastna, string phone, double charge)
        {
            foreach (Customer c in customers)
            {
                if (obj == c)
                {
                    c.FirstName = firstna;
                    c.LastName = lastna;
                    c.Phone = phone;
                    c.Charge = charge;
                }
            }
        }

        //Delete customer
        public void DeleteCustomer(Customer c)
        {
            customers.Remove(c);
        }

        //Search customer by ID
        public Customer SearchCustomer(int custID)
        {
            foreach (Customer c in customers)
            {
                if (c.ID == custID)
                {
                    return c;
                }
            }
            return null;
        }

    }
}
