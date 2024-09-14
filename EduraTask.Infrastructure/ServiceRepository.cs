using EduraTask.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Infrastructure
{
    internal class ServiceRepository : IServiceRepository
    {
        private readonly EduraContext _context;
        public ServiceRepository(EduraContext context)
        {
            _context = context;
        }
        public async Task<IQueryable<Service>> Get()
        {
            return await Task.FromResult(_context.Services.AsQueryable());
        }
    }
}
