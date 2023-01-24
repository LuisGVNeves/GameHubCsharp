using GameHub.JogoDaVelha.Model;
using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;
using GameHub.GameHubAssets.View;
using Newtonsoft.Json;

namespace GameHub.JogoDaVelha.Controller
{
    class JogoDaVelha : TabuleiroJogoDaVelha
    {
        //  Variaveis globais para realizar a substituição do intervalo [0-9] por X ou O do método EscolhaJogador
        public static string escolhaJogador1;
        public static string escolhaJogador2;
        public static string jogarDeNovo;

        // Variáveis para o método de pontuação
        public static int qtdEmpate;

        // Casting da escolha do jogador
        public static int escolhaJogadorUm;
        public static int escolhaJogadorDois;

        public static void iniciarCadastro()
        {
            Console.Clear();
            MenuHub.EstilizarMenu("AREA CADASTRO", ConsoleColor.DarkRed);

            StreamReader arquivoJson = new StreamReader("../../../GameHubAssets/Data/objetosJogadores.json");
            // # Vai ler o arquivo json até o final
            var json = arquivoJson.ReadToEnd();

            // # Pegando os dados do json e colocando em um lista dinamica
            var data = JsonConvert.DeserializeObject<dynamic[]>(json);

            Console.Write("\n                           Digite seu nome: ");
            Cadastro.usuario1.setNovoNome(Console.ReadLine());
            data[1].nome = Cadastro.usuario1.getNome();


            Console.Write("\n                           Digite sua senha: ");
            Cadastro.usuario1.setNovaSenha(Console.ReadLine());
            data[1].senha = Cadastro.usuario1.getSenha();


            Cadastro.listaUsuarios.Add(Cadastro.usuario1);
            Console.WriteLine("\n                       Usuario criado com sucesso !\n\n");

            Thread.Sleep(1000);
            Console.Clear();
            MenuHub.EstilizarMenu($"Quem vai jogar com o {Cadastro.usuario1.getNome()} ?", ConsoleColor.DarkRed);


            // @ Cadastro segundo jogador
            Console.Write("\n                           Digite seu nome: ");
            Cadastro.usuario2.setNovoNome(Console.ReadLine());
            data[2].nome = Cadastro.usuario1.getNome();


            Console.Write("\n                           Digite sua senha: ");
            Cadastro.usuario1.setNovaSenha(Console.ReadLine());
            data[2].senha = Cadastro.usuario1.getSenha();


            Cadastro.listaUsuarios.Add(Cadastro.usuario1);
            Console.WriteLine("\n                       Usuario criado com sucesso !\n\n");

            Thread.Sleep(1000);
            Console.Clear();

            Console.Write($"\nJogador 1 {Cadastro.usuario1.getNome()} qual você quer ser? letra X ou O: ");
            Cadastro.usuario1.setLetraJogo(Console.ReadLine().ToUpper());
            if (Cadastro.usuario1.getLetraJogo() == "X")
            {
                Cadastro.usuario2.setLetraJogo("O");
            }
            else
            {
                Cadastro.usuario2.setLetraJogo("X");
            }


            MenuHub.AdicionarTexto("\n------------------------------------------------------------", ConsoleColor.Red);

            Console.WriteLine($"\n\nJogador {Cadastro.usuario1.getNome()} começa com: {Cadastro.usuario1.getLetraJogo()}");
            Console.WriteLine($"\nJogador {Cadastro.usuario2.getNome()} começa com: {Cadastro.usuario2.getLetraJogo()}");

            MenuHub.AdicionarTexto("\n------------------------------------------------------------", ConsoleColor.Red);

            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void TratamentoExcessoes()
        {
            // # Decorar o menu antes de iniciar o game
            MenuHub.EstilizarMenu("Jogo da Velha", ConsoleColor.Red);

            MostrarTabuleiro();

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
                        Pecas.VerificaEmpate(jogarDeNovo);

                        // # Método que verifica se a vitória é horizontal e pergunta se deseja jogar de novo
                        Pecas.VerificaVitoriaHorizontal(jogarDeNovo);

                        // # Método que verifica se a vitória é vertical e pergunta se deseja jogar de novo
                        Pecas.VerificaVitoriaVertical(jogarDeNovo);

                        // # Método que verifica se a vitória é diagonal e pergunta se deseja jogar de novo
                        Pecas.VerificaVitoriaDiagonal(jogarDeNovo);

                        MostrarTabuleiro();

                    }

                }
            }


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
                                Pecas.VerificaEmpate(jogarDeNovo);

                                // # Método que verifica se a vitória é horizontal e pergunta se deseja jogar de novo
                                Pecas.VerificaVitoriaHorizontal(jogarDeNovo);

                                // # Método que verifica se a vitória é vertical e pergunta se deseja jogar de novo
                                Pecas.VerificaVitoriaVertical(jogarDeNovo);

                                // # Método que verifica se a vitória é diagonal e pergunta se deseja jogar de novo
                                Pecas.VerificaVitoriaDiagonal(jogarDeNovo);
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
                                Pecas.VerificaEmpate(jogarDeNovo);

                                // # Método que verifica se a vitória é horizontal e pergunta se deseja jogar de novo
                                Pecas.VerificaVitoriaHorizontal(jogarDeNovo);

                                // # Método que verifica se a vitória é vertical e pergunta se deseja jogar de novo
                                Pecas.VerificaVitoriaVertical(jogarDeNovo);

                                // # Método que verifica se a vitória é diagonal e pergunta se deseja jogar de novo
                                Pecas.VerificaVitoriaDiagonal(jogarDeNovo);
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
                        Pecas.VerificaEmpate(jogarDeNovo);

                        // # Método que verifica se a vitória é horizontal e pergunta se deseja jogar de novo
                        Pecas.VerificaVitoriaHorizontal(jogarDeNovo);

                        // # Método que verifica se a vitória é vertical e pergunta se deseja jogar de novo
                        Pecas.VerificaVitoriaVertical(jogarDeNovo);

                        // # Método que verifica se a vitória é diagonal e pergunta se deseja jogar de novo
                        Pecas.VerificaVitoriaDiagonal(jogarDeNovo);
                    }

                }
            }
        }

        public static void SubMenu()
        {
            // # Interface do submenu
            MenuHub.EstilizarMenu("SubMenu Jogo da Velha", ConsoleColor.Blue);
            Console.WriteLine("\n\n1 - Jogar de novo");
            Console.WriteLine("2 - Ver pontuação dos jogadores");
            Console.WriteLine("3 - Sair do jogo\n");

            Console.Write("Digite: ");
            jogarDeNovo = Console.ReadLine();

            switch (jogarDeNovo)
            {
                case "1":
                    Thread.Sleep(1300);
                    Console.Clear();

                    // Interface do xadrex
                    MenuHub.EstilizarMenu("Jogo da Velha", ConsoleColor.DarkRed);

                    // # Vai iniciar o jogo e resetar o intervalo [0-9]
                    PreencherTabuleiro();

                    IniciarJogoDaVelha();
                    break;
                case "2":
                    Thread.Sleep(1000);
                    Console.Clear();

                    // Interface do xadrex
                    MenuHub.EstilizarMenu("Pontuação", ConsoleColor.DarkGreen);

                    Ranking.MostrarPontuacaoJogoDaVelha();
                    break;
                case "3":
                    Console.Clear();

                    MenuHub.EstilizarMenu("--------------   Encerrando aplicação  --------------", ConsoleColor.Red);

                    Environment.Exit(0);
                    break;
            }
        }

        // # Método que inicia o jogo
        public static void IniciarJogoDaVelha()
        {
            // Preenche a matriz com números [0-9]
            PreencherTabuleiro();

            while (true)
            {
                // # Quando matriz for trocada de número [0-9] por X ou O, invoco a função mostra o tabuleiro para mostrar como está o jogo atual
                MostrarTabuleiro();

                // Método para perguntar ao usuário se ele deseja X ou O para preencher na matriz e trocar os números da matriz pela escolha do jogar X ou O
                TratamentoExcessoes();
            }

        }







    }
}
