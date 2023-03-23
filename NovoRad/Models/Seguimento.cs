using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Seguimento
    {
        public int SeguimentoId { get; set; }
        public string NomeSeguimento { get; set; }
        public ICollection<Ocorrencia> Ocorrencias { get; set; }
    }
}
