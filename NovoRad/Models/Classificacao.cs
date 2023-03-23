using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Classificacao
    {
        public int ClassificacaoId { get; set; }
        public string Nome { get; set; }
        public bool Inativo { get; set; }
        public int Prazo { get; set; }

        public ICollection<Ocorrencia> Ocorrencias { get; set; }
    }
}
