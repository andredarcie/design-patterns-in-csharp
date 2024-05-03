public abstract class SubscriptionDecorator : Subscription
{
    protected Subscription subscription;

    public SubscriptionDecorator(Subscription subscription)
    {
        this.subscription = subscription;
    }
}