using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caloric.Models
{
    public class CaracteristicasFisicas
    {
        [Key]
        public int CaracteFisicasId { get; set; }
        public int Altura { get; set; }
        public int Peso { get; set; }
        public string Biotipo { get; set; }

        public int PessoasId { get; set; }
        public Pessoas PessoaId { get; set; }

    }
}
