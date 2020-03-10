using System;
using System.Collections.Generic;
using System.Linq;

namespace TryCatch
{
  public class AddressBook
  {
    public Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();
    public void AddContact(Contact contact)
    {
      contacts.Add(contact.Email, contact);
    }
    public Contact GetByEmail(string email)
    {
      var contact = contacts.FirstOrDefault(contact => contact.Key == email);
      return contact.Value;
    }
  }
}