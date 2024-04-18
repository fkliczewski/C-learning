namespace NaukaKlas;

public abstract class Vehicle
{
    protected string Model;
    public abstract void Start();
    public abstract void Stop();

}
    
public class Car : Vehicle
{
    public Car(){
        Model = "Opel";
    }
    public override void Start(){
        Console.WriteLine($"Starting the car: {Model}");
    }
    public override void Stop(){
        Console.WriteLine($"Stopping the car: {Model}");
    }
}
    
public class Motorcycle : Vehicle
{
    public Motorcycle(){
        Model = "Harley";
    }
    public override void Start(){
        Console.WriteLine($"Starting the motorcycle: {Model}");
    }
    public override void Stop(){
        Console.WriteLine($"Stopping the motorcycle: {Model}");
    }
}