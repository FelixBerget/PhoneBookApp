using System;
using System.Collections.Generic;
using System.Text;

namespace PhoenbookApp
{
    public class Contact
    {
        private string _name;
        private string _phoneNumber;
        public Contact(string name, string phoneNumber)
        {
            _name = name;
            _phoneNumber = phoneNumber;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }
    }
}
