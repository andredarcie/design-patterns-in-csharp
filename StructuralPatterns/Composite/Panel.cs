public class Panel : IUIComponent
{
    private List<IUIComponent> children = new List<IUIComponent>();
    public string Name { get; private set; }

    public Panel(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("Panel: " + Name);
        foreach (var child in children)
        {
            child.Display();
        }
    }

    public void AddComponent(IUIComponent component)
    {
        children.Add(component);
    }

    public void RemoveComponent(IUIComponent component)
    {
        children.Remove(component);
    }
}