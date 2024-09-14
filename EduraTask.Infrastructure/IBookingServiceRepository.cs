using EduraTask.Domain;

namespace EduraTask.Infrastructure;

public interface IBookingServiceRepository
{
    Task<IQueryable<BookingService>> Get();
}
