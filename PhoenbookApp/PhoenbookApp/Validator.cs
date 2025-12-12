using System;
using System.Collections.Generic;
using System.Text;

namespace PhoenbookApp
{
    class Validator
    {
        public Validator() { }

        public void Validate(string response, Answerer _answerer, PhoneBook _phonebook) {
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
                return;
            }
            else
            {
                Console.WriteLine("Ugyldig input");
            }
        }
    }
}
