using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO_Heranca
{
    public class JogoDigital : Jogo
    {
        public string? LojaDigital { get; set; }

        public JogoDigital(string? nome, string? plataforma, string? lojaDigital) : base(nome, plataforma)
        {
            LojaDigital = lojaDigital;
        }

        public JogoDigital(string? nome, string? plataforma) : base(nome, plataforma){}
        public override void apresentarInformacoes()
        {
            Console.WriteLine($"{LojaDigital}: Mídia digital, {Nome}, {Plataforma}.");
        }
    }
}