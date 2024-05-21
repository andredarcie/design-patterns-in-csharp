public abstract class PaymentHandler
{
    protected PaymentHandler? _nextHandler;

    public void SetNextHandler(PaymentHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public abstract void Handle(PaymentRequest request);
}