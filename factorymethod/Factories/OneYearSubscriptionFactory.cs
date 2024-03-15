using factorymethod.Subscription;

namespace factorymethod.Factories;

public class OneYearSubscriptionFactory: SubscriptionFactory
{
    private readonly float _price;

    public OneYearSubscriptionFactory(float price)
    {
        _price = price;
    }

    public override ISubscription GetSubscription()
    {
        var subscription = new OneMonthSubscription(_price);
        return subscription;
    }
}