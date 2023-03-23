using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class UsuarioFuncionalidade
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int FuncionalidadeId { get; set; }
        public Funcionalidade Funcionalidade { get; set; }
    }
}
