using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class TipoAnexo
    {
        public int TipoAnexoId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string NomeTipoAnexoUpload { get; set; }

        public ICollection<Anexo> Anexo { get; set; }
    }
}
