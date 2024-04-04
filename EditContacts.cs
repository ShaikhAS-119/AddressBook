using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;
using System.Xml.Linq;

namespace AddressBook
{
    internal class EditContacts
    {
        //Universal variable
        static List<Contacts> list = AddressbookMain.list;
        public string name;
        Contacts contact;

        //Constructor
        /*public EditContacts(Contacts con)
        {
            this.contact = con;
        }*/

        public void Edit()
        {

            Console.WriteLine("************************************");
            Console.WriteLine("EDIT THE CONTACTS:-");
            Console.WriteLine();

         
            Console.WriteLine("Enter the full name : ");
            name = Console.ReadLine().ToUpper();

           

            try
            {

                foreach (var items in list)
                {
                    string objname = items.Name.ToString().ToUpper();

                    if (objname == name)
                    {

                        Console.WriteLine($"{name} found!!");
                        int data;
                        do
                        {


                            Console.WriteLine("choose what to edit: \n1. Edit Name\n2. Edit Phonenumber" +
                                      "\n3. Edit Email\n4. Edit Zip_code\n5. Edit State\n6. Edit City" +
                                      "\n7.Edit Address \n8.Back to Main Menu");
                            data = Convert.ToInt32(Console.ReadLine());



                            switch (data)
                            {
                                case 1:
                                    Console.WriteLine("Enter name to edit: ");
                                    items.Name = Console.ReadLine();

                                    break;
                                case 2:
                                    Console.WriteLine("Enter the PhoneNumber to edit: ");
                                    items.PhoneNum = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter Email to edit: ");
                                    items.Email = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter Zip Code to edit: ");
                                    items.Zipcode = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter State to edit: ");
                                    items.State = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter City to edit: ");
                                    items.City = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter Address to edit: ");
                                    items.Add = Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Wrong option:");
                                    break;
                            }
                        } while(data != 8);

                        
                        break;

                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            
            PrintAddBook.Print();
            
                }

            } }
        

     


    

    


