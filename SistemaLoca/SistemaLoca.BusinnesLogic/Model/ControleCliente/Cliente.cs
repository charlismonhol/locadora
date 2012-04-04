using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SistemaLoca.BusinnesLogic.Model.AtendimentoCliente
{
    public class Cliente
    {
        public int ID { get; set; }

        public string NumeroInscricao { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(60)]
        public string email { get; set; }

        [StringLength(1)]
        public string sexo { get; set; }

        public DateTime DataNascimento { get; set; }

        [StringLength(1)]
        public string Situacao { get; set; }
    }
}
