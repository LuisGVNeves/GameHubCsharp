using GameHub.Entity.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameHub.Entity.UsuarioHub;
using Newtonsoft.Json;
using GameHub.Entity.CadastroUsuarioHub;

namespace GameHub.JogoDeXadrez.Controller
{
    class JogoXadrez : Cadastro
    {
        // # Variáveis para manipular o tabuleiro de Xadrex
        public static int linhaOrigemJogador1, linhaDestinoJogador1, colunaOrigemJogador1, colunaDestinoJogador1;
        public static int linhaOrigemJogador2, linhaDestinoJogador2, colunaOrigemJogador2, colunaDestinoJogador2;
        public static void IniciarJogoXadrez()
        {
            /*
                # Ao iniciar o jogo de xadrez, quero saber se na lista de usuários tem pelo menos 2 jogadores, se não tiver, vou invocar o método de fazerCadastro.
                Passando 1 como parâmetro, que vai acessar o indice, da lista que está no arquivo json, para poder criar um novo usuário.
            */
            for (int i = 0; i < listaUsuarios.Count(); i++)
            {
                if(listaUsuarios.Count() < 2)
                {
                    Console.Clear();
                    MenuHub.EstilizarMenu("AREA CADASTRO", ConsoleColor.DarkRed);
                    MenuHub.AdicionarTexto("Para jogar xadrez, precisamos de mais um usuário no sistema, então cadastre mais um usuário\n\n");
                    MenuHub.AdicionarTexto("Aperte alguma tecla para prosseguir com o cadastro: \n\n");
                    Console.ReadKey();
                    FazerCadastro(1);
                }
            }

        }

    }
}
