namespace NaukaKlas;

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}
    
public class Square : IShape
{
    private double side;
    
    public Square(double side)
    {
        this.side = side;
    }
    
    public double CalculateArea()
    {
        return side * side;
    }
    
    public double CalculatePerimeter()
    {
        return 4 * side;
    }
}
    
public class CircleZad : IShape
{
    private double radius;
    
    public CircleZad(double radius)
    {
        this.radius = radius;
    }
    
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    
    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}
