using NovoRad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.ViewModels
{
    public class TriagemViewModel
    {
        public IEnumerable<Ocorrencia> Ocorrencia { get; set; }
        public IEnumerable<Usuario> Usuario { get; set; }
        // public Status Status { get; set; }
    }
}
