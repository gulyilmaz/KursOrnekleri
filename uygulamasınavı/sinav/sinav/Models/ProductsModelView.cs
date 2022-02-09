using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinav.Models
{
    public class ProductsModelView
    {
        public Urunler Urunler { get; set; }
        public List<Urunler> Ulist { get; set; }
        public Kategori Kategoriler { get; set; }
        public List<Kategori> Klist { get; set; }
        public List<Hakkimizda > Hlist { get; set; }
        public Hakkimizda hakkimizda { get; set; }
        public ozellik ozellik { get; set; }
        public List<ozellik> Olist { get; set; }
        public tarihce tarihce { get; set; }
        public List<SelectListItem> KategoriForDropdown { get; set; }
    }
}