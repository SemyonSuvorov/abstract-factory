using factorymethod.Subscription;

namespace factorymethod.Factories;

public class SixMonthsSubscriptionFactory: SubscriptionFactory
{
    private readonly float _price;

    public SixMonthsSubscriptionFactory(float price)
    {
        _price = price;
    }

    public override ISubscription GetSubscription()
    {
        var subscription = new SixMonthsSubscription(_price);
        return subscription;
    }
}