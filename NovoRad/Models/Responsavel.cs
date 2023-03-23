using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Responsavel
    {
        public int ResponsavelId { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string NomeResponsavel { get; set; }

        public ICollection<Ocorrencia> Ocorrencias { get; set; }
    }
}
