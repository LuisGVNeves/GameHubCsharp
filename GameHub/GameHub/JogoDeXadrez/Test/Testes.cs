using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;

namespace GameHub.JogoDeXadrez.test
{
    internal class Testes : TabuleiroXadrez
    {
        // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
        public static int TratarCaracteresLinha(int linhaOrigemJogador, int indiceJogador)
        {
            /*
                # O indice do jogador serve pra pegar o indice na lista do JSON, pra eu conseguir diferenciar qual usuário está cometendo o erro no input
            */
            if (indiceJogador == 1)
            {
                while (linhaOrigemJogador > 8 || linhaOrigemJogador < 0)
                {
                    MenuHub.AdicionarTexto($"\n{Cadastro.usuario1.getNome()} não existe esse número no tabuleiro de Xadrez, apenas números no intervalo [0-7]", ConsoleColor.DarkRed);

                    MenuHub.AdicionarTexto("\n\nInforme a linha da peça que você quer pegar: ");
                    linhaOrigemJogador = int.Parse(Console.ReadLine());
                }

            }
            if (indiceJogador == 2)
            {
                while (linhaOrigemJogador > 8 || linhaOrigemJogador < 0)
                {
                    MenuHub.AdicionarTexto($"\n{Cadastro.usuario2.getNome()} não existe esse número no tabuleiro de Xadrez, apenas números no intervalo [0-7]", ConsoleColor.DarkRed);

                    MenuHub.AdicionarTexto("\n\nInforme a linha da peça que você quer pegar: ");
                    linhaOrigemJogador = int.Parse(Console.ReadLine());
                }
            }
            return linhaOrigemJogador;
        }


        // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
        public static int TratarCaracteresColuna(int colunaOrigemJogador, int indiceJogador)
        {
            if (indiceJogador == 1)
            {
                while (colunaOrigemJogador > 8 || colunaOrigemJogador < 0)
                {
                    MenuHub.AdicionarTexto($"\n{Cadastro.usuario1.getNome()} não existe esse número no tabuleiro de Xadrez, apenas números no intervalo [0-7]", ConsoleColor.DarkRed);

                    MenuHub.AdicionarTexto("\n\nInforme a coluna da peça que você quer pegar: ");
                    colunaOrigemJogador = int.Parse(Console.ReadLine());
                }
            }
            if (indiceJogador == 2)
            {
                while (colunaOrigemJogador > 8 || colunaOrigemJogador < 0)
                {
                    MenuHub.AdicionarTexto($"\n{Cadastro.usuario2.getNome()} não existe esse número no tabuleiro de Xadrez, apenas números no intervalo [0-7]", ConsoleColor.DarkRed);

                    MenuHub.AdicionarTexto("\n\nInforme a coluna da peça que você quer pegar: ");
                    colunaOrigemJogador = int.Parse(Console.ReadLine());
                }
            }

            return colunaOrigemJogador;
        }


        // Verifica se o jogador1 está pegando alguma peça do tabuleiro adversário
        public static bool VerificarPecaIgualJogador1(int linhaOrigemJogador, int colunaOrigemJogador, int linhaDestinoJogador, int colunaDestinoJogador)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            char pecaJogador1 = tabuleiroXadrez[linhaOrigemJogador, colunaOrigemJogador];

            char pecaInimiga = tabuleiroXadrez[linhaDestinoJogador, colunaDestinoJogador];

            if (pecaJogador1 == 'T')
            {
                return false;
            }
            if (pecaJogador1 == 'C')
            {
                return false;
            }
            if (pecaJogador1 == 'B')
            {
                return false;
            }
            if (pecaJogador1 == 'Q')
            {
                return false;
            }
            if (pecaJogador1 == 'K')
            {
                return false;
            }
            if (pecaJogador1 == 'p')
            {
                return false;
            }


            return true;

        }

        public static bool VerificarPecaIgualJogador2(int linhaOrigemJogador, int colunaOrigemJogador, int linhaDestinoJogador, int colunaDestinoJogador)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            char pecaJogador2 = tabuleiroXadrez[linhaOrigemJogador, colunaOrigemJogador];

            char pecaInimiga = tabuleiroXadrez[linhaDestinoJogador, colunaDestinoJogador];

            if (pecaJogador2 == 't')
            {
                return false;
            }
            if (pecaJogador2 == 'c')
            {
                return false;
            }
            if (pecaJogador2 == 'b')
            {
                return false;
            }
            if (pecaJogador2 == 'q')
            {
                return false;
            }
            if (pecaJogador2 == 'k')
            {
                return false;
            }
            if (pecaJogador2 == 'P')
            {
                return false;
            }

            return true;
        }
    }
}
