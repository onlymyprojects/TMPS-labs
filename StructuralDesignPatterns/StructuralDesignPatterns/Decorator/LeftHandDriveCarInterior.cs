namespace StructuralDesignPatterns.Decorator;

public class LeftHandDriveCarInterior : ICarInterior
{
    public string Description { get; set; } = "Interior with left hand drive";

    public int Cost()
    {
        return 100;
    }
}
