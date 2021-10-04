using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{

    public class Investment : Account
    {

        public Investment(double openBalance, double intRate, double fees) : base(openBalance, intRate, fees)
        {
            accountType = "Investment";
        }

        public override String Info()
        {
            information = AccountType + " " + Id + "; " + "Balance " + "$" + Math.Round((Double)Balance, 2) + ";" 
            + " Interest Rate " + interest + "%;  Fee $" + Fee + ";";
            return LastTransaction + "\n" + Information;
        }

        protected override void ApplyFee()
        {
            balance = balance - fee;
            lastTransaction = "Transaction Failed, Fee Applied; ";



        }

        public override void AddInterest()
        {
            lastTransaction = "Interest Added: $" + CalcInterest() + "; ";
            balance = balance + CalcInterest();
        }
    }
}
