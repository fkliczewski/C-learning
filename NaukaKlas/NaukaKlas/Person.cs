using System.Runtime.CompilerServices;

namespace NaukaKlas;

public class Person
{
    public string FirstName;
    public string LastName;
    
    private DateTime dateofBirth;
    private string contactNumber;
    
    public static int Count = 0;
    
    public Person(string firstName, string lastName)
    {
        /*Console.WriteLine("Constructor1");*/
        FirstName = firstName;
        LastName = lastName;
        Count++;
    }
    public Person(DateTime dateofBirth, string firstName, string lastName) : this(firstName, lastName)
    {
        /*Console.WriteLine("Constructor2");*/
        this.DateOfBirth = dateofBirth;
    }
    public string ContactNumber
    {
        get { return contactNumber; }
        set
        {
            if (value.Length > 9)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                contactNumber = value;
            }
        }
    }

    public DateTime DateOfBirth
    {
        get { return dateofBirth; }
        set
        {
            if (value > DateTime.Now)
            {
                Console.WriteLine("Wrong birthday date");
            }
            else
            {
                dateofBirth = value;
            }
        }
    }

    /*public void SetDateOfBirth(DateTime date)
    {
        if (date > DateTime.Now)
        {
            Console.WriteLine("Invalid date of birth");
        }
        else
        {
            dateofBirth = date;
        }
    }

    public DateTime GetDateOfBirth() => dateofBirth;*/

    public void SayHi()
    {
        Console.WriteLine($"Hi, I'm {this.FirstName}, {dateofBirth}");
    }
}