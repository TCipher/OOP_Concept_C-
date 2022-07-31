using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Customer : EntityBase , ILoggable
    {
        public Customer()
            //constructor chaining, one constructor calling another constructor
            :this(0)
        {

        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public static int Instancecount { get; set; }
        //backing variable i.e a variable to store the value
        private string _lastName;
        public string LastName
        {
            get
            {
                //Any code before getting the value
                //like validation code
                return _lastName;
            }
            set
            {
                //Any code before seting the value like authorization
                _lastName = value;
            }
        }

        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public int MyProperty { get; set; }
        public int CustomerType { get; set; }
        // public Address WorkAddress { get; set; }
        // public Address HomeAddress { get; set; }
        public List<Address> AddressList { get; set; }


        public string FullName
        {
            get
            {
                string fullName = LastName;
                //if the firstname is not empty
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    //if the fullname i.e last name is not empty
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;

                }
                return fullName;

            }

        }
        public override bool  Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var logString = this.CustomerId + ": " +
                this.FullName + " " +
                "Email: " + this.EmailAddress + " " +
                "Status: " + this.EntityState.ToString();

            return logString;
        }
    }
}
