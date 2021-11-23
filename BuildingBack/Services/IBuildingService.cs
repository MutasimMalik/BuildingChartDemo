using BuildingBack.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Services
{
    public interface IBuildingService
    {
        Task<List<BuildingDto>> GetBuildingsAsync();
    }
}
