using System;
using System.Collections.Generic;
using System.Text;

namespace PhoenbookApp
{
    public class Answerer
    {

        public Answerer() { }

        public void findContact(PhoneBook _phonebook)
        {
            Console.WriteLine("Skriv inn navn du vil søke på");
            string response = Console.ReadLine();
            Console.Clear();
            Contact c = _phonebook.Search(response);
            if (c == null)
            {
                c = _phonebook.SearchWithNumber(response);
            }
            if (c == null)
            {
                Console.WriteLine("Ugyldig input");
                return;
            }
            Console.WriteLine("Navn : " + c.GetName());
            Console.WriteLine("Telefonummer : " + c.GetPhoneNumber());

        }

        public void ListContacts(PhoneBook _phonebook)
        {
            for (int i = 0; i < _phonebook.GetContacts().Count; i++)
            {
                Console.WriteLine("Navn : " + _phonebook.GetContacts()[i].GetName());
                Console.WriteLine("Telefonummer : " + _phonebook.GetContacts()[i].GetPhoneNumber());
            }
        }
    }
}
