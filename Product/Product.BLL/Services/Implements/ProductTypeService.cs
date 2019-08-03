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
    public class ProductTypeService : IProductTypeService
    {
        private readonly IProductTypeRepository _productTypeRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductTypeService(IProductTypeRepository productTypeRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _productTypeRepository = productTypeRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(ProductTypeViewModel productTypeViewModel)
        {
            var model = _mapper.Map<ProductTypeViewModel, ProductType>(productTypeViewModel);
            _productTypeRepository.Add(model);
        }

        public void Delete(ProductTypeViewModel productTypeViewModel)
        {
            var model = _mapper.Map<ProductTypeViewModel, ProductType>(productTypeViewModel);
            _productTypeRepository.Delete(model);
        }

        public void Update(ProductTypeViewModel productTypeViewModel)
        {
            var model = _mapper.Map<ProductTypeViewModel, ProductType>(productTypeViewModel);
            _productTypeRepository.Edit(model);
        }

        public IQueryable<ProductTypeViewModel> GetAll()
        {
            var listModel = _productTypeRepository.GetAll();
            return _mapper.ProjectTo<ProductTypeViewModel>(listModel);
        }

        public ProductTypeViewModel GetById(int id)
        {
            var model = _productTypeRepository.GetById(id);
            return _mapper.Map<ProductType, ProductTypeViewModel>(model);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

    }
}
