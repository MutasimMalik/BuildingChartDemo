using BuildingBack.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Repositories
{
    public interface IObjectRepository
    {
        Task<List<Object>> GetObjectsAsync();
    }
}
