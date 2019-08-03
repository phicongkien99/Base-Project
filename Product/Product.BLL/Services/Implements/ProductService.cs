using AutoMapper;
using Product.BLL.Repositories.Interfaces;
using Product.BLL.Services.Interfaces;
using Product.DAL.Entity;
using Product.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product.BLL.Services.Implements
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(ProductViewModel products)
        {
            var model = _mapper.Map<ProductViewModel, Products>(products);
            _productRepository.Add(model);
        }

        public void Update(ProductViewModel products)
        {
            var model = _mapper.Map<ProductViewModel, Products>(products);
            _productRepository.Edit(model);
        }

        public void Delete(ProductViewModel products)
        {
            var model = _mapper.Map<ProductViewModel, Products>(products);
            _productRepository.Delete(model);
        }

        public IQueryable<ProductViewModel> GetAll()
        {
            var listModel = _productRepository.GetAll();
            return _mapper.ProjectTo<ProductViewModel>(listModel);
        }

        public ProductViewModel GetById(int id)
        {
            var model = _productRepository.GetById(id);
            return _mapper.Map<Products, ProductViewModel>(model);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }
        
    }
}
