using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        //Fields
        private DateTime birthDate;
        //Properties
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public int Age { get; }
        public string Name { get { return FirstName + " " + LastName; } }

        public List<string> PhoneNumbers { get; } = new List<string>();
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (!(value.Year >= DateTime.Now.Year || value.Year <= DateTime.Now.Year - 120))
                {
                    birthDate = value;
                }
                else
                {
                    throw new ArgumentException("Age not accepted");
                }
            }
        }

        //Constructor
        public Customer(int customerid, string firstname, string lastname, string address, string zip, string city)
        {
            CustomerId = customerid;
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            Zip = zip;
            City = city;
        }
        //Methods
        public void AddPhoneNumber(string phone)
        {
            PhoneNumbers.Add(phone);
        }  
        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }
    }
}
