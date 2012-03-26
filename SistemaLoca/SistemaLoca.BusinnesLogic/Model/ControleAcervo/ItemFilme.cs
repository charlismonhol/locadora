using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SistemaLoca.BusinnesLogic.Model.ControleAcervo
{
    public class ItemFilme
    {
        [Key]
        [Column("idItemFilme")]
        public int Id { get; set; }

        [Required]
        public int NumeroSerie { get; set; }

        [Required]
        public DateTime DataAquisicao { get; set; }

        // Associação de muitos para 1
        // Navegabilidade bidirecional
        // O atributo required implica na regra cascade delete quando o filme for removido
        [Required]
        [ForeignKey("IdFilme")]
        public Filme Filme { get; set; } 

    }
}
