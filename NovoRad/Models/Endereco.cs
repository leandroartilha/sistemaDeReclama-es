using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento  { get; set; }
        public string Cep { get; set; }
        public string Bairro  { get; set; }
        public string Cidade  { get; set; }
        public string Estado  { get; set; }
        public int EnvolvidoId { get; set; }
        public Envolvido Envolvido { get; set; }
    }
}
