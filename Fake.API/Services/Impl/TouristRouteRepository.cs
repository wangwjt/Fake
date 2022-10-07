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

        public IEnumerable<TouristRoute> GetAll(string keyword)
        {
            // 延迟执行 可以叠加查询条件
            IQueryable<TouristRoute> result =  _dbContext.TouristRoutes;
            // 非空判断
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.Trim();
                result = result.Where(t => t.Title == keyword);
            }
            // 执行.ToList()后，查询数据；具有相同功能的还有.FirstOrDefault();区别是一个返回列表、一个返回单个数据
            return result.ToList();
        }

        public TouristRoute GetTouristRoute(string id)
        {
            return _dbContext.TouristRoutes.FirstOrDefault(n => n.Id == id.ToString());
        }

        public void AddTouristRoute(TouristRoute param)
        {
            if (param == null)
            {
                throw new ArgumentNullException(nameof(param));
            }
            _dbContext.TouristRoutes.Add(param);
            _dbContext.SaveChanges();
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Delete(TouristRoute param)
        {
            _dbContext.Remove(param);
            _dbContext.SaveChanges();
        }
    }
}
