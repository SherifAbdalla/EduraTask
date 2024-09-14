using EduraTask.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Infrastructure
{
    internal class TransactionRepository : ITransactionRepository
    {
        private readonly EduraContext _context;
        public TransactionRepository(EduraContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<Transaction>> Get()
        {
            return await Task.FromResult(_context.Transactions.AsQueryable());
        }

        public async Task<decimal> RevenueByBranch(int branchId, DateOnly startDate, DateOnly endDate)
        {
                var revenueByBranch = await _context.Bookings
                .Where(x => x.BranchId == branchId && x.BookingDate >= startDate && x.BookingDate <= endDate)
                    .Join(_context.Transactions,
                          b => b.BookingId,
                          t => t.BookingId,
                          (b, t) => new { b.BranchId, t.Amount })
                    .Select(g => 
                        g.Amount
                    )
                    .SumAsync();
            return revenueByBranch;

        }

        public async Task<decimal> RevenueByPaymentMethod(string paymentMethod)
        {
            var revenueByPaymentMethod = await _context.Transactions
                .Where(x=>x.PaymentMethod == paymentMethod)
        .Select(g => 
            g.Amount
        )
        .SumAsync();
            return revenueByPaymentMethod;
        }

        public async Task<decimal> RevenueByService(int serviceId, DateOnly startDate, DateOnly endDate)
        {
            var revenueByService = await _context.BookingsService
                .Where(x => x.ServiceId == serviceId)
        .Join(_context.Bookings,
              bs => bs.BookingId,
              s => s.BookingId,
              (bs, s) => new { s.BookingDate, bs.Price })
        .Where(x => x.BookingDate >= startDate && x.BookingDate <= endDate)
        .Select(g =>

            g.Price
        )
        .SumAsync();

            return revenueByService;
        }
    }
}
