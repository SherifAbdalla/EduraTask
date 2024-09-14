using EduraTask.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Application
{
    internal class RevenueByBranchReportHandler : IRequestHandler<RevenueByBranchReportCommand, decimal>
    {
        private readonly ITransactionRepository _repository;

        public RevenueByBranchReportHandler(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<decimal> Handle(RevenueByBranchReportCommand request, CancellationToken cancellationToken)
        {
            return await _repository.RevenueByBranch(request.BranchId, DateOnly.FromDateTime(request.StartDate), DateOnly.FromDateTime(request.EndDate));
        }
    }
}
