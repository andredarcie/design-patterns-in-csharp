public class StripeAdapter : IPaymentProcessor
{
    private readonly Stripe _stripe;

    public StripeAdapter(Stripe stripe)
    {
        _stripe = stripe;
    }

    public void ProcessPayment(string details)
    {
        string[] parts = details.Split(',');
        decimal amount = decimal.Parse(parts[0]);
        string currency = parts[1];
        _stripe.MakePayment(amount, currency);
    }
}