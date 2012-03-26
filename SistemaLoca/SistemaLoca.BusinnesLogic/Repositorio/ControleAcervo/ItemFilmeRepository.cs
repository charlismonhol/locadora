using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Passatempo.LogicaNegocio.Repository;
using SistemaLoca.BusinnesLogic.Model.ControleAcervo;
using SistemaLoca.BusinnesLogic.Model;

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
