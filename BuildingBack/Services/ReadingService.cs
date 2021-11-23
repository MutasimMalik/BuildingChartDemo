using AutoMapper;
using BuildingBack.DTOs;
using BuildingBack.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Services
{
    public class ReadingService : IReadingService
    {
        private readonly IReadingRepository _readingRepository;
        private readonly IMapper _mapper;

        public ReadingService(IReadingRepository readingRepository, IMapper mapper)
        {
            _readingRepository = readingRepository;
            _mapper = mapper;
        }

        public async Task<List<ReadingDto>> GetDataAsync(int buildingId,
                                                int objectId,
                                                int dataFieldId,
                                                DateTime startDate,
                                                DateTime endDate)
        {
            var readingData = await _readingRepository.GetDataAsync(buildingId, objectId, dataFieldId, startDate, endDate);
            return _mapper.Map<List<ReadingDto>>(readingData);
        }
    }
}
