using System;
using System.Collections.Generic;

namespace AddressBookUsingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book \n");

            ManageData manageData = new ManageData();

            ////UC2:create address book
            //manageData.CreateAddressBook();

            ////UC3:Insert row
            //manageData.InsertRowIntoTable();

            ////UC4: Edit Data
            manageData.CreateAddressBook();
            manageData.EditExistingContact();



        }
    }
}
