using Microsoft.AspNetCore.Mvc;
using MyGuide.BLL.Models;
using MyGuide.BLL.Services;

namespace MyGuide_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public async Task<ActionResult<CityModel>> GetCityData()
        {
            return _cityService.GetCityData();
        }
    }
}
