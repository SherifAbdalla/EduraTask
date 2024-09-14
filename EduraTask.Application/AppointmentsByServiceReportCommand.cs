using MediatR;

namespace EduraTask.Application;

public record AppointmentsByServiceReportCommand(int ServiceId, DateTime StartDate, DateTime EndDate) : IRequest<int>
{
}
