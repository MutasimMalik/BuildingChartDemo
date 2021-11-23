using BuildingBack.Models;
using BuildingBack.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Services
{
    public class DataFieldService : IDataFieldService
    {
        private readonly IDataFieldRepository _dataFieldRepository;

        public DataFieldService(IDataFieldRepository dataFieldRepository)
        {
            _dataFieldRepository = dataFieldRepository;
        }

        public async Task<List<DataField>> GetDataFieldsAsync()
        {
            return await _dataFieldRepository.GetDataFieldsAsync();
        }
    }
}
