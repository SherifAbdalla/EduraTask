using EduraTask.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Infrastructure
{
    internal class ClientRepository : IClientRepository
    {
        private readonly EduraContext _context;
        public ClientRepository(EduraContext context) { _context = context; }

        public async Task<IQueryable<ClientResult>> Get()
        {
            var currentYear = DateTime.Now.Year;
            var clients = _context.Clients
                .Join(_context.Bookings,
              b => b.ClientId,
              c => c.ClientId,
              (c, b) => new { b.BookingId, c.Gender, c.FirstName, c.LastName, c.Birthdate, c.City })
        .Join(_context.Branches,
              bc => bc.BookingId,
              br => br.BranchId,
              (bc, br) => new { br.Name, bc.Gender, bc.FirstName, bc.LastName, bc.Birthdate, bc.City })
                .Select(c => new ClientResult
                {
                FirstName = c.FirstName,
                LastName = c.LastName,
                Age = currentYear - c.Birthdate.Year,
                Gender = c.Gender,
                BookingName = c.Name,
                City = c.City
            }).AsQueryable();
            return await Task.FromResult(clients);
        }

    }
}
