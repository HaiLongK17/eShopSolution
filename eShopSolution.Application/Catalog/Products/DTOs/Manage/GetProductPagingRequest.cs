using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Application.DTOs;

namespace eShopSolution.Application.Catalog.Products.DTOs.Manage
{
    public class GetProductPagingRequest:PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds{get;set;}
        
    }
}