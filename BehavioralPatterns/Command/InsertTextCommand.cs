public class InsertTextCommand : ICommand
{
    private readonly Document _document;
    private readonly string _text;

    public InsertTextCommand(Document document, string text)
    {
        _document = document;
        _text = text;
    }

    public void Execute()
    {
        _document.Insert(_text);
    }

    public void Unexecute()
    {
        _document.Remove(_text);
    }
}