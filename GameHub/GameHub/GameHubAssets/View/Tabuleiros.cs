using GameHub.GameHubAssets.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.HubAssets.View
{
    // @ Assinaturas de métodos para as classes TabuleiroJogoDaVelha e TabuleiroXadrez
    public abstract class Tabuleiros
    {
        public abstract void PreencherTabuleiro();

        public abstract void MostrarTabuleiro(int linhas);

    }

    public class TabuleiroJogoDaVelha : Tabuleiros
    {
        // Construtor vazio para utilizar os métodos do tabuleiro sem precisar utilizar static
        public TabuleiroJogoDaVelha() { }

        // Matriz do tabuleiro
        public static string[,] tabuleiroJogoDaVelha = new string[3, 3];

        public bool getValorLinhasColunas(int linhas, int colunas, string letraJogo)
        {
            return tabuleiroJogoDaVelha[linhas, colunas] == letraJogo ? true : false;
        }

        public void setLetraJogo(int linhas, int colunas, string letraJogo)
        {
            tabuleiroJogoDaVelha[linhas, colunas] = letraJogo;
        }

        // # Método que preenche tabuleiro com números, para o usuário preencher com X ou O
        public override void PreencherTabuleiro()
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

        // # Método Mostrar Tabuleiros
        public override void MostrarTabuleiro(int linhas)
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

    public class TabuleiroXadrez : Tabuleiros
    {
        // Construtor vazio para utilizar os métodos do tabuleiro sem precisar utilizar static
        public TabuleiroXadrez() { }

        // # Criar a Matriz - 8 linhas e 8 colunas
        public static char[,] tabuleiroXadrez = new char[8, 8];

        // # Método para preencher o tabuleiro de Xadrez
        public override void PreencherTabuleiro()
        {
            // # Linha 1
            tabuleiroXadrez[0, 0] = 'T'; // Torre
            tabuleiroXadrez[0, 1] = 'C'; // Cavalo
            tabuleiroXadrez[0, 2] = 'B'; // Bispo
            tabuleiroXadrez[0, 3] = 'Q'; // Queen
            tabuleiroXadrez[0, 4] = 'K'; // King
            tabuleiroXadrez[0, 5] = 'B'; // Bispo
            tabuleiroXadrez[0, 6] = 'C'; // Cavalo
            tabuleiroXadrez[0, 7] = 'T'; // Torre

            // # Linha 2
            tabuleiroXadrez[1, 0] = 'p'; // Peões
            tabuleiroXadrez[1, 1] = 'p';
            tabuleiroXadrez[1, 2] = 'p';
            tabuleiroXadrez[1, 3] = 'p';
            tabuleiroXadrez[1, 4] = 'p';
            tabuleiroXadrez[1, 5] = 'p';
            tabuleiroXadrez[1, 6] = 'p';
            tabuleiroXadrez[1, 7] = 'p';


            // # Linha 3
            tabuleiroXadrez[2, 0] = ' ';
            tabuleiroXadrez[2, 1] = ' ';
            tabuleiroXadrez[2, 2] = ' ';
            tabuleiroXadrez[2, 3] = ' ';
            tabuleiroXadrez[2, 4] = ' ';
            tabuleiroXadrez[2, 5] = ' ';
            tabuleiroXadrez[2, 6] = ' ';
            tabuleiroXadrez[2, 7] = ' ';

            // # Linha 4
            tabuleiroXadrez[3, 0] = ' ';
            tabuleiroXadrez[3, 1] = ' ';
            tabuleiroXadrez[3, 2] = ' ';
            tabuleiroXadrez[3, 3] = ' ';
            tabuleiroXadrez[3, 4] = ' ';
            tabuleiroXadrez[3, 5] = ' ';
            tabuleiroXadrez[3, 6] = ' ';
            tabuleiroXadrez[3, 7] = ' ';

            // # Linha 5
            tabuleiroXadrez[4, 0] = ' ';
            tabuleiroXadrez[4, 1] = ' ';
            tabuleiroXadrez[4, 2] = ' ';
            tabuleiroXadrez[4, 3] = ' ';
            tabuleiroXadrez[4, 4] = ' ';
            tabuleiroXadrez[4, 5] = ' ';
            tabuleiroXadrez[4, 6] = ' ';
            tabuleiroXadrez[4, 7] = ' ';

            // # Linha 6
            tabuleiroXadrez[5, 0] = ' ';
            tabuleiroXadrez[5, 1] = ' ';
            tabuleiroXadrez[5, 2] = ' ';
            tabuleiroXadrez[5, 3] = ' ';
            tabuleiroXadrez[5, 4] = ' ';
            tabuleiroXadrez[5, 5] = ' ';
            tabuleiroXadrez[5, 6] = ' ';
            tabuleiroXadrez[5, 7] = ' ';

            // # Linha 7
            tabuleiroXadrez[6, 0] = 'P'; // Peões
            tabuleiroXadrez[6, 1] = 'P';
            tabuleiroXadrez[6, 2] = 'P';
            tabuleiroXadrez[6, 3] = 'P';
            tabuleiroXadrez[6, 4] = 'P';
            tabuleiroXadrez[6, 5] = 'P';
            tabuleiroXadrez[6, 6] = 'P';
            tabuleiroXadrez[6, 7] = 'P';

            // # Linha 8
            tabuleiroXadrez[7, 0] = 't'; // Torre
            tabuleiroXadrez[7, 1] = 'c'; // Cavalo
            tabuleiroXadrez[7, 2] = 'b'; // Bispo
            tabuleiroXadrez[7, 3] = 'q'; // Queen
            tabuleiroXadrez[7, 4] = 'k'; // King
            tabuleiroXadrez[7, 5] = 'b'; // Bispo
            tabuleiroXadrez[7, 6] = 'c'; // Cavalo
            tabuleiroXadrez[7, 7] = 't'; // Torre
        }

        // # Método que exibe o tabuleiro de Xadrez
        public override void MostrarTabuleiro(int linhas)
        {

            Ranking.MostrarPontuacaoJogoDeXadrez();

            MenuHub.AdicionarTexto("                    ╔═════════════════════════════════╗\n", ConsoleColor.DarkRed);

            for (int i = 0; i < linhas; i++)
            {
                if (i == 0)
                {
                    MenuHub.AdicionarTexto("              Linha\n");
                    MenuHub.AdicionarTexto("                      ═══════════════════════════════", ConsoleColor.DarkGray);
                    MenuHub.AdicionarTexto($"\n                {i}      ");
                    MenuHub.AdicionarTexto($"{tabuleiroXadrez[0, 0]} | {tabuleiroXadrez[0, 1]} | {tabuleiroXadrez[0, 2]} | {tabuleiroXadrez[0, 3]} | {tabuleiroXadrez[0, 4]} | {tabuleiroXadrez[0, 5]} | {tabuleiroXadrez[0, 6]} | {tabuleiroXadrez[0, 7]}\n", ConsoleColor.DarkRed);
                }
                if (i == 1)
                {
                    MenuHub.AdicionarTexto($"                {i}      ");
                    MenuHub.AdicionarTexto($"{tabuleiroXadrez[1, 0]} | {tabuleiroXadrez[1, 1]} | {tabuleiroXadrez[1, 2]} | {tabuleiroXadrez[1, 3]} | {tabuleiroXadrez[1, 4]} | {tabuleiroXadrez[1, 5]} | {tabuleiroXadrez[1, 6]} | {tabuleiroXadrez[1, 7]}\n", ConsoleColor.DarkRed);
                }
                if (i == 2)
                {
                    MenuHub.AdicionarTexto($"                {i}      {tabuleiroXadrez[2, 0]} | {tabuleiroXadrez[2, 1]} | {tabuleiroXadrez[2, 2]} | {tabuleiroXadrez[2, 3]} | {tabuleiroXadrez[2, 4]} | {tabuleiroXadrez[2, 5]} | {tabuleiroXadrez[2, 6]} | {tabuleiroXadrez[2, 7]}\n");
                }
                if (i == 3)
                {
                    MenuHub.AdicionarTexto($"                {i}      {tabuleiroXadrez[3, 0]} | {tabuleiroXadrez[3, 1]} | {tabuleiroXadrez[3, 2]} | {tabuleiroXadrez[3, 3]} | {tabuleiroXadrez[3, 4]} | {tabuleiroXadrez[3, 5]} | {tabuleiroXadrez[3, 6]} | {tabuleiroXadrez[3, 7]}\n");
                }
                if (i == 4)
                {
                    MenuHub.AdicionarTexto($"                {i}      {tabuleiroXadrez[4, 0]} | {tabuleiroXadrez[4, 1]} | {tabuleiroXadrez[4, 2]} | {tabuleiroXadrez[4, 3]} | {tabuleiroXadrez[4, 4]} | {tabuleiroXadrez[4, 5]} | {tabuleiroXadrez[4, 6]} | {tabuleiroXadrez[4, 7]}\n");
                }
                if (i == 5)
                {
                    MenuHub.AdicionarTexto($"                {i}      {tabuleiroXadrez[5, 0]} | {tabuleiroXadrez[5, 1]} | {tabuleiroXadrez[5, 2]} | {tabuleiroXadrez[5, 3]} | {tabuleiroXadrez[5, 4]} | {tabuleiroXadrez[5, 5]} | {tabuleiroXadrez[5, 6]} | {tabuleiroXadrez[5, 7]}\n");
                }
                if (i == 6)
                {
                    MenuHub.AdicionarTexto($"                {i}      {tabuleiroXadrez[6, 0]} | {tabuleiroXadrez[6, 1]} | {tabuleiroXadrez[6, 2]} | {tabuleiroXadrez[6, 3]} | {tabuleiroXadrez[6, 4]} | {tabuleiroXadrez[6, 5]} | {tabuleiroXadrez[6, 6]} | {tabuleiroXadrez[6, 7]}\n");
                }
                if (i == 7)
                {
                    MenuHub.AdicionarTexto($"                {i}      {tabuleiroXadrez[7, 0]} | {tabuleiroXadrez[7, 1]} | {tabuleiroXadrez[7, 2]} | {tabuleiroXadrez[7, 3]} | {tabuleiroXadrez[7, 4]} | {tabuleiroXadrez[7, 5]} | {tabuleiroXadrez[7, 6]} | {tabuleiroXadrez[7, 7]}\n");
                }
                if (i == 8)
                {
                    MenuHub.AdicionarTexto($"                {i}      {tabuleiroXadrez[8, 0]} | {tabuleiroXadrez[8, 1]} | {tabuleiroXadrez[8, 2]} | {tabuleiroXadrez[8, 3]} | {tabuleiroXadrez[8, 4]} | {tabuleiroXadrez[8, 5]} | {tabuleiroXadrez[8, 6]} | {tabuleiroXadrez[8, 7]}\n");
                }

                MenuHub.AdicionarTexto("                      ═══════════════════════════════\n", ConsoleColor.DarkGray);
            }

            MenuHub.AdicionarTexto("\n");
            MenuHub.AdicionarTexto("               Col     0   1   2   3   4   5   6   7\n\n", ConsoleColor.Cyan);

            MenuHub.AdicionarTexto("                    ╚════════════════════════════════╝", ConsoleColor.DarkRed);
            Console.ResetColor();

        }

    }
}
