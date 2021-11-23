using AutoMapper;
using BuildingBack.DTOs;
using BuildingBack.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly IMapper _mapper;

        public BuildingService(IBuildingRepository buildingRepository, IMapper mapper)
        {
            _buildingRepository = buildingRepository;
            _mapper = mapper;
        }

        public async Task<List<BuildingDto>> GetBuildingsAsync()
        {
            var buildingData = await _buildingRepository.GetBuildingsAsync();
            return _mapper.Map<List<BuildingDto>>(buildingData);
        }
    }
}
