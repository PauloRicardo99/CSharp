using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Domain
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }
    }
}
