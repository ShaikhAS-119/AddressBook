using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AddressBook
{
    internal class SearchByCityOrState
    {
        static List<Contacts> list = AddressbookMain.list;
        
        public static void Search()
        {
            Console.WriteLine("---------Search By City/State---------");
            Console.WriteLine();
            Console.WriteLine("Select option:--");
            Console.WriteLine("1. Search by City");
            Console.WriteLine("2. Search by State");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: ByCity();
                        break;
                case 2: ByState();                    
                        break;
                default: Console.WriteLine("Wrong Option..");
                        break;

            }

        }
        public static void ByCity()
        {
            Console.WriteLine("Enter the City name : ");
            string CityName = Console.ReadLine();
            
            foreach (var  contact in list)
            {
                if(contact.City == CityName)
                {
                    Console.WriteLine();
                    Console.WriteLine("************************************");
                    Console.WriteLine($"Nmae: {contact.Name.ToUpper()}\nAddress: {contact.Add}\nCity: {contact.City}\nState: {contact.State}\nZipCode: {contact.Zipcode}\nPhone: {contact.PhoneNum}\nEmail: {contact.Email}\n");
                }
            }
            
        }
        public static void ByState()
        {
            Console.WriteLine("Enter the State name : ");
            string StateName = Console.ReadLine();
            foreach (var contact in list)
            {
                if (contact.State == StateName)
                {
                    Console.WriteLine();
                    Console.WriteLine("************************************");
                    Console.WriteLine($"Nmae: {contact.Name.ToUpper()}\nAddress: {contact.Add}\nCity: {contact.City}\nState: {contact.State}\nZipCode: {contact.Zipcode}\nPhone: {contact.PhoneNum}\nEmail: {contact.Email}\n");
                }
            }

        }
    }
}
