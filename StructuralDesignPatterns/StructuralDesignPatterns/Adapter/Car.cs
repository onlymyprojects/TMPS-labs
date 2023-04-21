namespace StructuralDesignPatterns.Adapter;

public class Car : ICar
{
    public const int nrOfDoors = 4;
    public const int nrOfSeats = 5;
    public const int maxSpeed = 200;

    public void Ride()
    {
        Console.WriteLine("I am riding a car.");
    }
}
