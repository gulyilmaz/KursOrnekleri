using sinav.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinav.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        sinavdbEntities db = new sinavdbEntities();
        public ActionResult Detay(int id)
        {
            ProductsModelView p = new ProductsModelView();
            p.Klist = db.Kategori.ToList();
            p.Urunler=db.Urunler.Find(id);
            ViewBag.kategori = p.Urunler.Kategori.KategoriAd;
            return View(p);
        }
        public ActionResult Guncel(int id)
        {
            ProductsModelView p = new ProductsModelView();
            p.Urunler = db.Urunler.Find(id);
            p.Kategoriler = db.Kategori.Find(p.Urunler.KategoriId);
            p.KategoriForDropdown = DoldurCatDrop();
            return View(p);

        }
        [HttpPost]
        public ActionResult Guncel(int id, ProductsModelView p)
        {
            //Urunler secProduct =db.Urunler.Find(id);
            //Kategori seckategori = db.Kategori.Find(secProduct.KategoriId);
            ////secProduct.UrunId = p.Urunler.UrunId;
            //secProduct.UrunAd = p.Urunler.UrunAd;
            //secProduct.UrunResim = p.Urunler.UrunResim;
            //secProduct.Kategori.KategoriId = seckategori.KategoriId;
            //secProduct.KategoriId = p.Urunler.KategoriId;
            
            //db.Entry(p.Urunler).State = EntityState.Modified;
            ////db.Entry(p.Kategoriler).State = EntityState.Modified;

            //db.SaveChanges();
            return View();

        }
        private List<SelectListItem> DoldurCatDrop()
        {
            return db.Kategori.Select(x => new SelectListItem() { Text = x.KategoriAd, Value = x.KategoriId.ToString() }).ToList();
        }

    }
}