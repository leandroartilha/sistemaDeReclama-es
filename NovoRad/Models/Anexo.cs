using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Anexo
    {
        public int AnexoId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string NomeAnexoUpload { get; set; }
        public DateTime DataAnexo  { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Autor { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string DescricaoAnexo { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string ContentType { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public byte[] Bytes { get; set; }
        public int? TipoAnexoUploadId { get; set; }
        public TipoAnexo TipoAnexo { get; set; }
        public int? OcorrenciaId { get; set; }
        public Ocorrencia Ocorrencia { get; set; }
    }
}
