using GameHub.HubAssets.Model;

namespace GameHub.JogoDaVelha.View
{
    class Pontuacao
    {
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

            Console.Write($"Quantidade de empates: {JogoDaVelha.qtdEmpate}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ]");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("   [ ");
            Console.ResetColor();

            Console.Write($"Quantidade de jogadas: {JogoDaVelha.qtdEmpate + Cadastro.usuario1.getPontuacaoJogador() + Cadastro.usuario2.getPontuacaoJogador()}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ]");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n------------------------------------------------------------------\n");
            Console.ResetColor();
        }

    }
}
