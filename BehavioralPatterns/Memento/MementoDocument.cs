// A classe MementoDocument atua como o "Originator" no padrão Memento.
// Ela cria e usa Mementos para salvar e restaurar seu estado anterior.
public class MementoDocument
{
    // Texto atual do documento.
    public string Text { get; set; } = string.Empty;

    // Cria um Memento contendo o estado atual do documento.
    public Memento CreateMemento()
    {
        return new Memento(Text);
    }

    // Restaura o estado do documento a partir de um Memento fornecido.
    public void RestoreFromMemento(Memento memento)
    {
        Text = memento.Content;
    }
}