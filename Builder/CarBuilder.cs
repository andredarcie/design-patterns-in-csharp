public class CarBuilder : ICarBuilder
{
    private Car _car = new Car();

    public void BuildEngine(string type)
    {
        _car.Engine = type;
    }

    public void BuildSeats(int number)
    {
        _car.SeatCount = number;
    }

    public void BuildGPS(bool hasGPS)
    {
        _car.HasGPS = hasGPS;
    }

    public void BuildTyres(string type)
    {
        _car.Tyres = type;
    }

    public void PaintColor(string color)
    {
        _car.Color = color;
    }

    public Car GetResult()
    {
        Car result = _car;
        _car = new Car(); // Reset for the next building process
        return result;
    }
}