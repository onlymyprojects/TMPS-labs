using CreationalDesignPatterns.Cars;

namespace CreationalDesignPatterns.Motorcycles;

public class MotorcycleFactory : VehicleFactory
{
    private static MotorcycleFactory instance = null;

    private MotorcycleFactory() { }

    public static MotorcycleFactory GetInstance()
    {
        if (instance == null)
        {
            instance = new MotorcycleFactory();
        }

        return instance;
    }

    public override Vehicle CreateVehicle(string type)
    {
        Vehicle motorcycle;

        switch (type.ToLower())
        {
            case "scooter":
                motorcycle = new Scooter();
                break;
            case "sportbike":
                motorcycle = new SportBike();
                break;
            default: throw new ArgumentException("No such motorcycle.");
        }

        Console.WriteLine($"{type} created.");

        motorcycle.RideVehicle();

        return motorcycle;
    }
}
