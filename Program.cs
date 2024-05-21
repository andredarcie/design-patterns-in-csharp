namespace design_patterns_in_chsarp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreationalPatterns();
            StructuralPatterns();
            BehavioralPatterns();
        }

        public static void CreationalPatterns() {
            FactoryMethod();
            AbstractFactory();
            Builder();
            Prototype();
            CallSingleton();
        }

        public static void StructuralPatterns() {
            Adapter();
            Bridge();
            Composite();
            Decorator();
            Facade();
            Flyweight();
            Proxy();
        }

        public static void BehavioralPatterns() {
            ChainOfResponsibility();
        }

        private static void FactoryMethod() {
            Client.Start();
        }

        private static void AbstractFactory() {
            AbstractFactory factory = new MacFactory();
            IInput input = factory.CreateInput();
            ICheckbox checkbox = factory.CreateCheckbox();
            input.Paint();
            checkbox.Paint();
        }

        private static void Builder() {
            CarBuilder builder = new CarBuilder();
            CarDirector director = new CarDirector(builder);

            director.ConstructSportsCar();
            Car sportsCar = builder.GetResult();
            Console.WriteLine(sportsCar);

            director.ConstructSUV();
            Car suv = builder.GetResult();
            Console.WriteLine(suv);
        }

        private static void Prototype() {
            Robot originalRobot = new Robot("RX-101", 24);
            Robot clonedRobot = originalRobot.Clone();

            Console.WriteLine("Original: " + originalRobot);
            Console.WriteLine("Cloned: " + clonedRobot);
        }

        private static void CallSingleton() {
            // constructor is private
            // var obj = new Singleton();

            var obj = Singleton.Instance;

            obj.DoSomething();
        }

        private static void Adapter() {
            PayPal paypal = new PayPal();
            IPaymentProcessor paypalProcessor = new PayPalAdapter(paypal);
            paypalProcessor.ProcessPayment("100.00");

            Stripe stripe = new Stripe();
            IPaymentProcessor stripeProcessor = new StripeAdapter(stripe);
            stripeProcessor.ProcessPayment("50.00,USD");
        }

        private static void Bridge() {
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

        private static void Composite() {
            var mainPanel = new Panel("Main Panel");
            var subPanel = new Panel("Sub Panel");

            var okButton = new Button("OK Button");
            var cancelButton = new Button("Cancel Button");

            subPanel.AddComponent(okButton);
            subPanel.AddComponent(cancelButton);
            
            mainPanel.AddComponent(subPanel);

            mainPanel.Display();
        }

        private static void Decorator() {
            Subscription mySubscription = new BasicSubscription();
            Console.WriteLine($"{mySubscription.GetFeatures()} custa {mySubscription.GetCost():C}");

            mySubscription = new PremiumContent(mySubscription);
            mySubscription = new AdditionalDevices(mySubscription);
            Console.WriteLine($"{mySubscription.GetFeatures()} custa {mySubscription.GetCost():C}");
        }

        private static void Facade() {
            TravelFacade travelFacade = new TravelFacade();
            travelFacade.BookTravel(); // Facilita a reserva de todos os aspectos da viagem.
        }

        private static void Flyweight() {
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

        private static void Proxy() {
            IDatabase adminDatabase = new DatabaseProxy("Admin");
            adminDatabase.Query("SELECT * FROM Users");

            IDatabase userDatabase = new DatabaseProxy("User");
            userDatabase.Query("SELECT * FROM Users");
        }

        private static void ChainOfResponsibility() {
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
    }
}