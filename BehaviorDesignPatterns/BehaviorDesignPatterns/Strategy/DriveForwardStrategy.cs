namespace BehaviorDesignPatterns.Strategy;

public class DriveForwardStrategy : IDriveStrategy
{
    public void DriveCar()
    {
        Console.WriteLine("\nTurning on headlights");
        Console.WriteLine("Turning on wipers");
        Console.WriteLine("Turning on video recorder");
    }
}
