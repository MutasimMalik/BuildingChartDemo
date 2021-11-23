using BuildingBack.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingBack.Repositories
{
    public class BuildingRepository : IBuildingRepository
    {
        private readonly BuildingDbContext _context;

        public BuildingRepository(BuildingDbContext context)
        {
            _context = context;
        }

        public async Task<List<Building>> GetBuildingsAsync()
        {
            return await _context.Building.ToListAsync();
        }
    }
}
