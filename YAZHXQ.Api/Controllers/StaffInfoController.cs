using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YAZHXQ.IService;

namespace YAZHXQ.Api.Controllers
{
    [Route("api/staffinfo")]
    [ApiController]
    public class StaffInfoController : ControllerBase
    {
        private IStaffInfoService StaffInfoService { get; set; }

        public StaffInfoController(IStaffInfoService staffInfoService)
        {
            StaffInfoService = staffInfoService;
        }


        /// <summary>
        /// 获取所有人员信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public ActionResult<IEnumerable<string>> Get()
        {
            var staffList = this.StaffInfoService.GetALL();
            return new JsonResult(staffList);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
