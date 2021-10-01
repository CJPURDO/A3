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

        //Set selected account
        public void SetSelected(Account acc)
        {
            selectedAcc = acc;
        }

        //Return selected account
        public Account GetSelected()
        {
            return selectedAcc;
            ;
        }

        //Account information
        public string AccInfo(Account selectedAcc)
        {
            return selectedAcc.Id + " " + selectedAcc.Balance + " " + selectedAcc.Interest +
                "\n" + selectedAcc.Fee + ";";
        }

        //Create account
        public void CreateAccount(string accType, double openBalance, double intRate, double fees, double overdraft)
        {
            if (accType == "E") { accounts.Add(new Everyday(openBalance)); }
            else if (accType == "I") { accounts.Add(new Investment(openBalance, intRate, fees)); }
            else if (accType == "O") { accounts.Add(new Omni(openBalance, intRate, fees, overdraft)); }

            //accounts.Add(new Investment(openBalance, intRate, fees));
            //
        }

    }
}
