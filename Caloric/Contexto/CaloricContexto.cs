using Caloric.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caloric.Contexto
{
    public class CaloricContexto : DbContext
    {
        public CaloricContexto(DbContextOptions<CaloricContexto> options) : base(options)
        {



        }

        public DbSet<Alimentos> Alimentos { get; set; }
        public DbSet<CaracteristicasFisicas> CaracteristicasFisicas { get; set; }
        public DbSet<Enderecos> Enderecos { get; set; }
        public DbSet<Exercicios> Exercicios { get; set; }
        public DbSet<Nutrientes> Nutrientes { get; set; }
        public DbSet<Pessoas> Pessoas { get; set; }
        public DbSet<Quantidade> Quantidades { get; set; }
          

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<NutrientesAlimentos>().HasKey(x => new { x.AlimentosId, x.NutrientesId });
        }
          

        public DbSet<Caloric.Models.NutrientesAlimentos> NutrientesAlimentos { get; set; }
          

        public DbSet<Caloric.Models.RelatorioPrincipal> RelatorioPrincipal { get; set; }



    }
}
