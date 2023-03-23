using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Conclusao
    {
        public int ConclusaoId { get; set; }
        public int ResultadoId { get; set; }
        public Resultado Resultado { get; set; }
        
        [Column(TypeName = "varchar(300)")]
        public string TextoJustificativo { get; set; }
        public string ConsultivoJuridico { get; set; }
        public bool DesligamentoSJC { get; set; }
        public bool DesligamentoCJC { get; set; }
        public bool AdvertenciaVerbal { get; set; }
        public bool AdvertenciaEscrita { get; set; }
        public bool Suspensao { get; set; }
        public bool AfastamentoTerceiro { get; set; }
        public bool AdvertencuaTerceiro { get; set; }
        public bool NA { get; set; }
        public int OcorrenciaId { get; set; }
        public Ocorrencia Ocorrencia { get; set; }
    }
}
