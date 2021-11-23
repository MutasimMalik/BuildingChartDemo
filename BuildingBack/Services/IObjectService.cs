using BuildingBack.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBack.Services
{
    public interface IObjectService
    {
        Task<List<Object>> GetObjectsAsync();
    }
}
