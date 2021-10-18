using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    
    public class Controller
    {
        //Static list of customers for program-wide storage
        public static List<Customer> customers = new List<Customer>();

        public static Customer selectedCust;



        //Singleton instance of controller type
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

            double minusOverdraft = overdraft - (overdraft * 2);

            if (accType == "E") { c.myAccounts.Add(new Everyday(openBalance, intRate, fees)); }
            else if (accType == "I") { c.myAccounts.Add(new Investment(openBalance, intRate, fees)); }
            else if (accType == "O") { c.myAccounts.Add(new Omni(openBalance, intRate, fees, minusOverdraft)); }
        }



        public List<Account> GetAccountsList()
        {
            return selectedCust.myAccounts;
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
        public void AccTransfer(Account from, Account to, double amount, double charge)
        {
            from.Withdraw(amount, charge);
            to.Deposit(amount);
        }

        //Withdraw
        public void AccWithdraw(Account selectedAcc, double amount, double charge)
        {
            selectedAcc.Withdraw(amount, charge);
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
        public void SetCustomer(Customer c)
        {
            selectedCust = c;
        }

        //Return selected customer
        public Customer GetCustomer()
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







        // controls for saving data 

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
                Controller.customers = (List<Customer>)formatter.Deserialize(stream);
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


        // write the nextID attribute to file by saving the instance of singletondata
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
        /// Save all data - used upon closing the app
        /// </summary>
        public void Save()
        {
            WriteBinaryData();
            WriteID();
        }
    }
}
