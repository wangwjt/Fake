

using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace Fake.API.Controllers
{
    // 添加路由
    [Route("test1")]
    [Controller]
    public class ShoudongController : Controller
    {
        // 为该路由添加一个get方法
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "aaa","bbb"};
        }
    }
}
