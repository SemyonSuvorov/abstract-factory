using factorymethod.Subscription;

namespace factorymethod.Factories;

public class OneMonthSubscriptionFactory: SubscriptionFactory
{
    private readonly float _price;

    public OneMonthSubscriptionFactory(float price)
    {
        _price = price;
    }

    public override ISubscription GetSubscription()
    {
        var subscription = new OneMonthSubscription(_price);
        return subscription;
    }
}