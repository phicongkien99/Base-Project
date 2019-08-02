using AutoMapper;
using Product.DAL.Entity;
using Product.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.DAL.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Products, ProductViewModel>();
        }
    }
}
