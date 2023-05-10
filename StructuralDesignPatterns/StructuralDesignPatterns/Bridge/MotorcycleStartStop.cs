namespace StructuralDesignPatterns.Bridge;

public class MotorcycleStartStop : EngineStartStop
{
    public MotorcycleStartStop(IEngineStartStopActivator engineStartStopActivator) : base(engineStartStopActivator) { }

    public override void StartEngine()
    {
        base.StartEngine();
    }

    public override void StopEngine()
    {
        base.StopEngine();
    }
}
