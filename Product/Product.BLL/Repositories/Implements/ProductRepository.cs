using Product.BLL.Repositories.Interfaces;
using Product.DAL;
using Product.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.BLL.Repositories.Implements
{
    public class ProductRepository : BaseRepository<Products>, IProductRepository 
    {
        public ProductRepository(ProductContext context) : base(context)
        {

        }
    }
}
