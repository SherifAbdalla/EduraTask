using EduraTask.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Infrastructure
{
    internal class BranchRepository : IBranchRepository
    {
        private readonly EduraContext _context;
        public BranchRepository(EduraContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<Branch>> Get()
        {
            return await Task.FromResult(_context.Branches.AsQueryable());
        }
    }
}
