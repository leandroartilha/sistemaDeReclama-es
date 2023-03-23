using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Area
    {
        public int AreaId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public  string NomeArea { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
