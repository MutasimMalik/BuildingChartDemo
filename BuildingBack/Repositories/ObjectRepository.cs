using BuildingBack.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Repositories
{
    public class ObjectRepository : IObjectRepository
    {
        private readonly BuildingDbContext _context;

        public ObjectRepository(BuildingDbContext context)
        {
            _context = context;
        }

        public async Task<List<Object>> GetObjectsAsync()
        {
            return await _context.Object.ToListAsync();
        }
    }
}
