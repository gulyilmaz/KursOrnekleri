using CodeFirstKisiler.Filters;
using CodeFirstKisiler.Models;
using CodeFirstKisiler.Models.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstKisiler.Controllers
{
    public class KisiController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: Kisi
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Kisiler kisi)
        {
            db.Kisiler.Add(kisi);
           int sonuc= db.SaveChanges();
            if (sonuc > 0)
            {
                ViewBag.Result = "Kişi başarıyla eklendi";
                ViewBag.Status = "success";

            }
            else
            {
                ViewBag.Result = "Kişi eklenememiştir";
                ViewBag.Status = "danger";
            }
            return View();

        }
        [AutFilter]
        public ActionResult Duzenle(int? kisiid)
        {
            Kisiler kisi = new Kisiler();
            if (kisiid != null)
            {
                kisi = db.Kisiler.Where(x => x.ID == kisiid).FirstOrDefault();
            }
            return View(kisi);
        }
        [HttpPost]
        public ActionResult Duzenle(Kisiler model,int? kisiid)
        {Kisiler kisi=db.Kisiler.Where(x => x.ID == kisiid).FirstOrDefault();
            if (kisi != null)
            {
                kisi.Ad = model.Ad;
                kisi.Soyad = model.Soyad;
                kisi.Yas = model.Yas;
             int sonuc=  db.SaveChanges();
                if (sonuc > 0)
                {
                    ViewBag.Result = "Kişi güncellenmiştir";
                    ViewBag.Status = "success";
                }
                else
                {
                    ViewBag.Result = "Kişi güncellenememiştir";
                    ViewBag.Status = "danger";

                }
                
            }
            return View();

        }

        public ActionResult Sil(int? kisiid)
        {
            Kisiler kisi = new Kisiler();

            if(kisiid!=null)
            {
                kisi = db.Kisiler.Where(x => x.ID == kisiid).FirstOrDefault();
               
            }
            return View(kisi);
        }
        [HttpPost,ActionName("Sil")]
        public ActionResult SilOk(int? kisiid)
        {

            Kisiler kisi = new Kisiler();

            if (kisiid != null)
            {
                kisi = db.Kisiler.Where(x => x.ID == kisiid).FirstOrDefault();
                db.Kisiler.Remove(kisi);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }

    }
}