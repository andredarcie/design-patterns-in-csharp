public class AdditionalDevices : SubscriptionDecorator
{
    public AdditionalDevices(Subscription subscription) : base(subscription) { }

    public override string GetFeatures()
    {
        return subscription.GetFeatures() + ", Mais 2 dispositivos simultâneos";
    }

    public override double GetCost()
    {
        return subscription.GetCost() + 3.00;
    }
}