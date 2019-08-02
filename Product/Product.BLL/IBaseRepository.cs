using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.BLL
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

        //Task<IQueryable<T>> FindByAsync(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Delete(T entity);

        void Edit(T entity);

        T GetById(int id);

        T GetByCondition(Expression<Func<T, bool>> predicate);

        //Task<T> GetAsync(Guid id);

        //Task<T> GetAsync(Expression<Func<T, bool>> predicate);

        //Task<bool> IsExistsAsync(Expression<Func<T, bool>> predicate);

        //Task<bool> IsExistsAsync(Guid id);
    }
}
