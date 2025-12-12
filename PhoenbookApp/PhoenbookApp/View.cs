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
        Modifier _modifier;
        public View(PhoneBook p) {
            _phonebook = p;
            _answerer = new Answerer();
            _validator = new Validator();
            _modifier = new Modifier();
        }

        public void show()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Dette er phone book appen, her kan du finne kontakter");
                Console.WriteLine("Skriv (søk) for å søke, (list) for å få liste og (avslutt) for å stoppe appen");
                Console.WriteLine("Du kan også skrive (legg til) for å legge til ny bruker, og (fjern) for å fjerne en bruker");
                string response = Console.ReadLine();
                Console.Clear();
                running = _validator.Validate(response, _answerer, _phonebook,_modifier);

            }
        }
    }
}
