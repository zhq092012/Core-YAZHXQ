using System.Collections.Generic;
using System.Linq;
using YAZHXQ.Common;
using YAZHXQ.IService;
using YAZHXQ.Models.Models;

namespace YAZHXQ.Service
{
    public class StaffInfoService : BaseService<StaffInfo>, IStaffInfoService
    {
        public StaffInfoService(IRepositoryFactory repositoryFactory, YAXQZHYYContext context) : base(repositoryFactory, context)
        {
           
        }
        public List<StaffInfo> GetALL()
        {
            return _repository.GetAll().ToList();
        }
    }
}
