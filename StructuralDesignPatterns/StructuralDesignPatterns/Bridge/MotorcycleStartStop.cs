namespace StructuralDesignPatterns.Bridge;

public class MotorcycleStartStop : IEngineStartStop
{
    private readonly IEngineStartStopActivator _engineStartStopActivator;
    public MotorcycleStartStop(IEngineStartStopActivator engineStartStopActivator)
    {
        _engineStartStopActivator = engineStartStopActivator;
    }

    public void Start()
    {
        _engineStartStopActivator.StartEngine();
    }

    public void Stop()
    {
        _engineStartStopActivator.StopEngine();
    }
}
