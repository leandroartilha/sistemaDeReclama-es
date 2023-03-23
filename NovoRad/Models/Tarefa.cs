using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }

        public int? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int? DiasPrazoId { get; set; }

        public DiasPrazo DiasPrazo { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string AcaoTomada { get; set; }
        public DateTime DataInicio { get; set; }
        public int OcorrenciaId { get; set; }
        public Ocorrencia Ocorrencia { get; set; }
    }
}
