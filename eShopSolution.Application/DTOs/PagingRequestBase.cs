using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.Application.DTOs
{
    public class PagingRequestBase
    {
        public int pageIndex { get; set; }
        
        public int pageSize { get; set; }
        
        
    }
}