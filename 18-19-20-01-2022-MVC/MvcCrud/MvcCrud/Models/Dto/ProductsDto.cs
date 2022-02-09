using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCrud.Models.Dto
{
    public class ProductsDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }

    }
}