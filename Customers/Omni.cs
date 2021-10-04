using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    public class Omni : Account
    {   
        private double overdraft;

        //constructor with overdraft
        public Omni(double openBalance, double intRate, double Fees, double overdraftLimit) : base(openBalance, intRate, Fees)
        {
            accountType = "Omni";
            overdraft = overdraftLimit;
        }

        public override String Info()
        {
            information = AccountType + " " + Id + "; " + "Balance " + "$" + Math.Round((Double)Balance, 2) + ";" 
            + " Interest Rate " + interest + "%;  Fee $" + Fee + ";" + " " + "Overdraft Limit $" + overdraft + ";";
            return LastTransaction + "\n" + Information;
        }

        public override void Withdraw(double amount)
        {
            if ((balance - amount) < overdraft)
            {
                ApplyFee();

                //Omni account overides withdraw method to allow for overdraft
                throw new FailedWithdrawalException(AccountType + "; " + LastTransaction + " $" + Fee);             
            }
            else
            {
                balance = balance - amount;
                lastTransaction = "Withdrawal: $" + amount + "; ";
            }
        }

        public override double CalcInterest()
        {
            if (balance <= 1000)
            {
                lastTransaction = "Insufficient Funds (<$1000); ";
                return 0;
            }
            else
            {
                double percent = interest / 100;
                double interestAmount = ((Balance - 1000) * percent);
                return Math.Round((Double)interestAmount, 2);
            }    
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
