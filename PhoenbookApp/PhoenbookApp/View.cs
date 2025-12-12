using System;
using System.Collections.Generic;
using System.Text;

namespace PhoenbookApp
{
    public class View
    {
        PhoneBook _phonebook;
        Answerer _answerer;
        Validator _validator;
        public View(PhoneBook p) {
            _phonebook = p;
            _answerer = new Answerer();
            _validator = new Validator();
        }

        public void show()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Dette er phone book appen, her kan du finne kontakter");
                Console.WriteLine("Skriv (søk) for å søke, (list) for å få liste og (avslutt) for å stoppe appen");
                string response = Console.ReadLine();
                Console.Clear();
                running = _validator.Validate(response, _answerer, _phonebook);

            }
        }
    }
}
