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
            manageData.CreateAddressBook();



        }
    }
}
