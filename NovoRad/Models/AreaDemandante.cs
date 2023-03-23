using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class AreaDemandante
    {
        public int AreaDemandanteId { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Nome { get; set; }
        public bool Inativo { get; set; }
        public byte Prazo { get; set; }

        public ICollection<Ocorrencia> Ocorrencias { get; set; }
    }
}
