using System;
using System.Collections.Generic;

namespace AddressBookUsingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book \n");

            ////List to store values
            List<AddressBookData> addressBookDatas = new List<AddressBookData>();
            {
                new AddressBookData() { FirstName = "Tejaswi", LastName = "Shah", Address = "20 carry Road", City = "Howrah", State = "West Bengal", Zip = "711104", PhoneNumber = "9163572895", Email = "tejaswi@gmail.com" };
                new AddressBookData() { FirstName = "Girish", LastName = "Nayak", Address = "Lokpuram Society", City = "Thane", State = "Maharashtra", Zip = "400610", PhoneNumber = "9163121771", Email = "girish@gmail.com" };
              
            }



        }
    }
}
