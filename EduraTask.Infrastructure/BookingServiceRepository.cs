using EduraTask.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Infrastructure
{
    internal class BookingServiceRepository : IBookingServiceRepository
    {
        private readonly EduraContext _context;
        public BookingServiceRepository(EduraContext context)
        {
            _context = context;
        }
        public async Task<IQueryable<BookingService>> Get()
        {
            return await Task.FromResult(_context.BookingsService.AsQueryable());
        }
    }
}
