using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO_Heranca
{
    public class CursoOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public CursoOnline(string? nome, decimal preco, int cargaHoraria) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }
    }
}