using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{    
    public class Everyday : Account
    {
        //Constructor set type
        public Everyday(double openBalance) : base(openBalance)
        {
            accountType = "Everyday";
        }

        public override String Info()
        {
            information = AccountType + " " + Id + "; " + "Balance " + "$" + Math.Round((Double)Balance, 2) + ";";
            return LastTransaction + "\n" + Information;
        }

        protected override void ApplyFee()
        {
            lastTransaction = "Insufficient Funds, No Fee; ";
        }

        public override void AddInterest()
        {
            lastTransaction = "No Interest on this Account; ";
        }

    }
}

