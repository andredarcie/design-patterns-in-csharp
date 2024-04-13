public interface ICarBuilder
{
    void BuildEngine(string type);
    void BuildSeats(int number);
    void BuildGPS(bool hasGPS);
    void BuildTyres(string type);
    void PaintColor(string color);
    Car GetResult();
}