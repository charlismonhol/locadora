using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaLoca.BusinnesLogic.Model;
using SistemaLoca.BusinnesLogic.Model.ControleAcervo;

namespace SistemaLoca.BusinnesLogic.Repositorio.ControleAcervo
{
    public class DistribuidoraRepository : Repository<Distribuidora>
    {
        public DistribuidoraRepository(SistemaLocaDBContext dbContext_)
            : base(dbContext_)
        {

        }
    }
}
