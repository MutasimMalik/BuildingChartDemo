using BuildingBack.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BuildingBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataFieldController : ControllerBase
    {
        private readonly IDataFieldService _dataFieldService;

        public DataFieldController(IDataFieldService dataFieldService)
        {
            _dataFieldService = dataFieldService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDataFieldsAsyc()
        {
            return Ok(await _dataFieldService.GetDataFieldsAsync());
        }
    }
}
