using System;
using System.Collections.Generic;
using System.Text;

namespace PhoenbookApp
{
    public class Modifier
    {
        public Modifier() { }

        public void DeleteContact(PhoneBook _phoneBook)
        {
            Console.WriteLine("Skriv brukeren du vil fjerne");
            string response = Console.ReadLine();
            int previousSize = _phoneBook.GetContacts().Count;
            _phoneBook.RemoveContact(response);
            int currentSize = _phoneBook.GetContacts().Count;
            if (previousSize > currentSize)
            {
                Console.WriteLine("Fjernet bruker");
            }
        }

        public void AddContact(PhoneBook _phoneBook)
        {
            Console.WriteLine("Skriv inn navn");
            string response1 = Console.ReadLine();
            Console.WriteLine("Skriv inn tlf nummer");
            string response2  =Console.ReadLine();
            if (response2.Length != 8)
            {
                Console.WriteLine("Feil lengde på telefonnummer");
            }
            else {
                Contact c = new Contact(response1,response2);
                _phoneBook.AddContact(c);
                Console.WriteLine("Lagt til ny kontakt");
            }
        }
    }
}
