using MediatR;

namespace EduraTask.Application;

public record RevenueByBranchReportCommand(int BranchId, DateTime StartDate, DateTime EndDate) : IRequest<decimal>
{
}
