public class Robot : IPrototype<Robot>
{
    public string Model { get; set; }
    public int BatteryLife { get; set; }

    public Robot(string model, int batteryLife)
    {
        Model = model;
        BatteryLife = batteryLife;
    }

    public Robot Clone()
    {
        return new Robot(Model, BatteryLife);
    }

    public override string ToString()
    {
        return $"Robot Model: {Model}, Battery Life: {BatteryLife} hours";
    }
}