using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;


namespace AddressBook
{
    internal class AddressbookMain
    {

        public static List<Contacts> list;
        static Dictionary<string, Contacts> dic;

        public static void Addressbook()
        {

            list = new List<Contacts>();
            dic = new Dictionary<string, Contacts>();

            bool addMoreUsers = true;
            while (addMoreUsers)
            {
                Renamed:
                Console.WriteLine("Enter the first_name: ");
                string first_name = Console.ReadLine();

                Console.WriteLine("Enter the last_name: ");
                string last_name = Console.ReadLine();

                string name = string.Concat(first_name + " ", last_name);
                //verify name ussing dictionary

                foreach (KeyValuePair<string, Contacts> keyValuePair in dic)
                {
                    if(keyValuePair.Key.Equals(name))
                    {
                        Console.WriteLine("User is already exist....");
                        Console.WriteLine("please enter new user name: ");
                        goto Renamed;
                    }
                }
               
                Console.WriteLine("Enter the Address: ");
                string add = Console.ReadLine();

                Console.WriteLine("Enter the City name: ");
                string city = Console.ReadLine();

                Console.WriteLine("Enter the State name: ");
                string state = Console.ReadLine();

            reZip:
                Console.WriteLine("Enter the 6 digit Zip Code: ");
                string zip_code = Console.ReadLine();                

                Console.WriteLine("Enter the Phone number: ");
                string Phone_num = Console.ReadLine();            

                Console.WriteLine("Enter email: ");
                string email = Console.ReadLine();

                Contacts con = new Contacts(name, add, city, state, zip_code, Phone_num, email);
                //adding in dictionary               
                dic.Add(name, con);
                //adding in list
                list.Add(con);                

                Console.Write("Do you want to add another user? (yes/no): ");
                string response = Console.ReadLine();
                addMoreUsers = response.ToLower() == "yes";

            }

        }

    }
}
