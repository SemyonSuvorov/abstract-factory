namespace factorymethod.Subscription;

public interface ISubscription
{
    string Name { get; }
    string Description { get; }
    float GetPrice();
}