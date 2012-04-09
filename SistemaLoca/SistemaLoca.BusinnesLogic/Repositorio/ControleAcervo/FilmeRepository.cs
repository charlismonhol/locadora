using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaLoca.BusinnesLogic.Model.ControleAcervo;
using SistemaLoca.BusinnesLogic.Model;

namespace SistemaLoca.BusinnesLogic.Repositorio.ControleAcervo
{
    public class FilmeRepository : Repository<Filme>
    {
        public FilmeRepository(SistemaLocaDBContext dbContext_)
            : base(dbContext_)
        {
            
        }
        
        public List<Filme> getFilmesPorTitulo(string titulo)
        {
            return new List<Filme>(from f in _dbSet where f.Titulo.StartsWith(titulo) select f);
        }
    }
}
