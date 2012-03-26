using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaLoca.BusinnesLogic.Model;
using System.Data.Entity;
using SistemaLoca.BusinnesLogic.Model.ControleAcervo;

namespace SistemaLoca.BusinnesLogic.Teste
{
    [TestClass]
    public class FilmeTeste
    {
        SistemaLocaDBContext dbContext;

        public FilmeTeste()
        {
            // Recria o banco de dados. É necessário fechar todas as conexões abertas 
            Database.SetInitializer(new DropCreateDatabaseAlways<SistemaLocaDBContext>());

            // inicializa o contexto
            dbContext = new SistemaLocaDBContext();
        }

        [TestMethod]
        public void InserirFilmeTeste()
        {
            Filme filme = new Filme
            {
                Titulo = "Matrix",
                Ano = 1999,
                Itens = new List<ItemFilme>()
            };
            filme.Itens.Add(new ItemFilme
            {
                NumeroSerie = 1234,
                Filme = filme
            });

            dbContext.Filmes.Add(filme);
            dbContext.SaveChanges();

            filme = dbContext.Filmes.Find(1);
            Assert.AreEqual(filme.Titulo, "Matrix");
            Assert.AreEqual(filme.Itens.Count, 1);
        }

        [TestMethod]
        public void ConsultarFilmePorTituloTeste()
        {
            Filme filme = dbContext.Filmes.Where(f => f.Titulo == "Matrix").First<Filme>();
            Assert.AreEqual(filme.Titulo, "Matrix");
            Assert.AreEqual(filme.Itens.Count, 1); // lazy loading test
        }

        [TestMethod]
        public void ConsultarFilmePorIdTeste()
        {
            Filme filme = dbContext.Filmes.Find(1);
            Assert.AreEqual(filme.Titulo, "Matrix");
        }

        [TestMethod]
        public void AtualizarFilmeTeste()
        {
            Filme filme = dbContext.Filmes.Find(1);
            filme.Titulo = "Matrix 2";
            dbContext.SaveChanges();
            filme = dbContext.Filmes.Find(1);
            Assert.AreEqual(filme.Titulo, "Matrix 2");
        }

        [TestMethod]
        public void RemoverFilmeTeste()
        {
            Filme filme = dbContext.Filmes.Find(1);
            dbContext.Filmes.Remove(filme);
            dbContext.SaveChanges();
            filme = dbContext.Filmes.Find(1);
            Assert.IsNull(filme);
        }


    }
}
