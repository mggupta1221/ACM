using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        public Address(string addressid)
        {
            Addressid = addressid;
        }
        public Address()
        {

        }
        public string Addressid { get; private set; }
        public string StreetLine1 { get; set; }
        public string? StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string AddressType { get; set; }
        public bool Validate()
        {
            bool isValid = string.IsNullOrWhiteSpace(PostalCode) ? false : true;
            return isValid;
        }
    }
}
