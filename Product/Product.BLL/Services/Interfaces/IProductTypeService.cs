using Product.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product.BLL.Services.Interfaces
{
    public interface IProductTypeService 
    {
        void Add(ProductTypeViewModel products);

        void Update(ProductTypeViewModel products);

        void Delete(ProductTypeViewModel products);

        ProductTypeViewModel GetById(int id);

        IQueryable<ProductTypeViewModel> GetAll();

        void SaveChange();
    }
}
