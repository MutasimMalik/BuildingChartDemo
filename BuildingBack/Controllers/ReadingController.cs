using BuildingBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BuildingBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadingController : ControllerBase
    {
        private readonly IReadingService _readingService;

        public ReadingController(IReadingService readingService)
        {
            _readingService = readingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDataAsync(int buildingId, int objectId, int dataFieldId, DateTime startDate, DateTime endDate)
        {
            return Ok(await _readingService.GetDataAsync(buildingId, objectId, dataFieldId, startDate, endDate));
        }
    }
}
