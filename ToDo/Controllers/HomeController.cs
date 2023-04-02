using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDo.Models;


namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Listele()
        {
            ToDoListEntitiesConnectionString db = new ToDoListEntitiesConnectionString();
            ViewBag.Liste = db.List;
            return View();
        }
        [HttpPost]
        public ActionResult Kaydet(List l)
        {
            ToDoListEntitiesConnectionString db = new ToDoListEntitiesConnectionString();
            db.List.Add(l);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
        [HttpPost]
        public ActionResult Duzenle(List D)
        {
            ToDoListEntitiesConnectionString db = new ToDoListEntitiesConnectionString();
            List KL = db.List.FirstOrDefault(x => x.Id == D.Id);
            KL.Title = D.Title;
            KL.Description = D.Description;
            db.SaveChanges();
            return RedirectToAction("Listele");
        }

        public ActionResult Sil(int id)
        {
            ToDoListEntitiesConnectionString db = new ToDoListEntitiesConnectionString();
            List silinecek = db.List.FirstOrDefault(x => x.Id == id);
            db.List.Remove(silinecek);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
    }
}