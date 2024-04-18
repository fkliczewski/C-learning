using System;

namespace PhoneBookApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej witaj w mojej liście kontaktów, podaj numer by wybrać co chcesz zrobić:");
            Console.WriteLine("1 - dodaj kontakt");
            Console.WriteLine("2 - wyszukaj kontakt po numerze");
            Console.WriteLine("3 - wyświetl wszystkie kontakty");
            Console.WriteLine("4 - wyszukaj wszystkie kontakty zawierające nazwe");
            Console.WriteLine("x - by wyjść");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();
            phoneBook.AddContact(new Contact("Maciek",321));
            phoneBook.AddContact(new Contact("Ola",666));
            phoneBook.AddContact(new Contact("Kasia",698));

            while(true){
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("--Dodajesz kontakt--");
                        Console.WriteLine("Podaj nazwę nowego kontaktu: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Podaj numer nowego kontaktu: ");
                        var number = Console.ReadLine();
                        var newContact = new Contact(name, int.Parse(number));
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("--Wyszukujesz kontakt po numerze--");
                        Console.WriteLine("Podaj numer by wyszukać kontakt: ");
                        var numberToFind = Console.ReadLine();
                        phoneBook.FindByNumber(int.Parse(numberToFind));
                        break;
                    case "3":
                        Console.WriteLine("--Wyświetlasz wszystkie kontakty--");
                        phoneBook.ShowAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("--Wyszukujesz kontakt po nazwie--");
                        Console.WriteLine("Podaj nazwę po której mam szukać kontaktu/kontaktów: ");
                        var contactsToFind = Console.ReadLine();
                        phoneBook.FindByName(contactsToFind);
                        break;
                    case "x" :
                        return;
                    default:
                        Console.WriteLine("Niewłaściwy wybór");
                        break;
                }
                Console.WriteLine("Podaj kolejną czynność: ");
                userInput = Console.ReadLine();
            }
        }
    }
}