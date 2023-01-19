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

namespace GameHub.JogoDeXadrez.Controller
{
    class JogoXadrez : Cadastro
    {
        // # Variáveis para manipular o tabuleiro de Xadrex
        public static int linhaOrigemJogador1, linhaDestinoJogador1, colunaOrigemJogador1, colunaDestinoJogador1;
        public static int linhaOrigemJogador2, linhaDestinoJogador2, colunaOrigemJogador2, colunaDestinoJogador2;

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
                Thread.Sleep(1000);
                Console.Clear();
            }

            TabuleiroXadrez.PreencherTabuleiroXadrez();

            while (true)
            {
                // # Decorar o menu antes de iniciar o game
                MenuHub.EstilizarMenu(" Xadrez", ConsoleColor.Blue);

                // Mostrar o tabuleiro
                TabuleiroXadrez.MostrarTabuleiro(8);

                MenuHub.AdicionarTexto($"\n{Usuario.usuario1.getNome()} informe a linha da peça vermelha que você vai utilizar", ConsoleColor.DarkRed);
                linhaOrigemJogador1 = int.Parse(Console.ReadLine());
            }



        }

    }
}
