public static class CreationalPatterns
{
    public static void Execute()
    {
        Console.WriteLine("\n Creational Patterns \n");
        FactoryMethod();
        AbstractFactory();
        Builder();
        Prototype();
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