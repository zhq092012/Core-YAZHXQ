using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
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

        public IQueryable<StaffInfo> GetALL()
        {
            return _repository.GetAll();
        }
        /// <summary>
        /// 异步获取列表
        /// </summary>
        /// <returns></returns>
        public Task<List<StaffInfo>> GetALLAsync()
        {
            return _repository.GetALLAsync();
        }
        public Task<int> AddAsync(StaffInfo entity)
        {
            return _repository.AddAsync(entity);
        }

        public Task<int> DeleteAsync(StaffInfo entity)
        {
            return _repository.DeleteAsync(entity);
        }

        public Task<StaffInfo> FindAsync(params object[] keyValues)
        {
            return _repository.FindAsync(keyValues);
        }

        public Task<StaffInfo> FirstOrDefaultAsync(Expression<Func<StaffInfo, bool>> where)
        {
            return _repository.FirstOrDefaultAsync(where);
        }

        public Task<int> UpdateAsync(StaffInfo entity)
        {
            return _repository.UpdateAsync(entity);
        }

        public bool Any(Expression<Func<StaffInfo, bool>> where)
        {
            return _repository.Any(where);
        }
    }
}
