using EduraTask.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Infrastructure
{
    internal class BookingRepository : IBookingRepository
    {
        private readonly EduraContext _context;
        public BookingRepository(EduraContext context)
        {
            _context = context;
        }

        public async Task<int> AppointmentsByBranchId(int branchId, DateOnly startDate, DateOnly endDate)
        {
            var appointmentsByBranch = await _context.Bookings
                .Where(x => x.BranchId == branchId && x.BookingDate >= startDate && x.BookingDate <= endDate)
        .CountAsync();
            return appointmentsByBranch;
        }

        public async Task<int> AppointmentsByServiceId(int serviceId, DateOnly startDate, DateOnly endDate)
        {
            var appointmentsByService = await _context.BookingsService
                .Join(_context.Bookings,
                  bs => bs.BookingId,
                  b => b.BookingId,
                  (bs, b) => new { bs.ServiceId, b.BookingDate, b.BranchId, bs.Price })
                .Where(x => x.ServiceId == serviceId && x.BookingDate >= startDate && x.BookingDate <= endDate)

        .CountAsync();
            return appointmentsByService;
        }

        public async Task<int> AppointmentsByStatus(string status, DateOnly startDate, DateOnly endDate)
        {
            var appointmentsByStatus = await _context.Bookings
                .Where (x => x.Status == status && x.BookingDate >= startDate && x.BookingDate <= endDate)
        .CountAsync();
            return appointmentsByStatus;
        }

        public async Task<IQueryable<Booking>> Get()
        {
            return await Task.FromResult(_context.Bookings.AsQueryable());
        }
    }
}
