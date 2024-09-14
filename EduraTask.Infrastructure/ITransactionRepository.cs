using EduraTask.Domain;

namespace EduraTask.Infrastructure;

public interface ITransactionRepository
{
    Task<IQueryable<Transaction>> Get();
    Task<decimal> RevenueByService(int serviceId, DateOnly startDate, DateOnly endDate);
    Task<decimal> RevenueByBranch(int branchId, DateOnly startDate, DateOnly endDate);
    Task<decimal> RevenueByPaymentMethod(string paymentMethod);
}
