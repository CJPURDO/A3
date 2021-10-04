using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Customers
{
    //Abstract class can not be instantiated, only concrete subclasses can be instantiated
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

        //private Customer myCustomer;
        //public Customer MyCustomer
        //{
        //    get { return myCustomer; }
        //    set { myCustomer = value; }
        //}

        //private Customer myCustomer;

        //public Customer MyCustomer { get; set; }



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

        public void Transfer(Account from, Account to, double amount)
        {
            from.Withdraw(amount);
            to.Deposit(amount);
            
            lastTransaction = "Transfer: $" + amount + "; ";
        }

        //Apply transaction fee, virtual method can be overridden/specialised 
        protected virtual void ApplyFee()
        {
            balance = balance - fee;
            lastTransaction = "Transaction Failed, Fee Applied; ";
        }

        //Withdraw
        public virtual void Withdraw(double amount)
        {
            if (amount > balance)
            {
                ApplyFee();

                //if withdraw amount greater than balance throw exception, message appropriate to account type
                throw new FailedWithdrawalException(AccountType + "; " + LastTransaction + " $" + Fee);  
            }
            else
            {
                balance = balance - amount;
                lastTransaction = "Withdrawal: $" + amount + "; ";
            }          
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
}
