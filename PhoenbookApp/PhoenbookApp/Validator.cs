using System;
using System.Collections.Generic;
using System.Text;

namespace PhoenbookApp
{
    class Validator
    {
        public Validator() { }

        public bool Validate(string response, Answerer _answerer, PhoneBook _phonebook, Modifier _modifier) {
            if (response == "søk")
            {
                _answerer.findContact(_phonebook);
            }
            else if (response == "list")
            {
                _answerer.ListContacts(_phonebook);
            }
            else if (response == "avslutt")
            {
                return false;
            }
            else if(response == "legg til")
            {
                _modifier.AddContact(_phonebook);
            }
            else if(response == "fjern")
            {
                _modifier.DeleteContact(_phonebook);
            }
            else
            {
                Console.WriteLine("Ugyldig input");
            }
            return true;
        }
    }
}
