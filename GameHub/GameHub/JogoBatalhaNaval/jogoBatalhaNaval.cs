using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;

namespace GameHub.JogoBatalhaNaval
{
    // Herança da classe Barco para ter acesso aos possiveis movimentos do usuario
    public class jogoBatalhaNaval : TabuleiroNaval
    {
        public static TabuleiroNaval tabuleiroNaval = new TabuleiroNaval();

        public static int linhaDestino, colunaDestino = 0;

        // # Variável para incrementar cada vez que o usuário conseguir atingir uma parte do navio e identificar as vitórias
        public static int contagemTirosJogador1, contagemTirosJogador2;

        public static void VezJogador1()
        {
            Console.Write($"\n{Cadastro.usuario1.getNome()} Digite a linha do possível barco inimigo: ");
            linhaDestino = int.Parse(Console.ReadLine());
            
            Console.Write($"\n{Cadastro.usuario1.getNome()} Digite a coluna do possível barco inimigo: ");
            colunaDestino = int.Parse(Console.ReadLine());


            // Se a matriz rival tiver um pedaço do navio N, vou trocar por *

            if (tabuleiroNaval.tabuleiroNavalInimigo2[linhaDestino, colunaDestino] == 'N')
            {
                tabuleiroNaval.tabuleiroNavalInimigo2[linhaDestino, colunaDestino] = '*';
                tabuleiroNaval.tabuleiroNavalBase1[linhaDestino, colunaDestino] = '*';

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n\nJogador {Cadastro.usuario1.getNome()} acertou uma bomba no návio !");
                Console.ResetColor();

                // Incrementa a qtd de tiros do jogador
                contagemTirosJogador1++;

                // Incremento a pontuação do jogador em + 1
                Cadastro.usuario1.setPontuacaoJogador(contagemTirosJogador1,1);

                // 17 É a contagem total dos navios, na verdade são 5 navios, porém eles se estendem na matriz, então acaba aumentando o valor
                if(contagemTirosJogador1 == 17)
                {
                    Console.WriteLine($"\n\n                 Todos os navios do inimigo {Cadastro.usuario2.getNome()} foram atingidos !!");
                    Console.WriteLine("\n\n                 Aperte uma tecla para voltar ao menu");
                    Console.ReadKey();

                    MenuHub.MenuInicialHub();
                }


                Console.Write($"\n\nAperte uma tecla pra alternar pro outro jogador ! ");
                Console.ReadKey();
            }
            else
            {
                tabuleiroNaval.tabuleiroNavalInimigo2[linhaDestino, colunaDestino] = ' ';
                tabuleiroNaval.tabuleiroNavalBase1[linhaDestino, colunaDestino] = ' ';

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"\n\nErrou ! ");
                Console.ResetColor();

                Console.Write($"\n\nVez do jogador {Cadastro.usuario2.getNome()} aperte uma tecla pra iniciar jogada !");
                Console.ReadKey();

            }

        }

        public static void VezJogador2()
        {
            Console.Clear();

            // Mostrar o tabuleiro
            tabuleiroNaval.MostrarTabuleiroBase2();

            Console.Write($"\n{Cadastro.usuario2.getNome()} Digite a linha do possível barco inimigo: ");
            linhaDestino = int.Parse(Console.ReadLine());

            Console.Write($"\n{Cadastro.usuario2.getNome()} Digite a coluna do possível barco inimigo: ");
            colunaDestino = int.Parse(Console.ReadLine());


            if (tabuleiroNaval.tabuleiroNavalInimigo1[linhaDestino, colunaDestino] == 'N')
            {
                tabuleiroNaval.tabuleiroNavalInimigo1[linhaDestino, colunaDestino] = '*';
                tabuleiroNaval.tabuleiroNavalBase2[linhaDestino, colunaDestino] = '*';

                // Incrementa a qtd de tiros do jogador
                contagemTirosJogador2++;

                // Incremento a pontuação do jogador em + 1
                Cadastro.usuario2.setPontuacaoJogador(contagemTirosJogador2, 2);

                // 17 É a contagem total dos navios, na verdade são 5 navios, porém eles se estendem na matriz, então acaba aumentando o valor
                if (contagemTirosJogador2 == 17)
                {
                    Console.WriteLine($"\n\n                 Todos os navios do inimigo {Cadastro.usuario1.getNome()} foram atingidos !!");
                    Console.WriteLine("\n\n                 Aperte uma tecla para voltar ao menu");
                    Console.ReadKey();

                    MenuHub.MenuInicialHub();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n\nJogador {Cadastro.usuario2.getNome()} acertou uma bomba no návio !");
                Console.ResetColor();


                Console.Write($"\n\nAperte uma tecla pra alternar pro outro jogador ! ");
                Console.ReadKey();
            }
            else
            {
                tabuleiroNaval.tabuleiroNavalInimigo1[linhaDestino, colunaDestino] = ' ';
                tabuleiroNaval.tabuleiroNavalBase2[linhaDestino, colunaDestino] = ' ';

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"\n\nErrou ! ");
                Console.ResetColor();
             
                Console.Write($"\n\nVez do jogador {Cadastro.usuario1.getNome()} aperte uma tecla pra iniciar jogada !");
                Console.ReadKey();
            }

        }


        public static void IniciarJogoBatalhaNaval()
        {
            // Verificar se já tem algum nome preenchido no JSON
            if(Cadastro.usuario1.getNome() != "")
            {
                MenuHub.EstilizarMenu("Login player 1",ConsoleColor.Blue);
                Console.Write("Digite o nome do player 1: ");
                string resposta = Console.ReadLine();

                while(resposta != Cadastro.usuario1.getNome())
                {
                    Console.WriteLine("\n\nUsuário inválido. Deseja voltar ao menu principal?");
                    Console.WriteLine("\n               1 - SIM | 2 - NÃO");
                    Console.Write("\n\n                    Digite aqui: ");
                    short respostaUsuario = short.Parse(Console.ReadLine());

                    if(respostaUsuario == 1)
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
                    
                    if(resposta == Cadastro.usuario1.getNome())
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






                // Preencher os valores da matriz
                tabuleiroNaval.PreencherTabuleiro();

                while (true)
                {
                    // # Decorar o menu antes de iniciar o game
                    MenuHub.EstilizarMenu("Jogo naval", ConsoleColor.Blue);

                    // Mostrar o tabuleiro
                    tabuleiroNaval.MostrarTabuleiro(10);

                    // Começa a partida com o jogador 1 e depois jogador2
                    VezJogador1();

                    VezJogador2();
                }
            }
            else
            {
                // @ Cadastro jogador1 e jogador2
                Cadastro.FazerCadastroJogoNaval();

                // Preencher os valores da matriz
                tabuleiroNaval.PreencherTabuleiro();

                while (true)
                {
                    // # Decorar o menu antes de iniciar o game
                    MenuHub.EstilizarMenu("Jogo naval", ConsoleColor.Blue);

                    // Mostrar o tabuleiro
                    tabuleiroNaval.MostrarTabuleiro(10);

                    // Começa a partida com o jogador 1 e depois jogador2
                    VezJogador1();

                    VezJogador2();
                }
            }

        }
    }
}
