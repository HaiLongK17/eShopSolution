using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Application.DTOs;

namespace eShopSolution.Application.Catalog.Products.DTOs.Public
{
    public class GetProductPagingRequest:PagingRequestBase
    {
           public int CategoryId { get; set; }    
    }
}