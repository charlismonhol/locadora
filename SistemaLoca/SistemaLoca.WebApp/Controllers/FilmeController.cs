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
    public class FilmeController : Controller
    {
        private UnitOfWork uow = new UnitOfWork();

        //
        // GET: /Filme/

        public ViewResult Index()
        {
            return View(uow.FilmeRepository.GetAll());
        }

        //
        // GET: /Filme/Details/5

        public ViewResult Details(int id)
        {
            Filme filme = uow.FilmeRepository.GetByID(id);
            return View(filme);
        }
        
        //INICIO DO COMBO
        private void PopulateGenerosDropDownList(object selecionado = null)
        {
            IEnumerable<Genero> generos = uow.generoRepository.GetAll();
            ViewData["GeneroID"] = new SelectList(generos, "Id", "descricao", selecionado);
        }
 
        //
        // GET: /Filme/Create

        public ActionResult Create()
        {
            PopulateGenerosDropDownList();

            return View();
        }

        //
        // POST: /Filme/Create

        [HttpPost]
        public ActionResult Create(Filme filme)
        {
            if (ModelState.IsValid)
            {
                uow.FilmeRepository.Insert(filme);
                uow.Save();
                return RedirectToAction("Index");
            }

            PopulateGenerosDropDownList(filme.GeneroID);
            return View(filme);

        }
               
        //
        // GET: /Filme/Edit/5
 
        public ActionResult Edit(int id)
        {
            Filme filme = uow.FilmeRepository.GetByID(id);
            return View(filme);
        }

        //
        // POST: /Filme/Edit/5

        [HttpPost]
        public ActionResult Edit(Filme filme)
        {
            if (ModelState.IsValid)
            {
                uow.FilmeRepository.Update(filme);    
                uow.Save();
                return RedirectToAction("Index");
            }
            return View(filme);
        }

        //
        // GET: /Filme/Delete/5
 
        public ActionResult Delete(int id)
        {
            Filme filme = uow.FilmeRepository.GetByID(id);
            return View(filme);
        }

        //
        // POST: /Filme/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Filme filme = uow.FilmeRepository.GetByID(id);
            uow.FilmeRepository.Delete(filme);
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