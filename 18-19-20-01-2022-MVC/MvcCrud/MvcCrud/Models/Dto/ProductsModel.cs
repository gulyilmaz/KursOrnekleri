using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCrud.Models.Dto
{
    public class ProductsModel
    {
        public List<ProductsDto> plist { get; set; }
        public Products Products { get; set; }
        public List<SelectListItem> CategoriesForDropDown { get; set; }
        public List<SelectListItem> SupliersForDropDown { get; set; }
    }
}