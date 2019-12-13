using System;
using System.Collections.Generic;
using System.Text;
using YAZHXQ.Models.Models;

namespace YAZHXQ.Common
{
    public interface IRepositoryFactory
    {
        IRepository<T> CreateRepository<T>(YAXQZHYYContext mydbcontext) where T : class;
    }
}
