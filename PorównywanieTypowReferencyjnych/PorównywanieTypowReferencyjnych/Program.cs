namespace PorównywanieTypowReferencyjnych
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(350);
            Car car2 = new Car(350);

            bool czytesame = Equals(car1,car2);
            Console.WriteLine(czytesame);
        }
    }

    class Car
    {
        public static bool operator ==(Car left, Car right)
        {
            return Equals(left, right);
        }
        public static  bool operator !=(Car left, Car right)
        {
            return !Equals(left, right);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            Car carObj = (Car)obj;

            return this.HorsePower == carObj.HorsePower;
        }
        public Car(int horsePower)
        {
            HorsePower = horsePower;
        }
        public int HorsePower { get; set; }
    }
}