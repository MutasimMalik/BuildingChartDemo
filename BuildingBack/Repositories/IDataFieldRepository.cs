using BuildingBack.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Repositories
{
    public interface IDataFieldRepository
    {
        Task<List<DataField>> GetDataFieldsAsync();
    }
}
