class Client
{
    public static void Start()
    {
        TestButtonClick(new WebCanvas());
        TestButtonClick(new MobileCanvas());
    }

    public static void TestButtonClick(AbstractCanvas canvas)
    {
        Console.WriteLine($"{canvas.OnClick()}");
    }
}