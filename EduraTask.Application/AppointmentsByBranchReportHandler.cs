using EduraTask.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Application
{
    internal class AppointmentsByBranchReportHandler : IRequestHandler<AppointmentsByBranchReportCommand, int>
    {
        private readonly IBookingRepository _repository;

        public AppointmentsByBranchReportHandler(IBookingRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(AppointmentsByBranchReportCommand request, CancellationToken cancellationToken)
        {
            return await _repository.AppointmentsByBranchId(request.BranchId, DateOnly.FromDateTime(request.StartDate),  DateOnly.FromDateTime(request.EndDate));
        }
    }
}
