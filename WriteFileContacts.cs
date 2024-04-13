using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook
{
    internal class WriteFileContacts
    {
        static List<Contacts> list = AddressbookMain.list;
        public static void Write()
        {
            FileStream fileWrite = new FileStream(@"C:\Users\shaik\OneDrive\Desktop\VBPro\AddressBook\AddressBook.txt", FileMode.OpenOrCreate);
            StreamWriter s = new StreamWriter(fileWrite);

            foreach (Contacts item in list)
            {
                s.WriteLine($"Nmae: {item.Name.ToUpper()}\nAddress: {item.Add}\nCity: {item.City}\nState: {item.State}\nZipCode: {item.Zipcode}\nPhone: {item.PhoneNum}\nEmail: {item.Email}\n");
            }
            Console.WriteLine("created!!");

            s.Close();
            fileWrite.Close();
        }
    }
}
