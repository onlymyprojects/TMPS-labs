namespace StructuralDesignPatterns.Decorator;

public class Coaster : CarInteriorDecorator
{
    public Coaster(ICarInterior carInterior) : base(carInterior) { }

    public override string Description { get => base.Description + ", coaster"; }

    public override int Cost()
    {
        return base.Cost() + 30;
    }
}
