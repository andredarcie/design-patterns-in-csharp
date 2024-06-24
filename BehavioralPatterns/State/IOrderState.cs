public interface IOrderState
{
    void Handle(OrderContext context);
}