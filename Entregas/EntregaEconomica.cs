using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO_Heranca
{
    public class EntregaEconomica : Entrega
    {
        public override void calcularFrete()
        {
            Frete = Distancia * 10/100;
            Console.WriteLine($"Frete: {Frete:C}");
        }
    }
}