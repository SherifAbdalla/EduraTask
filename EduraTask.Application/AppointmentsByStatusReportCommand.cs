using MediatR;

namespace EduraTask.Application;

public record AppointmentsByStatusReportCommand(string Status, DateTime StartDate, DateTime EndDate) : IRequest<int>
{
}
