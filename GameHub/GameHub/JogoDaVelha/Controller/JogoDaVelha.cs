using GameHub.JogoDaVelha.Model;
using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;
using GameHub.JogoDaVelha.View;
using GameHub.GameHubAssets.View;
using Newtonsoft.Json;

namespace GameHub.JogoDaVelha.Controller
{
    class JogoDaVelha : TabuleiroJogoDaVelha
    {
        //  Variaveis globais para realizar a substituição do intervalo [0-9] por X ou O do método EscolhaJogador
        static string escolhaJogador1;
        static string escolhaJogador2;
        

        // Variável global para ser utilizada no menu para o método de pontuação
        public static int qtdEmpate;

        // Casting da escolha do jogador
        static int escolhaJogadorUm;
        static int escolhaJogadorDois;

        static void VezJogador1()
        {
            // Input do usuario
            Console.Write($"\nJogador {Cadastro.usuario1.getNome()} - Escolha o valor do tabuleiro que você quer preencher {Cadastro.usuario1.getLetraJogo()}: ");
            escolhaJogador1 = Console.ReadLine();

            // Casting do input do jogador
            escolhaJogadorUm = int.Parse(escolhaJogador1);

            // Checagem do intervalo [0-9]
            if (escolhaJogadorUm < 0 || escolhaJogadorUm > 9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\nNúmero não pertence ao intervalo [0-9] digite um número novamente: ");
                Console.ResetColor();

                string novoNumero = Console.ReadLine();
                escolhaJogador1 = novoNumero;
            }

            // Substituição na matriz do numero por X ou O
            for (int linhas = 0; linhas < 3; linhas++)
            {
                for (int colunas = 0; colunas < 3; colunas++)
                {
                    if (tabuleiroJogoDaVelha[linhas, colunas] == escolhaJogador1)
                    {

                        tabuleiroJogoDaVelha[linhas, colunas] = Cadastro.usuario1.getLetraJogo();

                        Thread.Sleep(200);
                        Console.Clear();

                        // # Decorar o menu
                        MenuHub.EstilizarMenu("Jogo da Velha", ConsoleColor.Red);

                        // # Método que verifica se deu velha
                        Pecas.VerificaEmpate(Menu.jogarDeNovo);

                        // # Método que verifica se a vitória é horizontal e pergunta se deseja jogar de novo
                        Pecas.VerificaVitoriaHorizontal(Menu.jogarDeNovo);

                        // # Método que verifica se a vitória é vertical e pergunta se deseja jogar de novo
                        Pecas.VerificaVitoriaVertical(Menu.jogarDeNovo);

                        // # Método que verifica se a vitória é diagonal e pergunta se deseja jogar de novo
                        Pecas.VerificaVitoriaDiagonal(Menu.jogarDeNovo);

                        MostrarTabuleiro();

                    }

                }
            }
        }
        static void VezJogador2()
        {
            // Input do usuario 2
            Console.Write($"\nJogador {Cadastro.usuario2.getNome()} - Escolha o valor do tabuleiro que você quer preencher com {Cadastro.usuario2.getLetraJogo()}: ");

            // Casting do input do jogador
            escolhaJogador2 = Console.ReadLine();

            // Casting do input do jogador
            escolhaJogadorDois = int.Parse(escolhaJogador2);


            // # Checagem para quando usuário escolha o mesmo numero já preenchido na matriz
            while (escolhaJogadorUm == escolhaJogadorDois || escolhaJogadorDois == escolhaJogadorUm)
            {
                if (escolhaJogadorUm == escolhaJogadorDois)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\nNúmero já preenchido escolha outro: ");
                    Console.ResetColor();

                    string novoNumero = Console.ReadLine();
                    escolhaJogadorDois = int.Parse(novoNumero);

                    for (int linhas = 0; linhas < 3; linhas++)
                    {
                        for (int colunas = 0; colunas < 3; colunas++)
                        {
                            if (tabuleiroJogoDaVelha[linhas, colunas] == novoNumero)
                            {
                                tabuleiroJogoDaVelha[linhas, colunas] = Cadastro.usuario2.getLetraJogo();

                                // # Método que verifica se deu velha
                                Pecas.VerificaEmpate(Menu.jogarDeNovo);

                                // # Método que verifica se a vitória é horizontal e pergunta se deseja jogar de novo
                                Pecas.VerificaVitoriaHorizontal(Menu.jogarDeNovo);

                                // # Método que verifica se a vitória é vertical e pergunta se deseja jogar de novo
                                Pecas.VerificaVitoriaVertical(Menu.jogarDeNovo);

                                // # Método que verifica se a vitória é diagonal e pergunta se deseja jogar de novo
                                Pecas.VerificaVitoriaDiagonal(Menu.jogarDeNovo);
                            }

                        }
                    }

                }
                else if (escolhaJogadorDois == escolhaJogadorUm)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\nNúmero já preenchido escolha outro: ");
                    Console.ResetColor();

                    string novoNumero = Console.ReadLine();
                    escolhaJogadorUm = int.Parse(novoNumero);

                    for (int linhas = 0; linhas < 3; linhas++)
                    {
                        for (int colunas = 0; colunas < 3; colunas++)
                        {
                            if (tabuleiroJogoDaVelha[linhas, colunas] == novoNumero)
                            {
                                tabuleiroJogoDaVelha[linhas, colunas] = Cadastro.usuario1.getLetraJogo();

                                // # Método que verifica se deu velha
                                Pecas.VerificaEmpate(Menu.jogarDeNovo);

                                // # Método que verifica se a vitória é horizontal e pergunta se deseja jogar de novo
                                Pecas.VerificaVitoriaHorizontal(Menu.jogarDeNovo);

                                // # Método que verifica se a vitória é vertical e pergunta se deseja jogar de novo
                                Pecas.VerificaVitoriaVertical(Menu.jogarDeNovo);

                                // # Método que verifica se a vitória é diagonal e pergunta se deseja jogar de novo
                                Pecas.VerificaVitoriaDiagonal(Menu.jogarDeNovo);
                            }

                        }
                    }
                }
                else
                {
                    break;
                }
            }


            // Checagem do intervalo [0-9]
            if (escolhaJogadorDois < 0 || escolhaJogadorDois > 9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\nNúmero não pertence ao intervalo [0-9] digite um número novamente: ");
                Console.ResetColor();

                string novoNumero = Console.ReadLine();
                escolhaJogador2 = novoNumero;
            }

            // Substituição na matriz do numero por X ou O
            for (int linhas = 0; linhas < 3; linhas++)
            {
                for (int colunas = 0; colunas < 3; colunas++)
                {
                    if (tabuleiroJogoDaVelha[linhas, colunas] == escolhaJogador2)
                    {

                        tabuleiroJogoDaVelha[linhas, colunas] = Cadastro.usuario2.getLetraJogo();

                        Thread.Sleep(200);
                        Console.Clear();

                        // # Decorar o menu
                        MenuHub.EstilizarMenu("Jogo da Velha", ConsoleColor.Red);

                        // # Método que verifica se deu velha
                        Pecas.VerificaEmpate(Menu.jogarDeNovo);

                        // # Método que verifica se a vitória é horizontal e pergunta se deseja jogar de novo
                        Pecas.VerificaVitoriaHorizontal(Menu.jogarDeNovo);

                        // # Método que verifica se a vitória é vertical e pergunta se deseja jogar de novo
                        Pecas.VerificaVitoriaVertical(Menu.jogarDeNovo);

                        // # Método que verifica se a vitória é diagonal e pergunta se deseja jogar de novo
                        Pecas.VerificaVitoriaDiagonal(Menu.jogarDeNovo);
                    }

                }
            }
        }


        // # Método que inicia o jogo
        public static void IniciarJogoDaVelha()
        {
            Cadastro.FazerCadastroJogoDaVelha();

            // Preenche a matriz com números [0-9]
            PreencherTabuleiro();

            while (true)
            {
                // # Decorar o menu antes de iniciar o game
                MenuHub.EstilizarMenu("Jogo da Velha", ConsoleColor.Red);

                // # Mostrar tabuleiro
                MostrarTabuleiro();

                // # Vez dos jogadores
                VezJogador1();
                VezJogador2();
            }

        }


    }
}
