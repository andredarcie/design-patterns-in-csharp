public class CardValidationHandler : PaymentHandler
{
    public override void Handle(PaymentRequest request)
    {
        request.IsCardValid = request.CardNumber.StartsWith("4");

        if (request.IsCardValid)
        {
            Console.WriteLine("Cartão válido verificado.");
            _nextHandler?.Handle(request);
        }
        else
        {
            Console.WriteLine("Cartão inválido.");
        }
    }
}