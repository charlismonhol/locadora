using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaLoca.BusinnesLogic.Model;
using System.Data.Entity;
using SistemaLoca.BusinnesLogic.Model.ControleAcervo;
using SistemaLoca.BusinnesLogic.Repositorio;

namespace SistemaLoca.BusinnesLogic.Teste
{
    [TestClass]
    public class FilmeTeste
    {
        UnitOfWork uow = new UnitOfWork();

        public FilmeTeste()
        {
            // Recria o banco de dados. É necessário fechar todas as conexões abertas 
            Database.SetInitializer(new DropCreateDatabaseAlways<SistemaLocaDBContext>());

            uow = new UnitOfWork();
        }

        [TestMethod]
        public void InserirFilmeTeste()
        {
            Filme filme = new Filme
            {
                Titulo = "Matrix",
                Ano = 1999,
                GeneroID = 1,
               Itens = new List<ItemFilme>()
            };
            filme.Itens.Add(new ItemFilme
            {
                NumeroSerie = 1234,
                Filme = filme,
                DataAquisicao = DateTime.Now
            });


            uow.FilmeRepository.Insert(filme);
            uow.Save();
            filme = uow.FilmeRepository.GetByID(1);
            Assert.AreEqual(filme.Titulo, "Matrix");
            Assert.AreEqual(filme.Itens.Count, 1);
        }

        [TestMethod]
        public void ConsultarFilmePorTituloTeste()
        {
            Filme filme = uow.FilmeRepository.getFilmesPorTitulo("Matrix").First<Filme>();
            Assert.AreEqual(filme.Titulo, "Matrix");
            Assert.AreEqual(filme.Itens.Count, 1); // lazy loading test
        }

        [TestMethod]
        public void ConsultarFilmePorIdTeste()
        {
            Filme filme = uow.FilmeRepository.GetByID(1);
            Assert.AreEqual(filme.Titulo, "Matrix");
        }

        [TestMethod]
        public void AtualizarFilmeTeste()
        {
            Filme filme = uow.FilmeRepository.GetByID(1);
            filme.Titulo = "Matrix 2";
            uow.Save();
            filme = uow.FilmeRepository.GetByID(1);
            Assert.AreEqual(filme.Titulo, "Matrix 2");
        }

        [TestMethod]
        public void RemoverFilmeTeste()
        {
            Filme filme = uow.FilmeRepository.GetByID(1);
            for(int i = 0; i < filme.Itens.Count ;i++){
                uow.itemFilmeRepository.Delete(filme.Itens[i]);
                uow.Save();
            }
            uow.FilmeRepository.Delete(filme);
            uow.Save();
            filme = uow.FilmeRepository.GetByID(1);
            Assert.IsNull(filme);
        }


    }
}
