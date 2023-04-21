namespace StructuralDesignPatterns.Decorator;

public interface ICarInterior
{
    string Description { get; set; }

    int Cost();
}
