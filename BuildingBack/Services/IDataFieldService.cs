using BuildingBack.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Services
{
    public interface IDataFieldService
    {
        Task<List<DataField>> GetDataFieldsAsync();
    }
}
