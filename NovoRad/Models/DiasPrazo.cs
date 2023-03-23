using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class DiasPrazo
    {
        public int DiasPrazoId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string NomeDiasPrazo { get; set; }
        public ICollection<Tarefa> Tarefa { get; set; }
    }
} 
