// A classe Memento é usada para armazenar o estado de um objeto (neste caso, MementoDocument).
// O Memento armazena o estado interno do objeto MementoDocument de uma forma que o MementoDocument
// possa ser restaurado para esse estado mais tarde.
public class Memento
{
    // O conteúdo do documento no momento da criação do Memento.
    public string Content { get; private set; }

    // Construtor que inicializa o Memento com o conteúdo fornecido.
    public Memento(string content)
    {
        Content = content;
    }
}