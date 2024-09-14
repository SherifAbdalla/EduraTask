using EduraTask.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Application
{
    internal class RevenueByPaymentMethodReportHandler : IRequestHandler<RevenueByPaymentMethodReportCommand, decimal>
    {
        private readonly ITransactionRepository _repository;

        public RevenueByPaymentMethodReportHandler(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<decimal> Handle(RevenueByPaymentMethodReportCommand request, CancellationToken cancellationToken)
        {
            return await _repository.RevenueByPaymentMethod(request.PaymentMethod);
        }
    }
}
