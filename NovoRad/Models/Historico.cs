using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Historico
    {
        public int HistoricoId { get; set; }
        public DateTime Data { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Autor { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Acao { get; set; }
        public int OcorrenciaId { get; set; }
        public Ocorrencia Ocorrencia { get; set; }
    }
}
