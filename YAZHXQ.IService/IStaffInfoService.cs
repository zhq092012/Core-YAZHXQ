using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YAZHXQ.Models.Models;

namespace YAZHXQ.IService
{
    public interface IStaffInfoService
    {
         IQueryable<StaffInfo> GetALL();
        /// <summary>
        /// 异步获取实体列表
        /// </summary>
        /// <returns></returns>
        Task<List<StaffInfo>> GetALLAsync();
        /// <summary>
        /// 异步获取第一个符合条件的实体
        /// </summary>
        /// <returns></returns>
        Task<StaffInfo> FirstOrDefaultAsync(Expression<Func<StaffInfo, bool>> @where);
        /// <summary>
        /// 异步添加实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> AddAsync(StaffInfo entity);
        /// <summary>
        /// 异步查找第一个符合条件的实体
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        Task<StaffInfo> FindAsync(params object[] keyValues);
        /// <summary>
        /// 异步更新实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> UpdateAsync(StaffInfo entity);
        /// <summary>
        /// 异步删除实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> DeleteAsync(StaffInfo entity);
        /// <summary>
        /// 判断是否满足条件
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        bool Any(Expression<Func<StaffInfo, bool>> @where);
    }
}
