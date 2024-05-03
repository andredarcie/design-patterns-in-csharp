public class PremiumContent : SubscriptionDecorator
{
    public PremiumContent(Subscription subscription) : base(subscription) { }

    public override string GetFeatures()
    {
        return subscription.GetFeatures() + ", Conteúdo Premium";
    }

    public override double GetCost()
    {
        return subscription.GetCost() + 5.00;
    }
}