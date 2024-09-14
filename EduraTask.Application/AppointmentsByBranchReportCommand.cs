using MediatR;

namespace EduraTask.Application;

public record AppointmentsByBranchReportCommand(int BranchId, DateTime StartDate, DateTime EndDate) : IRequest<int>
{
}
