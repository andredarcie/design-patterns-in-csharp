public class ConcreteObserverB : IObserver
{
    private string _name;

    public ConcreteObserverB(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} recebeu a mensagem: {message}");
    }
}