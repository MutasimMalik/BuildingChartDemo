using BuildingBack.Models;
using BuildingBack.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Services
{
    public class ObjectService : IObjectService
    {
        private readonly IObjectRepository _objectRepository;

        public ObjectService(IObjectRepository objectRepository)
        {
            _objectRepository = objectRepository;
        }

        public async Task<List<Object>> GetObjectsAsync()
        {
            return await _objectRepository.GetObjectsAsync();
        }
    }
}
