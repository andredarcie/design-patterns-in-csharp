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
        IMediator chatMediator = new ChatMediator();

        ChatUser user1 = new ConcreteChatUser("Alice");
        ChatUser user2 = new ConcreteChatUser("Bob");
        ChatUser user3 = new ConcreteChatUser("Charlie");

        chatMediator.RegisterUser(user1);
        chatMediator.RegisterUser(user2);
        chatMediator.RegisterUser(user3);

        user1.Send("Hello, everyone!");
        user2.Send("Hi Alice!");
        user3.Send("Hey Alice and Bob!");
    }
}