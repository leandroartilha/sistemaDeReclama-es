using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Envolvido
    {
        public int EnvolvidoId { get; set; }
        public int? TipoEnvolvimentoId { get; set; }
        public TipoEnvolvimento TipoEnvolvimento { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string CPF_CNPJ { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string? RG { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? Emissor { get; set; }

        [Column(TypeName = "varchar(2)")]
        public string? UF { get; set; }
        public bool PPE { get; set; }
        public DateTime? DataNascimento { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string? NomeMae { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string? NomePai { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string? Perfil { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string? NumeroSAP { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string? Login { get; set; }
        public int? AcaoTomadaId { get; set; }
        public AcaoTomada AcaoTomada { get; set; }
        public int? MedidaDisciplinarId { get; set; }
        public MedidaDisciplinar MedidaDisciplinar { get; set; }
        public int? EmpresaId { get; set; }
        public int OcorrenciaId { get; set; }
        public Ocorrencia Ocorrencia { get; set; }
        public ICollection<Endereco> Endereco { get; set; }
    }
}
