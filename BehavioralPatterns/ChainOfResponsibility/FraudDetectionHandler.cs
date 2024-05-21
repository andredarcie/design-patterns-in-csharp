public class FraudDetectionHandler : PaymentHandler
{
    public override void Handle(PaymentRequest request)
    {
        request.IsFraudDetected = false;

        if (!request.IsFraudDetected)
        {
            Console.WriteLine("Nenhuma fraude detectada.");
            _nextHandler?.Handle(request);
        }
        else
        {
            Console.WriteLine("Fraude detectada.");
        }
    }
}
