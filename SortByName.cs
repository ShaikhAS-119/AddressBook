using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace AddressBook
{
    internal class SortByName
    {
        static List<Contacts> list = AddressbookMain.list;
        public static void SortName()
        {
            Console.WriteLine("---------After sorting By Name---------");
            Console.WriteLine();
            var sorted = list.OrderBy(x => x.Name).ToList();
            foreach (var contact in sorted)
            {                
                Console.WriteLine($"Nmae: {contact.Name.ToUpper()}\nAddress: {contact.Add}\nCity: {contact.City}\nState: {contact.State}\nZipCode: {contact.Zipcode}\nPhone: {contact.PhoneNum}\nEmail: {contact.Email}\n");
            }
           
        }
    }
}
