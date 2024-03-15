namespace factorymethod.Subscription;

public class SixMonthsSubscription: ISubscription
{
    public string Name { get; } = "Six months subscription";

    private readonly float _price;

    public List<string> Services { get; } = new(){ "Music", "Movies" };

    public string Description { get; } = "Advanced subscription. Listen to music without restrictions for " +
                                         "six months. Also provides access to our online film service";

    public SixMonthsSubscription(float price)
    {
        _price = price;
    }

    public float GetPrice()
    {
        return _price;
    }
}