namespace StructuralDesignPatterns.Adapter;

public class Motorcycle : IMotorcycle
{
    public const int nrOfSeats = 2;
    public const int maxSpeed = 350;

    public void RideMotorcycle()
    {
        Console.WriteLine("I am riding a motorcycle.");
    }
}
