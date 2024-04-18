using System;
using System.Text;
using System.Text.RegularExpressions;

namespace FirstProject
{
    public class GradeCalculator
    {
        public static string CalculateGrade(double percentage)
        {
            if(percentage>=90)
            {
                return "A"; 
            }
            else if(percentage>=80)
            {
                return "B"; 
            }
            else if(percentage>=70)
            {
                return "C"; 
            }
            else if(percentage>=60)
            {
                return "D"; 
            }
            else{
                return "F";
            }
        }
    }
    public class ParkingCalculator
    {
        public static double CalculateParkingFee(int hours)
        {
            double result = 0;
            switch(hours)
            {
                case 0:
                    result = 0;
                    break;
                case 1:
                    result = 5;
                    break;
                default:
                    result = 5 + (hours-1)*3;
                    break;
            }

            return result;
        }
    }
    
    public class TemperatureAnalyzer
    {
        // Znajduje najwyższą temperaturę w tablicy temperatur
        public static int FindHighestTemperature(int[] temperatures)
        {
            int highest = temperatures[0];
            foreach(int temp in temperatures)
            {
                if(temp > highest)
                {
                    highest = temp;
                }
            }
            return highest;
        }
    
        // Znajduje najniższą temperaturę w tablicy temperatur
        public static int FindLowestTemperature(int[] temperatures)
        {
            int lowest = temperatures[0];
            foreach(int temp in temperatures)
            {
                if(temp < lowest)
                {
                    lowest = temp;
                }
            }
            return lowest;
        }
    }

    public class IteratingTest
    {
        // Znajduje najwyższą temperaturę w tablicy temperatur
        public static int FindHighestTemperature(int[] temperatures)
        {
            int highest = temperatures[0];
            foreach(int temp in temperatures)
            {
                if(temp > highest)
                {
                    highest = temp;
                }
            }
            return highest;
        }
    
        // Znajduje najniższą temperaturę w tablicy temperatur
        public static int FindLowestTemperature(int[] temperatures)
        {
            int lowest = temperatures[0];
            foreach(int temp in temperatures)
            {
                if(temp < lowest)
                {
                    lowest = temp;
                }
            }
            return lowest;
        }
    }

    #region ProgramClassRegion
    internal class Program
    {
        /// <summary>
        /// pozdro
        /// </summary>
        /// <param name="args">eees</param>
        private static void Main(string[] args)
        {
            //konsola
            
            /*Console.WriteLine("Type your name: ");

            string name = Console.ReadLine();
            
            Console.WriteLine("Hello " + name);
            
            //typy

            string someText = "Some text";

            char jChar = 'j';
            char jChar2 = '\u006A';

            bool isUserReady = false;

            DateTime now = DateTime.Now;
            DateTime birthDay = new DateTime(2001, 10, 29);

            byte byteNum = 200;
            float floatNum = 1.5F;
            decimal decimalNum = 1.5M;
            double doubleNum = 1.5;*/
            
            //String i StringBuilder

            /*string message1;
            message1 = "some value";
            Console.WriteLine(message1);

            string message2 = null;
            Console.WriteLine(message2);
            
            string message3 = string.Empty;

            string text = "He said \"Yes\"";
            Console.WriteLine(text);
            
            string windowLocation = "c:\\windows";
            Console.WriteLine(windowLocation);

            string fontsFolder = @"c:\windows\fonts";
            Console.WriteLine(fontsFolder);
            
            string concatenated = string.Concat(text, " to ", "me");
            string concatenated2 = text + " to " + "me";
            Console.WriteLine(concatenated);
            Console.WriteLine(concatenated2);
            
            
            string interpolated = $"{text} to me";
            Console.WriteLine(interpolated);
            
            StringBuilder sb = new StringBuilder("This");
            sb.Append("is");
            sb.Append("a");
            sb.Append("long");
            sb.Append("text");

            string result = sb.ToString();
            Console.WriteLine(result);*/
            
            //operatory
            
            /*int result;
            int x = 10;
            int y = 5;

            result = (x + y);
            Console.WriteLine("Addition Operator: x + y = " + result);

            result = (x - y);
            Console.WriteLine("Subtraction Operator: x - y = " + result);

            result = (x * y);
            Console.WriteLine("Multiplication Operator: x * y = " + result);

            result = (x / y);
            Console.WriteLine("Division Operator: x / y = " + result);

            result = (x % y);
            Console.WriteLine("Modulo Operator: x % y = " + result);

            int value = (2 + 2) * 5; //20

            Console.WriteLine("*******************");

            int value1 = 10;
            int value2 = 10;

            Console.WriteLine("Pre-increment result:");
            Console.WriteLine(++value1);


            Console.WriteLine("Post-increment result:");
            Console.WriteLine(value2++);
            Console.WriteLine(value2);

            Console.WriteLine("***************");
            bool boolResult;
            x = 2;
            y = 10;

            boolResult = (x == y);
            Console.WriteLine("Equal to Operator: (x == y) = " + boolResult);

            boolResult = (x > y);
            Console.WriteLine("Greater than Operator: (x > y) = " + boolResult);

            boolResult = (x < y);
            Console.WriteLine("Less than Operator: (x < y) = " + boolResult);

            boolResult = (x >= y);
            Console.WriteLine("Greater than or Equal to: (x >= y) =  " + boolResult);

            boolResult = (x <= y);
            Console.WriteLine("Lesser than or Equal to: (x <= y) = " + boolResult);

            boolResult = (x != y);
            Console.WriteLine("Not Equal to Operator: (x != y) = " + boolResult);

            Console.WriteLine("***************");

            bool a = true;
            bool b = false;

            boolResult = a && b;
            Console.WriteLine("AND Operator: a && b = " + boolResult);

            boolResult = a || b;
            Console.WriteLine("OR Operator: a || b = " + boolResult);

            boolResult = !a;
            Console.WriteLine("NOT Operator: !a = " + boolResult);

            Console.WriteLine("***************");
            x = 5;
            y = 10;

            int greaterNumber = x > y ? x : y;
            Console.WriteLine("Ternary conditional operator: x > y ? x : y = " + greaterNumber);*/
            
            
            //komentarze
            
            //kom
            
            /*
             cosik
             */
            
            ///
            ///
            
            
            //if-else

            /*Console.WriteLine("Enter your year of birth: ");
            string userInput = Console.ReadLine();

            int yearOfBirth = int.Parse(userInput);
            
            bool isUserOver18 = DateTime.Now.Year - yearOfBirth > 18;
            if (isUserOver18)
            {
                Console.WriteLine("hello");
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("Dziś wtorek");
            }
            else
            {
                Console.WriteLine("acces denied");
            }
            
            Console.WriteLine("bye bye");*/
            
            //switch

            /*switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It is monday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Last day of the work week");
                    break;
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("weekend");
                    break;
                default:
                    Console.WriteLine("The middle of the work week");
                    break;
            }*/
            
            //parsowanie

            /*byte byteValue = 100;
            int intValue = byteValue;
            byte byteValue2 = (byte)intValue;
            double doubleValue = 3.5;
            int intValue2 = (int)doubleValue;

            string stringValue = intValue2.ToString();
            
            string userInput = Console.ReadLine();
            int yearOfBirth;
            if (int.TryParse(userInput, out yearOfBirth))
            {
                int age = DateTime.Now.Year - yearOfBirth;
                Console.WriteLine($"Twój wiek to {age}");
            }
            else
            {
                Console.WriteLine("Incorrect Value");
            }*/
            
            
            //kalkulator bmi
            
            /*Console.WriteLine("Kalkulator BMI");
            Console.WriteLine("Podaj swoją wagę (kg): ");
            double waga;
            double wzrost;
            if (double.TryParse(Console.ReadLine(), out waga))
            {
                Console.WriteLine("Podaj swój wzrost w metrach (użyj przecinka): ");
                if (double.TryParse(Console.ReadLine(), out wzrost))
                {
                    double bmi = waga / (wzrost * wzrost);
                    Console.WriteLine("Twoje bmi to: " + bmi);
                    if (bmi < 18.5)
                    {
                        Console.WriteLine("Niedowaga");
                    }
                    else if (bmi >= 18.5 && bmi < 25)
                    {
                        Console.WriteLine("Waga normalna");
                    }
                    else if (bmi >= 25 && bmi < 30)
                    {
                        Console.WriteLine("Nadwaga");
                    }
                    else if (bmi >= 30 && bmi < 35)
                    {
                        Console.WriteLine("Otyłość");
                    }
                    else
                    {
                        Console.WriteLine("Otyłość olbrzymia");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Źle podałeś wzrost");
                }
            }
            else
            {
                Console.WriteLine("źle podałeś wagę");
            }*/

            //tablice

            /*string[] cars = { "a1", "a2", "a3" };
            string car = cars[0]; //a1
            cars[2] = "tesla"; //podmieniam a3 na tesle
            int arrLength = cars.Length;
            string car2 = cars[cars.Length - 1];*/


            //pętle
            
            //for, while, do-while, foreach
            
            //zadanie na pętle i używani konsoli
            
            /*Console.WriteLine("Podawaj cyfry a ja je zsumuję, jak podasz 0 to kończę program: ");
            int number, highest, sum;
            number = int.Parse(Console.ReadLine());
            highest = number;
            sum = number;

            while (number != 0)
            {
                number = int.Parse(Console.ReadLine());
                highest = number > highest ? number : highest;
                sum += number;
            } 
            Console.WriteLine($"Największa liczba to {highest}, a suma liczb to {sum}");*/
            
            //ENUM
            
            /*Console.WriteLine("What is your gender? 1 - Male, 2 - Female");
            string userInput = Console.ReadLine();

            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInput);

            if (userGender == Gender.Male)
            {
                Console.WriteLine("Only women alowed");
            }
            else
            {
                Console.WriteLine("Hi! ;)");
            }*/
            
            //NULLABLE

            /*int? favoriteNumber = default;
            
            Console.WriteLine("Favorite number: " + ((favoriteNumber.HasValue) ? favoriteNumber.Value.ToString() : ""));*/
            
            //Wyjątki try-catch-finally

            /*string[] cars = { "Volvo", "BMW", "Mazda" };

            try
            {
                Console.WriteLine("Inside try - 1");
                cars[4] = "Tesla";
                Console.WriteLine("Inside try - 2");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Out of range exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("Other exception");
            }
            finally
            {
                Console.WriteLine("Clean");
            }
            Console.WriteLine("Out of try catch");*/
            
            //Namespace - coś jak importy
            
            //zadanie z datami + TimeSpan
            
            /*Console.WriteLine("Podaj datę urodzin to policzę ile dni minęło od kiedy się uroodziłeś!");
            Console.WriteLine("Podaj datę (dd.MM.yyyy): ");
            string stringBirth = Console.ReadLine();
            DateTime birthDay = DateTime.Parse(stringBirth);

            TimeSpan timeSPan = DateTime.Now - birthDay;

            Console.WriteLine($"Urodziłeś się {timeSPan.TotalDays} dni temu");*/

            
            //Regexy

            Regex regex = new Regex(@"^([\w]+\.?[\w]+)@([a-zA-Z]*\.[a-zA-Z]{2,3})$");
            string email = ".test.test2@gmail.com";

            bool isMatch = regex.IsMatch(email);
            Console.WriteLine(isMatch);
        }
    }
    #endregion
}

