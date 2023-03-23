using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using NovoRad.Models;

namespace NovoRad.Models
{
    public class AcaoTomada
    {
        public int AcaoTomadaId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string NomeAcaoTomada { get; set; }
        public ICollection<Envolvido> Envolvidos { get; set; }
    }
}
