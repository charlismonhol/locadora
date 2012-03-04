using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaLoca.BusinnesLogic.Model;
using Passatempo.LogicaNegocio.Repository;

namespace SistemaLoca.BusinnesLogic.Repositorio
{
    public class ItemFilmeRepository : Repository<ItemFilme>
    {
        public ItemFilmeRepository(SistemaLocaDBContext dbContext_)
            : base(dbContext_)
        {
            
        }

    }
}
