using Fake.API.DataBase;
using Fake.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fake.API.Services.Impl
{
    public class TouristRouteRepository : ITouristRouteRepository
    {
        private readonly AppDBContext _dbContext;

        public TouristRouteRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TouristRoute> GetAll()
        {
            return _dbContext.TouristRoutes;
        }

        public TouristRoute GetTouristRoute(string id)
        {
            return _dbContext.TouristRoutes.FirstOrDefault(n => n.Id == id.ToString());
        }
    }
}
