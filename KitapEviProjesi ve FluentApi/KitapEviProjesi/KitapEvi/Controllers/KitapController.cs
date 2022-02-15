using KitapEvi_DataAcces.Data;
using KitapEvi_Models.Models;
using KitapEvi_Models.Models.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapEvi.Controllers
{
    public class KitapController : Controller
    {
        private readonly KitapEviContext _db;
        public KitapController(KitapEviContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //List<Kitap> klist = _db.Kitaplar.ToList();
            //foreach (var item in klist)
            //{//uygulanır ama verimli değil.Her bir kitap kaydı için sürekli sorgu atar daha hızlı olması için explicitloading kullanıyorum 
            //    item.Yayinevi = _db.YayinEvleri.FirstOrDefault(x => x.YayineviID == item.YayineviID);

            //}
            List<Kitap> klist = _db.Kitaplar.Include(x => x.Yayinevi).ToList();
            //ilgili alanlara innerjoin yaparak getitir.
            //foreach (var item in klist)
            //{
            //    item.Kategori = _db.Kategoriler.FirstOrDefault(x => x.KategoriID == item.KategoriID);
            //}
            klist = _db.Kitaplar.Include(x => x.Kategori).ToList();
            return View(klist);
        }
        public IActionResult Update_Insert(int? id)
        {
            KitapVM obj = new KitapVM();
            obj.Yayinevilistesi = _db.YayinEvleri.Select(x => new SelectListItem
            {
                Text = x.YayinEviAdi,
                Value = x.YayineviID.ToString()
            }) ;
            obj.KategoriListesi = _db.Kategoriler.Select(x => new SelectListItem
            {
                Text = x.KategoriAd,
                Value = x.KategoriID.ToString()
            });
            if(id==null)
            {
                return View(obj);
            }
            //duzenleme
            obj.Kitap = _db.Kitaplar.FirstOrDefault(x => x.KitapID == id);
            if(obj==null)
            {
                return NotFound();
            }
            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update_Insert(KitapVM obj)
        {
            if (obj.Kitap.KitapID == 0)
            {
                _db.Kitaplar.Add(obj.Kitap);
            }
            else
            {
                _db.Kitaplar.Update(obj.Kitap);
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var obj = _db.Kitaplar.FirstOrDefault(x => x.KitapID == id);
            _db.Kitaplar.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Detaylar(int? id)
        {
            KitapVM obj = new KitapVM();
            if (id == null)
            {
                return View(obj);
            }
            //düzenleme
            obj.Kitap = _db.Kitaplar.FirstOrDefault(x => x.KitapID == id);
            obj.Kitap.KitapDetay = _db.KitapDetaylar.FirstOrDefault(x => x.KitapID == id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);                                       


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Detaylar(KitapVM obj)
        {
            if(obj.Kitap.KitapDetay.KitapDetayID==0)
            {
                //create
                var kitapdb = _db.Kitaplar.FirstOrDefault(x => x.KitapID == obj.Kitap.KitapID);
                obj.Kitap.KitapDetay.KitapID = kitapdb.KitapID;
                _db.KitapDetaylar.Add(obj.Kitap.KitapDetay);
                _db.SaveChanges();
               
                kitapdb.KitapDetayID = obj.Kitap.KitapDetay.KitapDetayID;
                _db.SaveChanges();
            }
            else
            {
                //update

                var kitap = _db.Kitaplar.FirstOrDefault(x => x.KitapID == obj.Kitap.KitapID);
                obj.Kitap.KitapDetay.KitapID = kitap.KitapID;
                _db.KitapDetaylar.Update(obj.Kitap.KitapDetay);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
