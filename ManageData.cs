using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AddressBookUsingLINQ
{
    class ManageData
    {
        /// <summary>
        /// Data table to store address book details
        /// </summary>
        public DataTable dataTable = new DataTable();

        /// <summary>
        /// Create an Address Book with following parameters:
        /// </summary>
        public void CreateAddressBook()
        {
            ////Declaring Columns:
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("EmailID", typeof(string));

            ////Declaring Rows:
            dataTable.Rows.Add("Tejaswi", "Shah", "Howrah", "Shibpur", "West Bengal", 711104, "9163572895", "tejaswi@gmail.com");
            dataTable.Rows.Add("Girish", "Nayak", "Durgapur", "A zone", "West Bengal", 713209, "897654326", "girish@gmail.com");
            dataTable.Rows.Add("Tanmay", "Agarwal", "Kolkata", "NewTown", "West Bengal", 711034, "916345678", "tanmay@gmail.com");
            dataTable.Rows.Add("Harsh", "Nath", "Patna", "Patna City", "Bihar", 600807, "9163121771", "nath@gmail.com");
            DisplayData();
        }

        /// <summary>
        /// Display Data
        /// </summary>
        public void DisplayData()
        {
            try
            {
                var recordedData = from data in dataTable.AsEnumerable() select data;
                foreach (var list in recordedData)
                {
                    Console.WriteLine("First Name: " + list.Field<string>("FirstName") +" "+ "Last Name: " + list.Field<string>("LastName") + " " +
                        "Address " + list.Field<string>("Address") + " " + "City : " + list.Field<string>("City") + " " + "State: " + list.Field<string>("State") + " " + "Zip : " + list.Field<int>("Zip")
                       +" " + "Phone Number " + list.Field<string>("PhoneNumber") + " " + "Email: " + list.Field<string>("EmailID"));

                }
            }
            ////Catch Exception If any
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

    

    

