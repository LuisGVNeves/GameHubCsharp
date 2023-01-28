using GameHub.GameHubAssets.View;
using GameHub.HubAssets.View;
using GameHub.JogoDaVelha.Model;
using GameHub.JogoDaVelha.Controller;


namespace GameHub.JogoDaVelha.View
{
    internal class Menu : Pecas
    {
        public static TabuleiroJogoDaVelha tabuleiroJogoDaVelha = new TabuleiroJogoDaVelha();

        public static string jogarDeNovo;
        public static void SubMenu()
        {
            // # Interface do submenu
            MenuHub.EstilizarMenu("SubMenu Jogo da Velha", ConsoleColor.Blue);
            Console.WriteLine("\n\n                              1 - Jogar de novo");
            Console.WriteLine("                              2 - Ver pontuação dos jogadores");
            Console.WriteLine("                              3 - Voltar ao Menu inicial");
            Console.WriteLine("                              4 - Sair do jogo\n");

            MenuHub.AdicionarTexto("\n\n           ╚══════════════════════════════════════════════════════════╝", ConsoleColor.DarkBlue);
            MenuHub.AdicionarTexto("\n\n\n\n\n                                  Digite aqui: ");
            jogarDeNovo = Console.ReadLine();

            if(jogarDeNovo == "1")
            {
                Thread.Sleep(1300);
                Console.Clear();

                // Interface do xadrex
                MenuHub.EstilizarMenu("Jogo da Velha", ConsoleColor.DarkRed);

                // # Vai iniciar o jogo e resetar o intervalo [0-9]
                tabuleiroJogoDaVelha.PreencherTabuleiro();

                Controller.JogoDaVelha.IniciarJogoDaVelha();
            }

            if(jogarDeNovo == "2")
            {
                Thread.Sleep(1000);
                Console.Clear();

                // Interface do xadrex
                MenuHub.EstilizarMenu("Pontuação", ConsoleColor.DarkGreen);

                Ranking.MostrarPontuacaoJogoDaVelha();
            }

            if(jogarDeNovo == "3")
            {
                Thread.Sleep(1000);
                Console.Clear();

                MenuHub.MenuInicialHub();
            }

            if(jogarDeNovo == "4")
            {
                Console.Clear();

                MenuHub.EstilizarMenu("--------------   Encerrando aplicação  --------------", ConsoleColor.Red);

                Environment.Exit(0);
            }
        }
    }
}
