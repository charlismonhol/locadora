using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaLoca.BusinnesLogic.Model.ControleAcervo;

namespace SistemaLoca.BusinnesLogic.Model.AtendimentoCliente
{
    public class Reserva 
    {
        public int Id { get; set; }

        public DateTime DataReserva { get; set; }

        public Cliente Cliente { get; set; }

        public Filme Filme { get; set; }

        public Midia Midia { get; set; }
    }
}
