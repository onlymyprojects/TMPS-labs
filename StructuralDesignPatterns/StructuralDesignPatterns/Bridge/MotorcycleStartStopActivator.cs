namespace StructuralDesignPatterns.Bridge;

public class MotorcycleStartStopActivator : IEngineStartStopActivator
{
    public void StartEngine()
    {
        Console.WriteLine("Motorcycle engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Motorcycle engine stoped.\n");
    }
}
