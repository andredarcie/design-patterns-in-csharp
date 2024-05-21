public class BalanceCheckHandler : PaymentHandler
{
    public override void Handle(PaymentRequest request)
    {
        request.HasSufficientBalance = request.Amount <= 1000;

        if (request.HasSufficientBalance)
        {
            Console.WriteLine("Saldo suficiente verificado.");
            _nextHandler?.Handle(request);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}