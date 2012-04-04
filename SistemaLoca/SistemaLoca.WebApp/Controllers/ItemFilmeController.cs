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
    public class ItemFilmeController : Controller
    {
        private SistemaLocaDBContext db = new SistemaLocaDBContext();

        //
        // GET: /ItemFilme/

        public ViewResult Index()
        {
            return View(db.ItensFilmes.ToList());
        }

        //
        // GET: /ItemFilme/Details/5

        public ViewResult Details(int id)
        {
            ItemFilme itemfilme = db.ItensFilmes.Find(id);
            return View(itemfilme);
        }

        //
        // GET: /ItemFilme/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ItemFilme/Create

        [HttpPost]
        public ActionResult Create(ItemFilme itemfilme)
        {
            if (ModelState.IsValid)
            {
                db.ItensFilmes.Add(itemfilme);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(itemfilme);
        }
        
        //
        // GET: /ItemFilme/Edit/5
 
        public ActionResult Edit(int id)
        {
            ItemFilme itemfilme = db.ItensFilmes.Find(id);
            return View(itemfilme);
        }

        //
        // POST: /ItemFilme/Edit/5

        [HttpPost]
        public ActionResult Edit(ItemFilme itemfilme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemfilme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemfilme);
        }

        //
        // GET: /ItemFilme/Delete/5
 
        public ActionResult Delete(int id)
        {
            ItemFilme itemfilme = db.ItensFilmes.Find(id);
            return View(itemfilme);
        }

        //
        // POST: /ItemFilme/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            ItemFilme itemfilme = db.ItensFilmes.Find(id);
            db.ItensFilmes.Remove(itemfilme);
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