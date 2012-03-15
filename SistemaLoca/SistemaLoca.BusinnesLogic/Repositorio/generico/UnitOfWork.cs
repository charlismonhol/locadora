using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaLoca.BusinnesLogic.Model;
using SistemaLoca.BusinnesLogic.Repositorio;

namespace Passatempo.LogicaNegocio.Repository
{
    //Padrão de implementação de unidade de trabalho
    //http://www.asp.net/entity-framework/tutorials/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application

    /// <summary>
    ///  A classe UnityOfWork coordena o trabalho de vários repositórios 
    ///  criando apenas um database context e o compartilha entre todos os repositórios.
    /// </summary>
    public class UnitOfWork : IDisposable
    {

        private bool _disposed;

        protected SistemaLocaDBContext _dbContext;

        public UnitOfWork()
        {
            this._disposed = false;
            this._dbContext = new SistemaLocaDBContext();
        }

        public void Save()
        {
            this._dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing_)
        {
            if (!this._disposed)
            {
                if (disposing_)
                {
                    this._dbContext.Dispose();
                }
            }

            this._disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private FilmeRepository _filmeRepository;
        public FilmeRepository FilmeRepository
        {
            get
            {
                if (this._filmeRepository == null)
                {
                    this._filmeRepository =
                        new FilmeRepository(this._dbContext);
                }
                return this._filmeRepository;
            }
        }
        
        private ItemFilmeRepository _itemFilmeRepository;
        public ItemFilmeRepository itemFilmeRepository
        {
            get
            {
                if (this._itemFilmeRepository == null)
                {
                    this._itemFilmeRepository =
                        new ItemFilmeRepository(this._dbContext);
                }
                return this._itemFilmeRepository;
            }
        }
    }
}
