public class Document
{
    private string _content = string.Empty;

    public void Insert(string text)
    {
        _content += text;
        Console.WriteLine("Document content: " + _content);
    }

    public void Remove(string text)
    {
        if (_content.EndsWith(text))
        {
            _content = _content.Substring(0, _content.Length - text.Length);
            Console.WriteLine("Document content: " + _content);
        }
    }
}