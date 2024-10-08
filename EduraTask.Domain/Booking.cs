﻿namespace EduraTask.Domain;

public class Booking
{
    public int BookingId { get; set; }
    public DateOnly BookingDate { get; set; }
    public TimeOnly BookingTime { get; set; }
    public string Status { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; }
    public int BranchId { get; set; }
    public Branch Branch { get; set; }

    public ICollection<BookingService> BookingServices { get; set; }
    public ICollection<Transaction> Transactions { get; set; }
}
