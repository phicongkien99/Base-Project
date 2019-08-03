using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Product.BLL.Services.Interfaces;
using Product.Common;
using Product.DAL.ViewModels;

namespace Product.Views.Controllers
{

    public class ProductAPIController : ControllerBase
    {

        private readonly IProductService _productService;
        private readonly IProductTypeService _productTypeService;
        //private readonly IConfiguration _configuration;

        public ProductAPIController(IProductService productService, IProductTypeService productTypeService /*, IConfiguration configuration*/)
        {
            _productService = productService;
            _productTypeService = productTypeService;
            //_configuration = configuration;
        }

        [HttpGet("api/getAllProduct")]
        public JToken Get()
        {
            List<ProductViewModel> listProduct = _productService.GetAll().ToList();
            setTypeName(listProduct);
            return JToken.FromObject(listProduct);
        }

        private List<ProductViewModel> setTypeName(List<ProductViewModel> listProduct)
        {
            List<ProductTypeViewModel> listProdcutType = _productTypeService.GetAll().ToList();

            foreach (var product in listProduct)
            {
                foreach (var prodcutType in listProdcutType)
                {
                    if (compareTypeId(product, prodcutType))
                    {
                        product.TypeName = prodcutType.Name;
                        break;
                    }
                }
            }

            return listProduct;
        }

        private bool compareTypeId(ProductViewModel productViewModel, ProductTypeViewModel productTypeViewModel)
        {
            if (productViewModel.TypeId == productTypeViewModel.Id)
            {
                return true;
            }
            return false;
        }
    }
}