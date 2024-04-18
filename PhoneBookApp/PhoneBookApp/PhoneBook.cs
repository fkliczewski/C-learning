namespace PhoneBookApp;

public class PhoneBook
{
    private List<Contact> ContactList = new List<Contact>();

    public void AddContact(Contact contact)
    {
        ContactList.Add(contact);
    }

    public void FindByNumber(int number)
    {
        Contact contact = ContactList.FirstOrDefault(c => c.Number == number);
        if (contact == null)
        {
            Console.WriteLine("Brak kontaktu o podanym numerze.");
        }
        else
        {
            Console.WriteLine($"Nazwa: {contact.Name}, numer: {contact.Number}");
        }
    }

    public void ShowAllContacts()
    {
        int i = 1;
        foreach (var contact in ContactList)
        {
            Console.WriteLine($"Kontakt nr {i} - Nazwa: {contact.Name}, numer: {contact.Number}");
            i++;
        }
    }

    public void FindByName(string name)
    {
        List<Contact> tempContactList = ContactList.Where(c => c.Name.Contains(name)).ToList();
        int i = 1;
        foreach (var contact in tempContactList)
        {
            Console.WriteLine($"Kontakt nr {i} - Nazwa: {contact.Name}, numer: {contact.Number}");
            i++;
        }
    }
    
    
}