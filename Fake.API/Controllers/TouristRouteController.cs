using Fake.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Fake.API.Controllers
{
    [Route("tourist_route/all")]
    [ApiController]
    public class TouristRouteController : ControllerBase
    {

        private ITouristRouteRepository _touristRouteRepository;

        // 通过构造函数，注入 Repository
        public TouristRouteController(ITouristRouteRepository touristRouteRepository)
        {
            _touristRouteRepository = touristRouteRepository;
        }

        [HttpGet]
        public IActionResult GetAllTouristRoute()
        {
            IEnumerable<Models.TouristRoute> data = _touristRouteRepository.GetAll();
            return Ok(data);
        }



    }
}
