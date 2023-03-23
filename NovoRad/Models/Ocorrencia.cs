using NovoRad.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Ocorrencia
    {
        public int OcorrenciaId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Titulo { get; set; }

        [DisplayName("Responsavel")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int ResponsavelId { get; set; }
        public Responsavel Responsavel { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int ClassificacaoId { get; set; }
        public Classificacao Classificacao { get; set; }

        [Column(TypeName = "varchar(2)")]
        public string UF { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int PrioridadeId { get; set; }
        public Prioridade Prioridade { get; set; }

        [DisplayName("Area Demandante")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int AreaDemandanteId { get; set; }
        public AreaDemandante AreaDemandante { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int SeguimentoId { get; set; }
        public Seguimento Seguimento { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        [DisplayName("Descricao Apuracao")]
        public string DescricaoApuracao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int AmbienteId { get; set; }
        public Ambiente Ambiente { get; set; }

        [DisplayName("NomeAmbiente")]
        public string NomeAmbiente { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataConclusao { get; set; }
        public bool OperacaoPolicial { get; set; }
        public double ValorPerda { get; set; }
        public double ValorRecuperado { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public ICollection<Historico> Historico { get; set; }
        public ICollection<Envolvido> Envolvido { get; set; }
        public ICollection<Conclusao> Conclusao { get; set; }
        public ICollection<Anexo> Anexo { get; set; }
        public ICollection<Tarefa> Tarefa { get; set; }
    }
}
