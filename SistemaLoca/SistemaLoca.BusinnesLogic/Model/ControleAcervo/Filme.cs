using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SistemaLoca.BusinnesLogic.Model.ControleAcervo
{
    public class Filme
    {
        //O EF trata a propriedade ID ou Id como PK por convenção
        //[Key]
        //[Column("idFilme")]
        public int Id { get; set; }

        [StringLength(60)]
        public string Titulo { get; set; }

        public int Ano { get; set; }

        // associação de muitos para um 
        // virtual é necessário para habilitar o lazy loading
        public virtual List<ItemFilme> Itens { get; set; }

        [Required]
        [Display(Name = "Gênero")]
        public int GeneroID { get; set; }
        public virtual Genero Genero { get; set; }

        public virtual Distribuidora Distribuidora { get; set; }

    }
}
