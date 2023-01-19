using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameHub.Entity.CadastroUsuarioHub;

namespace GameHub.Entity.Menu
{
    class MenuHub
    {
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


        // Menu com Hub inicial
        public static void MenuInicialHub()
        {
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


        // Método para mostrar o menu de cadastro
        public static int MostrarMenuCadastro()
        {
            EstilizarMenu("HubJogos SharpCoders", ConsoleColor.DarkRed);
            AdicionarTexto("            Olá seja bem-vindo ao hub de jogos da Sharp Coders !\n\n");
            AdicionarTexto("                        Deseja realizar um cadastro ?\n\n                             1 - Sim   2 - Não");
            AdicionarTexto("\n\n                                Digite aqui: ");
            short respostaUsuario = short.Parse(Console.ReadLine());

            switch (respostaUsuario)
            {
                case 1:
                    // Fazer cadastro do usuário que está na posição[0] do arquivo json
                    Cadastro.FazerCadastro(0);
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            return 2;
        }
    }
}
