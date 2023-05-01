namespace BehaviorDesignPatterns.State;

public interface IHeadlightsState
{
    void Handle(Headlights headlights);
}
