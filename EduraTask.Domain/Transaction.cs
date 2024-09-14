namespace EduraTask.Domain;

public class Transaction
{
    public int TransactionId { get; set; }
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; }
    public DateOnly PaymentDate { get; set; }

    public int BookingId { get; set; }
    public Booking Booking { get; set; }
}
