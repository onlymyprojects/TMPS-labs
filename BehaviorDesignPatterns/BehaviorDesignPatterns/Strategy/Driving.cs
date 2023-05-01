namespace BehaviorDesignPatterns.Strategy;

public class Driving
{
    private readonly IDriveStrategy _driveStrategy;

    public Driving(IDriveStrategy driveStrategy)
    {
        _driveStrategy = driveStrategy;
    }

    public void Drive()
    {
        _driveStrategy.DriveCar();
    }
}
