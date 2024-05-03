using System;
using System.Net;

namespace design_patterns_in_chsarp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreationalPatterns();
            StructuralPatterns();
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
    }
}