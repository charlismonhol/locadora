﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SistemaLoca.BusinnesLogic.Model.ControleAcervo
{
    public class Distribuidora
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string RazaoSocial { get; set; }

        [Required]
        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(100)]
        public string Endereco { get; set; }

        [StringLength(25)]
        public string Telefone { get; set; }

        [StringLength(100)]
        public string PessoaContato { get; set; }

        public virtual ICollection<Filme> Filmes { get; set; }
    }
}
