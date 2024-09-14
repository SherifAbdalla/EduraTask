using EduraTask.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Application
{
    internal class RevenueByServiceReportHandler : IRequestHandler<RevenueByServiceReportCommand, decimal>
    {
        private readonly ITransactionRepository _repository;

        public RevenueByServiceReportHandler(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<decimal> Handle(RevenueByServiceReportCommand request, CancellationToken cancellationToken)
        {
            return await _repository.RevenueByService(request.ServiceId, DateOnly.FromDateTime(request.StartDate), DateOnly.FromDateTime(request.EndDate));
        }
    }
}
