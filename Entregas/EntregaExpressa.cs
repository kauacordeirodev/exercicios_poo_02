using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO_Heranca
{
    public class EntregaExpressa : Entrega
    {
        public override void calcularFrete()
        {
            Frete = Distancia * 25/100;
            Console.WriteLine($"Frete: {Frete:C}");
        }
    }
}