using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO_Heranca
{
    public class JogoFisico : Jogo
    {
        public string? LojaFisica { get; set; }

        public JogoFisico(string? nome, string? plataforma, string? lojaFisica) : base(nome, plataforma)
        {
            LojaFisica = lojaFisica;
        }

        public override void apresentarInformacoes()
        {
            Console.WriteLine($"{LojaFisica}: Mídia física, {Nome}, {Plataforma}.");
        }
    }
}