using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SistemaLoca.BusinnesLogic.Model.AtendimentoCliente
{
    public class Titular : Cliente
    {
        public int Cpf { get; set; }

        [StringLength(100)]
        public string Endereco { get; set; }

        [StringLength(25)]
        public string TelefoneResidencial { get; set; }

        [StringLength(25)]
        public string TelefoneComercial { get; set; }

        [StringLength(25)]
        public string TelefoneCelular { get; set; }

    }
}
