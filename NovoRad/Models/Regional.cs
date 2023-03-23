using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Regional
    {
        public int RegionalId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string NomeRegional { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string NomeTerritorio { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
