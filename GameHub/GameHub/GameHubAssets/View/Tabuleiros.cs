using GameHub.GameHubAssets.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.HubAssets.View
{
    // @ Classe abstrata para assinaturas de métodos para as classes TabuleiroJogoDaVelha, TabuleiroXadrez e tabuleiro pra batalha naval
    public abstract class Tabuleiros
    {
        public abstract void PreencherTabuleiro();

        public abstract void MostrarTabuleiro(int linhas);

    }


    // # Classe TabuleiroJogoDaVelha herda da classe Tabuleiro para preencher as assinaturas da classe abstrata
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


    // # Classe TabuleiroXadrez herda da classe Tabuleiro para preencher as assinaturas da classe abstrata
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


    // # Classe TabuleiroXadrez herda da classe Tabuleiro para preencher as assinaturas da classe abstrata
    public class TabuleiroNaval : Tabuleiros
    {
        public char[,] tabuleiroNavalBase = new char[10, 10];
        public char[,] tabuleiroNavalInimigo1 = new char[10, 10];
        public char[,] tabuleiroNavalInimigo2 = new char[10, 10];


        // Construtor vazio
        public TabuleiroNaval() { }

        // Sobreescrita dos métodos da classe abstrata tabuleiro
        public override void PreencherTabuleiro()
        {
            // # Preencher tabuleiro base
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabuleiroNavalBase[i, j] += '~';
                }
            }

            // # Preencher tabuleiro 1
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabuleiroNavalInimigo1[i, j] += '~';

                    if (tabuleiroNavalInimigo1[1, 3] == '~' && tabuleiroNavalInimigo1[2, 3] == '~' && tabuleiroNavalInimigo1[3, 3] == '~' && tabuleiroNavalInimigo1[5, 4] == '~' && tabuleiroNavalInimigo1[5, 5] == '~' && tabuleiroNavalInimigo1[5, 6] == '~' && tabuleiroNavalInimigo1[8, 6] == '~' && tabuleiroNavalInimigo1[8, 7] == '~' && tabuleiroNavalInimigo1[8, 8] == '~' && tabuleiroNavalInimigo1[8, 9] == '~' && tabuleiroNavalInimigo1[9, 0] == '~' && tabuleiroNavalInimigo1[9, 1] == '~' && tabuleiroNavalInimigo1[9, 2] == '~' && tabuleiroNavalInimigo1[9, 3] == '~')
                    {
                        tabuleiroNavalInimigo1[0, 5] = 'N';
                        tabuleiroNavalInimigo1[0, 6] = 'N';
                        tabuleiroNavalInimigo1[0, 7] = 'N';

                        tabuleiroNavalInimigo1[1, 3] = 'N';
                        tabuleiroNavalInimigo1[2, 3] = 'N';
                        tabuleiroNavalInimigo1[3, 3] = 'N';

                        tabuleiroNavalInimigo1[5, 4] = 'N';
                        tabuleiroNavalInimigo1[5, 5] = 'N';
                        tabuleiroNavalInimigo1[5, 6] = 'N';

                        tabuleiroNavalInimigo1[8, 6] = 'N';
                        tabuleiroNavalInimigo1[8, 7] = 'N';
                        tabuleiroNavalInimigo1[8, 8] = 'N';
                        tabuleiroNavalInimigo1[8, 9] = 'N';

                        tabuleiroNavalInimigo1[9, 0] = 'N';
                        tabuleiroNavalInimigo1[9, 1] = 'N';
                        tabuleiroNavalInimigo1[9, 2] = 'N';
                        tabuleiroNavalInimigo1[9, 3] = 'N';

                    }
                }
            }

            // # Preencher tabuleiro 2
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabuleiroNavalInimigo2[i, j] += '~';

                    if (tabuleiroNavalInimigo2[0, 1] == '~' && tabuleiroNavalInimigo2[0, 2] == '~' && tabuleiroNavalInimigo2[0, 3] == '~' && tabuleiroNavalInimigo2[1, 3] == '~' && tabuleiroNavalInimigo2[2, 3] == '~' && tabuleiroNavalInimigo2[3, 3] == '~' && tabuleiroNavalInimigo2[5, 4] == '~' && tabuleiroNavalInimigo2[5, 5] == '~' && tabuleiroNavalInimigo2[5, 6] == '~' && tabuleiroNavalInimigo2[8, 6] == '~' && tabuleiroNavalInimigo2[8, 7] == '~' && tabuleiroNavalInimigo2[8, 8] == '~' && tabuleiroNavalInimigo2[8, 9] == '~' && tabuleiroNavalInimigo2[9, 0] == '~' && tabuleiroNavalInimigo2[9, 1] == '~' && tabuleiroNavalInimigo2[9, 2] == '~' && tabuleiroNavalInimigo2[9, 3] == '~')
                    {
                        tabuleiroNavalInimigo2[0, 1] = 'N';
                        tabuleiroNavalInimigo2[0, 2] = 'N';
                        tabuleiroNavalInimigo2[0, 3] = 'N';
                        tabuleiroNavalInimigo2[1, 3] = 'N';
                        tabuleiroNavalInimigo2[2, 3] = 'N';
                        tabuleiroNavalInimigo2[3, 3] = 'N';
                        tabuleiroNavalInimigo2[5, 4] = 'N';
                        tabuleiroNavalInimigo2[5, 5] = 'N';
                        tabuleiroNavalInimigo2[5, 6] = 'N';
                        tabuleiroNavalInimigo2[8, 6] = 'N';
                        tabuleiroNavalInimigo2[8, 7] = 'N';
                        tabuleiroNavalInimigo2[8, 8] = 'N';
                        tabuleiroNavalInimigo2[8, 9] = 'N';
                        tabuleiroNavalInimigo2[9, 0] = 'N';
                        tabuleiroNavalInimigo2[9, 1] = 'N';
                        tabuleiroNavalInimigo2[9, 2] = 'N';
                        tabuleiroNavalInimigo2[9, 3] = 'N';
                    }
                }
            }

            return;

        }

        public override void MostrarTabuleiro(int linhas)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                ╔════════════════════════════════════════╗", ConsoleColor.DarkGray);
            Console.ResetColor();
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"               0   {tabuleiroNavalBase[0, 0]} | {tabuleiroNavalBase[0, 1]} | {tabuleiroNavalBase[0, 2]} | {tabuleiroNavalBase[0, 3]} | {tabuleiroNavalBase[0, 4]} | {tabuleiroNavalBase[0, 5]} | {tabuleiroNavalBase[0, 6]} | {tabuleiroNavalBase[0, 7]} | {tabuleiroNavalBase[0, 8]} | {tabuleiroNavalBase[0, 9]}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"               1   {tabuleiroNavalBase[1, 0]} | {tabuleiroNavalBase[1, 1]} | {tabuleiroNavalBase[1, 2]} | {tabuleiroNavalBase[1, 3]} | {tabuleiroNavalBase[1, 4]} | {tabuleiroNavalBase[1, 5]} | {tabuleiroNavalBase[1, 6]} | {tabuleiroNavalBase[1, 7]} | {tabuleiroNavalBase[1, 8]} | {tabuleiroNavalBase[1, 9]}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"               2   {tabuleiroNavalBase[2, 0]} | {tabuleiroNavalBase[2, 1]} | {tabuleiroNavalBase[2, 2]} | {tabuleiroNavalBase[2, 3]} | {tabuleiroNavalBase[2, 4]} | {tabuleiroNavalBase[2, 5]} | {tabuleiroNavalBase[2, 6]} | {tabuleiroNavalBase[2, 7]} | {tabuleiroNavalBase[2, 8]} | {tabuleiroNavalBase[2, 9]}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  ---------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"               3   {tabuleiroNavalBase[3, 0]} | {tabuleiroNavalBase[3, 1]} | {tabuleiroNavalBase[3, 2]} | {tabuleiroNavalBase[3, 3]} | {tabuleiroNavalBase[3, 4]} | {tabuleiroNavalBase[3, 5]} | {tabuleiroNavalBase[3, 6]} | {tabuleiroNavalBase[3, 7]} | {tabuleiroNavalBase[3, 8]} | {tabuleiroNavalBase[3, 9]}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  ---------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"               4   {tabuleiroNavalBase[4, 0]} | {tabuleiroNavalBase[4, 1]} | {tabuleiroNavalBase[4, 2]} | {tabuleiroNavalBase[4, 3]} | {tabuleiroNavalBase[4, 4]} | {tabuleiroNavalBase[4, 5]} | {tabuleiroNavalBase[4, 6]} | {tabuleiroNavalBase[4, 7]} | {tabuleiroNavalBase[4, 8]} | {tabuleiroNavalBase[4, 9]}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"               5   {tabuleiroNavalBase[5, 0]} | {tabuleiroNavalBase[5, 1]} | {tabuleiroNavalBase[5, 2]} | {tabuleiroNavalBase[5, 3]} | {tabuleiroNavalBase[5, 4]} | {tabuleiroNavalBase[5, 5]} | {tabuleiroNavalBase[5, 6]} | {tabuleiroNavalBase[5, 7]} | {tabuleiroNavalBase[5, 8]} | {tabuleiroNavalBase[5, 9]}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  ---------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"               6   {tabuleiroNavalBase[6, 0]} | {tabuleiroNavalBase[6, 1]} | {tabuleiroNavalBase[6, 2]} | {tabuleiroNavalBase[6, 3]} | {tabuleiroNavalBase[6, 4]} | {tabuleiroNavalBase[6, 5]} | {tabuleiroNavalBase[6, 6]} | {tabuleiroNavalBase[6, 7]} | {tabuleiroNavalBase[6, 8]} | {tabuleiroNavalBase[6, 9]}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  ---------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"               7   {tabuleiroNavalBase[7, 0]} | {tabuleiroNavalBase[7, 1]} | {tabuleiroNavalBase[7, 2]} | {tabuleiroNavalBase[7, 3]} | {tabuleiroNavalBase[7, 4]} | {tabuleiroNavalBase[7, 5]} | {tabuleiroNavalBase[7, 6]} | {tabuleiroNavalBase[7, 7]} | {tabuleiroNavalBase[7, 8]} | {tabuleiroNavalBase[7, 9]}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"               8   {tabuleiroNavalBase[8, 0]} | {tabuleiroNavalBase[8, 1]} | {tabuleiroNavalBase[8, 2]} | {tabuleiroNavalBase[8, 3]} | {tabuleiroNavalBase[8, 4]} | {tabuleiroNavalBase[8, 5]} | {tabuleiroNavalBase[8, 6]} | {tabuleiroNavalBase[8, 7]} | {tabuleiroNavalBase[8, 8]} | {tabuleiroNavalBase[8, 9]}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"               9   {tabuleiroNavalBase[9, 0]} | {tabuleiroNavalBase[9, 1]} | {tabuleiroNavalBase[9, 2]} | {tabuleiroNavalBase[9, 3]} | {tabuleiroNavalBase[9, 4]} | {tabuleiroNavalBase[9, 5]} | {tabuleiroNavalBase[9, 6]} | {tabuleiroNavalBase[9, 7]} | {tabuleiroNavalBase[9, 8]} | {tabuleiroNavalBase[9, 9]}");

            Console.WriteLine("\n\n                   0   1   2   3   4   5   6   7   8   9");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(@"
                ╚════════════════════════════════════════╝", ConsoleColor.DarkGray);
            Console.ResetColor();
        }


        // Métodos para mostrar o tabuleiro dos inimigos com navios em diferentes lugares
        public void MostrarTabuleiroInimigo1()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                              ╔═══════════════════════════════════════╗");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo1[0, 5] == 'N')
            {
                Console.Write($"                                {tabuleiroNavalInimigo1[0, 0]} | {tabuleiroNavalInimigo1[0, 1]} | {tabuleiroNavalInimigo1[0, 2]} | {tabuleiroNavalInimigo1[0, 3]} | {tabuleiroNavalInimigo1[0, 4]} | ");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[0, 5]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");


                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[0, 6]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");


                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[0, 7]}");


                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");

                Console.WriteLine($"{tabuleiroNavalInimigo1[0, 8]} | {tabuleiroNavalInimigo1[0, 9]}");
                Console.ResetColor();

            }



            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo1[1, 3] == 'N')
            {
                Console.Write($"                                {tabuleiroNavalInimigo1[1, 0]} | {tabuleiroNavalInimigo1[1, 1]} | {tabuleiroNavalInimigo1[1, 2]} | ");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[1, 3]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($" | {tabuleiroNavalInimigo1[1, 4]} | {tabuleiroNavalInimigo1[1, 5]} | {tabuleiroNavalInimigo1[1, 6]} | {tabuleiroNavalInimigo1[1, 7]} | {tabuleiroNavalInimigo1[1, 8]} | {tabuleiroNavalInimigo1[1, 9]}");
                Console.ResetColor();

            }





            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo1[2, 3] == 'N')
            {
                Console.Write($"                                {tabuleiroNavalInimigo1[2, 0]} | {tabuleiroNavalInimigo1[2, 1]} | {tabuleiroNavalInimigo1[2, 2]} | ");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[2, 3]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($" | {tabuleiroNavalInimigo1[2, 4]} | {tabuleiroNavalInimigo1[2, 5]} | {tabuleiroNavalInimigo1[2, 6]} | {tabuleiroNavalInimigo1[2, 7]} | {tabuleiroNavalInimigo1[2, 8]} | {tabuleiroNavalInimigo1[2, 9]}");
                Console.ResetColor();

            }



            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo1[3, 3] == 'N')
            {
                Console.Write($"                                {tabuleiroNavalInimigo1[3, 0]} | {tabuleiroNavalInimigo1[3, 1]} | {tabuleiroNavalInimigo1[3, 2]} | ");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[3, 3]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($" | {tabuleiroNavalInimigo1[3, 4]} | {tabuleiroNavalInimigo1[3, 5]} | {tabuleiroNavalInimigo1[3, 6]} | {tabuleiroNavalInimigo1[3, 7]} | {tabuleiroNavalInimigo1[3, 8]} | {tabuleiroNavalInimigo1[3, 9]}");
                Console.ResetColor();

            }




            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"                                {tabuleiroNavalInimigo1[4, 0]} | {tabuleiroNavalInimigo1[4, 1]} | {tabuleiroNavalInimigo1[4, 2]} | {tabuleiroNavalInimigo1[4, 3]} | {tabuleiroNavalInimigo1[4, 4]} | {tabuleiroNavalInimigo1[4, 5]} | {tabuleiroNavalInimigo1[4, 6]} | {tabuleiroNavalInimigo1[4, 7]} | {tabuleiroNavalInimigo1[4, 8]} | {tabuleiroNavalInimigo1[4, 9]}");


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo1[5, 4] == 'N')
            {
                Console.Write($"                                {tabuleiroNavalInimigo1[5, 0]} | {tabuleiroNavalInimigo1[5, 1]} | {tabuleiroNavalInimigo1[5, 2]} | {tabuleiroNavalInimigo1[5, 3]} | ");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[5, 4]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");


                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[5, 5]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");


                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[5, 6]}");


                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");

                Console.WriteLine($"{tabuleiroNavalInimigo1[5, 7]} | {tabuleiroNavalInimigo1[5, 8]} | {tabuleiroNavalInimigo1[5, 9]}");
                Console.ResetColor();

            }



            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"                                {tabuleiroNavalInimigo1[6, 0]} | {tabuleiroNavalInimigo1[6, 1]} | {tabuleiroNavalInimigo1[6, 2]} | {tabuleiroNavalInimigo1[6, 3]} | {tabuleiroNavalInimigo1[6, 4]} | {tabuleiroNavalInimigo1[6, 5]} | {tabuleiroNavalInimigo1[6, 6]} | {tabuleiroNavalInimigo1[6, 7]} | {tabuleiroNavalInimigo1[6, 8]} | {tabuleiroNavalInimigo1[6, 9]}");




            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"                                {tabuleiroNavalInimigo1[7, 0]} | {tabuleiroNavalInimigo1[7, 1]} | {tabuleiroNavalInimigo1[7, 2]} | {tabuleiroNavalInimigo1[7, 3]} | {tabuleiroNavalInimigo1[7, 4]} | {tabuleiroNavalInimigo1[7, 5]} | {tabuleiroNavalInimigo1[7, 6]} | {tabuleiroNavalInimigo1[7, 7]} | {tabuleiroNavalInimigo1[7, 8]} | {tabuleiroNavalInimigo1[7, 9]}");


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo1[8, 6] == 'N')
            {
                Console.Write($"                                {tabuleiroNavalInimigo1[8, 0]} | {tabuleiroNavalInimigo1[8, 1]} | {tabuleiroNavalInimigo1[8, 2]} | {tabuleiroNavalInimigo1[8, 3]} | {tabuleiroNavalInimigo1[8, 4]} | {tabuleiroNavalInimigo1[8, 5]} | ");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[8, 6]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");


                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[8, 7]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");


                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[8, 8]}");


                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{tabuleiroNavalInimigo1[8, 9]}");
                Console.ResetColor();

            }


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo1[9, 0] == 'N')
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"                                {tabuleiroNavalInimigo1[9, 0]}");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[9, 1]}");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[9, 2]}");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{tabuleiroNavalInimigo1[9, 3]}");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | {tabuleiroNavalInimigo1[9, 4]} | {tabuleiroNavalInimigo1[9, 5]} | {tabuleiroNavalInimigo1[9, 6]} | {tabuleiroNavalInimigo1[9, 7]} | {tabuleiroNavalInimigo1[9, 8]} | {tabuleiroNavalInimigo1[9, 9]}");
                Console.ResetColor();

            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                              ╚═══════════════════════════════════════╝");
            Console.ResetColor();

        }

        public void MostrarTabuleiroInimigo2()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                              ╔═══════════════════════════════════════╗");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo2[0, 1] == 'N')
            {
                Console.Write($"                                {tabuleiroNavalInimigo2[0, 0]} | ");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{tabuleiroNavalInimigo2[0, 1]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");


                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{tabuleiroNavalInimigo2[0, 2]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");


                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{tabuleiroNavalInimigo2[0, 3]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");

                Console.WriteLine($"{tabuleiroNavalInimigo2[0, 4]} | {tabuleiroNavalInimigo2[0, 5]} | {tabuleiroNavalInimigo2[0, 6]} | {tabuleiroNavalInimigo2[0, 7]} | {tabuleiroNavalInimigo2[0, 8]} | {tabuleiroNavalInimigo2[0, 9]}");
                Console.ResetColor();

            }



            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo2[1, 3] == 'N')
            {
                Console.Write($"                                {tabuleiroNavalInimigo2[1, 0]} | {tabuleiroNavalInimigo2[1, 1]} | {tabuleiroNavalInimigo2[1, 2]} | ");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{tabuleiroNavalInimigo2[1, 3]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($" | {tabuleiroNavalInimigo2[1, 4]} | {tabuleiroNavalInimigo2[1, 5]} | {tabuleiroNavalInimigo2[1, 6]} | {tabuleiroNavalInimigo2[1, 7]} | {tabuleiroNavalInimigo2[1, 8]} | {tabuleiroNavalInimigo2[1, 9]}");
                Console.ResetColor();

            }




            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo2[2, 3] == 'N')
            {
                Console.Write($"                                {tabuleiroNavalInimigo2[2, 0]} | {tabuleiroNavalInimigo2[2, 1]} | {tabuleiroNavalInimigo2[2, 2]} | ");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{tabuleiroNavalInimigo2[2, 3]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($" | {tabuleiroNavalInimigo2[2, 4]} | {tabuleiroNavalInimigo2[2, 5]} | {tabuleiroNavalInimigo2[2, 6]} | {tabuleiroNavalInimigo2[2, 7]} | {tabuleiroNavalInimigo2[2, 8]} | {tabuleiroNavalInimigo2[2, 9]}");
                Console.ResetColor();

            }



            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo2[3, 3] == 'N')
            {
                Console.Write($"                                {tabuleiroNavalInimigo2[3, 0]} | {tabuleiroNavalInimigo2[3, 1]} | {tabuleiroNavalInimigo2[3, 2]} | ");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{tabuleiroNavalInimigo2[3, 3]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($" | {tabuleiroNavalInimigo2[3, 4]} | {tabuleiroNavalInimigo2[3, 5]} | {tabuleiroNavalInimigo2[3, 6]} | {tabuleiroNavalInimigo2[3, 7]} | {tabuleiroNavalInimigo2[3, 8]} | {tabuleiroNavalInimigo2[3, 9]}");
                Console.ResetColor();

            }




            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"                                {tabuleiroNavalInimigo2[4, 0]} | {tabuleiroNavalInimigo2[4, 1]} | {tabuleiroNavalInimigo2[4, 2]} | {tabuleiroNavalInimigo2[4, 3]} | {tabuleiroNavalInimigo2[4, 4]} | {tabuleiroNavalInimigo2[4, 5]} | {tabuleiroNavalInimigo2[4, 6]} | {tabuleiroNavalInimigo2[4, 7]} | {tabuleiroNavalInimigo2[4, 8]} | {tabuleiroNavalInimigo2[4, 9]}");


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo2[5, 4] == 'N')
            {
                Console.Write($"                                {tabuleiroNavalInimigo2[5, 0]} | {tabuleiroNavalInimigo2[5, 1]} | {tabuleiroNavalInimigo2[5, 2]} | {tabuleiroNavalInimigo2[5, 3]} | ");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{tabuleiroNavalInimigo2[5, 4]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");


                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{tabuleiroNavalInimigo2[5, 5]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");


                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{tabuleiroNavalInimigo2[5, 6]}");


                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");

                Console.WriteLine($"{tabuleiroNavalInimigo2[5, 7]} | {tabuleiroNavalInimigo2[5, 8]} | {tabuleiroNavalInimigo2[5, 9]}");
                Console.ResetColor();

            }



            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"                                {tabuleiroNavalInimigo2[6, 0]} | {tabuleiroNavalInimigo2[6, 1]} | {tabuleiroNavalInimigo2[6, 2]} | {tabuleiroNavalInimigo2[6, 3]} | {tabuleiroNavalInimigo2[6, 4]} | {tabuleiroNavalInimigo2[6, 5]} | {tabuleiroNavalInimigo2[6, 6]} | {tabuleiroNavalInimigo2[6, 7]} | {tabuleiroNavalInimigo2[6, 8]} | {tabuleiroNavalInimigo2[6, 9]}");




            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"                                {tabuleiroNavalInimigo2[7, 0]} | {tabuleiroNavalInimigo2[7, 1]} | {tabuleiroNavalInimigo2[7, 2]} | {tabuleiroNavalInimigo2[7, 3]} | {tabuleiroNavalInimigo2[7, 4]} | {tabuleiroNavalInimigo2[7, 5]} | {tabuleiroNavalInimigo2[7, 6]} | {tabuleiroNavalInimigo2[7, 7]} | {tabuleiroNavalInimigo2[7, 8]} | {tabuleiroNavalInimigo2[7, 9]}");


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo2[8, 6] == 'N')
            {
                Console.Write($"                                {tabuleiroNavalInimigo2[8, 0]} | {tabuleiroNavalInimigo2[8, 1]} | {tabuleiroNavalInimigo2[8, 2]} | {tabuleiroNavalInimigo2[8, 3]} | {tabuleiroNavalInimigo2[8, 4]} | {tabuleiroNavalInimigo2[8, 5]} | ");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{tabuleiroNavalInimigo2[8, 6]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");


                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{tabuleiroNavalInimigo2[8, 7]}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");


                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{tabuleiroNavalInimigo2[8, 8]}");


                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{tabuleiroNavalInimigo2[8, 9]}");
                Console.ResetColor();

            }


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               ---------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (tabuleiroNavalInimigo2[9, 0] == 'N')
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"                                {tabuleiroNavalInimigo2[9, 0]}");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{tabuleiroNavalInimigo2[9, 1]}");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{tabuleiroNavalInimigo2[9, 2]}");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | ");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{tabuleiroNavalInimigo2[9, 3]}");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" | {tabuleiroNavalInimigo2[9, 4]} | {tabuleiroNavalInimigo2[9, 5]} | {tabuleiroNavalInimigo2[9, 6]} | {tabuleiroNavalInimigo2[9, 7]} | {tabuleiroNavalInimigo2[9, 8]} | {tabuleiroNavalInimigo2[9, 9]}");
                Console.ResetColor();

            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                              ╚═══════════════════════════════════════╝");
            Console.ResetColor();

        }

    }

}
