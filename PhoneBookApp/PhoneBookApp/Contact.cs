namespace PhoneBookApp;

public class Contact
{
    public string Name { get; set; }
    public int Number { get; set; }

    public Contact(string name, int number)
    {
        Name = name;
        Number = number;
    }
}