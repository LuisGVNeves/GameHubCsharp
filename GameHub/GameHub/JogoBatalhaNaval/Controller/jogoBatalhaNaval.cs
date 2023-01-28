using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.JogoBatalhaNaval.Controller
{
    public class jogoBatalhaNaval
    {
        public static TabuleiroNaval tabuleiroNaval = new TabuleiroNaval();

        // # Método que inicia o jogo
        public static void IniciarJogoBatalhaNaval()
        {
            Cadastro.FazerCadastroJogoNaval();

            // Preenche a matriz com números [0-9]
            tabuleiroNaval.PreencherTabuleiro();

            // # Decorar o menu antes de iniciar o game
            MenuHub.EstilizarMenu("Batalha Naval", ConsoleColor.DarkBlue);

            // # Mostrar tabuleiro
            tabuleiroNaval.MostrarTabuleiro(10);

        }

    }
}
