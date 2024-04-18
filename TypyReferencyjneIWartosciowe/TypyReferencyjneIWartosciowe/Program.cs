﻿namespace TypyReferencyjneIWartosciowe
{
    class Program
    {
        static bool isDivisible(int value, int factor, out int reminder)
        {
            reminder = value % factor;

            return reminder == 0;
        }
        static void Double(ref int value)
        {
            value = 2 * value;
            Console.WriteLine($"value: "+value);
        }
        static void Main(string[] args)
        {
            int someValue = 5;
            Double(ref someValue);
            
            Console.WriteLine($"someValue: "+ someValue);

            int value = 5;
            int factor = 2;
            int reminder;

            if (isDivisible(value, factor, out reminder))
            {
                Console.WriteLine($"{value} is divisible by {factor}");
            }
            else
            {
                Console.WriteLine($"{value} is not divisible by {factor}. Reminder: {reminder}");
            }
        }
    }
}