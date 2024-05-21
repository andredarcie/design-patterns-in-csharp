public class PaymentRequest
{
    public string CardNumber { get; set; }
    public decimal Amount { get; set; }
    public bool IsFraudDetected { get; set; }
    public bool IsCardValid { get; set; }
    public bool HasSufficientBalance { get; set; }

    public PaymentRequest(string cardNumber, decimal amount)
    {
        CardNumber = cardNumber;
        Amount = amount;
    }
}