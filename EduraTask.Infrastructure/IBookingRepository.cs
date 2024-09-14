using EduraTask.Domain;

namespace EduraTask.Infrastructure;

public interface IBookingRepository
{
    Task<IQueryable<Booking>> Get();
    Task<int> AppointmentsByServiceId(int serviceId, DateOnly startDate, DateOnly endDate);
    Task<int> AppointmentsByBranchId(int branchId, DateOnly startDate, DateOnly endDate);
    Task<int> AppointmentsByStatus(string status, DateOnly startDate, DateOnly endDate);
}
