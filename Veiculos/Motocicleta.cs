using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO_Heranca
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

        public override void exibirInformacoes(){
            Console.WriteLine($"Modelo: {Modelo}, Marca: {Marca}, Cilindradas: {Cilindradas}.");
        }
    }
}