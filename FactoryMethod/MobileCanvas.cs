class MobileCanvas : AbstractCanvas
{
    public override IButton CreateButton()
    {
        return new MobileButton();
    }
}