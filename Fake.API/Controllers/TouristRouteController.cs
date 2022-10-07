using Fake.API.Dto;
using Fake.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using System.Collections;
using Fake.API.Models;

namespace Fake.API.Controllers
{
    [Route("tourist_route/all")]
    [ApiController]
    public class TouristRouteController : ControllerBase
    {

        private ITouristRouteRepository _touristRouteRepository;
        private readonly IMapper _autoMapper;       // 私有变量 下划线开头

        // 通过构造函数，注入 Repository
        public TouristRouteController(ITouristRouteRepository touristRouteRepository, IMapper autoMapper)
        {
            _touristRouteRepository = touristRouteRepository;
            _autoMapper = autoMapper;
        }

        [HttpGet]
        public IActionResult GetAllTouristRoute([FromQuery(Name = "keyword")] string keyword)
        {
            IEnumerable<Models.TouristRoute> data = _touristRouteRepository.GetAll(keyword);
            IEnumerable<TouristRouteDTO> result = _autoMapper.Map<IEnumerable<TouristRouteDTO>>(data);
            return Ok(result); // Ok():代表http状态码200
        }

        [HttpGet("{id}")]  // tourist_route/all/{id}
        public IActionResult GetTouristRouteById(string id)
        {
            Models.TouristRoute touristRoute = _touristRouteRepository.GetTouristRoute(id);
            if (touristRoute == null)
            {
                string msg = $"数据不存在{id}";
                return Ok(msg);
            }

            /*            TouristRouteDTO result = new TouristRouteDTO()
                        {
                            Id = touristRoute.Id,
                            Title = touristRoute.Title,
                            Desc = touristRoute.Desc,
                            CreateTime = touristRoute.CreateTime.ToString(),
                        };*/

            TouristRouteDTO touristRouteDTO = _autoMapper.Map<TouristRouteDTO>(touristRoute);
            return Ok(touristRouteDTO);
        }

        [HttpPost]
        public IActionResult AddToTouristRoute([FromBody] AddTouristRouteDTO param)
        {
            TouristRoute touristRoute = _autoMapper.Map<TouristRoute>(param);
            _touristRouteRepository.AddTouristRoute(touristRoute);
            return Ok("OK");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTouristRoute([FromRoute(Name ="id")] string id, [FromBody] UpdateTouristRouteDTO param)
        {
            Models.TouristRoute touristRoute = _touristRouteRepository.GetTouristRoute(id);
            if (touristRoute == null)
            {
                string msg = $"数据不存在{id}，更新失败";
                return Ok(msg);
            }
            _autoMapper.Map(param, touristRoute);
            _touristRouteRepository.Save();

            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Del([FromRoute(Name ="id")] string id)
        {
            Models.TouristRoute touristRoute = _touristRouteRepository.GetTouristRoute(id);
            if (touristRoute == null)
            {
                string msg = $"数据不存在{id}，删除失败";
                return Ok(msg);
            }
            _touristRouteRepository.Delete(touristRoute);
            return Ok("OK");
        }
    }
}
