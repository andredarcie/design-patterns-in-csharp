public class MacFactory : AbstractFactory
{
    public IInput CreateInput()
    {
        return new MacInput();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}