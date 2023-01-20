using GameHub.JogoDeXadrez.Controller;
using GameHub.Entity.UsuarioHub;
using System;
using GameHub.Entity.Tabuleiro;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameHub.JogoDeXadrez.View;
using GameHub.Entity.Menu;

namespace GameHub.JogoDeXadrez.Model
{
    class Pecas : Tabuleiros
    {
        // # Variavel pra calcular deslocamento das peças no tabuleiro
        static int deslocamentoVertical;
        static int deslocamentoHorizontal;

        public static List<char> listaDePecasVermelhas = new List<char>();
        public static List<char> listaDePecasBrancas = new List<char>();


        // # Se o movimento da peça torre estiver no deslocamento vertical da linha 0 ou no deslocamento horizontal da coluna 0
        public static void VerificarPecaTorre(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            char peca = tabuleiroXadrez[linhaOrigem, colunaOrigem];

            // # Pegar a peça inimiga que vai estar no destino que o usuário vai querer colocar
            char pecaInimiga = tabuleiroXadrez[linhaDestino, colunaDestino];


            // #  Calculo total da linha destino com a linha origem e vice versa
            deslocamentoVertical = Math.Abs(linhaDestino - linhaOrigem);
            deslocamentoHorizontal = Math.Abs(colunaDestino - colunaOrigem);


            // # Movimentos da torre Escura e Branca
            if (peca == 'T' && (deslocamentoVertical == 0 || deslocamentoHorizontal == 0))
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'P')
                {
                    listaDePecasVermelhas.Add('P');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(5, 1);
                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 't')
                {
                    listaDePecasVermelhas.Add('t');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(5, 1);
                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'c')
                {
                    listaDePecasVermelhas.Add('c');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(5, 1);
                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'b')
                {
                    listaDePecasVermelhas.Add('b');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(5, 1);
                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'q')
                {
                    listaDePecasVermelhas.Add('q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(5, 1);
                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'k')
                {
                    listaDePecasVermelhas.Add('k');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(5, 1);
                    return;
                }


                // Tratamento caso o jogador coma a própria peça
                while (pecaInimiga == 'p' || pecaInimiga == 'T' || pecaInimiga == 'C' || pecaInimiga == 'B' || pecaInimiga == 'Q' || pecaInimiga == 'K')
                {
                    // Mostrar o tabuleiro
                    TabuleiroXadrez.MostrarTabuleiro(8);

                    // Input do usuario novamente
                    JogoXadrez.VezJogador1();

                    if (pecaInimiga != 'p' || pecaInimiga != 'T' || pecaInimiga != 'C' || pecaInimiga != 'B' || pecaInimiga != 'Q' || pecaInimiga != 'K')
                    {
                        JogoXadrez.VezJogador2();
                    }

                }

                // Torre vai chegar
                tabuleiroXadrez[linhaDestino, colunaDestino] = tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

            }

            if (peca == 't' && (deslocamentoVertical == 0 || deslocamentoHorizontal == 0))
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'p')
                {
                    listaDePecasBrancas.Add('p');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(5,2);
                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 'T')
                {
                    listaDePecasBrancas.Add('T');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(5,2);
                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'C')
                {
                    listaDePecasBrancas.Add('C');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(5,2);
                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'B')
                {
                    listaDePecasBrancas.Add('B');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(5,2);
                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'Q')
                {
                    listaDePecasBrancas.Add('Q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(5,2);
                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'K')
                {
                    listaDePecasBrancas.Add('K');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(5,2);
                    return;
                }


                // Tratamento caso o jogador coma a própria peça
                while (pecaInimiga == 'P' || pecaInimiga == 't' || pecaInimiga == 'c' || pecaInimiga == 'b' || pecaInimiga == 'q' || pecaInimiga == 'k')
                {
                    // Mostrar o tabuleiro
                    TabuleiroXadrez.MostrarTabuleiro(8);

                    // Input do usuario novamente
                    JogoXadrez.VezJogador2();

                    if (pecaInimiga == 'P' || pecaInimiga == 't' || pecaInimiga == 'c' || pecaInimiga == 'b' || pecaInimiga == 'q' || pecaInimiga == 'k')
                    {
                        JogoXadrez.VezJogador1();
                    }

                }

                // Torre vai chegar
                tabuleiroXadrez[linhaDestino, colunaDestino] = tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }

        }


        // # Se o movimento da peça Bispo tiver a mesma quantidade de vezes que for o movimento horizontal ou vertical, ou seja, ele sempre vai se movimentar na diagonal
        public static void VerificarPecaBispo(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            char peca = tabuleiroXadrez[linhaOrigem, colunaOrigem];

            // # Pegar a peça inimiga que vai estar no destino que o usuário vai querer colocar
            char pecaInimiga = tabuleiroXadrez[linhaDestino, colunaDestino];

            // # Movimentos do bispo, se deslocamento vertical for igual ao deslocamento horizontal | bispo pode mexer
            deslocamentoVertical = Math.Abs(linhaDestino - linhaOrigem);
            deslocamentoHorizontal = Math.Abs(colunaDestino - colunaOrigem);


            if (peca == 'B' && deslocamentoVertical == deslocamentoHorizontal)
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'P')
                {
                    listaDePecasVermelhas.Add('P');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(3,1);
                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 't')
                {
                    listaDePecasVermelhas.Add('t');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(3,1);
                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'c')
                {
                    listaDePecasVermelhas.Add('c');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(3,1);
                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'b')
                {
                    listaDePecasVermelhas.Add('b');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(3,1);
                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'q')
                {
                    listaDePecasVermelhas.Add('q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(3,1);
                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'k')
                {
                    listaDePecasVermelhas.Add('k');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(3,1);
                    return;
                }


                // Tratamento caso o jogador coma a própria peça
                while (pecaInimiga == 'p' || pecaInimiga == 'T' || pecaInimiga == 'C' || pecaInimiga == 'B' || pecaInimiga == 'Q' || pecaInimiga == 'K')
                {
                    // Mostrar o tabuleiro
                    TabuleiroXadrez.MostrarTabuleiro(8);

                    // Input do usuario novamente
                    JogoXadrez.VezJogador1();

                    if(pecaInimiga != 'p' || pecaInimiga != 'T' || pecaInimiga != 'C' || pecaInimiga != 'B' || pecaInimiga != 'Q' || pecaInimiga != 'K')
                    {
                        JogoXadrez.VezJogador2();
                    }

                }



                // Torre vai chegar
                tabuleiroXadrez[linhaDestino, colunaDestino] = tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }

            if (peca == 'b' && deslocamentoVertical == deslocamentoHorizontal)
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'p')
                {
                    listaDePecasBrancas.Add('p');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(3,2);
                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 'T')
                {
                    listaDePecasBrancas.Add('T');


                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(3,2);
                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'C')
                {
                    listaDePecasBrancas.Add('C');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(3,2);
                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'B')
                {
                    listaDePecasBrancas.Add('B');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(3,2);
                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'Q')
                {
                    listaDePecasBrancas.Add('Q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(3,2);
                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'K')
                {
                    listaDePecasBrancas.Add('K');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(3,2);
                    return;
                }


                // Tratamento caso o jogador coma a própria peça
                while (pecaInimiga == 'P' || pecaInimiga == 't' || pecaInimiga == 'c' || pecaInimiga == 'b' || pecaInimiga == 'q' || pecaInimiga == 'k')
                {
                    // Mostrar o tabuleiro
                    TabuleiroXadrez.MostrarTabuleiro(8);

                    // Input do usuario novamente
                    JogoXadrez.VezJogador2();

                    if (pecaInimiga == 'P' || pecaInimiga == 't' || pecaInimiga == 'c' || pecaInimiga == 'b' || pecaInimiga == 'q' || pecaInimiga == 'k')
                    {
                        JogoXadrez.VezJogador1();
                    }

                }

                // Torre vai chegar
                tabuleiroXadrez[linhaDestino, colunaDestino] = tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }

        }


        // # Se o movimento da peça cavalo simular a letra L
        public static void VerificarPecaCavalo(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            char peca = tabuleiroXadrez[linhaOrigem, colunaOrigem];

            // # Pegar a peça inimiga que vai estar no destino que o usuário vai querer colocar
            char pecaInimiga = tabuleiroXadrez[linhaDestino, colunaDestino];

            deslocamentoVertical = Math.Abs(linhaDestino - linhaOrigem);
            deslocamentoHorizontal = Math.Abs(colunaDestino - colunaOrigem);


            // # Movimentos do cavalo, vai simular como se estivesse escrevendo a letra L, então se deslocamento vertical for igual a 1 e deslocamento horizontal for igual a 2 | bispo pode mexer

            if (peca == 'C' && (deslocamentoVertical == 1 && deslocamentoHorizontal == 2 ||
                deslocamentoVertical == 2 && deslocamentoHorizontal == 1))
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'P')
                {
                    listaDePecasVermelhas.Add('P');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(3,1);
                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 't')
                {
                    listaDePecasVermelhas.Add('t');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(3,1);
                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'c')
                {
                    listaDePecasVermelhas.Add('c');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(3,1);
                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'b')
                {
                    listaDePecasVermelhas.Add('b');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(3,1);
                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'q')
                {
                    listaDePecasVermelhas.Add('q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(3,1);
                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'k')
                {
                    listaDePecasVermelhas.Add('k');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(3,1);
                    return;
                }

                // Torre vai chegar
                tabuleiroXadrez[linhaDestino, colunaDestino] = tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }


            if (peca == 'c' && (deslocamentoVertical == 1 && deslocamentoHorizontal == 2 ||
                deslocamentoVertical == 2 && deslocamentoHorizontal == 1))
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'p')
                {
                    listaDePecasBrancas.Add('p');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(3,2);
                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 'T')
                {
                    listaDePecasBrancas.Add('T');


                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(3,2);
                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'C')
                {
                    listaDePecasBrancas.Add('C');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(3,2);
                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'B')
                {
                    listaDePecasBrancas.Add('B');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(3,2);
                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'Q')
                {
                    listaDePecasBrancas.Add('Q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(3,2);
                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'K')
                {
                    listaDePecasBrancas.Add('K');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(3,2);
                    return;
                }

                // Cavalo vai chegar
                tabuleiroXadrez[linhaDestino, colunaDestino] = tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

            }
        }


        // # Se o movimento da peça Rainha tiver a mesma quantidade de vezes que for o movimento horizontal ou vertical
        public static void VerificarPecaRainha(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            char peca = tabuleiroXadrez[linhaOrigem, colunaOrigem];

            // # Pegar a peça inimiga que vai estar no destino que o usuário vai querer colocar
            char pecaInimiga = tabuleiroXadrez[linhaDestino, colunaDestino];

            deslocamentoVertical = Math.Abs(linhaDestino - linhaOrigem);
            deslocamentoHorizontal = Math.Abs(colunaDestino - colunaOrigem);


            /* 
                No movimento da rainha temos a condição que: 
                Se o deslocamento vertical for a mesma quantidade de quadradinhos que o deslocamento horizontal = Pode mexer
                Se o deslocamente horizontal for igual a 0 = pode mexer 
                Se o deslocamento vertical for igual a 0 = pode mexer
            */
            if (peca == 'Q' && (deslocamentoVertical == deslocamentoHorizontal ||
                deslocamentoVertical == 0 || deslocamentoHorizontal == 0))
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'P')
                {
                    listaDePecasVermelhas.Add('P');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(9,1);
                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 't')
                {
                    listaDePecasVermelhas.Add('t');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(9,1);
                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'c')
                {
                    listaDePecasVermelhas.Add('c');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(9,1);
                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'b')
                {
                    listaDePecasVermelhas.Add('b');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(9,1);
                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'q')
                {
                    listaDePecasVermelhas.Add('q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(9,1);
                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'k')
                {
                    listaDePecasVermelhas.Add('k');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(9,1);
                    return;
                }

                // Torre vai chegar
                tabuleiroXadrez[linhaDestino, colunaDestino] = tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }

            if (peca == 'q' && (deslocamentoVertical == deslocamentoHorizontal ||
                deslocamentoVertical == 0 || deslocamentoHorizontal == 0))
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'p')
                {
                    listaDePecasBrancas.Add('p');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(9,2);
                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 'T')
                {
                    listaDePecasBrancas.Add('T');


                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(9,2);
                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'C')
                {
                    listaDePecasBrancas.Add('C');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(9,2);
                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'B')
                {
                    listaDePecasBrancas.Add('B');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(9,2);
                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'Q')
                {
                    listaDePecasBrancas.Add('Q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(9,2);
                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'K')
                {
                    listaDePecasBrancas.Add('K');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(9,2);
                    return;
                }

                // Cavalo vai chegar
                tabuleiroXadrez[linhaDestino, colunaDestino] = tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }
        }

        // # Se o movimento da peça Rei andar apenas 1 casa
        public static void VerificarPecaRei(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            char peca = tabuleiroXadrez[linhaOrigem, colunaOrigem];

            // # Pegar a peça inimiga que vai estar no destino que o usuário vai querer colocar
            char pecaInimiga = tabuleiroXadrez[linhaDestino, colunaDestino];


            deslocamentoVertical = Math.Abs(linhaDestino - linhaOrigem);
            deslocamentoHorizontal = Math.Abs(colunaDestino - colunaOrigem);

            // #  O rei só pode deslocar uma casa tanto na vertical como na horizontal 

            if (peca == 'K' && deslocamentoVertical >= 0 && deslocamentoVertical <= 1 && deslocamentoHorizontal >= 0 && deslocamentoHorizontal <= 1)
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'P')
                {
                    listaDePecasVermelhas.Add('P');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 't')
                {
                    listaDePecasVermelhas.Add('t');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'c')
                {
                    listaDePecasVermelhas.Add('c');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'b')
                {
                    listaDePecasVermelhas.Add('b');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'q')
                {
                    listaDePecasVermelhas.Add('q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'k')
                {
                    listaDePecasVermelhas.Add('k');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    return;
                }

                // Torre vai chegar
                tabuleiroXadrez[linhaDestino, colunaDestino] = tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }

            if (peca == 'k' && deslocamentoVertical >= 0 && deslocamentoVertical <= 1 && deslocamentoHorizontal >= 0 && deslocamentoHorizontal <= 1)
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'p')
                {
                    listaDePecasBrancas.Add('p');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 'T')
                {
                    listaDePecasBrancas.Add('T');


                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'C')
                {
                    listaDePecasBrancas.Add('C');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'B')
                {
                    listaDePecasBrancas.Add('B');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'Q')
                {
                    listaDePecasBrancas.Add('Q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'K')
                {
                    listaDePecasBrancas.Add('K');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    return;
                }

                // Cavalo vai chegar
                tabuleiroXadrez[linhaDestino, colunaDestino] = tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }

        }

        // # Se o movimento da peça Peoao andar apenas pra frente 1 casa
        public static void VerificarPecaPeao(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            char peca = tabuleiroXadrez[linhaOrigem, colunaOrigem];

            // # Pegar a peça inimiga que vai estar no destino que o usuário vai querer colocar
            char pecaInimiga = tabuleiroXadrez[linhaDestino, colunaDestino];

            deslocamentoVertical = Math.Abs(linhaDestino - linhaOrigem);
            deslocamentoHorizontal = Math.Abs(colunaDestino - colunaOrigem);

            // #  O peão só pode andar apenas 1 casa para frente na mesma coluna

            if (peca == 'p' && linhaDestino - linhaOrigem == 1 && deslocamentoHorizontal == 0)
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'p')
                {
                    listaDePecasBrancas.Add('p');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(1,1);
                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 'T')
                {
                    listaDePecasBrancas.Add('T');


                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(1,1);
                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'C')
                {
                    listaDePecasBrancas.Add('C');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(1,1);
                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'B')
                {
                    listaDePecasBrancas.Add('B');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(1,1);
                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'Q')
                {
                    listaDePecasBrancas.Add('Q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(1,1);
                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'K')
                {
                    listaDePecasBrancas.Add('K');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario1.setPontuacaoJogador(1,1);
                    return;
                }

                // Cavalo vai chegar
                tabuleiroXadrez[linhaDestino, colunaDestino] = tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }
            if (peca == 'P' && linhaOrigem - linhaDestino == 1 && deslocamentoHorizontal == 0)
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'P')
                {
                    listaDePecasVermelhas.Add('P');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(1,2);
                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 't')
                {
                    listaDePecasVermelhas.Add('t');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(1,2);
                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'c')
                {
                    listaDePecasVermelhas.Add('c');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(1,2);
                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'b')
                {
                    listaDePecasVermelhas.Add('b');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(1,2);
                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'q')
                {
                    listaDePecasVermelhas.Add('q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(1,2);
                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'k')
                {
                    listaDePecasVermelhas.Add('k');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Usuario.usuario2.setPontuacaoJogador(1,2);
                    return;
                }

                // Torre vai chegar
                tabuleiroXadrez[linhaDestino, colunaDestino] = tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }
        }


        // # Método para mover a peça
        public static bool MoverPeca(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // Caso o usuário digite corretamente o intervalo do tabuleiro 8x8: Retorna true ou false
            if (linhaOrigem >= 0 && linhaOrigem < 8 && colunaOrigem >= 0 && colunaOrigem < 8 &&
                linhaDestino >= 0 && linhaDestino < 8 && colunaDestino >= 0 && colunaDestino < 8)
            {
                // Verifica o movimento da torre para fazer o movimento
                VerificarPecaTorre(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                // Verifica o movimento do bispo para fazer o movimento
                VerificarPecaBispo(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                // Verifica o movimento do cavalo para fazer o movimento
                VerificarPecaCavalo(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                // Verifica o movimento da rainha para fazer o movimento
                VerificarPecaRainha(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                // Verifica o movimento do rei para fazer o movimento
                VerificarPecaRei(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                // Verifica o movimento do peão para fazer o movimento
                VerificarPecaPeao(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
