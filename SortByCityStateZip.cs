using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    internal class SortByCityStateZip
    {
        static List<Contacts> list = AddressbookMain.list;
        public static void SortOptions()
        {
            Console.WriteLine("---------Sort By City, State, Zip---------");
            Console.WriteLine();
            Console.WriteLine("Select option:--");
            Console.WriteLine("1. Search by City");
            Console.WriteLine("2. Search by State");
            Console.WriteLine("3. Search by Zip");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ByCity();
                    break;
                case 2:
                    ByState();
                    break;
                case 3:
                    ByZip();
                    break;
                default:
                    Console.WriteLine("Wrong Option..");
                    break;

            }
        }
        public static void ByCity()
        {
            Console.WriteLine("---------After sorting By City---------");
            Console.WriteLine();
            var sorted = list.OrderBy(x => x.City).ToList();
            foreach (var contact in sorted)
            {
                Console.WriteLine($"Nmae: {contact.Name.ToUpper()}\nAddress: {contact.Add}\nCity: {contact.City}\nState: {contact.State}\nZipCode: {contact.Zipcode}\nPhone: {contact.PhoneNum}\nEmail: {contact.Email}\n");
            }

        }
        public static void ByState()
        {
            Console.WriteLine("---------After sorting By State---------");
            Console.WriteLine();
            var sorted = list.OrderBy(x => x.State).ToList();
            foreach (var contact in sorted)
            {
                Console.WriteLine($"Nmae: {contact.Name.ToUpper()}\nAddress: {contact.Add}\nCity: {contact.City}\nState: {contact.State}\nZipCode: {contact.Zipcode}\nPhone: {contact.PhoneNum}\nEmail: {contact.Email}\n");
            }
        }
        public static void ByZip()
        {
            Console.WriteLine("---------After sorting By ZipCode---------");
            Console.WriteLine();
            var sorted = list.OrderBy(x => x.Zipcode).ToList();
            foreach (var contact in sorted)
            {
                Console.WriteLine($"Nmae: {contact.Name.ToUpper()}\nAddress: {contact.Add}\nCity: {contact.City}\nState: {contact.State}\nZipCode: {contact.Zipcode}\nPhone: {contact.PhoneNum}\nEmail: {contact.Email}\n");
            }
        }
    }
}
