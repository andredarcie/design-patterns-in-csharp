public class Button : IUIComponent
{
    public string Name { get; private set; }

    public Button(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("Displaying Button: " + Name);
    }

    public void AddComponent(IUIComponent component)
    {
        throw new InvalidOperationException("Cannot add component to a button.");
    }

    public void RemoveComponent(IUIComponent component)
    {
        throw new InvalidOperationException("Cannot remove component from a button.");
    }
}