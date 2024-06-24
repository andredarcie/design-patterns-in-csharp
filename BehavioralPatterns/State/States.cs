public class NewOrderState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("Novo pedido recebido. Mudando para estado 'Processando'.");
        context.State = new ProcessingOrderState();
    }
}

public class ProcessingOrderState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("Pedido está sendo processado. Mudando para estado 'Enviado'.");
        context.State = new ShippedOrderState();
    }
}

public class ShippedOrderState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("Pedido foi enviado. Mudando para estado 'Entregue'.");
        context.State = new DeliveredOrderState();
    }
}

public class DeliveredOrderState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("Pedido foi entregue ao cliente.");
    }
}