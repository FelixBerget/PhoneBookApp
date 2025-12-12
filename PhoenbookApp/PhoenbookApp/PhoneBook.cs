using System;
using System.Collections.Generic;
using System.Text;

namespace PhoenbookApp
{
    public class PhoneBook
    {
        private List<Contact> _contacts;

        public PhoneBook()
        {
            _contacts = new List<Contact>();
        }

        public List<Contact> GetContacts (){
            return _contacts; 
        }
        public Contact Search(string name)
        {
            name = name.ToLower();
            return _contacts.Find(x => x.GetName().ToLower().Contains(name));

        }
        public Contact SearchWithNumber(string phoneNumber)
        {
            return _contacts.Find(x => x.GetPhoneNumber() == (phoneNumber));
        }
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
        public void RemoveContact(string name)
        {
            _contacts.RemoveAll(x => x.GetName().ToLower() == name.ToLower());
        }

    }
}
