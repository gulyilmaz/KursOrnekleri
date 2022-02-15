using KitapEvi_DataAcces.Data;
using KitapEvi_Models.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapEvi.Controllers
{
    public class YazarController : Controller
    {
        private readonly KitapEviContext _db;
        public YazarController(KitapEviContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            List<Yazar> ylist = _db.Yazarlar.ToList();
            return View(ylist);
        }
        public IActionResult Update_Insert(int? id)
        {//view yok
            Yazar obj = new Yazar();
            if (id == null)
            {
                return View(obj);
            }
            obj = _db.Yazarlar.FirstOrDefault(x => x.YazarID == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update_Insert(Yazar obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.YazarID == 0)
                {
                    //create
                    _db.Yazarlar.Add(obj);
                }
                else
                {
                    //update
                    _db.Yazarlar.Update(obj);

                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int id)
        {
            var obj = _db.Yazarlar.FirstOrDefault(x => x.YazarID == id);
            _db.Yazarlar.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
