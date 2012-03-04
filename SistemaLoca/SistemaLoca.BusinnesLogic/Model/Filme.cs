using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaLoca.BusinnesLogic.Model;
using System.ComponentModel.DataAnnotations;

namespace SistemaLoca.BusinnesLogic.Model
{
    public class Filme
    {
        //O EF trata a propriedade ID ou Id como PK por convenção
        //[key]
        //[Column("codigo")]
        public int Id { get; set; }

        public string Titulo { get; set; }
        public int Ano { get; set; }

        // associação de muitos para um 
        // virtual é necessário para habilitar o lazy loading
        public virtual List<ItemFilme> Itens { get; set; }

    }
}
