using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.Core.DataProvider
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Table { get; }

        T GetById(object id);

        Task<T> GetByIdAsync(object id);

        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        T Insert(T entity);

        Task<T> InsertAsync(T entity);

        int InsertRange(IEnumerable<T> entities);

        Task<int> InsertRangeAsync(IEnumerable<T> entities);

        T Update(T entity);

        Task<T> UpdateAsync(T entity);

        int UpdateRange(IEnumerable<T> entities);

        Task<int> UpdateRangeAsync(IEnumerable<T> entities);

        int Delete(T entity);

        int Delete(object id);

        Task<int> DeleteAsync(T entity);

        Task<int> DeleteAsync(object id);
    }
}