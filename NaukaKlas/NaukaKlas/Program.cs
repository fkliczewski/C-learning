using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ClassLibrary1;

namespace NaukaKlas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Przykłady na klasie Person
            
            /*Person bill = new Person("Bill", "Wick");
            
            bill.DateOfBirth = new DateTime(1990, 1,1);
            
            bill.SayHi();
            bill.ContactNumber = "999888777";
            Console.WriteLine(bill.ContactNumber);

            Person john = new Person(new DateTime(1990, 1, 2), "John", "Wick");
            
            john.SayHi();

            
            Console.WriteLine("Objects of Person count: " + Person.Count);*/
            
            //Kolejne przykłady
            
            /*Class1 test = new Class1();*/ //test internal

            /*File file = new File();*/ //file jest abstrakcyjną klasą
            
            //Dziedziczenie, interfejsy i klasy abstrakcyjne

            /*ExcelFile excelFile = new ExcelFile();

            excelFile.CreatedOn = DateTime.Now;
            excelFile.FileName = "excel-file";
            
            excelFile.GenerateReport();

            WordDocumentFile wordDocumentFile = new WordDocumentFile();
            
            wordDocumentFile.CreatedOn = DateTime.Now;
            wordDocumentFile.FileName = "word-file";
            
            wordDocumentFile.Print();*/

            Shape[] shapes = { new Circle(), new Rectangle(), new Triangle() };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

        }
    }
    
}

