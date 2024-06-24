public class ConcreteObserverA : IObserver
{
    private string _name;

    public ConcreteObserverA(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} recebeu a mensagem: {message}");
    }
}