// Implementação da estratégia de pagamento com cartão de crédito
public class CreditCardPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        // Lógica específica para processar pagamento com cartão de crédito
        Console.WriteLine($"Processando pagamento de {amount:C} com cartão de crédito.");
    }
}

// Implementação da estratégia de pagamento com PayPal
public class PayPalPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        // Lógica específica para processar pagamento com PayPal
        Console.WriteLine($"Processando pagamento de {amount:C} com PayPal.");
    }
}

// Implementação da estratégia de pagamento com transferência bancária
public class BankTransferPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        // Lógica específica para processar pagamento com transferência bancária
        Console.WriteLine($"Processando pagamento de {amount:C} com transferência bancária.");
    }
}