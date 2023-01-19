using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameHub.Entity.CadastroUsuarioHub;

namespace GameHub.Entity
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
            AdicionarTexto("                                       3 - Outro jogo ");

            AdicionarTexto("\n                                   ════════════════════════\n");
            AdicionarTexto("                                       4 - Sair");

            AdicionarTexto("\n\n            ╚════════════════════════════════════════════════════════════════════╝");
            AdicionarTexto("\n\n\n\n\n                                        Digite aqui: ");
        }

        // # Método que adiciona texto recebe parâmetro opcional, caso eu não queira estilizar com outra cor no futuro
        public static void AdicionarTexto(string texto, ConsoleColor corLetra = ConsoleColor.White)
        {
            Console.ForegroundColor = corLetra;
            Console.Write(@$"{texto}");
        }

        // # Método para estilizar a interface do terminal
        public static void EstilizarMenu(string texto, ConsoleColor cor)
        {
            Console.Clear();
            Console.BackgroundColor = cor;
            Console.ForegroundColor = ConsoleColor.White;
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
