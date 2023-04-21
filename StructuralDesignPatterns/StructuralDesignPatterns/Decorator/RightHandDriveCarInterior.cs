namespace StructuralDesignPatterns.Decorator;

public class RightHandDriveCarInterior : ICarInterior
{
    public string Description { get; set; } = "Interior with right hand drive";

    public int Cost()
    {
        return 100;
    }
}
