using MediatR;

namespace EduraTask.Application;

public record RevenueByServiceReportCommand(int ServiceId, DateTime StartDate, DateTime EndDate) : IRequest<decimal>
{
}
