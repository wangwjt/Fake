using Fake.API.Models;
using System;
using System.Collections.Generic;

namespace Fake.API.Services
{
    public class MockTouristRoute : ITouristRouteRepository
    {
        public IEnumerable<TouristRoute> GetAll()
        {
            List<TouristRoute> list = new List<TouristRoute>();
            list.Add(new TouristRoute(Guid.NewGuid(), "title", "描述", new Decimal(59.6468), 784.786786, DateTime.Now));
            list.Add(new TouristRoute(Guid.NewGuid(), "这是Title", "这是描述", new Decimal(25.4), 25.7, DateTime.Now));
            return list;
        }

        public TouristRoute GetTouristRoute(Guid id)
        {
            return new TouristRoute(Guid.NewGuid(), "这是Title", "这是描述", new Decimal(25.4), 25.7, DateTime.Now);
        }
    }
}
