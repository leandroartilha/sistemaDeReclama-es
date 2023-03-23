using NovoRad.Migrations;
using NovoRad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.ViewModels
{
    public class ComboBoxViewModel
    {
        public IEnumerable<Ocorrencia> Ocorrencia{get;set; }
        public IEnumerable<Classificacao> Classificacao { get; set; }
        public Classificacao Class { get; set; }
        public IEnumerable<AreaDemandante> AreaDemandante { get; set; }
        public IEnumerable<Ambiente> Ambiente { get; set; }
    }
}
