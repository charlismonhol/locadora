using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaLoca.BusinnesLogic.Model.ControleAcervo;
using SistemaLoca.BusinnesLogic.Model;

namespace SistemaLoca.WebApp.Controllers
{ 
    public class MidiaController : Controller
    {
        private SistemaLocaDBContext db = new SistemaLocaDBContext();

        //
        // GET: /Midia/

        public ViewResult Index()
        {
            return View(db.Midias.ToList());
        }

        //
        // GET: /Midia/Details/5

        public ViewResult Details(int id)
        {
            Midia midia = db.Midias.Find(id);
            return View(midia);
        }

        //
        // GET: /Midia/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Midia/Create

        [HttpPost]
        public ActionResult Create(Midia midia)
        {
            if (ModelState.IsValid)
            {
                db.Midias.Add(midia);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(midia);
        }
        
        //
        // GET: /Midia/Edit/5
 
        public ActionResult Edit(int id)
        {
            Midia midia = db.Midias.Find(id);
            return View(midia);
        }

        //
        // POST: /Midia/Edit/5

        [HttpPost]
        public ActionResult Edit(Midia midia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(midia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(midia);
        }

        //
        // GET: /Midia/Delete/5
 
        public ActionResult Delete(int id)
        {
            Midia midia = db.Midias.Find(id);
            return View(midia);
        }

        //
        // POST: /Midia/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Midia midia = db.Midias.Find(id);
            db.Midias.Remove(midia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}