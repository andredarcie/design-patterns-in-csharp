public class BasicSubscription : Subscription
{
    public override string GetFeatures()
    {
        return "Acesso a conteúdo básico";
    }

    public override double GetCost()
    {
        return 9.99;
    }
}