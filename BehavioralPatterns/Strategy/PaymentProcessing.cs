// Interface de Estratégia que define o método de processamento de pagamento
public interface IPaymentStrategy
{
    void ProcessPayment(double amount);
}