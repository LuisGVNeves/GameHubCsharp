using GameHub.JogoDaVelha.Model;
using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;
using GameHub.JogoDaVelha.View;
using GameHub.GameHubAssets.View;
using Newtonsoft.Json;

namespace GameHub.JogoDaVelha.Controller
{
    class JogoDaVelha
    {
        public static TabuleiroJogoDaVelha tabuleiroJogoDaVelha = new TabuleiroJogoDaVelha();

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
                    if (tabuleiroJogoDaVelha.getValorLinhasColunas(linhas, colunas,escolhaJogador1))
                    {

                        tabuleiroJogoDaVelha.setLetraJogo(linhas, colunas, Cadastro.usuario1.getLetraJogo());

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

                        tabuleiroJogoDaVelha.MostrarTabuleiro(3);

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
                            if (tabuleiroJogoDaVelha.getValorLinhasColunas(linhas,colunas, novoNumero))
                            {
                                tabuleiroJogoDaVelha.setLetraJogo(linhas, colunas, Cadastro.usuario2.getLetraJogo());

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
                            if (tabuleiroJogoDaVelha.getValorLinhasColunas(linhas, colunas, novoNumero))
                            {
                                tabuleiroJogoDaVelha.setLetraJogo(linhas, colunas, Cadastro.usuario1.getLetraJogo());

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
                    if (tabuleiroJogoDaVelha.getValorLinhasColunas(linhas, colunas, escolhaJogador2))
                    {

                        tabuleiroJogoDaVelha.setLetraJogo(linhas, colunas, Cadastro.usuario2.getLetraJogo());

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

        public static void IniciarJogoDaVelha()
        {
            // Verificar se já tem algum nome preenchido no JSON
            if (Cadastro.usuario1.getNome() != "")
            {
                MenuHub.EstilizarMenu("Login player 1", ConsoleColor.Blue);
                Console.Write("Digite o nome do player 1: ");
                string resposta = Console.ReadLine();

                while (resposta != Cadastro.usuario1.getNome())
                {
                    Console.WriteLine("\n\nUsuário inválido. Deseja voltar ao menu principal?");
                    Console.WriteLine("\n               1 - SIM | 2 - NÃO");
                    Console.Write("\n\n                    Digite aqui: ");
                    short respostaUsuario = short.Parse(Console.ReadLine());

                    if (respostaUsuario == 1)
                    {
                        MenuHub.MenuInicialHub();
                    }
                    else
                    {
                        Console.Clear();
                        MenuHub.EstilizarMenu("Login player 1", ConsoleColor.Blue);
                        Console.Write("\n\nDigite novamente o nome do usuário: ");
                        resposta = Console.ReadLine();
                    }

                    if (resposta == Cadastro.usuario1.getNome())
                    {
                        Console.WriteLine($"\n\nUsuário {Cadastro.usuario1.getNome()} logado com sucesso ! ");
                        Console.WriteLine("\n\nAperte alguma tecla para ir pro login do segundo jogador: ");
                        Console.ReadKey();
                    }
                }


                if (Cadastro.usuario2.getNome() != "")
                {
                    MenuHub.EstilizarMenu("Login player 2", ConsoleColor.DarkBlue);
                    Console.Write("Digite o nome do player 2: ");
                    string respostaUsuario2 = Console.ReadLine();

                    while (respostaUsuario2 != Cadastro.usuario2.getNome())
                    {
                        Console.WriteLine("\n\nUsuário inválido. Deseja voltar ao menu principal?");
                        Console.WriteLine("\n               1 - SIM | 2 - NÃO");
                        Console.Write("\n\n                    Digite aqui: ");
                        short respostaUsuario = short.Parse(Console.ReadLine());

                        if (respostaUsuario == 1)
                        {
                            MenuHub.MenuInicialHub();
                        }
                        else
                        {
                            Console.Clear();
                            MenuHub.EstilizarMenu("Login player 2", ConsoleColor.DarkBlue);
                            Console.Write("\n\nDigite novamente o nome do usuário: ");
                            respostaUsuario2 = Console.ReadLine();
                        }

                        if (resposta == Cadastro.usuario2.getNome())
                        {
                            Console.WriteLine($"\n\nUsuário {Cadastro.usuario2.getNome()} logado com sucesso ! ");
                        }
                    }
                }






                // Preenche a matriz com números [0-9]
                tabuleiroJogoDaVelha.PreencherTabuleiro();

                while (true)
                {
                    // # Decorar o menu antes de iniciar o game
                    MenuHub.EstilizarMenu("Jogo da Velha", ConsoleColor.Red);

                    // # Mostrar tabuleiro
                    tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                    // # Vez dos jogadores
                    VezJogador1();
                    VezJogador2();
                }
            }
            else
            {
                // @ Cadastro jogador1 e jogador2
                Cadastro.FazerCadastroJogoDaVelha();

                // Preenche a matriz com números [0-9]
                tabuleiroJogoDaVelha.PreencherTabuleiro();

                while (true)
                {
                    // # Decorar o menu antes de iniciar o game
                    MenuHub.EstilizarMenu("Jogo da Velha", ConsoleColor.Red);

                    // # Mostrar tabuleiro
                    tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                    // # Vez dos jogadores
                    VezJogador1();
                    VezJogador2();
                }
            }

        }
    }
}
