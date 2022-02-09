using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workingwithmodel.Models
{
    public class ProductModel
    {
        public int productId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}