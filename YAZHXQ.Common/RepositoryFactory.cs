using System;
using System.Collections.Generic;
using System.Text;
using YAZHXQ.Models.Models;

namespace YAZHXQ.Common
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IRepository<T> CreateRepository<T>(YAXQZHYYContext mydbcontext) where T : class
        {
            return new Repository<T>(mydbcontext);
        }
    }
}
