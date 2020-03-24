using System;
using System.Collections.Generic;
using System.Linq;

namespace TryCatch
{
    class Program
    {
        // Main
        static void Main(string[] args)
        {
            // Create a few contacts
            Contact bob = new Contact()
            {
                FirstName = "Bob", LastName = "Smith",
                Email = "bob.smith@email.com",
                Address = "100 Some Ln, Testville, TN 11111"
            };
            Contact sue = new Contact()
            {
                FirstName = "Sue", LastName = "Jones",
                Email = "sue.jones@email.com",
                Address = "322 Hard Way, Testville, TN 11111"
            };
            Contact juan = new Contact()
            {
                FirstName = "Juan", LastName = "Lopez",
                Email = "juan.lopez@email.com",
                Address = "888 Easy St, Testville, TN 11111"
            };

            // Create an AddressBook and add some contacts to it
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact(bob);
            addressBook.AddContact(sue);
            addressBook.AddContact(juan);

            // Try to addd a contact a second time
            try
            {
                addressBook.AddContact(sue);
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("User already exist!");
            }

            // Create a list of emails that match our Contacts
            List<string> emails = new List<string>()
            {
                "sue.jones@email.com",
                "juan.lopez@email.com",
                "bob.smith@email.com",
            };

            // Insert an email that does NOT match a Contact
            try
            {
                emails.Insert(1, "not.in.addressbook@email.com");
            }
            catch
            {
                Console.WriteLine("No contact with that email was found");

            }

            //  Search the AddressBook by email and print the information about each Contact
            foreach (string email in emails)
            {
                try
                {

                    Contact contact = addressBook.GetByEmail(email);
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"Name: {contact.FullName}");
                    Console.WriteLine($"Email: {contact.Email}");
                    Console.WriteLine($"Address: {contact.Address}");
                }
                catch
                {
                    Console.WriteLine($"{email} could not be found!");
                }
            }
        }
    }
}