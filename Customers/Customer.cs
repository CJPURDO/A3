using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    public class Customer
    {   
        //Class variables
        private int iD;
        private static int nextID = 1;
        private string firstName;
        private string lastName;
        private string phone;
        private double charge;

        //get and set property accessors 
        public int ID { get => iD; set => iD = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public double Charge { get => charge; set => charge = value; }

        public string IdFullName
        {
            get
            {
                return string.Format("{0} {1} {2}", ID, FirstName, LastName);
            }
        }

        public string ChargePercent
        {
            get
            {
                return (Charge * 100).ToString() + "%";
            }
        }




        //Constructors 
        public Customer()
        {
            ID = nextID;
            nextID++;
        }

        public Customer(string newFirstName, string newLastName, string newPhone, double newCharge) : this()
        {
            FirstName = newFirstName;
            LastName = newLastName;
            Phone = newPhone;
            Charge = newCharge;
        }
    }

}

