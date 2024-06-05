public abstract class ChatUser
{
    protected IMediator? _mediator;
    protected string _name;

    public ChatUser(string name)
    {
        _name = name;
    }

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}