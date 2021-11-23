using BuildingBack.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Repositories
{
    public class DataFiledRepository : IDataFieldRepository
    {
        private readonly BuildingDbContext _context;

        public DataFiledRepository(BuildingDbContext context)
        {
            _context = context;
        }

        public async Task<List<DataField>> GetDataFieldsAsync()
        {
            return await _context.DataField.ToListAsync();
        }
    }
}
