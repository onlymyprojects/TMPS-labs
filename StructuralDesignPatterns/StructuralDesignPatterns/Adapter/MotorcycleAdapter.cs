namespace StructuralDesignPatterns.Adapter;

public class MotorcycleAdapter : ICar
{
    private readonly IMotorcycle _motorcycle;

    public MotorcycleAdapter(IMotorcycle motorcycle)
    {
        _motorcycle = motorcycle;
    }

    public void Ride()
    {
        _motorcycle.RideMotorcycle();
    }
}
