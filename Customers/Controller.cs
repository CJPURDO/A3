using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    public class Controller
    {
        //Static list of customers for program-wide storage
        public static List<Customer> customers = new List<Customer>();
        public static Customer selectedCust;

        //Set selected customer
        public void SetSelected(Customer cust)
        {
            selectedCust = cust;
        }

        //Return selected customer
        public Customer GetSelected()
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

    }
}
