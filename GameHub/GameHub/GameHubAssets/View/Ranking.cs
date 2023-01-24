using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;
using GameHub.JogoDeXadrez.Model;
using GameHub.JogoDaVelha.Controller;

namespace GameHub.GameHubAssets.View
{
    class Ranking
    {
        public static void MostrarPontuacaoJogoDeXadrez()
        {
            Console.Clear();

            // # Decorar o menu antes de iniciar o game
            MenuHub.EstilizarMenu(" Xadrez", ConsoleColor.DarkRed);

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

        public static void MostrarPontuacaoJogoDaVelha()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[ ");
            Console.ResetColor();

            Console.Write($"Jogador {Cadastro.usuario1.getNome()} está com {Cadastro.usuario1.getPontuacaoJogador()} pontos");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ]");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [");
            Console.ResetColor();


            Console.Write($"Jogador {Cadastro.usuario2.getNome()} está com {Cadastro.usuario2.getPontuacaoJogador()} pontos");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ]");
            Console.ResetColor();

            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[ ");
            Console.ResetColor();

            Console.Write($"Quantidade de empates: {JogoDaVelha.Controller.JogoDaVelha.qtdEmpate}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ]");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("   [ ");
            Console.ResetColor();

            Console.Write($"Quantidade de jogadas: {JogoDaVelha.Controller.JogoDaVelha.qtdEmpate + Cadastro.usuario1.getPontuacaoJogador() + Cadastro.usuario2.getPontuacaoJogador()}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ]");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n------------------------------------------------------------------\n");
            Console.ResetColor();
        }
    }
}
