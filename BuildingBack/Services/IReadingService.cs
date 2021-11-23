
using BuildingBack.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Services
{
    public interface IReadingService
    {
        Task<List<ReadingDto>> GetDataAsync(int buildingId, int objectId, int dataFieldId, DateTime startDate, DateTime endDate);
    }
}
