namespace addressbook
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddContact add= new AddContact();
            add.AddContactm();
            Contacts contacts = add.AddContactm();
        }
    }
}