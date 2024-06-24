public class OrderContext
{
    private IOrderState _state;

    public OrderContext(IOrderState state)
    {
        State = state;
    }

    public IOrderState State
    {
        get { return _state; }
        set
        {
            _state = value;
            Console.WriteLine($"Estado do pedido mudou para: {_state.GetType().Name}");
        }
    }

    public void NextState()
    {
        _state.Handle(this);
    }
}