using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string NomeProduto { get; set; }
        public ICollection<Ocorrencia> Ocorrencias { get; set; }
    }
}
