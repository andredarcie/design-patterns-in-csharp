public static class BehavioralPatterns
{
    public static void Execute()
    {
        // Title
        Console.WriteLine("\n══════════════════════════════");
        Console.WriteLine("       Behavioral Patterns");
        Console.WriteLine("══════════════════════════════\n");

        // Chain of Responsibility
        Console.WriteLine("Chain of Responsibility:");
        Console.WriteLine("─────────────────────────");
        Console.WriteLine("  ┌───┐    ┌───┐    ┌───┐");
        Console.WriteLine("  │ A │ →  │ B │ →  │ C │");
        Console.WriteLine("  └───┘    └───┘    └───┘\n");

        ChainOfResponsibility();

        // Command
        Console.WriteLine("Command:");
        Console.WriteLine("──────────");
        Console.WriteLine("  [Button] → ExecuteCommand()");
        Console.WriteLine("          → Command Action\n");

        Command();

        // Iterator
        Console.WriteLine("Iterator:");
        Console.WriteLine("───────────");
        Console.WriteLine("  Collection: [Item1, Item2, Item3]");
        Console.WriteLine("  Iterator:    ↑\n");

        Iterator();

        // Mediator
        Console.WriteLine("Mediator:");
        Console.WriteLine("─────────────");
        Console.WriteLine("  [ComponentA] ");
        Console.WriteLine("      ↑");
        Console.WriteLine("      ↓");
        Console.WriteLine("  [Mediator]");
        Console.WriteLine("      ↑");
        Console.WriteLine("      ↓");
        Console.WriteLine("  [ComponentB]\n");

        Mediator();

        // Memento
        Console.WriteLine("Memento:");
        Console.WriteLine("────────────");
        Console.WriteLine("  Originator: Current State");
        Console.WriteLine("      ↑");
        Console.WriteLine("      ↓");
        Console.WriteLine("  Memento: Saved State");
        Console.WriteLine("      ↑");
        Console.WriteLine("      ↓");
        Console.WriteLine("  Caretaker: Holds Memento\n");

        Memento();

        Observer();

        State();
    }

    private static void ChainOfResponsibility() 
    {
        PaymentHandler balanceCheck = new BalanceCheckHandler();
        PaymentHandler cardValidation = new CardValidationHandler();
        PaymentHandler fraudDetection = new FraudDetectionHandler();

        balanceCheck.SetNextHandler(cardValidation);
        cardValidation.SetNextHandler(fraudDetection);

        var creditCardNumber = "4111111111111111";
        var amount = 500;
        PaymentRequest request = new PaymentRequest(creditCardNumber, amount);
        balanceCheck.Handle(request);
    }

    private static void Command() 
    {
        Document document = new Document();
        CommandManager commandManager = new CommandManager();

        var insertCommand1 = new InsertTextCommand(document, "Hello ");
        var insertCommand2 = new InsertTextCommand(document, "World!");

        commandManager.ExecuteCommand(insertCommand1);
        commandManager.ExecuteCommand(insertCommand2);

        commandManager.Undo(); // Remove "World!"
        commandManager.Redo(); // Adiciona "World!" novamente
    }

    private static void Iterator() 
    {
        UserCollection userCollection = new UserCollection();
        userCollection.AddUser(new User("Alan Turing", "alan.turing@example.com"));
        userCollection.AddUser(new User("Grace Hopper", "grace.hopper@example.com"));
        userCollection.AddUser(new User("Ada Lovelace", "ada.lovelace@example.com"));
        userCollection.AddUser(new User("Donald Knuth", "donald.knuth@example.com"));

        IIterator iterator = userCollection.CreateIterator();

        while (iterator.HasNext())
        {
            User user = iterator.Next();
            Console.WriteLine($"Name: {user.Name}, Email: {user.Email}");
        }
    }

    private static void Mediator() 
    {
        // Cria um mediador de chat
        IMediator chatMediator = new ChatMediator();

        // Cria três usuários do chat com nomes diferentes
        ChatUser user1 = new ConcreteChatUser("Alan Turing");
        ChatUser user2 = new ConcreteChatUser("Ada Lovelace");
        ChatUser user3 = new ConcreteChatUser("John von Neumann");

        // Registra os usuários no mediador de chat
        chatMediator.RegisterUser(user1);
        chatMediator.RegisterUser(user2);
        chatMediator.RegisterUser(user3);

        // Usuário 1 envia uma mensagem para todos
        user1.Send("Olá, pessoal!");
        // Usuário 2 responde para "Alan Turing"
        user2.Send("Oi Alan Turing!");
        // Usuário 3 envia uma mensagem para "Alan Turing" e "Ada Lovelace"
        user3.Send("Ei Alan Turing e Ada Lovelace!");
    }

    private static void Memento() 
    {
        // Cria um novo documento que suporta o padrão Memento
        MementoDocument doc = new MementoDocument();

        // Cria um histórico para armazenar os estados do documento
        DocumentHistory history = new DocumentHistory();

        // Define o texto do documento para a primeira linha de texto
        doc.Text = "Primeira linha de texto";
        // Salva o estado atual do documento no histórico
        history.SaveState(doc);

        // Modifica o texto do documento para a segunda linha de texto
        doc.Text = "Segunda linha de texto";
        // Salva o novo estado do documento no histórico
        history.SaveState(doc);

        // Modifica o texto do documento para a terceira linha de texto
        doc.Text = "Terceira linha de texto";
        // Exibe o conteúdo atual do documento
        Console.WriteLine("Conteúdo atual do Documento: " + doc.Text);
        
        // Desfaz a última alteração no documento, voltando ao estado anterior
        history.Undo(doc);
        // Exibe o conteúdo do documento após o primeiro desfazer
        Console.WriteLine("Após o primeiro desfazer: " + doc.Text);

        // Desfaz mais uma alteração, voltando ao estado ainda mais anterior
        history.Undo(doc);
        // Exibe o conteúdo do documento após o segundo desfazer
        Console.WriteLine("Após o segundo desfazer: " + doc.Text);

        // Tenta desfazer novamente, o que pode não ter efeito se não houver mais estados anteriores
        history.Undo(doc);
    }

    private static void Observer() {
        // Cria o sujeito
        ConcreteSubject subject = new ConcreteSubject();

        // Cria observadores
        ConcreteObserverA observerA = new ConcreteObserverA("Observador A");
        ConcreteObserverB observerB = new ConcreteObserverB("Observador B");

        // Anexa os observadores ao sujeito
        subject.Attach(observerA);
        subject.Attach(observerB);

        // Altera o estado do sujeito
        subject.Message = "Primeira mensagem";

        // Desanexa um observador
        subject.Detach(observerA);

        // Altera o estado do sujeito novamente
        subject.Message = "Segunda mensagem";

        // Output esperado:
        // Observador A recebeu a mensagem: Primeira mensagem
        // Observador B recebeu a mensagem: Primeira mensagem
        // Observador B recebeu a mensagem: Segunda mensagem
    }

    private static void State()
    {
        // Configura o contexto com o estado inicial "Novo Pedido"
        OrderContext order = new OrderContext(new NewOrderState());

        // Faz a transição pelos estados do pedido
        order.NextState(); // De "Novo" para "Processando"
        order.NextState(); // De "Processando" para "Enviado"
        order.NextState(); // De "Enviado" para "Entregue"
        order.NextState(); // Permanece em "Entregue"

        // Output esperado:
        // Estado do pedido mudou para: NewOrderState
        // Novo pedido recebido. Mudando para estado 'Processando'.
        // Estado do pedido mudou para: ProcessingOrderState
        // Pedido está sendo processado. Mudando para estado 'Enviado'.
        // Estado do pedido mudou para: ShippedOrderState
        // Pedido foi enviado. Mudando para estado 'Entregue'.
        // Estado do pedido mudou para: DeliveredOrderState
        // Pedido foi entregue ao cliente.
    }
}