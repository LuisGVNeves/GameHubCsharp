using Newtonsoft.Json;
using GameHub.JogoDeXadrez.Model;
using GameHub.HubAssets.View;
using GameHub.HubAssets.Model;
using GameHub.JogoDeXadrez.test;

namespace GameHub.JogoDeXadrez.Controller
{
    class JogoXadrez : Cadastro
    {
        public static TabuleiroXadrez tabuleiroXadrez = new TabuleiroXadrez();


        // # Variáveis para manipular o tabuleiro de Xadrex
        public static int linhaOrigemJogador1, linhaDestinoJogador1, colunaOrigemJogador1, colunaDestinoJogador1;
        public static int linhaOrigemJogador2, linhaDestinoJogador2, colunaOrigemJogador2, colunaDestinoJogador2;

        public static void VezJogador1()
        {

            // # Verifico se a linha de origem e a coluna de origem está correto no intervalo [0-7]

            MenuHub.AdicionarTexto($"\n{usuario1.getNome()}", ConsoleColor.DarkRed);
            MenuHub.AdicionarTexto($" informe a linha da peça vermelha que você vai utilizar: ");
            linhaOrigemJogador1 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            linhaOrigemJogador1 = Testes.TratarCaracteresLinha(linhaOrigemJogador1,1);


            MenuHub.AdicionarTexto($"\n{usuario1.getNome()}", ConsoleColor.DarkRed);
            MenuHub.AdicionarTexto($" informe a coluna da peça vermelha que você vai utilizar: ");
            colunaOrigemJogador1 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            colunaOrigemJogador1 = Testes.TratarCaracteresColuna(colunaOrigemJogador1,1);



            // # Método vai verificar se o jogador  está pegando alguma peça do tabuleiro adversário

            while (Testes.VerificarPecaIgualJogador1(linhaOrigemJogador1, colunaOrigemJogador1, linhaDestinoJogador1, colunaDestinoJogador1) == true)
            {
                MenuHub.AdicionarTexto("\nA peça do Inimigo não pode ser usada !\n\n", ConsoleColor.DarkRed);

                MenuHub.AdicionarTexto($"\n{Cadastro.usuario1.getNome()}", ConsoleColor.DarkRed);
                MenuHub.AdicionarTexto($" informe a linha da peça vermelha que você vai utilizar: ");
                linhaOrigemJogador1 = int.Parse(Console.ReadLine());

                MenuHub.AdicionarTexto($"\n{Cadastro.usuario1.getNome()}", ConsoleColor.DarkRed);
                MenuHub.AdicionarTexto($" informe a coluna da peça vermelha que você vai utilizar: ");
                colunaOrigemJogador1 = int.Parse(Console.ReadLine());
            }


            // Peça para mostrar a peça que o usuário escolheu no tabuleiro
            char peca = TabuleiroXadrez.tabuleiroXadrez[linhaOrigemJogador1, colunaOrigemJogador1];


            MenuHub.AdicionarTexto($"\n{usuario1.getNome()}", ConsoleColor.DarkRed);
            MenuHub.AdicionarTexto($" informe a linha que você quer colocar a peça [ {peca} ] vermelha: ");
            linhaDestinoJogador1 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            linhaDestinoJogador1 = Testes.TratarCaracteresLinha(linhaDestinoJogador1,1);





            MenuHub.AdicionarTexto($"\n{usuario1.getNome()}", ConsoleColor.DarkRed);
            MenuHub.AdicionarTexto($" informe a coluna que você quer colocar a peça [ {peca} ] vermelha: ");
            colunaDestinoJogador1 = int.Parse(Console.ReadLine());


            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            colunaDestinoJogador1 = Testes.TratarCaracteresColuna(colunaDestinoJogador1,1);



            // # REPLICAÇÃO DE CÓDIGO -- ALTERAR -- Verificar se a peça que o usuário digitou está no intervalo [0-7] e acontece a lógica de movimentar a peça

            if (Pecas.MoverPeca(linhaOrigemJogador1, colunaOrigemJogador1, linhaDestinoJogador1, colunaDestinoJogador1) != true)
            {
                MenuHub.AdicionarTexto("\nERRO Coordenadas inválidas\n\nPressione alguma tecla para digitar as coordenadas novamente: ", ConsoleColor.DarkRed);
                Console.ReadKey();
            }
            // REPLICAÇÃO DE CÓDIGO -- ALTERAR -- Verificar se a peça que o usuário digitou está no intervalo [0-7] e acontece a lógica de movimentar a peça


            // # Mostra o tabuleiro pro usuario a cada peça digitada
            tabuleiroXadrez.MostrarTabuleiro(8);
        }

        public static void VezJogador2()
        {

            MenuHub.AdicionarTexto($"\n{Cadastro.usuario2.getNome()}");
            MenuHub.AdicionarTexto(" Informe a linha da peça branca que você vai utilizar:");
            linhaOrigemJogador2 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            linhaOrigemJogador2 = Testes.TratarCaracteresLinha(linhaOrigemJogador2,2);


            MenuHub.AdicionarTexto($"\n{Cadastro.usuario2.getNome()}");
            MenuHub.AdicionarTexto($" Informe a coluna da peça branca que você vai utilizar: ");
            colunaOrigemJogador2 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador 2 colocar caracteres acima de 8 ou menor que 0
            colunaOrigemJogador2 = Testes.TratarCaracteresColuna(colunaOrigemJogador2,2);


            // # Método vai verificar se o jogador 2 está pegando alguma peça do tabuleiro adversário

            while (Testes.VerificarPecaIgualJogador2(linhaOrigemJogador2, colunaOrigemJogador2, linhaDestinoJogador2, colunaDestinoJogador2) == true)
            {
                MenuHub.AdicionarTexto("\nA peça do Inimigo não pode ser usada !\n\n", ConsoleColor.DarkRed);

                MenuHub.AdicionarTexto($"\n{Cadastro.usuario2.getNome()}");
                MenuHub.AdicionarTexto($" Informe a linha da peça branca que você vai utilizar: ");
                linhaOrigemJogador2 = int.Parse(Console.ReadLine());

                MenuHub.AdicionarTexto($"\n{Cadastro.usuario2.getNome()}");
                MenuHub.AdicionarTexto($" Informe a coluna da peça branca que você vai utilizar: ");
                colunaOrigemJogador2 = int.Parse(Console.ReadLine());

            }


            char peca = TabuleiroXadrez.tabuleiroXadrez[linhaOrigemJogador2, colunaOrigemJogador2];

            MenuHub.AdicionarTexto($"\n{Cadastro.usuario2.getNome()}");
            MenuHub.AdicionarTexto($" Informe a linha que você quer colocar a peça [ {peca} ] branca: ");
            linhaDestinoJogador2 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            linhaDestinoJogador2 = Testes.TratarCaracteresLinha(linhaDestinoJogador2,2);


            MenuHub.AdicionarTexto($"\n{Cadastro.usuario2.getNome()}");
            MenuHub.AdicionarTexto($" Informe a coluna que você quer colocar a peça [ {peca} ] branca: ");
            colunaDestinoJogador2 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            colunaDestinoJogador2 = Testes.TratarCaracteresColuna(colunaDestinoJogador2,2);


            // # Verificar se a peça que o usuário digitou está no intervalo [0-7]
            if (Pecas.MoverPeca(linhaOrigemJogador2, colunaOrigemJogador2, linhaDestinoJogador2, colunaDestinoJogador2) != true)
            {
                MenuHub.AdicionarTexto("\nERRO Coordenadas inválidas\n\nPressione alguma tecla para digitar as coordenadas novamente: ", ConsoleColor.DarkRed);
                Console.ReadKey();
            }


            // # Mostra o tabuleiro pro usuario a cada peça digitada
            tabuleiroXadrez.MostrarTabuleiro(8);
        }

        public static void IniciarJogoXadrez()
        {
            // @ Cadastro jogador1 e jogador2
            FazerCadastroXadrez();

            // Preencher os valores da matriz
            tabuleiroXadrez.PreencherTabuleiro();

            while (true)
            {
                // # Decorar o menu antes de iniciar o game
                MenuHub.EstilizarMenu(" Xadrez", ConsoleColor.Blue);

                // Mostrar o tabuleiro
                tabuleiroXadrez.MostrarTabuleiro(8);

                // Começa a partida com o jogador 1 e depois jogador2
                VezJogador1();
                VezJogador2();
            }
        }
    }
}
