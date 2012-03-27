using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaLoca.BusinnesLogic.Model.ControleAcervo;
using SistemaLoca.BusinnesLogic.Model;

namespace SistemaLoca.BusinnesLogic.Repositorio.ControleAcervo
{
    public class GeneroRepository: Repository<Genero>
    {
        public GeneroRepository(SistemaLocaDBContext dbContext_)
            : base(dbContext_)
        {
            
        }
    }
}
