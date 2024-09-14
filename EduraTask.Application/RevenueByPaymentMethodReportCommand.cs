using MediatR;

namespace EduraTask.Application;

public record RevenueByPaymentMethodReportCommand(string PaymentMethod) : IRequest<decimal>
{
}
