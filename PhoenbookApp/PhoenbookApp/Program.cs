namespace PhoenbookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook p = new PhoneBook();
            p.AddContact(new Contact("Felix", "11111111"));
            p.AddContact(new Contact("Madher", "22222222"));
            p.AddContact(new Contact("Jonas", "33333333"));
            p.AddContact(new Contact("Kasper", "44444444"));
            p.RemoveContact("Felix");
            View v = new View(p);
            v.show();
        }
    }
}
