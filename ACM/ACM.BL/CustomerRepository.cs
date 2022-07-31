using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //create the instance of the customer class
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            //code that retrieves the defined customer

            //Temporary hard coded values to return 
            //a Populated customer
            if(customerId == 1)
            {
                customer.EmailAddress = "tochind29@gmail.com";
                customer.FirstName = "Tochukwu";
                customer.LastName = "Ndefo";
            }
            return customer;
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        /// <summary>
        /// Save the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves the defined customer
            return true;
        }

       
    }
}

