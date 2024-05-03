public class TravelFacade
{
    private FlightBooking flightBooking;
    private HotelBooking hotelBooking;
    private CarRental carRental;

    public TravelFacade()
    {
        flightBooking = new FlightBooking();
        hotelBooking = new HotelBooking();
        carRental = new CarRental();
    }

    public void BookTravel()
    {
        flightBooking.BookFlight();
        hotelBooking.BookRoom();
        carRental.RentCar();
        Console.WriteLine("Todas as reservas de viagem foram concluídas.");
    }
}