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
    public class GeneroController : Controller
    {
        private SistemaLocaDBContext db = new SistemaLocaDBContext();

        //
        // GET: /Genero/

        public ViewResult Index()
        {
            return View(db.Generos.ToList());
        }

        //
        // GET: /Genero/Details/5

        public ViewResult Details(int id)
        {
            Genero genero = db.Generos.Find(id);
            return View(genero);
        }

        //
        // GET: /Genero/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Genero/Create

        [HttpPost]
        public ActionResult Create(Genero genero)
        {
            if (ModelState.IsValid)
            {
                db.Generos.Add(genero);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(genero);
        }
        
        //
        // GET: /Genero/Edit/5
 
        public ActionResult Edit(int id)
        {
            Genero genero = db.Generos.Find(id);
            return View(genero);
        }

        //
        // POST: /Genero/Edit/5

        [HttpPost]
        public ActionResult Edit(Genero genero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(genero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genero);
        }

        //
        // GET: /Genero/Delete/5
 
        public ActionResult Delete(int id)
        {
            Genero genero = db.Generos.Find(id);
            return View(genero);
        }

        //
        // POST: /Genero/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Genero genero = db.Generos.Find(id);
            db.Generos.Remove(genero);
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