using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Status
    {
        public int StatusId { get; set; }
        public string NomeStatus { get; set; }
        public ICollection<Ocorrencia> Ocorrencias { get; set; }
    }
}
