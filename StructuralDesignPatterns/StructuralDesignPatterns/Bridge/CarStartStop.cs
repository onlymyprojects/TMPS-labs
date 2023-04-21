namespace StructuralDesignPatterns.Bridge;

public class CarStartStop : IEngineStartStop
{
    private readonly IEngineStartStopActivator _engineStartStopActivator;
    public CarStartStop(IEngineStartStopActivator engineStartStopActivator)
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
