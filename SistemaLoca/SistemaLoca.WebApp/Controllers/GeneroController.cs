using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaLoca.BusinnesLogic.Model.ControleAcervo;
using SistemaLoca.BusinnesLogic.Model;
using SistemaLoca.BusinnesLogic.Repositorio;

namespace SistemaLoca.WebApp.Controllers
{ 
    public class GeneroController : Controller
    {
        private UnitOfWork uow = new UnitOfWork();

        //
        // GET: /Genero/

        public ViewResult Index()
        {
            return View(uow.generoRepository.GetAll());
        }

        //
        // GET: /Genero/Details/5

        public ViewResult Details(int id)
        {
            Genero genero = uow.generoRepository.GetByID(id);
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
                uow.generoRepository.Insert(genero);
                uow.Save();
                return RedirectToAction("Index");  
            }

            return View(genero);
        }
        
        //
        // GET: /Genero/Edit/5
 
        public ActionResult Edit(int id)
        {
            Genero genero = uow.generoRepository.GetByID(id);
            return View(genero);
        }

        //
        // POST: /Genero/Edit/5

        [HttpPost]
        public ActionResult Edit(Genero genero)
        {
            if (ModelState.IsValid)
            {
                uow.generoRepository.Update(genero);
                uow.Save();
                return RedirectToAction("Index");
            }
            return View(genero);
        }

        //
        // GET: /Genero/Delete/5
 
        public ActionResult Delete(int id)
        {
            Genero genero = uow.generoRepository.GetByID(id);
            return View(genero);
        }

        //
        // POST: /Genero/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Genero genero = uow.generoRepository.GetByID(id);
            uow.generoRepository.Delete(genero);
            uow.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            uow.Dispose();
            base.Dispose(disposing);
        }
    }
}