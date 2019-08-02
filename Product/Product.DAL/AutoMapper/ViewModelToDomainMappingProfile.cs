using AutoMapper;
using Product.DAL.Entity;
using Product.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.DAL.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Products>()
                .ConstructUsing(p => new Products(p.Id, p.Name, p.TypeId, p.Price, p.Status));
        }
    }
}
