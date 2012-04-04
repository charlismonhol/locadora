using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaLoca.BusinnesLogic.Model;
using SistemaLoca.BusinnesLogic.Model.AtendimentoCliente;
using SistemaLoca.BusinnesLogic.Repositorio.ControleAcervo;

namespace SistemaLoca.BusinnesLogic.Repositorio.ControleCliente
{
    public class ClienteRepository : Repository<Cliente>
    {
        public ClienteRepository(SistemaLocaDBContext dbContext_)
            : base(dbContext_)
        {

        }
    {
    }
}
