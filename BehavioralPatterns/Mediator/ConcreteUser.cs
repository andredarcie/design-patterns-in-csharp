public class ConcreteChatUser : ChatUser
{
    public ConcreteChatUser(string name) : base(name) { }

    public override void Send(string message)
    {
        if (_mediator != null) {
            Console.WriteLine($"{_name} sends: {message}");
            _mediator.SendMessage(message, this);
        }
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{_name} receives: {message}");
    }
}