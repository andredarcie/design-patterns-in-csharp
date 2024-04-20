public class PayPalAdapter : IPaymentProcessor
{
    private readonly PayPal _payPal;

    public PayPalAdapter(PayPal payPal)
    {
        _payPal = payPal;
    }

    public void ProcessPayment(string details)
    {
        decimal amount = decimal.Parse(details);
        _payPal.SendPayment(amount);
    }
}