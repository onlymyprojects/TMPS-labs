namespace BehaviorDesignPatterns.Strategy;

public class DriveBackwardStrategy : IDriveStrategy
{
    public void DriveCar()
    {
        Console.WriteLine("\nTurning on parking lights");
        Console.WriteLine("Turning on parking senzor");
        Console.WriteLine("Turning on parking video camera");
    }
}
