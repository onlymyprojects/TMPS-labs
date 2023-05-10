namespace StructuralDesignPatterns.Bridge;

public abstract class EngineStartStop
{
    private readonly IEngineStartStopActivator _engineStartStopActivator;

    public EngineStartStop(IEngineStartStopActivator engineStartStopActivator)
    {
        _engineStartStopActivator = engineStartStopActivator;
    }

    public virtual void StartEngine()
    {
        _engineStartStopActivator.StartEngine();
    }
    public virtual void StopEngine()
    {
        _engineStartStopActivator.StopEngine();
    }
}
