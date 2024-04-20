public class WinFactory : AbstractFactory
{
    public IInput CreateInput()
    {
        return new WinInput();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WinCheckbox();
    }
}