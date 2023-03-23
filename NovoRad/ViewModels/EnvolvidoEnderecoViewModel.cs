using NovoRad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.ViewModels
{
    public class EnvolvidoEnderecoViewModel
    {
        public IEnumerable<Endereco> Enderecos { get; set; }
        public IEnumerable<Envolvido> Envolvidos { get; set; }
        public Envolvido Envolvido { get; set; }
        public Endereco Endereco { get; set; }


    }
}
