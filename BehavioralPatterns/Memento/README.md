No padrão de design Memento, três componentes principais trabalham juntos para gerenciar os estados de um objeto de forma que possam ser restaurados posteriormente:

- *Memento*: Esta classe é essencial para armazenar o estado interno de um objeto, denominado "Originator", sem expor sua estrutura interna. No exemplo dado, a classe Memento contém uma propriedade Content, que armazena o estado do texto de um documento. Cada instância de Memento representa um snapshot do estado do documento em um ponto específico no tempo. Esses objetos são criados pelo Originator e são utilizados para restaurar seu estado quando necessário.

- *Originator (MementoDocument)*: O Originator é o objeto cujo estado é salvo e restaurado e, neste caso, é representado pela classe MementoDocument. Esta classe mantém dados que podem mudar ao longo do tempo (aqui, a propriedade Text). O Originator cria um Memento de seu estado atual através do método CreateMemento() e pode restaurar qualquer estado anterior usando o método RestoreFromMemento(Memento memento), que atualiza o Text do documento para o estado armazenado no Memento.

- *Caretaker (DocumentHistory)*: O Caretaker gerencia o ciclo de vida dos objetos Memento sem modificar ou acessar diretamente seu conteúdo. A classe DocumentHistory atua como Caretaker, mantendo uma pilha de Mementos que representam os estados históricos do documento. Ele oferece métodos para SaveState(MementoDocument doc), que salva o estado atual do Originator empilhando um novo Memento, e Undo(MementoDocument doc), que desfaz a última alteração restaurando o estado do Originator ao estado mais recente armazenado e removendo este Memento da pilha. Se a pilha estiver vazia, uma mensagem é exibida indicando que não há mais estados para desfazer.