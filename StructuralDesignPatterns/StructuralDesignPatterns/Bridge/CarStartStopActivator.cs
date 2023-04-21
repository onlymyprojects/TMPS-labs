namespace StructuralDesignPatterns.Bridge;

public class CarStartStopActivator : IEngineStartStopActivator
{
    public void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Car engine stoped.\n");
    }
}
