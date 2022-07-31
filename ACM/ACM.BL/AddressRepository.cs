using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            //create the instance of the Address class
            //Pass in the requested id
            Address address = new Address(addressId);
            //code that retrieves the defined address
            //temporary hard coded values to return
            //a populate address
            if(addressId == 1)
            {
                address.StreetLine1 = "Orile Igamu";
                address.StreetLine2 = "Alhaji Ajala";
                address.City = "Lagos";
                address.State = "Lagos State";
                address.Country = "Nigeria";
                address.PostalCode = "10001";
            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //code that retrieves the defined address
            //for the customer

            //Temporary hard coded values to return
            //a set of address for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AdressType = 1,
                StreetLine1 = "Alhaji Ajala",
                StreetLine2 = "Alhaji jimoh",
                City = "Lagos",
                State = "Lagos",
                Country = "Nigeria",
                PostalCode = "10001"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AdressType = 2,
                StreetLine1 = "Ajala",
                StreetLine2 = "Alhaji",
                City = "Lagos",
                State = "Lagos",
                Country = "Nigeria",
                PostalCode = "10001"
            };
            addressList.Add(address);
            return addressList;
        }
        public bool Save(Address address)
        {
            //code that Saves the defined address
            return true;
        }
      
    }
}
