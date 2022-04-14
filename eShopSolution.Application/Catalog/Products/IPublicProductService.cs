using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Application.Catalog.Products.DTOs.Manage;
using eShopSolution.Application.DTOs;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PageResult<ProductViewModel>GetAllByCategoryId(GetProductPagingRequest request);
    }
}