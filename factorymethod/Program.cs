using factorymethod.Factories;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the subscription type yot want to create: ");
        Console.WriteLine(">1 – One month subscription");
        Console.WriteLine(">2 – Six months subscription");
        Console.WriteLine(">3 – One year subscription");
        var subscriptionType = Console.ReadLine() ?? string.Empty;
        var factory = GetFactory(subscriptionType);
        var subscription = factory.GetSubscription();
        Console.WriteLine("\n>Subscription you've just created: ");
        Console.WriteLine(
            $"\tName:\t\t{subscription.Name}\n" +
            $"\tDescription:\t{subscription.Description}\n" +
            $"\tPrice:\t\t{subscription.GetPrice()}");
    }
    private static SubscriptionFactory GetFactory(string subscriptionType) =>
        subscriptionType switch
        {
            "1" => new OneMonthSubscriptionFactory(150),
            "2" => new SixMonthsSubscriptionFactory(700),
            "3" => new OneYearSubscriptionFactory(1300)
        };
}



