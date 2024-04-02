using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    internal class DeleteContacts
    {
        public static void delete()
        {
            List<Contacts> list = AddressbookMain.list;
            Contacts contacts = new Contacts();

            Console.WriteLine("************************************");
            Console.WriteLine("DELETE THE CONTACTS:-");
            Console.WriteLine();
            Console.WriteLine("Enter the full name : ");
            string name = Console.ReadLine().ToUpper();

            try
            {

                foreach (var items in list)
                {
                    string value = items.Name.ToString().ToUpper();
                    if (value == name)
                    {
                        list.Remove(items);
                        Console.WriteLine("----------After removing---------");
                        PrintAddBook.print();
                    }
                    else
                    {
                        Console.WriteLine($"{name} not found!!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
 
            }
        }
    }
}
