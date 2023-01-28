using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;


namespace GameHub.JogoBatalhaNaval
{
    // Classe para identificar possiveis movimentos do tabuleiro inimigo
    public class Barco
    {



        /* Variaveis para identificar onde o jogador vai escolhar o campo na matriz que ele quer
        public static void VezJogador1()
        {
            Console.Write($"\n{Cadastro.usuario1.getNome()} Digite a linha do possível barco inimigo: ");
            linhaDestino = int.Parse(Console.ReadLine());

            Console.Write($"\n{Cadastro.usuario1.getNome()} Digite a coluna do possível barco inimigo: ");
            colunaDestino = int.Parse(Console.ReadLine());


            if (tabuleiroNaval.getValorLinhasColunasTabuleiroNaval2(i, j, 'N') && tabuleiroNaval.getValorLinhasColunasTabuleiroNaval2(linhaDestino, colunaDestino, 'N'))
            {
                tabuleiroNaval.tabuleiroNavalBase[linhaDestino, colunaDestino] = '*';
                Console.WriteLine("Acertou uma bomba no návio !");
            }

        }
        */
        /*
        public static void VezJogador2()
        {
            Console.Write($"\n{Cadastro.usuario2.getNome()} Digite a linha do possível barco inimigo: ");
            linhaDestino = int.Parse(Console.ReadLine());

            Console.Write($"\n{Cadastro.usuario2.getNome()} Digite a coluna do possível barco inimigo: ");
            colunaDestino = int.Parse(Console.ReadLine());


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (tabuleiroNaval.tabuleiroNavalInimigo1[linhaDestino, colunaDestino] == 'N')
                    {
                        tabuleiroNaval.tabuleiroNavalInimigo1[linhaDestino, colunaDestino] = '*';
                        tabuleiroNaval.tabuleiroNavalBase[linhaDestino, colunaDestino] = '*';

                        Console.WriteLine("Acertou uma bomba no návio !");

                    }
                }
            }
        }
        */
    }
}
