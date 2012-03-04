using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Passatempo.LogicaNegocio.Repository;

namespace SistemaLoca.BusinnesLogic.Repositorio
{
    public class UnitOfWorkMapeamento : UnitOfWork
    {
        private FilmeRepository _filmeRepository;
        public FilmeRepository FilmeRepository
        {
            get
            {
                if (this._filmeRepository == null)
                {
                    this._filmeRepository =
                        new FilmeRepository(base._dbContext);
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
                        new ItemFilmeRepository(base._dbContext);
                }
                return this._itemFilmeRepository;
            }
        }

    }
}
