using System.ComponentModel.DataAnnotations.Schema;

namespace EduraTask.Domain;

public class Client
{
    public int ClientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public DateOnly Birthdate { get; set; }

    public ICollection<Booking> Bookings { get; set; }

}

public class ClientResult
{
    public int ClientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public DateOnly Birthdate { get; set; }
    public string BookingName { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}
