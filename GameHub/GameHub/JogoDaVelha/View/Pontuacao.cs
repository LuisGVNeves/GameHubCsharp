using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameHub.Entity.UsuarioHub;

namespace GameHub.JogoDaVelha.View
{
    class Pontuacao
    {
        public static void MostrarPontuacaoJogoDaVelha()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[ ");
            Console.ResetColor();

            Console.Write($"Jogador {Usuario.usuario1.getNome()} está com {Usuario.usuario1.getPontuacaoJogador()} pontos");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ]");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [");
            Console.ResetColor();


            Console.Write($"Jogador {Usuario.usuario2.getNome()} está com {Usuario.usuario2.getPontuacaoJogador()} pontos");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ]");
            Console.ResetColor();

            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[ ");
            Console.ResetColor();

            Console.Write($"Quantidade de empates: {JogoDaVelha.qtdEmpate}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ]");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("   [ ");
            Console.ResetColor();

            Console.Write($"Quantidade de jogadas: {JogoDaVelha.qtdEmpate + Usuario.usuario1.getPontuacaoJogador() + Usuario.usuario2.getPontuacaoJogador()}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ]");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n------------------------------------------------------------------\n");
            Console.ResetColor();

        }

    }
}
