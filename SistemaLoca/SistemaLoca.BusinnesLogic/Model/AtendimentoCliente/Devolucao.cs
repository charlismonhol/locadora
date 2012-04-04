using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaLoca.BusinnesLogic.Model.AtendimentoCliente
{
    public class Devolucao
    {

        public int Id { get; set; }

        public Locacao Locacao { get; set; }
    }
}
