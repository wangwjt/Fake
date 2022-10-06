using Fake.API.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Fake.API.Services
{
    public interface ITouristRouteRepository
    {
        // 获取所有
        IEnumerable<TouristRoute> GetAll(string keyword);

        // 获取单个
        TouristRoute GetTouristRoute(string id);
    }
}
