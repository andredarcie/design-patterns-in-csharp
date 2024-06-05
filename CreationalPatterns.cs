public static class CreationalPatterns
{
    public static void Execute()
    {
        // Title
        Console.WriteLine("\n══════════════════════════════");
        Console.WriteLine("        Creational Patterns");
        Console.WriteLine("══════════════════════════════\n");

        // Factory Method
        Console.WriteLine("Factory Method:");
        Console.WriteLine("──────────────────────────");
        Console.WriteLine("  Creator → [FactoryMethod()]");
        Console.WriteLine("          → [Product]\n");

        FactoryMethod();

        // Abstract Factory
        Console.WriteLine("Abstract Factory:");
        Console.WriteLine("───────────────────────────");
        Console.WriteLine("  [AbstractFactory] → CreateProductA()");
        Console.WriteLine("                    → CreateProductB()");
        Console.WriteLine("  [ProductA]        [ProductB]\n");

        AbstractFactory();

        // Builder
        Console.WriteLine("Builder:");
        Console.WriteLine("─────────────");
        Console.WriteLine("  [Director] → Construct()");
        Console.WriteLine("              [Builder]");
        Console.WriteLine("              [Product]\n");

        Builder();

        // Prototype
        Console.WriteLine("Prototype:");
        Console.WriteLine("─────────────────────");
        Console.WriteLine("  [Prototype] → Clone()");
        Console.WriteLine("              [Clone]\n");

        Prototype();

        // Singleton
        Console.WriteLine("Singleton:");
        Console.WriteLine("───────────────");
        Console.WriteLine("  [Singleton]");
        Console.WriteLine("  GetInstance() → [Instance]\n");

        CallSingleton();
    }

    private static void FactoryMethod() 
    {
        Client.Start();
    }

    private static void AbstractFactory() 
    {
        AbstractFactory factory = new MacFactory();
        IInput input = factory.CreateInput();
        ICheckbox checkbox = factory.CreateCheckbox();
        input.Paint();
        checkbox.Paint();
    }

    private static void Builder() 
    {
        CarBuilder builder = new CarBuilder();
        CarDirector director = new CarDirector(builder);

        director.ConstructSportsCar();
        Car sportsCar = builder.GetResult();
        Console.WriteLine(sportsCar);

        director.ConstructSUV();
        Car suv = builder.GetResult();
        Console.WriteLine(suv);
    }

    private static void Prototype() 
    {
        Robot originalRobot = new Robot("RX-101", 24);
        Robot clonedRobot = originalRobot.Clone();

        Console.WriteLine("Original: " + originalRobot);
        Console.WriteLine("Cloned: " + clonedRobot);
    }

    private static void CallSingleton() 
    {
        var obj = Singleton.Instance;
        obj.DoSomething();
    }
}