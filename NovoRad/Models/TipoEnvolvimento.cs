using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using NovoRad.Models;

namespace NovoRad.Models
{
    public class TipoEnvolvimento
    {
        public int TipoEnvolvimentoId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? NomeTipoEnvolvimento { get; set; }

        public ICollection<Envolvido> Envolvidos { get; set; }
    }
}
