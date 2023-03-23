using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Prioridade
    {
        public int Id { get; set; }
        public int NumeroPrioridade { get; set; }

        public ICollection<Ocorrencia> Ocorrencias { get; set; }
    }
}
