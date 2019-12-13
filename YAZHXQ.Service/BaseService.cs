using System;
using YAZHXQ.Common;
using YAZHXQ.IService;
using YAZHXQ.Models.Models;

namespace YAZHXQ.Service
{
    public class BaseService : IBaseService
    {
        private IRepositoryFactory _repositoryFactory;
        private YAXQZHYYContext _context;

        public BaseService(IRepositoryFactory repositoryFactory, YAXQZHYYContext context)
        {
            _repositoryFactory = repositoryFactory;
            _context = context;
        }

        public IRepository<T> CreateService<T>() where T : class, new()
        {
            return _repositoryFactory.CreateRepository<T>(_context);
        }
    }
}
