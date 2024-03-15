using factorymethod.Subscription;

namespace factorymethod.Factories;

public abstract class SubscriptionFactory
{
    public abstract ISubscription GetSubscription(); 
}