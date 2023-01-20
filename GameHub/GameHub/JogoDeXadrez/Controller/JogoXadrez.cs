using GameHub.Entity.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameHub.Entity.UsuarioHub;
using Newtonsoft.Json;
using GameHub.Entity.CadastroUsuarioHub;
using GameHub.JogoDeXadrez.View;
using GameHub.Entity.Testes;
using GameHub.JogoDeXadrez.Model;

namespace GameHub.JogoDeXadrez.Controller
{
    class JogoXadrez : Cadastro
    {
        // # Variáveis para manipular o tabuleiro de Xadrex
        public static int linhaOrigemJogador1, linhaDestinoJogador1, colunaOrigemJogador1, colunaDestinoJogador1;
        public static int linhaOrigemJogador2, linhaDestinoJogador2, colunaOrigemJogador2, colunaDestinoJogador2;

        static void VezJogador1()
        {
            MenuHub.AdicionarTexto($"\n{Usuario.usuario1.getNome()}", ConsoleColor.DarkRed);
            MenuHub.AdicionarTexto($" informe a linha da peça vermelha que você vai utilizar: ");
            linhaOrigemJogador1 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            linhaOrigemJogador1 = Testes.TratarCaracteresLinha(linhaOrigemJogador1);

            MenuHub.AdicionarTexto($"\n{Usuario.usuario1.getNome()}", ConsoleColor.DarkRed);
            MenuHub.AdicionarTexto($" informe a coluna da peça que você quer pegar: ");
            colunaOrigemJogador1 = int.Parse(Console.ReadLine());


            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            colunaOrigemJogador1 = Testes.TratarCaracteresColuna(colunaOrigemJogador1);


            // # Método vai verificar se o jogador  está pegando alguma peça do tabuleiro adversário
            while (Testes.VerificarPecaIgualJogador1(linhaOrigemJogador1, colunaOrigemJogador1, linhaDestinoJogador1, colunaDestinoJogador1) == true)
            {
                MenuHub.AdicionarTexto("\nA peça do Inimigo não pode ser usada !\n\n", ConsoleColor.DarkRed);

                MenuHub.AdicionarTexto($"\n{Usuario.usuario1.getNome()} informe a linha da peça que você quer pegar: ");
                linhaOrigemJogador1 = int.Parse(Console.ReadLine());

                MenuHub.AdicionarTexto($"\n{Usuario.usuario1.getNome()} informe a coluna da peça que você quer pegar: ");
                colunaOrigemJogador1 = int.Parse(Console.ReadLine());
            }


            MenuHub.AdicionarTexto($"\n{Usuario.usuario1.getNome()} informe a linha que você quer colocar a peça: ");
            linhaDestinoJogador1 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            linhaDestinoJogador1 = Testes.TratarCaracteresLinha(linhaDestinoJogador1);



            MenuHub.AdicionarTexto($"\n{Usuario.usuario1.getNome()} informe a coluna que você quer colocar a peça: ");
            colunaDestinoJogador1 = int.Parse(Console.ReadLine());


            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            colunaDestinoJogador1 = Testes.TratarCaracteresColuna(colunaDestinoJogador1);



            // # Verificar se a peça que o usuário digitou está no intervalo [0-7] e acontece a lógica de movimentar a peça

            if (Pecas.MoverPeca(linhaOrigemJogador1, colunaOrigemJogador1, linhaDestinoJogador1, colunaDestinoJogador1) != true)
            {
                MenuHub.AdicionarTexto("\nERRO Coordenadas inválidas\n\nPressione alguma tecla para digitar as coordenadas novamente: ", ConsoleColor.DarkRed);
                Console.ReadKey();
            }


            // # Mostra o tabuleiro pro usuario a cada peça digitada
            TabuleiroXadrez.MostrarTabuleiro(8);
        }

        static void VezJogador2()
        {
            MenuHub.AdicionarTexto($"\n{Usuario.usuario2.getNome()}");
            MenuHub.AdicionarTexto(" informe a linha da peça branca que você vai utilizar:");
            linhaOrigemJogador2 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            linhaOrigemJogador2 = Testes.TratarCaracteresLinha(linhaOrigemJogador2);



            MenuHub.AdicionarTexto($"\n{Usuario.usuario2.getNome()} informe a coluna da peça que você quer pegar: ");
            colunaOrigemJogador2 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            colunaOrigemJogador2 = Testes.TratarCaracteresColuna(colunaOrigemJogador2);


            // # Método vai verificar se o jogador 2 está pegando alguma peça do tabuleiro adversário

            while (Testes.VerificarPecaIgualJogador2(linhaOrigemJogador2, colunaOrigemJogador2, linhaDestinoJogador2, colunaDestinoJogador2) == true)
            {
                MenuHub.AdicionarTexto("\nA peça do Inimigo não pode ser usada !\n\n", ConsoleColor.DarkRed);

                MenuHub.AdicionarTexto($"\n{Usuario.usuario2.getNome()} informe a linha da peça que você quer pegar: ");
                linhaOrigemJogador2 = int.Parse(Console.ReadLine());

                MenuHub.AdicionarTexto($"\n{Usuario.usuario2.getNome()} informe a coluna da peça que você quer pegar: ");
                colunaOrigemJogador2 = int.Parse(Console.ReadLine());

            }




            MenuHub.AdicionarTexto($"\n{Usuario.usuario2.getNome()} informe a linha que você quer colocar a peça: ");
            linhaDestinoJogador2 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            linhaDestinoJogador2 = Testes.TratarCaracteresLinha(linhaDestinoJogador2);


            MenuHub.AdicionarTexto($"\n{Usuario.usuario2.getNome()} informe a coluna que você quer colocar a peça: ");
            colunaDestinoJogador2 = int.Parse(Console.ReadLine());

            // # Tratamento para não deixar o jogador colocar caracteres acima de 8 ou menor que 0
            colunaDestinoJogador2 = Testes.TratarCaracteresColuna(colunaDestinoJogador2);


            // # Verificar se a peça que o usuário digitou está no intervalo [0-7]
            if (Pecas.MoverPeca(linhaOrigemJogador2, colunaOrigemJogador2, linhaDestinoJogador2, colunaDestinoJogador2) != true)
            {
                MenuHub.AdicionarTexto("\nERRO Coordenadas inválidas\n\nPressione alguma tecla para digitar as coordenadas novamente: ", ConsoleColor.DarkRed);
                Console.ReadKey();
            }


            // # Mostra o tabuleiro pro usuario a cada peça digitada
            TabuleiroXadrez.MostrarTabuleiro(8);
        }


        public static void IniciarJogoXadrez()
        {

            using (StreamReader arquivoJson = new StreamReader("../../../Entity/Serializacao/objetosJogadores.json"))
            {
                // # Vai ler o arquivo json até o final
                var json = arquivoJson.ReadToEnd();

                // # Pegando os dados do json e colocando em um lista dinamica
                var data = JsonConvert.DeserializeObject<dynamic[]>(json);

                Console.Clear();
                MenuHub.EstilizarMenu($"Quem vai jogar com o jogador {Usuario.usuario1.getNome()}", ConsoleColor.DarkRed);
                MenuHub.AdicionarTexto("Para jogar xadrez, precisamos de mais um usuário no sistema, então cadastre mais um usuário\n\n");
                MenuHub.AdicionarTexto("Aperte alguma tecla para prosseguir com o cadastro: \n\n");
                Console.ReadKey();

                Console.Write("\n                           Digite seu nome: ");
                data[1].nome = Console.ReadLine();
                Usuario.usuario2.setNovoNome((string)data[1].nome);

                Console.Write("\n                           Digite sua senha: ");
                data[1].senha = Console.ReadLine();


                listaUsuarios.Add(Usuario.usuario2);

                Console.WriteLine("\n                       Cadastro criado com sucesso !\n\n");

                Console.WriteLine($"\n                          Jogador {Usuario.usuario1.getNome()} vai jogar com as peças escuras !");
                Usuario.usuario1.setCorPecaXadrez("red");

                Console.WriteLine($"\n                          Jogador {Usuario.usuario2.getNome()} vai jogar com as peças claras !");
                Usuario.usuario2.setCorPecaXadrez("white");

                Thread.Sleep(1500);
                Console.Clear();
            }

            TabuleiroXadrez.PreencherTabuleiroXadrez();

            while (true)
            {
                // # Decorar o menu antes de iniciar o game
                MenuHub.EstilizarMenu(" Xadrez", ConsoleColor.Blue);

                // Mostrar o tabuleiro
                TabuleiroXadrez.MostrarTabuleiro(8);

                // Começa a partida com o jogador 1 e depois jogador2
                VezJogador1();
                VezJogador2();



            }




        }

    }
}
