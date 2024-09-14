using EduraTask.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Application
{
    internal class CustomerDemographicsReportHandler : IRequestHandler<CustomerDemographicsReportCommand, IEnumerable<CustomerDemographicsReportResult>>
    {
        private readonly IClientRepository _repository;

        public CustomerDemographicsReportHandler(IClientRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<CustomerDemographicsReportResult>> Handle(CustomerDemographicsReportCommand request, CancellationToken cancellationToken)
        {
            var clients = await _repository.Get();

            return clients.Select(c => new CustomerDemographicsReportResult() { Age = c.Age, FirstName = c.FirstName, LastName = c.LastName, Gender = c.Gender, BookingName = c.BookingName, City = c.City }).AsEnumerable();
        }
    }
}
