using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string NomeUsuario { get; set; }
        public int RegionalId { get; set; }
        public Regional Regional { get; set; }
        
        [Column(TypeName = "varchar(2)")]
        public string UF { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Telefone { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Cpf { get; set; }
        public bool Inativo { get; set; }
        public int AreaId { get; set; }
        public Area Area { get; set; }


    }
}
