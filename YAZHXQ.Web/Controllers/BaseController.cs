using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YAZHXQ.Web.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// 每页数据
        /// </summary>
        public const int PageSize = 10;
    }
}