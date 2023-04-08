namespace CreationalDesignPatterns.Cars;

public class CarFactory : VehicleFactory
{
    private static CarFactory instance = null;

    private CarFactory() { }

    public static CarFactory GetInstance()
    {
        if (instance == null)
        {
            instance = new CarFactory();
        }

        return instance;
    }

    public override Vehicle CreateVehicle(string type)
    {
        Vehicle car;

        switch (type.ToLower())
        {
            case "sedan":
                car = new Sedan();
                break;
            case "universal":
                car = new Universal();
                break;
            default: throw new ArgumentException("No such car.");
        }

        Console.WriteLine($"{type} created.");

        car.RideVehicle();

        return car;
    }
}
