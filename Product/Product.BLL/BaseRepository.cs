using Microsoft.EntityFrameworkCore;
using Product.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.BLL
{
    public class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : class
    {
        ProductContext _context;

        public BaseRepository(ProductContext context)
        {
            _context = context;
        }
        public virtual void Add(T entity)
        {
            _context.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public virtual void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public virtual void Edit(T entity)
        {
            _context.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).AsQueryable();
        }

        //public virtual Task<IQueryable<T>> FindByAsync(Expression<Func<T, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        public virtual T GetById(int id)
        {
            if (id > 0)
            {
                return _context.Set<T>().Find(id);
            }
            return null;
        }

        public virtual T GetByCondition(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public virtual IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items = items.Include(includeProperty);
                }
            }
            return items;
        }

        //public virtual Task<T> GetAsync(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual Task<bool> IsExistsAsync(Expression<Func<T, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual Task<bool> IsExistsAsync(Guid id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
