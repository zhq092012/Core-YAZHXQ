using System;
using YAZHXQ.Common;

namespace YAZHXQ.IService
{
    public interface IBaseService
    {
        IRepository<T> CreateService<T>() where T : class, new();
    }
}
