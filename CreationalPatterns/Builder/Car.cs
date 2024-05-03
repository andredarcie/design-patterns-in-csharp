public class Car
{
    public string Engine { get; set; } = "";
    public int SeatCount { get; set; }
    public bool HasGPS { get; set; }
    public string Tyres { get; set; } = "";
    public string Color { get; set; } = "";

    public override string ToString()
    {
        return $"Engine: {Engine}, Seats: {SeatCount}, GPS: {HasGPS}, Tyres: {Tyres}, Color: {Color}";
    }
}