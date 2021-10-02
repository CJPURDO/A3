using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    public class Controller2
    {
        //Static list of accounts for program-wide storage
        public static List<Account> accounts = new List<Account>();
        public static Account selectedAcc;
        public static Everyday selectedE;
        public static Omni selectedO;


        //Set selected account
        public void SetSelected(Account acc)
        {
            selectedAcc = acc;         
        }

        //Return selected account
        public Account GetSelected()
        {
            return selectedAcc;   
        }


        //Deposit
        public void AccDeposit(Account selectedAcc, double amount)
        {
            selectedAcc.Deposit(amount);
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

        //Account information
        public string AccInfo(Account selectedAcc)
        {
                return selectedAcc.Info();   
        }

        //Create account
        public void CreateAccount(string accType, double openBalance, double intRate, double fees, double overdraft)
        {
            if (accType == "E") { accounts.Add(new Everyday(openBalance)); }
            else if (accType == "I") { accounts.Add(new Investment(openBalance, intRate, fees)); }
            else if (accType == "O") { accounts.Add(new Omni(openBalance, intRate, fees, overdraft)); }

        }

        //Account Balance
        public string AccBal(Account selectedAcc)
        {
            return "Balance $" + selectedAcc.Balance + " ;";
        }


        //Delete account
        public void DeleteAccount(Account a)
        {
            accounts.Remove(a);
        }

        //Search account by ID
        public Account SearchAccount(int accID)
        {
            foreach (Account a in accounts)
            {
                if (a.Id == accID)
                {
                    return a;
                }
            }
            return null;
        }


        
    }
}
