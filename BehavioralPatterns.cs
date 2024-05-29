public static class BehavioralPatterns
{
    public static void Execute()
    {
        Console.WriteLine("\n Behavioral Patterns \n");
        ChainOfResponsibility();
        Command();
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

        // Execute some commands
        var insertCommand1 = new InsertTextCommand(document, "Hello ");
        var insertCommand2 = new InsertTextCommand(document, "World!");

        commandManager.ExecuteCommand(insertCommand1);
        commandManager.ExecuteCommand(insertCommand2);

        // Undo the last command
        commandManager.Undo();

        // Redo the last command
        commandManager.Redo();
    }
}