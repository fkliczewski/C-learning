namespace IteratorYield
{
    public class Program
    {
        public static IEnumerable<int> GetData()
        {
            Console.WriteLine("Get data start");
            
            var result = new List<int>();
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Get data element: " + i);
                result.Add(i);
            }

            Console.WriteLine("Get data end");
            
            return result;
        }
        public static IEnumerable<int> GetYieldedData()
        {
            Console.WriteLine("Get YieldData start");
            
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Get YieldData element: " + i);
                yield return i;
            }
            
            Console.WriteLine("Get YieldData stop");
        }
        
        static void Main(string[] args)
        {
            var yieldedData = GetYieldedData();
            foreach (int element in yieldedData)
            {
                Console.WriteLine("Main element: " + element);
            }
        }
    }
}