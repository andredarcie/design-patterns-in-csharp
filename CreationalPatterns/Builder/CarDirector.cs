public class CarDirector
{
    private ICarBuilder _builder;

    public CarDirector(ICarBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructSportsCar()
    {
        _builder.BuildEngine("V8");
        _builder.BuildSeats(2);
        _builder.BuildGPS(true);
        _builder.BuildTyres("Sport");
        _builder.PaintColor("Red");
    }

    public void ConstructSUV()
    {
        _builder.BuildEngine("V6");
        _builder.BuildSeats(8);
        _builder.BuildGPS(true);
        _builder.BuildTyres("Off-road");
        _builder.PaintColor("Black");
    }
}