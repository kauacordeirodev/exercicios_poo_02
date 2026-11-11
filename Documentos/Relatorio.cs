using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO_Heranca
{
    public class Relatorio : IImprimivel, IExportavel
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo relatório...");
        }

        public void Exportar()
        {
            Console.WriteLine("Exportando relatório...");
        }
    }
}