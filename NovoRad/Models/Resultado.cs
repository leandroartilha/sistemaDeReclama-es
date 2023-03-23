using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Resultado
    {
        public int ResultadoId { get; set; }
        
        [Column(TypeName = "varchar(50)")]

        public string NomeResultado { get; set; }
        public ICollection<Conclusao> Conclusao { get; set; }
    }
}
