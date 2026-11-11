using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO_Heranca
{
    public abstract class Entrega
    {
        public decimal Frete { get; set; }
        public decimal Distancia { get; set; }

        public abstract void calcularFrete();
    }
}