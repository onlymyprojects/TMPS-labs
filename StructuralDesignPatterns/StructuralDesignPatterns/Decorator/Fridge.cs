namespace StructuralDesignPatterns.Decorator;

public class Fridge : CarInteriorDecorator
{
    public Fridge(ICarInterior carInterior) : base(carInterior) { }

    public override string Description { get => base.Description + ", fridge"; }

    public override int Cost()
    {
        return base.Cost() + 30;
    }
}
