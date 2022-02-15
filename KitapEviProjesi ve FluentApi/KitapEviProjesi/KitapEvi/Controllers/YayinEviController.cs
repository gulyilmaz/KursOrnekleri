using KitapEvi_DataAcces.Data;
using KitapEvi_Models.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapEvi.Controllers
{
    public class YayinEviController : Controller
    {
        private readonly KitapEviContext _db;
        public YayinEviController(KitapEviContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            List<Yayinevi> objlist = _db.YayinEvleri.ToList();
            return View(objlist);
        }
        public IActionResult Update_Insert(int? id)
        {
            Yayinevi obj = new Yayinevi();
            if (id == null)
            {
                return View(obj);
            }
            obj = _db.YayinEvleri.FirstOrDefault(x => x.YayineviID == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update_Insert(Yayinevi obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.YayineviID == 0)
                {
                    //create
                    _db.YayinEvleri.Add(obj);
                }
                else
                {
                    //update
                    _db.YayinEvleri.Update(obj);

                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int id)
        {
            var obj = _db.YayinEvleri.FirstOrDefault(x => x.YayineviID == id);
            _db.YayinEvleri.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
