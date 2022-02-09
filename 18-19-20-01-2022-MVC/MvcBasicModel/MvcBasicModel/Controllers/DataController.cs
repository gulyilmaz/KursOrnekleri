using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasicModel.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Webmaster()
        {
            Master master = new Master();
            master.id = 1001;
            master.Ad = "gül";
            master.Soyad = "yılmaz";
            //  1.yol viewbag
            ViewBag.id = master.id;
            ViewBag.Ad = master.Ad;
            ViewBag.Soyad = master.Soyad;
            ViewBag.Master = master;

            //return View();
            //2.yol Model göndermek .Model demek datanın kendisi
            return View(master);
        }



        public ActionResult Personel()
        {
            List<Personel> plist = new List<Personel>();
            Personel p = new Personel();
            p.id = 1;
            p.Ad = "Sena";
            p.Soyad = "Mutlu";
            p.Maas = 5000;
            plist.Add(p);
            Personel p2 = new Personel();
            p2.id = 2;
            p2.Ad = "Eda";
            p2.Soyad = "Şahin";
            p2.Maas = 6000;
            plist.Add(p2);
            Personel p3 = new Personel();
            p3.id = 3;
            p3.Ad = "Mehmet";
            p3.Soyad = "Yılmaz";
            p3.Maas = 6000;
            plist.Add(p3);
            return View(plist);
        }
        public ActionResult Adres()
        {

            List<Adres> alist = new List<Adres>();
            Adres a = new Adres();
            a.ID = 34;
            a.sehirismi = "İstanbul";
            alist.Add(a);
            Adres a2 = new Adres();
            a2.ID = 35;
            a2.sehirismi = "İzmir";
            alist.Add(a2);
            Adres a3 = new Adres();
            a3.ID = 17;
            a3.sehirismi = "Çanakkale";
            alist.Add(a3);
            return View(alist);
        }
    }
}