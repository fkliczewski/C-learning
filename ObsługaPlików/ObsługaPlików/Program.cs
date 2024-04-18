using System;
using System.IO;

namespace ObsługaPlików
{
    class Program
    {
        static void ScanAndAppend()
        {
            var files = Directory.GetFiles("C:\\Users\\Filip\\Desktop\\KursC#\\TextFiles\\pliki", "*.txt", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                File.AppendAllText(file, "All rights reserved  ");
            }
        }
        static void ReadFiles()
        {
            var document1 = File.ReadAllText("C:\\Users\\Filip\\Desktop\\KursC#\\TextFiles\\document1.txt");
            var document2 = File.ReadAllLines("C:\\Users\\Filip\\Desktop\\KursC#\\TextFiles\\document2.txt");

            var document2String = string.Join(Environment.NewLine, document2);
            
            Console.WriteLine("doc1");
            Console.WriteLine(document1);
            
            Console.WriteLine("doc2");
            Console.WriteLine(document2String);
        }
        static void GenerateDocuments()
        {
            Console.WriteLine("Insert name: ");
            var name = Console.ReadLine();
            
            Console.WriteLine("Insert orderNumber: ");
            var orderNumber = Console.ReadLine();

            var template = File.ReadAllText("C:\\Users\\Filip\\Desktop\\KursC#\\TextFiles\\template.txt");
            var document = template.Replace("{name}", name)
                .Replace("{orderNumber}", orderNumber)
                .Replace("{dateTime}", DateTime.Now.ToString());
            
            File.WriteAllText($"C:\\Users\\Filip\\Desktop\\KursC#\\TextFiles\\document - {name}.txt", document);
        }
        static void Main(string[] args)
        {
            //ReadFiles();
            //GenerateDocuments();
            ScanAndAppend();
        }
    }
}