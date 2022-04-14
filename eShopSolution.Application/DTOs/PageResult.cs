using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.Application.DTOs
{
    public class PageResult<T>
    {
        public List<T>Items{get; set;}
        public int TotalRecord { get; set; }
        
        
    }
}