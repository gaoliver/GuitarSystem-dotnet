using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarSystem.Models
{
    public class Guitarra
    {
        public int GuitarraID { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public string Situacao { get; set; }

        public string Cor { get; set; }

        public string MadeiraBraco { get; set; }

        public string MadeiraCorpo { get; set; }

        public string Ponte { get; set; }

        public string Captacao { get; set; }

        public decimal Valor { get; set; }
    }
}
