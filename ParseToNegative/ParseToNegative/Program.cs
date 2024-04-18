namespace ParseToNegative
{
    class Program
    {
        static bool TryParseToNegative(string input, out int result)
        {
            if (int.TryParse(input, out result))
            {
                if (result < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                result = default;
                return false;
            }
        }
        static void Main(string[] args)
        {
            int inputVal;

            while (!TryParseToNegative(Console.ReadLine(), out inputVal))
            {
                Console.WriteLine("Podaj ujemną liczbę: ");
            }
            
            Console.WriteLine($"Podana negatywna liczba to: {inputVal}");
        }
    }
}