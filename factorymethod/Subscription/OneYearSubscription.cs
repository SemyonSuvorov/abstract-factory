namespace factorymethod.Subscription;

public class OneYearSubscription: ISubscription
{
    public string Name { get; } = "One year subscription";

    private readonly float _price;
    
    public List<string> Services { get; } = new(){ "Music", "Movies", "Bank", "Messenger", "Marketplace" };

    public string Description { get; } = "Best subscription. Listen to music without restrictions for " +
                                              "one year. Also provides access to all of our services";

    public OneYearSubscription(float price)
    {
        _price = price;
    }

    public float GetPrice()
    {
        return _price;
    }
}