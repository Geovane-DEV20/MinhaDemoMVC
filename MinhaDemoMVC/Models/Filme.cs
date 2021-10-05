using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMVC.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Título { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }
        public string Valor { get; set; }
        public int Avaliacao { get; set; }
    }
}
