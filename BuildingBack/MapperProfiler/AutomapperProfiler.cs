using AutoMapper;
using BuildingBack.DTOs;
using BuildingBack.Models;

namespace BuildingBack.MapperProfiler
{
    public class AutomapperProfiler : Profile
    {
        public AutomapperProfiler()
        {
            CreateMap<Reading, ReadingDto>().ReverseMap();
            CreateMap<Building, BuildingDto>().ReverseMap();
        }
    }
}
