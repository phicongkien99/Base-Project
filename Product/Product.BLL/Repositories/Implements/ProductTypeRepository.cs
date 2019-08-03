using Product.BLL.Repositories.Interfaces;
using Product.DAL;
using Product.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.BLL.Repositories.Implements
{
    public class ProductTypeRepository : BaseRepository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(ProductContext context) : base(context)
        {

        }
    }
}
