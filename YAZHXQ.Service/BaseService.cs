using System;
using Microsoft.EntityFrameworkCore;
using YAZHXQ.Common;
using YAZHXQ.IService;
using YAZHXQ.Models.Models;

namespace YAZHXQ.Service
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private IRepositoryFactory _repositoryFactory;
        private DbContext _context;
        protected IRepository<T> _repository;

        public BaseService(IRepositoryFactory repositoryFactory, DbContext context)
        {
            _repositoryFactory = repositoryFactory;
            _context = context;
            _repository = _repositoryFactory.CreateRepository<T>(_context);
        }
    }
}
