public class Stripe
{
    public void MakePayment(decimal amount, string currency)
    {
        Console.WriteLine($"Paying {amount} {currency} via Stripe");
    }
}