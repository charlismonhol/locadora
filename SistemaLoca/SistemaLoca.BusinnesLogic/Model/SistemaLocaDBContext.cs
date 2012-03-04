using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SistemaLoca.BusinnesLogic.Model;

namespace SistemaLoca.BusinnesLogic.Model
{
    public class SistemaLocaDBContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<ItemFilme> ItensFilme { get; set; }

    }
}
