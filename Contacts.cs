using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    internal class Contacts
    {

        public string Add { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string Zipcode { get; set; }

        public string PhoneNum { get; set; }

        public string Email { get; set; }
        //public string PhoneNumber { get; set; }
        public string Name { get; set; }

        public Contacts()
        {

        }
        public Contacts(string name, string add, string city, string state, string code, string phone, string mail)
        {
            this.Name = name;
            this.City = city;
            this.State = state;
            this.PhoneNum = phone;
            this.Email = mail;
            this.Zipcode = code;
            this.Add = add;

        }
    }
}