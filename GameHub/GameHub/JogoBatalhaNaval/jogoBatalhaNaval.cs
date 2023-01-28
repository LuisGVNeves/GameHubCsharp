using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;

namespace GameHub.JogoBatalhaNaval
{
    // Herança da classe Barco para ter acesso aos possiveis movimentos do usuario
    public class jogoBatalhaNaval : TabuleiroNaval
    {
        public static TabuleiroNaval tabuleiroNaval = new TabuleiroNaval();

        public static int linhaDestino, colunaDestino = 0;

        public static void VezJogador1()
        {
            Console.Write($"\n{Cadastro.usuario1.getNome()} Digite a linha do possível barco inimigo: ");
            linhaDestino = int.Parse(Console.ReadLine());
            
            Console.Write($"\n{Cadastro.usuario1.getNome()} Digite a coluna do possível barco inimigo: ");
            colunaDestino = int.Parse(Console.ReadLine());



            if (tabuleiroNavalInimigo2[linhaDestino, colunaDestino] == 'N')
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                tabuleiroNavalInimigo2[linhaDestino, colunaDestino] = '*';
                tabuleiroNaval.tabuleiroNavalBase[linhaDestino, colunaDestino] = '*';
                Console.ResetColor();

                Console.WriteLine($"Jogador {Cadastro.usuario1.getNome()} acertou uma bomba no návio ! aperte uma tecla pra alternar pro outro jogador ! ");
                Console.ReadKey();
            }
            else
            {
                tabuleiroNavalInimigo2[linhaDestino, colunaDestino] = ' ';
                tabuleiroNaval.tabuleiroNavalBase[linhaDestino, colunaDestino] = ' ';
                Console.WriteLine($"Errou ! vez do jogador {Cadastro.usuario2.getNome()} aperte uma tecla pra iniciar jogada !");
                Console.ReadKey();
            }

        }

        public static void IniciarJogoBatalhaNaval()
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
            }
        }
    }
}
