using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiilTabloOlusturma.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public ICollection<SuplierProduct> SuplierProducts { get; set; }
        public ProductDetails ProductDetails { get; set; }


    }
}
