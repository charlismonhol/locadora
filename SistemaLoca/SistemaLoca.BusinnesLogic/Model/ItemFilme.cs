using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaLoca.BusinnesLogic.Model;
using System.ComponentModel.DataAnnotations;

namespace SistemaLoca.BusinnesLogic.Model
{
    public class ItemFilme
    {
        public int Id { get; set; }
        public int NumeroSerie { get; set; }

        // Associação de muitos para 1
        // Navegabilidade bidirecional
        // O atributo required implica na regra cascade delete quando o filme for removido
        [Required]
        public Filme Filme { get; set; } 

    }
}
