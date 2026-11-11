using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO_Heranca
{
    public abstract class Veiculo
    {
        public string? Modelo { get; set; }
        public string? Marca { get; set; }

        public virtual void exibirInformacoes(){
            Console.WriteLine($"Modelo: {Modelo}, Marca: {Marca}.");
        }
    }
}