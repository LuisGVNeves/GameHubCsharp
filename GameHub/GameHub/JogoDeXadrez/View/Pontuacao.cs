using GameHub.JogoDeXadrez.Model;
using GameHub.HubAssets.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameHub.HubAssets.View;

namespace GameHub.JogoDeXadrez.View
{
    class Pontuacao
    {
        public static void MostrarPontuacaoJogoDeXadrez()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("         [ ");
            Console.ResetColor();

            Console.Write($"Jogador {Cadastro.usuario1.getNome()} está com {Cadastro.usuario1.getPontuacaoJogador()} pontos");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" ]");
            Console.ResetColor();

            Console.Write(" Peças capturadas:");
            for (int i = 0; i < Pecas.listaDePecasVermelhas.Count(); i++)
            {
                MenuHub.AdicionarTexto($" [{Pecas.listaDePecasVermelhas[i]}]", ConsoleColor.Gray);
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\n         [ ");
            Console.ResetColor();


            Console.Write($"Jogador {Cadastro.usuario2.getNome()} está com {Cadastro.usuario2.getPontuacaoJogador()} pontos");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" ]");
            Console.ResetColor();

            Console.Write(" Peças capturadas:");
            for (int i = 0; i < Pecas.listaDePecasBrancas.Count(); i++)
            {
                MenuHub.AdicionarTexto($" [{Pecas.listaDePecasBrancas[i]}]", ConsoleColor.DarkRed);
            }
            Console.WriteLine("\n");
        }
    }
}
