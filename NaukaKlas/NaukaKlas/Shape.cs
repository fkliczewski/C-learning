namespace NaukaKlas
{

    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }

    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing triangle");
        }
    }
}