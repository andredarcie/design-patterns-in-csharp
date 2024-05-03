public interface IUIComponent
{
    string Name { get; }
    void Display();
    void AddComponent(IUIComponent component);
    void RemoveComponent(IUIComponent component);
}