namespace BehaviorDesignPatterns.State;

public class HeadlightsTurnedOffState : IHeadlightsState
{
    public void Handle(Headlights headlights)
    {
        headlights.State = new HeadlightsTurnedOnState();
    }
}
