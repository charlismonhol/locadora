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
    public class DistribuidoraController : Controller
    {
        private SistemaLocaDBContext db = new SistemaLocaDBContext();

        //
        // GET: /Distribuidora/

        public ViewResult Index()
        {
            return View(db.Distribuidoras.ToList());
        }

        //
        // GET: /Distribuidora/Details/5

        public ViewResult Details(int id)
        {
            Distribuidora distribuidora = db.Distribuidoras.Find(id);
            return View(distribuidora);
        }

        //
        // GET: /Distribuidora/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Distribuidora/Create

        [HttpPost]
        public ActionResult Create(Distribuidora distribuidora)
        {
            if (ModelState.IsValid)
            {
                db.Distribuidoras.Add(distribuidora);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(distribuidora);
        }
        
        //
        // GET: /Distribuidora/Edit/5
 
        public ActionResult Edit(int id)
        {
            Distribuidora distribuidora = db.Distribuidoras.Find(id);
            return View(distribuidora);
        }

        //
        // POST: /Distribuidora/Edit/5

        [HttpPost]
        public ActionResult Edit(Distribuidora distribuidora)
        {
            if (ModelState.IsValid)
            {
                db.Entry(distribuidora).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(distribuidora);
        }

        //
        // GET: /Distribuidora/Delete/5
 
        public ActionResult Delete(int id)
        {
            Distribuidora distribuidora = db.Distribuidoras.Find(id);
            return View(distribuidora);
        }

        //
        // POST: /Distribuidora/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Distribuidora distribuidora = db.Distribuidoras.Find(id);
            db.Distribuidoras.Remove(distribuidora);
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