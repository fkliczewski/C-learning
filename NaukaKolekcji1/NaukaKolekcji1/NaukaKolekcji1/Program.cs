using System;
using System.Collections.Generic;

namespace NaukaKolekcji1
{
    public class TaskManagerZadanie
    {
        private List<string> tasks = new List<string>();
    
        public void AddTask(string task)
        {
            tasks.Add(task);
        }
    
        public void RemoveTask(string task)
        {
            tasks.Remove(task);
        }
    
        public List<string> GetTasks()
        {
            return tasks;
        }
    }
    
    internal class Program
    {
        static void DisplayElements(List<int> list)
        {
            Console.WriteLine("--lista--");
            foreach (int element in list)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //int[] intArray = { 1, 2, 3, 4, 5 };

            List<int> intList = new List<int>(){6, 1, 20, 3, 45, 60, 100, 2};
            
            DisplayElements(intList);
            
            
            Console.WriteLine("NewElement: ");
            string userInput = Console.ReadLine();
            int intValue = int.Parse(userInput);
            intList.Add(intValue);
            
            DisplayElements(intList);

            Console.WriteLine("Removing: ");
            intList.RemoveRange(1, 2);
            DisplayElements(intList);
            
            Console.WriteLine("Sorting: ");
            intList.Sort();
            DisplayElements(intList);
            
             
        }
    }
}