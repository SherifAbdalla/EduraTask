using EduraTask.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Infrastructure
{
    internal class EduraContext : DbContext
    {
        public EduraContext(DbContextOptions<EduraContext> options) : base(options)
        { }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingService> BookingsService { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
