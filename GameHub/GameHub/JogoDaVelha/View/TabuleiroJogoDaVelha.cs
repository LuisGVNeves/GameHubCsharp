using GameHub.HubAssets.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.JogoDaVelha.View
{
    class TabuleiroJogoDaVelha : Tabuleiro
    {
        // # Método que preenche tabuleiro com números, para o usuário preencher com X ou O
        public static void PreencherTabuleiro()
        {
            // # Linha 1
            tabuleiroJogoDaVelha[0, 0] = "1";
            tabuleiroJogoDaVelha[0, 1] = "2";
            tabuleiroJogoDaVelha[0, 2] = "3";

            // # Linha 2
            tabuleiroJogoDaVelha[1, 0] = "4";
            tabuleiroJogoDaVelha[1, 1] = "5";
            tabuleiroJogoDaVelha[1, 2] = "6";


            // # Linha 3
            tabuleiroJogoDaVelha[2, 0] = "7";
            tabuleiroJogoDaVelha[2, 1] = "8";
            tabuleiroJogoDaVelha[2, 2] = "9";
        }

        // # Método Mostrar Tabuleiro
        public static void MostrarTabuleiro()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                              ╔═══════════╗");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"                                {tabuleiroJogoDaVelha[0, 0]} | {tabuleiroJogoDaVelha[0, 1]} | {tabuleiroJogoDaVelha[0, 2]} ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               -----------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"                                {tabuleiroJogoDaVelha[1, 0]} | {tabuleiroJogoDaVelha[1, 1]} | {tabuleiroJogoDaVelha[1, 2]} ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("                               -----------\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"                                {tabuleiroJogoDaVelha[2, 0]} | {tabuleiroJogoDaVelha[2, 1]} | {tabuleiroJogoDaVelha[2, 2]} ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                              ╚═══════════╝");
            Console.ResetColor();
        }
    }
}
