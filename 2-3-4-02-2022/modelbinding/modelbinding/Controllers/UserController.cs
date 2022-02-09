using modelbinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modelbinding.Controllers
{
    public class UserController : Controller
    {
        kullaniciEntities db = new kullaniciEntities();
        // GET: User
        public ActionResult Index()
        {
            var model = new UserViewIndexModel
            {
                Users = db.usertablo.ToList()
            };
            return View(model);
        }
        public ActionResult Insert()
        {
            return View();
        }


        #region Using Request Object
        //[HttpPost]
        //public RedirectToRouteResult UserInsert()
        //{
        //    var firstname = Request.Form["firstname"];
        //    var lastname = Request.Form["lastname"];
        //    var birthdate = Convert.ToDateTime(Request.Form["birthdate"]);

        //    db.usertablo.Add(new usertablo { firstname = firstname, lastname = lastname, birthdate = birthdate });
        //    db.SaveChanges();


        //    return RedirectToAction("Index");
        //}

        #endregion


        #region Using Primitive Types
        // Parametre ile yollanan değerleri bulmak için önce forma,sonra route a,sonra Querystringe bakar
        //public RedirectToRouteResult UserInsert( string firstname,string lastname, DateTime birthdate)
        //{
        //    db.usertablo.Add(new usertablo
        //    {
        //        firstname = firstname,
        //        lastname = lastname,
        //        birthdate = birthdate
        //    });
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        #endregion
        #region  Using FormCollection
        //public RedirectToRouteResult UserInsert(FormCollection collection)
        //{
        //    var firstname = collection["firstname"];
        //    var lastname = collection["lastname"];
        //    var birthdate = Convert.ToDateTime( collection["birthdate"]);
        //    db.usertablo.Add(new usertablo { firstname = firstname, lastname = lastname, birthdate = birthdate });
        //    db.SaveChanges();

        //    return RedirectToAction("Index");
        //}
        #endregion

        #region Using ComplexType
        public RedirectToRouteResult UserInsert(usertablo user)
        {
            db.usertablo.Add(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        public ActionResult Detay(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }
            var kisi = db.usertablo.FirstOrDefault(t => t.id == id);


            return View(kisi);
        }
    }
}