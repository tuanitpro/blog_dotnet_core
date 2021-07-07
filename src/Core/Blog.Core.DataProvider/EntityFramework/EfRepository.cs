using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blog.Core.DataProvider.EntityFramework
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext dbContext;

        public EfRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public virtual IQueryable<T> Table => dbContext.Set<T>();

        public virtual int Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            return dbContext.SaveChanges();
        }

        public virtual int Delete(object id)
        {
            var entity = GetById(id);
            return Delete(entity);
        }

        public virtual async Task<int> DeleteAsync(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            return await dbContext.SaveChangesAsync();
        }

        public virtual async Task<int> DeleteAsync(object id)
        {
            var entity = await GetByIdAsync(id);
            return await DeleteAsync(entity);
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public virtual T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public virtual T Insert(T entity)
        {
            dbContext.Set<T>().Add(entity);
            dbContext.SaveChanges();

            return entity;
        }

        public virtual async Task<T> InsertAsync(T entity)
        {
            dbContext.Set<T>().Add(entity);
            await dbContext.SaveChangesAsync();

            return entity;
        }

        public virtual int InsertRange(IEnumerable<T> entities)
        {
            dbContext.Set<T>().AddRange(entities);
            return dbContext.SaveChanges();
        }

        public virtual async Task<int> InsertRangeAsync(IEnumerable<T> entities)
        {
            dbContext.Set<T>().AddRange(entities);
            return await dbContext.SaveChangesAsync();
        }

        public virtual T Update(T entity)
        {
            dbContext.Set<T>().Update(entity);
            dbContext.SaveChanges();
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            dbContext.Set<T>().Update(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual int UpdateRange(IEnumerable<T> entities)
        {
            dbContext.Set<T>().UpdateRange(entities);
            return dbContext.SaveChanges();
        }

        public virtual async Task<int> UpdateRangeAsync(IEnumerable<T> entities)
        {
            dbContext.Set<T>().UpdateRange(entities);
            return await dbContext.SaveChangesAsync();
        }
    }
}