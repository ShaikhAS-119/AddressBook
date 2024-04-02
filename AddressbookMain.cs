using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;


namespace AddressBook
{
    internal class AddressbookMain
    {
        
        public static List<Contacts> list{ get; set; }
        public static void Addressbook()
        {
            AddressbookMain adbook = new AddressbookMain();
            list = new List<Contacts>();

            bool addMoreUsers = true;
            while (addMoreUsers)
            {
                Console.WriteLine("Enter the first_name: ");
                string first_name = Console.ReadLine();
                Console.WriteLine("Enter the last_name: ");
                string last_name = Console.ReadLine();

                string name = string.Concat(first_name + " ", last_name);                              
                                
                Console.WriteLine("Enter the Address: ");
                string add = Console.ReadLine();

                Console.WriteLine("Enter the City name: ");
                string city = Console.ReadLine();

                Console.WriteLine("Enter the State name: ");
                string state = Console.ReadLine();
           
                Console.WriteLine("Enter the 6 digit Zip Code: ");
                string zip_code = Console.ReadLine();
                
                Console.WriteLine("Enter the Phone number: ");                
                string Phone_num = Console.ReadLine();                

                Console.WriteLine("Enter email: ");
                string email = Console.ReadLine();               
        
                Contacts con = new Contacts(name, add, city, state, zip_code, Phone_num, email);
                list.Add(con);
                Console.WriteLine();
                Console.WriteLine("Contacts added Successfully :)");
                Console.WriteLine();
                
                Console.Write("Do you want to add another user? (yes/no): ");
                string response = Console.ReadLine();
                addMoreUsers = response.ToLower() == "yes";
            }

        }       
    }
}
