using CodeFirstKisiler.Models;
using CodeFirstKisiler.Models.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstKisiler.Controllers
{
    public class AdresController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: Adres
        public ActionResult Yeni()
        {
            List<SelectListItem> kisilerlist = db.Kisiler.Select(x => new SelectListItem { Text = x.Ad, Value = x.ID.ToString() }).ToList();
            TempData["Kisiler"] = kisilerlist;
            ViewBag.kisiler = kisilerlist;
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Adres adres)
        {
            Kisiler kisi = db.Kisiler.Where(x => x.ID == adres.KisiId).FirstOrDefault();
            if(kisi!=null)
            {
                adres.Kisiler = kisi;
                db.Adresler.Add(adres);
                int sonuc=db.SaveChanges();
                if(sonuc>0)
                {
                    ViewBag.Result = "Adres başarıyla eklenmiştir";
                    ViewBag.Status = "success";
                }
                else
                {
                    ViewBag.Result = "Adres eklenememiştir";
                    ViewBag.Status = "danger";

                }
                ViewBag.kisiler = TempData["Kisiler"];
                
            }
            return View();
        }
        public ActionResult Duzenle(int? adresid)
        {
            Adres adres = new Adres();
            if (adresid != null)
            {
                List<SelectListItem> kisilerlist = db.Kisiler.Select(x => new SelectListItem()
                {
                    Text = x.Ad,
                    Value = x.ID.ToString()
                }).ToList();

                TempData["kisiler"] = kisilerlist;
                ViewBag.kisiler = kisilerlist;
                adres = db.Adresler.Where(x => x.ID == adresid).FirstOrDefault();

            }
            return View(adres);
        }
        [HttpPost]
        public ActionResult Duzenle(Adres model, int? adresid)
        {
            Kisiler kisi = db.Kisiler.Where(x => x.ID == model.KisiId).FirstOrDefault();
            Adres adres = db.Adresler.Where(x => x.ID == adresid).FirstOrDefault();

            if(kisi!=null)
            {
                adres.Kisiler = kisi;
                adres.AdresTanim = model.AdresTanim;
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    ViewBag.Result = "Adres başarıyla güncellenmiştir";
                    ViewBag.Status = "success";
                }
                else
                {
                    ViewBag.Result = "Adres güncellenememiştir";
                    ViewBag.Status = "danger";

                }
                ViewBag.kisiler = TempData["Kisiler"];


            }
            return View();

        }
        public ActionResult Sil(int? adresid)
        {
            Adres adres = new Adres();
            if (adresid != null)
            {
                adres = db.Adresler.Where(x => x.ID == adresid).FirstOrDefault();
                adres.Kisiler = db.Kisiler.Where(x => x.ID == adres.KisiId).FirstOrDefault();
            }
            return View(adres);
        }
        [HttpPost,ActionName("Sil")]
        public ActionResult SilOk(int? adresid)
        {
            Adres adres = new Adres();
            if (adresid != null)
            {
                adres = db.Adresler.Where(x => x.ID == adresid).FirstOrDefault();
                db.Adresler.Remove(adres);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }


    }

}