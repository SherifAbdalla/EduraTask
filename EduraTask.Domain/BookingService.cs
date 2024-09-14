namespace EduraTask.Domain;

public class BookingService
{
    public int BookingServiceId { get; set; }
    public decimal Price { get; set; }

    public int BookingId { get; set; }
    public Booking Booking { get; set; }
    public int ServiceId { get; set; }
    public Service Service { get; set; }
}
