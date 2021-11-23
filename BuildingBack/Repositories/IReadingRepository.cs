using BuildingBack.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Repositories
{
    public interface IReadingRepository
    {
        Task<List<Reading>> GetDataAsync(int buildingId, int objectId, int dataFieldId, DateTime startDate, DateTime endDate);
    }
}
