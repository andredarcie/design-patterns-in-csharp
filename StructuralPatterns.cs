public static class StructuralPatterns
{
    public static void Execute()
    {
        Console.WriteLine("\n Structural Patterns \n");
        Adapter();
        Bridge();
        Composite();
        Decorator();
        Facade();
        Flyweight();
        Proxy();
    }

    private static void Adapter() 
    {
        PayPal paypal = new PayPal();
        IPaymentProcessor paypalProcessor = new PayPalAdapter(paypal);
        paypalProcessor.ProcessPayment("100.00");

        Stripe stripe = new Stripe();
        IPaymentProcessor stripeProcessor = new StripeAdapter(stripe);
        stripeProcessor.ProcessPayment("50.00,USD");
    }

    private static void Bridge() 
    {
        IDevice tv = new TV();
        RemoteControl remote = new RemoteControl(tv);
        remote.TogglePower();
        remote.SetChannel(3);
        remote.VolumeUp();

        IDevice radio = new Radio();
        RemoteControl radioRemote = new RemoteControl(radio);
        radioRemote.TogglePower();
        radioRemote.SetChannel(88);
        radioRemote.VolumeDown();
    }

    private static void Composite() 
    {
        var mainPanel = new Panel("Main Panel");
        var subPanel = new Panel("Sub Panel");

        var okButton = new Button("OK Button");
        var cancelButton = new Button("Cancel Button");

        subPanel.AddComponent(okButton);
        subPanel.AddComponent(cancelButton);
        
        mainPanel.AddComponent(subPanel);

        mainPanel.Display();
    }

    private static void Decorator() 
    {
        Subscription mySubscription = new BasicSubscription();
        Console.WriteLine($"{mySubscription.GetFeatures()} custa {mySubscription.GetCost():C}");

        mySubscription = new PremiumContent(mySubscription);
        mySubscription = new AdditionalDevices(mySubscription);
        Console.WriteLine($"{mySubscription.GetFeatures()} custa {mySubscription.GetCost():C}");
    }

    private static void Facade() 
    {
        TravelFacade travelFacade = new TravelFacade();
        travelFacade.BookTravel();
    }

    private static void Flyweight() 
    {
        ChessBoard board = new();

        board.PlacePiece(0, 0, "White", "Rook");
        board.PlacePiece(0, 1, "White", "Knight");
        board.PlacePiece(0, 2, "White", "Bishop");
        board.PlacePiece(0, 3, "White", "Queen");
        board.PlacePiece(0, 4, "White", "King");
        board.PlacePiece(0, 5, "White", "Bishop"); // Usa instância já criada
        board.PlacePiece(0, 6, "White", "Knight"); // Usa instância já criada
        board.PlacePiece(0, 7, "White", "Rook"); // Usa instância já criada

        board.PlacePiece(7, 0, "Black", "Rook");
        board.PlacePiece(7, 1, "Black", "Knight");
        board.PlacePiece(7, 2, "Black", "Bishop");
        board.PlacePiece(7, 3, "Black", "Queen");
        board.PlacePiece(7, 4, "Black", "King");
        board.PlacePiece(7, 5, "Black", "Bishop"); // Usa instância já criada
        board.PlacePiece(7, 6, "Black", "Knight"); // Usa instância já criada
        board.PlacePiece(7, 7, "Black", "Rook"); // Usa instância já criada

        board.Display();
    }

    private static void Proxy() 
    {
        IDatabase adminDatabase = new DatabaseProxy("Admin");
        adminDatabase.Query("SELECT * FROM Users");

        IDatabase userDatabase = new DatabaseProxy("User");
        userDatabase.Query("SELECT * FROM Users");
    }
}