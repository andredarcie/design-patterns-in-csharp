class WebCanvas : AbstractCanvas
{
    public override IButton CreateButton()
    {
        return new WebButton();
    }
}
