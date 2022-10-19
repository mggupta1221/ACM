using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public List<Customer> Retrieve()
        {

            return new List<Customer>();
        }
        public Customer Retrieve(int customerId)
        {
            //creating instance of Customer class
            //passing requested id
            Customer customer = new Customer(customerId);

            //code to retreive customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }



        public bool Save()
        {
            return true;
        }




    }
}
