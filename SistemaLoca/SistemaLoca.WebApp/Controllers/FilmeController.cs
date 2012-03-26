using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaLoca.BusinnesLogic.Model;
using SistemaLoca.BusinnesLogic.Model.ControleAcervo;

namespace SistemaLoca.WebApp.Controllers
{ 
    public class FilmeController : Controller
    {
        private SistemaLocaDBContext db = new SistemaLocaDBContext();

        //
        // GET: /Filme/

        public ViewResult Index()
        {
            return View(db.Filmes.ToList());
        }

        //
        // GET: /Filme/Details/5

        public ViewResult Details(int id)
        {
            Filme filme = db.Filmes.Find(id);
            return View(filme);
        }

        //
        // GET: /Filme/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Filme/Create

        [HttpPost]
        public ActionResult Create(Filme filme)
        {
            if (ModelState.IsValid)
            {
                db.Filmes.Add(filme);
                db.SaveChanges();

                return RedirectToAction("Index");  
            }

            return View(filme);
        }
        
        //
        // GET: /Filme/Edit/5
 
        public ActionResult Edit(int id)
        {
            Filme filme = db.Filmes.Find(id);
            return View(filme);
        }

        //
        // POST: /Filme/Edit/5

        [HttpPost]
        public ActionResult Edit(Filme filme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filme);
        }

        //
        // GET: /Filme/Delete/5
 
        public ActionResult Delete(int id)
        {
            Filme filme = db.Filmes.Find(id);
            return View(filme);
        }

        //
        // POST: /Filme/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Filme filme = db.Filmes.Find(id);
            db.Filmes.Remove(filme);
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