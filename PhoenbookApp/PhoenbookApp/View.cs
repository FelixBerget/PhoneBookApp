using System;
using System.Collections.Generic;
using System.Text;

namespace PhoenbookApp
{
    public class View
    {
        PhoneBook _phonebook;
        Answerer _answererer;
        public View(PhoneBook p) {
            _phonebook = p;
            _answererer = new Answerer();
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
                    _answererer.findContact(_phonebook);
                }
                else if(response == "list")
                {
                    _answererer.ListContacts(_phonebook);
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
    }
}
