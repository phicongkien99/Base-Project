using System;
using System.Collections.Generic;
using System.Text;

namespace Product.BLL
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
