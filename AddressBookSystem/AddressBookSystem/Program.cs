using System;
using System.Collections;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Welcome to Address Book\n");
            UC1_CreateContact uc1 = new UC1_CreateContact();
            uc1.CreateContact();

            Console.WriteLine("UC2 starting");
            UC2_AddNewContacts uc2 = new UC2_AddNewContacts();
            uc2.AddNewContacts();

            Console.WriteLine("UC3 starting");
            UC3_UpdateExistingContact uc3 = new UC3_UpdateExistingContact();    
            uc3.UpdateContact();

            Console.WriteLine("UC4 starting");
            UC4_DeleteContact uc4 = new UC4_DeleteContact();
            uc4.ContactDelete();

            Console.ReadKey();


        }
    }
}