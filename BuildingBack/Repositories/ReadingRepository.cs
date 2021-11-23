using BuildingBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingBack.Repositories
{
    public class ReadingRepository : IReadingRepository
    {
        private readonly BuildingDbContext _context;

        public ReadingRepository(BuildingDbContext context)
        {
            _context = context;
        }

        public async Task<List<Reading>> GetDataAsync(int buildingId,
                                                int objectId,
                                                int dataFieldId,
                                                DateTime startDate,
                                                DateTime endDate)
        {
            var result = await _context.Reading.Where(x => x.TimeStamp >= startDate && x.TimeStamp <= endDate
                                    &&    (buildingId == 0 || x.BuildingId == buildingId)
                                    && (dataFieldId == 0 || x.DataFieldId == dataFieldId)
                                    && (objectId == 0 || x.ObjectId == objectId)).ToListAsync();

            return result;
        }
    }
}
