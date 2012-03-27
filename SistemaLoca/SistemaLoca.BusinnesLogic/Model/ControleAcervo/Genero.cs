using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SistemaLoca.BusinnesLogic.Model.ControleAcervo
{
    public class Genero
    {
        //[Key]
        //[Column("idGenero")]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        private string descricao { get; set; }

        //public virtual ICollection<Filme> Filmes { get; set; }
    }
}
