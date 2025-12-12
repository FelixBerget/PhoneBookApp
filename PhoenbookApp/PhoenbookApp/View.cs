using System;
using System.Collections.Generic;
using System.Text;

namespace PhoenbookApp
{
    public class View
    {
        PhoneBook _phonebook;
        public View(PhoneBook p) {
            _phonebook = p;
        }

        public void show()
        {
            while (true)
            {
                Console.WriteLine("Dette er phone book appen, her kan du finne kontakter");
                Console.WriteLine("Skriv (søk) for å søke, (list) for å få liste og (avslutt) for å stoppe appen");
                string response = Console.ReadLine();
                Console.Clear();
                if(response == "søk")
                {
                    findContact();
                }
                else if(response == "list")
                {
                    ListContacts();
                }
                else if( response == "avslutt")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Ugyldig input");
                }
            }
        }
        public void findContact()
        {
            Console.WriteLine("Skriv inn navn du vil søke på");
            string response = Console.ReadLine();
            Console.Clear();
            Contact c = _phonebook.Search(response);
            if(c == null)
            {
                c = _phonebook.SearchWihtNumber(response);
            }
            if(c == null)
            {
                Console.WriteLine("Ugyldig input");
                return;
            }
            Console.WriteLine("Navn : " + c.GetName());
            Console.WriteLine("Telefonummer : " + c.GetPhoneNumber());

        }

        public void ListContacts()
        {
            for(int i = 0; i < _phonebook.GetContacts().Count; i++)
            {
                Console.WriteLine("Navn : " + _phonebook.GetContacts()[i].GetName());
                Console.WriteLine("Telefonummer : " + _phonebook.GetContacts()[i].GetPhoneNumber());
            }
        }
    }
}
