using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaLoca.BusinnesLogic.Model.ControleAcervo;

namespace SistemaLoca.BusinnesLogic.Model.AtendimentoCliente
{
    public class Locacao
    {
        public int Id { get; set; }

        public DateTime DataLocacao { get; set; }

        public double ValorLocacao { get; set; }

        public DateTime DataDevolucaoPrevisat { get; set; }

        public Reserva Reserva { get; set; }

        public ItemFilme ItemFilme { get; set; }

    }
}
