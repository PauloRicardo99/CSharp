using Loja.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Domain
{
    class Funcionario : Pessoa
    {
        public int Id { get; set; }
        public float Salario { get; set; }
        public CategoriaFuncionario Categoria { get; set; }
    }
}
