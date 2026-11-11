using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO_Heranca
{
    public class RetiradaLocal : Entrega
    {
        public override void calcularFrete()
        {
            Console.WriteLine("A retirada local não possui frete!");
        }
    }
}