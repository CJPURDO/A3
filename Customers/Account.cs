using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Customers
{
    //Abstract class can not be instantiated, only concrete subclasses can be instantiated
    [Serializable]
    public abstract class Account
    {
        protected static int nextID = 1;
        protected int id;
        protected string accountType;
        protected double balance;
        protected String information;
        protected String lastTransaction;
        protected double fee;
        protected double interest;


        //get and set property accessors
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public double Interest
        {
            get { return interest; }
            set { interest = value; }
        }
        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }
        public string Information
        {
            get { return information; }
            set { information = value; }
        }
        public string LastTransaction
        {
            get { return lastTransaction; }
            set { lastTransaction = value; }
        }

        public string IdTypeBalance
        {
            get
            {
                return string.Format("{0} {1} ${2}", Id, AccountType, Balance);
            }
        }


        //overloading constructors hierarchy
        public Account()
        {
            id = nextID;
            nextID++;
        }
        public Account(double openBalance) : this()
        {
            balance = openBalance;
        }
        public Account(double openBalance, double intRate) : this(openBalance)
        {
            interest = intRate;
        }
        public Account(double openBalance, double intRate, double fees) : this(openBalance, intRate)
        {
            fee = fees;
        }


        //Methods
        //Account info, abstract method, all derived classes must provide implementation
        public abstract String Info();

        //Deposit method
        public void Deposit(double amount)
        {
            balance = balance + amount;
            lastTransaction = "Deposited: $" + amount + "; ";
        }


        //Withdraw
        public virtual void Withdraw(double amount, double charge)
        {
            if (amount > balance)
            {
                ApplyFee(charge);

                //if withdraw amount greater than balance throw exception, message appropriate to account type
                throw new FailedWithdrawalException(AccountType + "; " + LastTransaction + " $" + Fee);
            }
            else
            {
                balance = balance - amount;
                lastTransaction = "Withdrawal: $" + amount + "; ";
            }
        }

        //Apply transaction fee, virtual method can be overridden/specialised 
        protected virtual void ApplyFee(double charge)
        {
            balance = balance - (fee * charge);
            lastTransaction = "Transaction Failed, Fee Applied; ";
        }

        

        //Calculate interest
        public  virtual double CalcInterest()
        {
            double percent = interest / 100;
            double interestAmount =  Balance * percent;
            return Math.Round((Double)interestAmount, 2);
        }

        //Add interest
        public virtual void AddInterest()
        {
            lastTransaction = "Interest Added: $" + CalcInterest() + "; ";
            balance = balance + CalcInterest();  
        }
    }

    [Serializable]
    public class Everyday : Account
    {
        //Constructor set type
        public Everyday(double openBalance, double intRate, double fees) : base(openBalance, intRate, fees)
        {
            accountType = "Everyday";
        }

        public override String Info()
        {
            information = AccountType + " " + Id + "; " + "Balance " + "$" + Math.Round((Double)Balance, 2) + ";";
            return LastTransaction + "\n" + Information;
        }

        protected override void ApplyFee(double charge)
        {
            lastTransaction = "Insufficient Funds, No Fee; ";
        }

        public override void AddInterest()
        {
            lastTransaction = "No Interest on this Account; ";
        }

    }

    [Serializable]
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

        protected override void ApplyFee(double charge)
        {
            balance = balance - (fee * charge);
            lastTransaction = "Transaction Failed, Fee Applied; ";



        }

        public override void AddInterest()
        {
            lastTransaction = "Interest Added: $" + CalcInterest() + "; ";
            balance = balance + CalcInterest();
        }
    }



    [Serializable]
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

        public override void Withdraw(double amount, double charge)
        {
            if ((balance - amount) < overdraft)
            {
                ApplyFee(charge);

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

        protected override void ApplyFee(double charge)
        {
            balance = balance - (fee * charge);
            lastTransaction = "Transaction Failed, Fee Applied; ";
        }

        public override void AddInterest()
        {
            lastTransaction = "Interest Added: $" + CalcInterest() + "; ";
            balance = balance + CalcInterest();
        }
    }


}
