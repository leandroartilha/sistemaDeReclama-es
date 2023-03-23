using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using NovoRad.Models;

namespace NovoRad.Models
{
    public class MedidaDisciplinar
    {
        public int MedidaDisciplinarId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? NomeMedidaDisciplinar { get; set; }
        public ICollection<Envolvido> Envolvidos { get; set; }
    }
}
