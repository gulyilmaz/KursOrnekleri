using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCategories.Models
{
    public class ProductsModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        //public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CompanyName { get; set; }
        //public string Description { get; set; }
        //public int EmployeeId { get; set; }
        //public string Firstname { get; set; }
        //public string LastName { get; set; }
        //public string Adress { get; set; }
    }
}