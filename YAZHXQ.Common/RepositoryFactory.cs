using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using YAZHXQ.Models.Models;

namespace YAZHXQ.Common
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IRepository<T> CreateRepository<T>(DbContext mydbcontext) where T : class
        {
            return new Repository<T>(mydbcontext);
        }
    }
}
