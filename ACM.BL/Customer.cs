using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {


        public Customer()
        {

        }


        public Customer(int customerId) // as it has private setter
        {
            this.CustomerId=customerId;
        }


        private string  _lastName;
        public string LastName
        {   
            get => _lastName; 
            set => _lastName = value; 
        }

        public string  FirstName { get; set; }
        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }
        public static  int InstanceCount { get; set; } // accessed using classname | 1 instance shared with all if changed by 1 visible to all|

        public string FullName 
        {
            get
            {
                string fullName =LastName;

                if (!string.IsNullOrWhiteSpace(FirstName)) {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName+=" , ";
                    }
                    fullName+=FirstName;
                }
                return fullName;
            }
        }

        public bool Validate()
        {
            bool isValid;
            isValid= (string.IsNullOrWhiteSpace(LastName))|| (string.IsNullOrWhiteSpace(EmailAddress))?false:true;
            return isValid;
        }

        public List <Customer> Retrieve()
        {
           
            return new List<Customer>();
        }
        public Customer Retrieve(int CustomerId)
        {

            return new Customer();
        }



        public bool Save()
        {
            return true;
        }

         
    }
}






