using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace LitService.Controllers
{
    [RoutePrefix("api/demo")]
    public class DemoController : BaseController
    {
        /// <summary>
        /// 测试API是否准备就绪
        /// </summary>
        /// <returns></returns>
        [Route("get")]
        [HttpGet]
        public ApiResult Get()
        {
            return ApiResult.OK();
        }
    }
}
