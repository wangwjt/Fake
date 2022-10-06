using Fake.API.Models;
using System;
using System.Collections.Generic;

namespace Fake.API.Services
{
    public class MockTouristRoute : ITouristRouteRepository
    {
        public IEnumerable<TouristRoute> GetAll(string keyword)
        {
            List<TouristRoute> list = new List<TouristRoute>();
            list.Add(new TouristRoute(Guid.NewGuid().ToString(), "title", "描述", new Decimal(59.6468), 7786786, DateTime.Now));
            list.Add(new TouristRoute(Guid.NewGuid().ToString(), "这是Title", "这是描述", new Decimal(25.4), 257, DateTime.Now));
            return list;
        }

        public TouristRoute GetTouristRoute(string id)
        {
            return new TouristRoute(Guid.NewGuid().ToString(), "这是Title", "这是描述", new Decimal(25.4), 257, DateTime.Now);
        }
    }
}
