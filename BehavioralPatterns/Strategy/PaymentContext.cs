// Contexto que utiliza uma estratégia de pagamento para processar um pagamento
public class PaymentContext
{
    private IPaymentStrategy? _paymentStrategy;

    // Método para definir a estratégia de pagamento
    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    // Método para processar o pagamento utilizando a estratégia definida
    public void ProcessPayment(double amount)
    {
        if (_paymentStrategy is null)
        {
            throw new InvalidOperationException("Estratégia de pagamento não está definida.");
        }

        _paymentStrategy.ProcessPayment(amount);
    }
}