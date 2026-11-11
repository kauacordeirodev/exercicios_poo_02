using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO_Heranca
{
    public abstract class ProdutoDigital
    {
        public string? Nome { get; set; }
        public decimal Preco { get; set; }

        public ProdutoDigital(string? nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}