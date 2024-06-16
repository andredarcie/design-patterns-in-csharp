// A classe DocumentHistory atua como o "Caretaker" no padrão Memento.
// Ela é responsável por armazenar o histórico de estados do documento (Mementos) e
// fornece métodos para salvar e desfazer estados do documento.
public class DocumentHistory
{
    // Armazena os estados anteriores do documento em uma pilha.
    private Stack<Memento> history = new Stack<Memento>();

    // Salva o estado atual do documento. Cria um memento do estado atual do documento
    // e empilha no histórico.
    public void SaveState(MementoDocument doc)
    {
        history.Push(doc.CreateMemento());
    }

    // Desfaz a última alteração no documento. Se houver estados salvos,
    // restaura o documento para o estado mais recente e remove esse estado do histórico.
    public void Undo(MementoDocument doc)
    {
        if (history.Count > 0)
        {
            doc.RestoreFromMemento(history.Pop());
        }
        else
        {
            Console.WriteLine("Não há mais desfazer disponíveis.");
        }
    }
}