using EduraTask.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Application
{
    internal class AppointmentsByServiceReportHandler : IRequestHandler<AppointmentsByServiceReportCommand, int>
    {
        private readonly IBookingRepository _repository;

        public AppointmentsByServiceReportHandler(IBookingRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(AppointmentsByServiceReportCommand request, CancellationToken cancellationToken)
        {
            return await _repository.AppointmentsByServiceId(request.ServiceId, DateOnly.FromDateTime(request.StartDate), DateOnly.FromDateTime(request.EndDate));
        }
    }
}
