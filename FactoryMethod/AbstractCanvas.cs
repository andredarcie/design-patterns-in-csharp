abstract class AbstractCanvas
{
    public abstract IButton CreateButton();

    public string OnClick()
    {
        return CreateButton().OnClick();
    }
}