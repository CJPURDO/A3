using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    //Controller element of the MVC design pattern application
    //Responds to user inputs and interacts with Customer Account data model objects

    /// <summary>
    /// Povides functionality between the user-facing interfaces and the 
    /// object and serialization classes of the application
    /// Provides methods for access to the Accounts and Customer classes instances
    /// CRUD object functionality and persists storage application
    /// </summary>
    [Serializable]
    public class Controller
    {
        //Static list of customers for program-wide storage
        public static List<Customer> customers = new List<Customer>();

        //Static customer variable across program
        public static Customer c;



        //Singleton pattern restricts class instantiation to 'single' one
        /// <summary>
        /// This is a singleton pattern return for an instance of the controller class
        /// </summary>
        /// <returns>Instance of controller</returns>
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
        /// <summary>
        /// Adds an account to a customers account list
        /// </summary>
        /// <param name="c">Customer</param>
        /// <param name="accType">Type of Account</param>
        /// <param name="openBalance">Opening Balance of account</param>
        /// <param name="intRate">Interest rate</param>
        /// <param name="fees">Fee Amount for account</param>
        /// <param name="overdraft">Overdraft limit for account</param>
        public void CreateAccount(Customer c, string accType, double openBalance, double intRate, double fees, double overdraft)
        {
            double minusOverdraft = overdraft - (overdraft * 2);
            if (accType == "E") { c.myAccounts.Add(new Everyday(openBalance, intRate, fees)); }
            else if (accType == "I") { c.myAccounts.Add(new Investment(openBalance, intRate, fees)); }
            else if (accType == "O") { c.myAccounts.Add(new Omni(openBalance, intRate, fees, minusOverdraft)); }
        }

        //Retrieve customer's list of accounts
        /// <summary>
        /// Retrieve the Accounts of the selected customer
        /// </summary>
        /// <returns>The Account list of the selected customer</returns>
        public List<Account> GetAccountsList()
        {
            return c.myAccounts;
        }


        //Account information
        /// <summary>
        /// Returns information of account
        /// </summary>
        /// <param name="a">The account</param>
        public string AccInfo(Account a)
        {
            return a.Info();
        }

        //Account Balance
        /// <summary>
        /// Returns account balance
        /// </summary>
        /// <param name="a">The account</param>
        public string AccBal(Account a)
        {
            return "Balance $" + a.Balance + " ;";
        }

        //Deposit
        /// <summary>
        /// Deposits an amount into a customers account
        /// </summary>
        /// <param name="a">The account</param>
        /// <param name="amount">Amount to be deposited</param> 
        public void AccDeposit(Account a, double amount)
        {
            a.Deposit(amount);
        }

        //Transfer between accounts
        /// <summary>
        /// Transfers from one account to another
        /// </summary>
        /// <param name="from">The account to transfer from</param>
        /// <param name="to">The account to transfer to</param>
        /// <param name="amount">The amount to transfer</param>
        /// <param name="charge">The charge rate of the customer</param>
        public void AccTransfer(Account from, Account to, double amount, double charge)
        {
            from.Withdraw(amount, charge);
            to.Deposit(amount);
        }

        //Withdraw
        /// <summary>
        /// Withdraw from an account. Will apply a fee if the funds are insufficient
        /// </summary>
        /// <param name="a">The account</param>
        /// <param name="amount">Amount to withdraw</param>
        /// <param name="charge">The charge rate ofthe customer type</param>
        ///<exception cref="FailedWithdrawalException">Thrown if funds are less than amount withdrawn, or if overdraft is exceeded</exception>
        public void AccWithdraw(Account a, double amount, double charge)
        {
            a.Withdraw(amount, charge);
        }

        //Calculate Interest
        /// <summary>
        /// Calculates interest of account based on its interest rate
        /// </summary>
        /// <param name="a">The account</param>
        public void AccCalcInt(Account a)
        {
            a.CalcInterest();
        }

        //Add Interest
        /// <summary>
        /// Adds calculated interest to account
        /// </summary>
        /// <param name="a">The account</param>
        public void AccAddInt(Account a)
        {
            a.AddInterest();
        }



        //Delete account
        /// <summary>
        /// Deletes an Account
        /// </summary>
        /// <param name="a">The account to delete</param>
        public void DeleteAccount(Account a)
        {
            c.myAccounts.Remove(a);
        }



        //Search account by ID number
        /// <summary>
        /// Search for account ID
        /// </summary>
        /// <param name="accID">The account ID number to search</param>
        /// <returns>An account if found, null if not</returns>
        public Account SearchAccount(int accID)
        {
            foreach (Account a in c.myAccounts)
            {
                if (a.Id == accID)
                {
                    return a;
                }
            }
            return null;
        }





        //Set selected customer
        /// <summary>
        /// Sets the static variable for selected customer c
        /// </summary>
        /// <param name="cust">Selected customer</param>
        public void SetCustomer(Customer cust)
        {
            c = cust;
        }

        //Return selected customer
        /// <summary>
        /// Returns the currently selectedcustomer
        /// </summary>
        /// <returns>Selected customer</returns>
        public Customer GetCustomer()
        {
            return c;
        }

        //Customer information
        /// <summary>
        /// Returns customer information
        /// </summary>
        /// <returns>Selected customer information</returns>
        public string CustInfo(Customer c)
        {
            return c.ID + " " + c.FirstName + " " + c.LastName +
                "\n" + c.Phone +
                "\n" + c.ChargePercent + ";";
        }

        //Create customer
        /// <summary>
        /// This method creates a customer object
        /// </summary>
        /// <param name="firstna">Customer First Name</param>
        /// <param name="lastna">Customer Last Name</param>
        /// <param name="phone">Customer Phone number</param>
        /// <param name="charge">Customer charge rate - staff 0.5, customer 1.0</param>
        public void CreateCustomer(string firstna, string lastna, string phone, double charge)
        {
            customers.Add(new Customer(firstna, lastna, phone, charge));
        }

        //Update customer
        /// <summary>
        /// Enables the editing of customer attributes
        /// </summary>
        /// <param name="c">Customer to be updated</param>     
        /// <param name="firstna">Customer First Name</param>
        /// <param name="lastna">Customer Last Name</param>
        /// <param name="phone">Customer contact number</param>
        /// <param name="charge">Customer charge rate</param>
        public void UpdateCustomer(Customer c, string firstna, string lastna, string phone, double charge)
        {
            foreach (Customer cust in customers)
            {
                if (c == cust)
                {
                    c.FirstName = firstna;
                    c.LastName = lastna;
                    c.Phone = phone;
                    c.Charge = charge;
                }
            }
        }

        //Delete customer
        /// <summary>
        /// Deletes a customer
        /// </summary>
        /// <param name="c">The customer to delete</param>
        public void DeleteCustomer(Customer c)
        {
            customers.Remove(c);
        }

        //Search customer by ID
        /// <summary>
        /// Finds a customer based upon thier ID number
        /// </summary>
        /// <param name="custID">Customer Number</param>
        /// <returns></returns>
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


        //public Customer FindPublicationByTitle(int id)
        //{
        //    foreach (Customer c in customers)
        //    {
        //        if (c.ID == id) { return c; }
        //    }
        //    return null;  //we will look at unhappy paths in the next unit. 
        //}






        // Controls for saving data 

        /// <summary>
        /// Saves Customer Data to file
        /// </summary>
        public void WriteBinaryData()
        {
            //create a formatting object
            IFormatter formatter = new BinaryFormatter();

            //Create a new IO stream to write to the file Objects.bin
            Stream stream = new FileStream("objects.bin", FileMode.Create,
            FileAccess.Write, FileShare.None);

            //use the formatter to serialize the collection and send it to the filestream
            formatter.Serialize(stream, customers);

            //close the file
            stream.Close();

        }

        /// <summary>
        /// Reads customer data from file, or closes if the file is empty to prevent exception
        /// </summary>
        public void ReadBinaryData()
        {

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Objects.bin", FileMode.Open, FileAccess.Read,
            FileShare.Read);

            // if the file is empty, do nothing
            if (new FileInfo("Objects.bin").Length == 0)
            {
                stream.Close();
            }

            //if the file has data, read it
            else
            {
                customers = (List<Customer>)formatter.Deserialize(stream);
                stream.Close();

            }
        }


        //Get the saved value of nextID if there is one
        /// <summary>
        /// Get the stored nextID value from file
        /// </summary>
        public void setIDinstance()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Data.bin", FileMode.Open, FileAccess.Read,
            FileShare.Read);

            SingletonData.setInstance((SingletonData)formatter.Deserialize(stream));
            stream.Close();

        }


        // Write the nextID attribute to file by saving the instance of singletondata
        /// <summary>
        /// Save the nextID value tofile
        /// </summary>
        public void WriteID()
        {
            //create a formatting object
            IFormatter formatter = new BinaryFormatter();

            //Create a new IO stream to write to the file Objects.bin
            Stream stream = new FileStream("Data.bin", FileMode.Create,
            FileAccess.Write, FileShare.None);

            //use the formatter to serialize the collection and send it to the filestream
            formatter.Serialize(stream, SingletonData.getInstance());

            //close the file
            stream.Close();
        }

        /// <summary>
        /// Save data
        /// </summary>
        public void Save()
        {
            WriteBinaryData();
            WriteID();
        }
    }
}
