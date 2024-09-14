using EduraTask.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Application
{
    internal class AppointmentsByStatusReportHandler : IRequestHandler<AppointmentsByStatusReportCommand, int>
    {
        private readonly IBookingRepository _repository;

        public AppointmentsByStatusReportHandler(IBookingRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(AppointmentsByStatusReportCommand request, CancellationToken cancellationToken)
        {
            return await _repository.AppointmentsByStatus(request.Status, DateOnly.FromDateTime(request.StartDate), DateOnly.FromDateTime(request.EndDate));
        }
    }
}
