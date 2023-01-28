using GameHub.GameHubAssets.View;
using GameHub.JogoDeXadrez.Controller;
using GameHub.JogoBatalhaNaval.Controller;

namespace GameHub.HubAssets.View
{
    class MenuHub
    {
        // Menu com Hub inicial
        public static void MenuInicialHub()
        {
            Console.Clear();

            // # Menu inicial
            EstilizarMenu("BEM-VINDO AO HUB DE JOGOS SHARP CODERS", ConsoleColor.DarkRed);

            AdicionarTexto("\n\n       ╔═════════════════════════  Qual jogo deseja jogar:  ════════════════════════╗\n\n\n");

            AdicionarTexto("                                   ════════════════════════\n");
            AdicionarTexto("                                       1 - Jogo da velha ");

            AdicionarTexto("\n                                   ════════════════════════\n");
            AdicionarTexto("                                       2 - Xadrez ");

            AdicionarTexto("\n                                   ════════════════════════\n");
            AdicionarTexto("                                       3 - Batalha Naval ");

            AdicionarTexto("\n                                   ════════════════════════\n");
            AdicionarTexto("                                       4 - Ranking ");

            AdicionarTexto("\n                                   ════════════════════════\n");
            AdicionarTexto("                                       5 - Sair");

            AdicionarTexto("\n\n            ╚════════════════════════════════════════════════════════════════════╝");
            AdicionarTexto("\n\n\n\n\n                                        Digite aqui: ");

            short respostaUsuario = short.Parse(Console.ReadLine());

            if(respostaUsuario == 1)
            {
                JogoDaVelha.Controller.JogoDaVelha.IniciarJogoDaVelha();
            }
            if (respostaUsuario == 2)
            {
                JogoXadrez.IniciarJogoXadrez();
            }
            if(respostaUsuario == 3)
            {
                JogoBatalhaNaval.Controller.jogoBatalhaNaval.IniciarJogoBatalhaNaval();
            }
            if (respostaUsuario == 4)
            {
                Ranking.MostrarRankingGlobal();
            }
                Environment.Exit(0);
        }


        // # Método que adiciona texto recebe parâmetro opcional, caso eu não queira estilizar com outra cor no futuro
        public static void AdicionarTexto(string texto, ConsoleColor corLetra = ConsoleColor.White)
        {
            Console.ForegroundColor = corLetra;
            Console.Write(@$"{texto}");
        }


        // # Método para estilizar a interface do terminal
        public static void EstilizarMenu(string texto, ConsoleColor corBackGround, ConsoleColor corTexto = ConsoleColor.White)
        {
            Console.Clear();
            Console.BackgroundColor = corBackGround;
            Console.ForegroundColor = corTexto;
            Console.Write("                     ");
            Console.Write("┌─┐");

            Console.Write("└─┘");
            Console.Write($"  {texto}  ");
            Console.Write("┌─┐");
            Console.Write("└─┘");
            Console.Write("                     ");
            Console.WriteLine("\n");
            Console.ResetColor();
        }

    }
}
