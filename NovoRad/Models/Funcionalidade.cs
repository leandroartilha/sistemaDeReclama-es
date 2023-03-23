using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Funcionalidade
    {
        public int FuncionalidadeId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string NomeFuncionalidade { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string NomeObjetoFuncionalidade { get; set; }
        
        [Column(TypeName = "varchar(100)")]
        public string DescricaoFuncionalidade { get; set; }
    }
}
