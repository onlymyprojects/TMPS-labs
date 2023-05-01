namespace BehaviorDesignPatterns.State;

public class HeadlightsTurnedOnState : IHeadlightsState
{
    public void Handle(Headlights headlights)
    {
        headlights.State = new HeadlightsTurnedOffState();
    }
}
