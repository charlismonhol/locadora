using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SistemaLoca.BusinnesLogic.Model.ControleAcervo
{
    public class ItemFilme
    {
        public int Id { get; set; }

        [Required]
        public int NumeroSerie { get; set; }

        public DateTime DataAquisicao { get; set; }

        // Associação de muitos para 1
        // Navegabilidade bidirecional
        // O atributo required implica na regra cascade delete quando o filme for removido
        public virtual Filme Filme { get; set; }
    }
}
