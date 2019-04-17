using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VehicleTrading.Core.Contracts.Services;

namespace VehicleTrading.Website.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        private readonly ICarMakeService _carMakeService;

        public ApiController(ICarMakeService carMakeService) => _carMakeService = carMakeService;

        [HttpGet("carmakes")]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetAllCarMakes() => Ok(await _carMakeService.GetAllIdsAndNamesAsync());
    }
}