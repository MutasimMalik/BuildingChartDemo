using BuildingBack.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BuildingBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectController : ControllerBase
    {
        private readonly IObjectService _objectService;

        public ObjectController(IObjectService objectService)
        {
            _objectService = objectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetObjectsAsync()
        {
            return Ok(await _objectService.GetObjectsAsync());
        }
    }
}
