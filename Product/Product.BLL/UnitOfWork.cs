using Product.DAL;
using System;

namespace Product.BLL
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProductContext _context;
        public UnitOfWork(ProductContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
