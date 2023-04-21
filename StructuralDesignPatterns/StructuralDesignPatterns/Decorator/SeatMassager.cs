namespace StructuralDesignPatterns.Decorator;

public class SeatMassager : CarInteriorDecorator
{
    public SeatMassager(ICarInterior carInterior) : base(carInterior) { }

    public override string Description { get => base.Description + ", seat massager"; }

    public override int Cost()
    {
        return base.Cost() + 30;
    }
}
