namespace factorymethod.Subscription;

public class OneMonthSubscription : ISubscription
{
    public string Name { get; } = "One month subscription";

    private readonly float _price;
    
    public List<string> Services { get; } = new(){ "Music" };


    public string Description { get; } = "Basic subscription. Listen to music without restrictions for " +
                                              "one month. Less profitable over a long distance.";
    public OneMonthSubscription(float price)
    {
        _price = price;
    }

    public float GetPrice()
    {
        return _price;
    }
}