namespace BehaviorDesignPatterns.State;

public class Headlights
{
    IHeadlightsState headlightsState;

    public Headlights(IHeadlightsState headlightsState)
    {
        this.headlightsState = headlightsState;
    }

    public IHeadlightsState State
    {
        get { return headlightsState; }
        set
        {
            headlightsState = value;
            Console.WriteLine("State: " + headlightsState.GetType().Name);
        }
    }

    public void TurnOnOff()
    {
        headlightsState.Handle(this);
    }
}
