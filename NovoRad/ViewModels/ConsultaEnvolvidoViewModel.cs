using NovoRad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.ViewModels
{
    public class ConsultaEnvolvidoViewModel
    {
        public IEnumerable<Envolvido> Envolvidos { get; set; }
        public Envolvido Envolvido { get; set; }
    }
}
