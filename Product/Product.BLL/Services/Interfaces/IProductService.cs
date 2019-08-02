using Product.DAL.Entity;
using Product.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product.BLL.Services.Interfaces
{
    public interface IProductService 
    {
        void Add(ProductViewModel products);

        void Update(ProductViewModel products);

        void Delete(ProductViewModel products);

        ProductViewModel GetById(int id);
    
        IQueryable<ProductViewModel> GetAll();

        void SaveChange();
    }
}
