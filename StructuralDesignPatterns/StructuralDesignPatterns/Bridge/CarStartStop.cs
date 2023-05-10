namespace StructuralDesignPatterns.Bridge;

public class CarStartStop : EngineStartStop
{
    public CarStartStop(IEngineStartStopActivator engineStartStopActivator) : base(engineStartStopActivator) { }

    public virtual void StartStartEngine()
    {
        base.StartEngine();
    }

    public virtual void StopEngine()
    {
        base.StopEngine();
    }
}
