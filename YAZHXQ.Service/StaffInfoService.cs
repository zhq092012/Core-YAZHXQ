using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YAZHXQ.Common;
using YAZHXQ.IService;
using YAZHXQ.Models.Models;

namespace YAZHXQ.Service
{
    public class StaffInfoService : BaseService,IStaffInfoService
    {
        public StaffInfoService(IRepositoryFactory repositoryFactory, YAXQZHYYContext context) : base(repositoryFactory, context)
        {
        }

        public List<StaffInfo> GetALL()
        {
            var service = this.CreateService<StaffInfo>();
            return service.GetAll().ToList();
        }
    }
}
