using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    internal class CountByCityOrState
    {
        static List<Contacts> list = AddressbookMain.list;
        public static void Count()
        {
            Console.WriteLine("---------Count By City/State---------");
            Console.WriteLine();
            Console.WriteLine("Select option:--");
            Console.WriteLine("1. Count by City");
            Console.WriteLine("2. Count by State");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ByCity();
                    break;
                case 2:
                    ByState();
                    break;
                default:
                    Console.WriteLine("Wrong Option..");
                    break;

            }

        }
        public static void ByCity()
        {
            Console.WriteLine("Enter the City name : ");
            string CityName = Console.ReadLine();

            int count = 0;

            foreach (var contact in list)
            {
                if (contact.City == CityName)
                {
                    count++;
                }
            }

            Console.WriteLine("City count is "+count);

        }
        public static void ByState()
        {
            Console.WriteLine("Enter the State name : ");
            string StateName = Console.ReadLine();
            int count = 0;
            foreach (var contact in list)
            {
                if (contact.State == StateName)
                {
                    count++;
                }
            }

            Console.WriteLine("State count is " + count);

        }

    }
}

    

