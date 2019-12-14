using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using YAZHXQ.Models.Models;

namespace YAZHXQ.Common
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _context;
        private readonly DbSet<T> _dbSet;
        private readonly string _connStr;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
            _connStr = _context.Database.GetDbConnection().ConnectionString;
        }
        public IQueryable<T> Entities => this._dbSet.AsNoTracking();
        public IQueryable<T> TrackEntities => this._dbSet;
        public T Add(T entity, bool isSave = true)
        {
            this._dbSet.Add(entity);
            if (isSave)
            {
                this.SaveChanges();
            }
            return entity;
        }
        public bool AddRange(IEnumerable<T> entitys, bool isSave = true)
        {
            this._dbSet.AddRange(entitys);
            if (isSave)
            {
                return this.SaveChanges() > 0;
            }
            return false;
        }
        public bool Any(Expression<Func<T, bool>> @where)
        {
            return this._dbSet.AsNoTracking().Any(@where);
        }
        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified)
        {
            if (_context.Database.CurrentTransaction == null)
            {
                _context.Database.BeginTransaction(isolationLevel);
            }
        }
        public void Commit()
        {
            var transaction = _context.Database.CurrentTransaction;
            if (transaction != null)
            {
                try
                {
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        public int Count()
        {
            return this._dbSet.AsNoTracking().Count();
        }
        public int Count(Expression<Func<T, bool>> @where)
        {
            return this._dbSet.AsNoTracking().Count(@where);
        }
        public bool Delete(T entity, bool isSave = true)
        {
            this._dbSet.Remove(entity);
            if (isSave)
            {
                return this.SaveChanges() > 0;
            }
            return false;
        }
        public bool Delete(bool isSave = false, params T[] entitys)
        {
            this._dbSet.RemoveRange(entitys);
            if (isSave)
            {
                return this.SaveChanges() > 0;
            }
            return false;
        }
        public bool Delete(object id, bool isSave = true)
        {
            this._dbSet.Remove(this._dbSet.Find(id));
            if (isSave)
            {
                return this.SaveChanges() > 0;
            }
            return false;
        }
        public bool Delete(Expression<Func<T, bool>> @where, bool isSave = true)
        {
            T[] entitys = this._dbSet.Where(@where).ToArray();
            if (entitys.Length > 0)
            {
                this._dbSet.RemoveRange(entitys);
            }
            if (isSave)
            {
                return this.SaveChanges() > 0;
            }
            return false;
        }
        public void Dispose()
        {
            this._context.Dispose();
        }
        public IQueryable<T> Distinct(Expression<Func<T, bool>> @where)
        {
            return this._dbSet.AsNoTracking().Where(@where).Distinct();
        }
        public T FirstOrDefault(Expression<Func<T, bool>> @where)
        {
            return this._dbSet.AsNoTracking().FirstOrDefault(@where);
        }
        public T FirstOrDefault<TOrder>(Expression<Func<T, bool>> @where, Expression<Func<T, TOrder>> order, bool isDesc = false)
        {
            if (isDesc)
            {
                return this._dbSet.AsNoTracking().OrderByDescending(order).FirstOrDefault(@where);
            }
            else
            {
                return this._dbSet.AsNoTracking().OrderBy(order).FirstOrDefault(@where);
            }
        }
        public IQueryable<T> GetAll()
        {
            return this._dbSet.AsNoTracking();
        }
        public IQueryable<T> GetAll<TOrder>(Expression<Func<T, TOrder>> order, bool isDesc = false)
        {
            if (isDesc)
            {
                return this._dbSet.AsNoTracking().OrderByDescending(order);
            }
            return this._dbSet.AsNoTracking().OrderBy(order);
        }
        public T GetById<Ttype>(Ttype id)
        {
            return this._dbSet.Find(id);
        }
        public Ttype Max<Ttype>(Expression<Func<T, Ttype>> column)
        {
            if (this._dbSet.AsNoTracking().Any())
            {
                return this._dbSet.AsNoTracking().Max<T, Ttype>(column);
            }
            return default(Ttype);
        }
        public Ttype Max<Ttype>(Expression<Func<T, Ttype>> column, Expression<Func<T, bool>> @where)
        {
            if (this._dbSet.AsNoTracking().Any(@where))
            {
                return this._dbSet.AsNoTracking().Where(@where).Max<T, Ttype>(column);
            }
            return default(Ttype);
        }
        public Ttype Min<Ttype>(Expression<Func<T, Ttype>> column)
        {
            if (this._dbSet.AsNoTracking().Any())
            {
                return this._dbSet.AsNoTracking().Min<T, Ttype>(column);
            }
            return default(Ttype);
        }
        public Ttype Min<Ttype>(Expression<Func<T, Ttype>> column, Expression<Func<T, bool>> where)
        {
            if (this._dbSet.AsNoTracking().Any(@where))
            {
                return this._dbSet.AsNoTracking().Where(@where).Min<T, Ttype>(column);
            }
            return default(Ttype);
        }
        public void Rollback()
        {
            if (_context.Database.CurrentTransaction != null)
            {
                _context.Database.CurrentTransaction.Rollback();
            }
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
        public TType Sum<TType>(Expression<Func<T, TType>> selector, Expression<Func<T, bool>> where) where TType : new()
        {
            object result = 0;
            if (new TType().GetType() == typeof(decimal))
            {
                result = this._dbSet.AsNoTracking().Where(where).Sum(selector as Expression<Func<T, decimal>>);
            }
            if (new TType().GetType() == typeof(decimal?))
            {
                result = this._dbSet.AsNoTracking().Where(where).Sum(selector as Expression<Func<T, decimal?>>);
            }
            if (new TType().GetType() == typeof(double))
            {
                result = this._dbSet.AsNoTracking().Where(where).Sum(selector as Expression<Func<T, double>>);
            }
            if (new TType().GetType() == typeof(double?))
            {
                result = this._dbSet.AsNoTracking().Where(where).Sum(selector as Expression<Func<T, double?>>);
            }
            if (new TType().GetType() == typeof(float))
            {
                result = this._dbSet.AsNoTracking().Where(where).Sum(selector as Expression<Func<T, float>>);
            }
            if (new TType().GetType() == typeof(float?))
            {
                result = this._dbSet.AsNoTracking().Where(where).Sum(selector as Expression<Func<T, float?>>);
            }
            if (new TType().GetType() == typeof(int))
            {
                result = this._dbSet.AsNoTracking().Where(where).Sum(selector as Expression<Func<T, int>>);
            }
            if (new TType().GetType() == typeof(int?))
            {
                result = this._dbSet.AsNoTracking().Where(where).Sum(selector as Expression<Func<T, int?>>);
            }
            if (new TType().GetType() == typeof(long))
            {
                result = this._dbSet.AsNoTracking().Where(where).Sum(selector as Expression<Func<T, long>>);
            }
            if (new TType().GetType() == typeof(long?))
            {
                result = this._dbSet.AsNoTracking().Where(where).Sum(selector as Expression<Func<T, long?>>);
            }
            return (TType)result;
        }
        public bool Update(T entity, bool isSave = true)
        {
            var entry = this._context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                entry.State = EntityState.Modified;
            }
            if (isSave)
            {
                return this.SaveChanges() > 0;
            }
            return false;
        }
        public bool Update(bool isSave = true, params T[] entitys)
        {
            var entrys = this._context.Entry(entitys);
            if (entrys.State == EntityState.Detached)
            {
                entrys.State = EntityState.Modified;
            }
            if (isSave)
            {
                return this.SaveChanges() > 0;
            }
            return false;
        }
        public IQueryable<T> Where(Expression<Func<T, bool>> @where)
        {
            return this._dbSet.Where(@where);
        }
        public IQueryable<T> Where<TOrder>(Expression<Func<T, bool>> @where, Expression<Func<T, TOrder>> order, bool isDesc = false)
        {
            if (isDesc)
            {
                return this._dbSet.Where(@where).OrderByDescending(order);
            }
            return this._dbSet.Where(@where).OrderBy(order);
        }
        public IEnumerable<T> Where<TOrder>(Func<T, bool> where, Func<T, TOrder> order, int pageIndex, int pageSize, out int count, bool isDesc = false)
        {
            count = Count();
            if (isDesc)
            {
                return this._dbSet.Where(@where).OrderByDescending(order).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            return this._dbSet.Where(@where).OrderBy(order).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
        public IQueryable<T> Where<TOrder>(Expression<Func<T, bool>> where, Expression<Func<T, TOrder>> order, int pageIndex, int pageSize, out int count, bool isDesc = false)
        {
            count = Count();
            if (isDesc)
            {
                return this._dbSet.Where(@where).OrderByDescending(order).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            return this._dbSet.Where(@where).OrderBy(order).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
    }
}
