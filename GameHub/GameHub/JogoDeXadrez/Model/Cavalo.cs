﻿using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;
using GameHub.JogoDeXadrez.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.JogoDeXadrez.Model
{
    class Cavalo : TabuleiroXadrez
    {
        public static TabuleiroXadrez tabuleiroXadrez = new TabuleiroXadrez();

        // # Se o movimento da peça cavalo simular a letra L
        public static void VerificarPecaCavalo(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            char peca = TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem];

            // # Pegar a peça inimiga que vai estar no destino que o usuário vai querer colocar
            char pecaInimiga = TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino];

            Pecas.deslocamentoVertical = Math.Abs(linhaDestino - linhaOrigem);
            Pecas.deslocamentoHorizontal = Math.Abs(colunaDestino - colunaOrigem);


            // # Movimentos do cavalo, vai simular como se estivesse escrevendo a letra L, então se deslocamento vertical for igual a 1 e deslocamento horizontal for igual a 2 | bispo pode mexer

            if (peca == 'C' && (Pecas.deslocamentoVertical == 1 && Pecas.deslocamentoHorizontal == 2 ||
                Pecas.deslocamentoVertical == 2 && Pecas.deslocamentoHorizontal == 1))
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'P')
                {
                    Pecas.listaDePecasVermelhas.Add('P');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(3, 1);
                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 't')
                {
                    Pecas.listaDePecasVermelhas.Add('t');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(3, 1);
                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'c')
                {
                    Pecas.listaDePecasVermelhas.Add('c');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(3, 1);
                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'b')
                {
                    Pecas.listaDePecasVermelhas.Add('b');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(3, 1);
                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'q')
                {
                    Pecas.listaDePecasVermelhas.Add('q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(3, 1);
                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'k')
                {
                    Pecas.listaDePecasVermelhas.Add('k');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(3, 1);
                    return;
                }


                // Tratamento caso o jogador coma a própria peça
                while (pecaInimiga == 'p' || pecaInimiga == 'T' || pecaInimiga == 'C' || pecaInimiga == 'B' || pecaInimiga == 'Q' || pecaInimiga == 'K')
                {
                    // Mostrar o tabuleiro
                    tabuleiroXadrez.MostrarTabuleiro(8);

                    // Input do usuario novamente
                    JogoXadrez.VezJogador1();

                    if (pecaInimiga != 'p' || pecaInimiga != 'T' || pecaInimiga != 'C' || pecaInimiga != 'B' || pecaInimiga != 'Q' || pecaInimiga != 'K')
                    {
                        JogoXadrez.VezJogador2();
                    }

                }


                // Torre vai chegar
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }


            if (peca == 'c' && (Pecas.deslocamentoVertical == 1 && Pecas.deslocamentoHorizontal == 2 ||
                Pecas.deslocamentoVertical == 2 && Pecas.deslocamentoHorizontal == 1))
            {
                // Se onde a torre for ficar, tiver os peões do inimigo, usuario 1 ganha 5 pontos
                if (pecaInimiga == 'p')
                {
                    Pecas.listaDePecasBrancas.Add('p');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(3, 2);
                    return;

                }

                // Se houver torres inimigas
                if (pecaInimiga == 'T')
                {
                    Pecas.listaDePecasBrancas.Add('T');


                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(3, 2);
                    return;
                }

                // Se houver cavalos inimigos
                if (pecaInimiga == 'C')
                {
                    Pecas.listaDePecasBrancas.Add('C');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(3, 2);
                    return;
                }

                // Se houver bispos inimigos
                if (pecaInimiga == 'B')
                {
                    Pecas.listaDePecasBrancas.Add('B');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(3, 2);
                    return;
                }

                // Se houver queen inimigos
                if (pecaInimiga == 'Q')
                {
                    Pecas.listaDePecasBrancas.Add('Q');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(3, 2);
                    return;
                }

                // Se houver king inimigos
                if (pecaInimiga == 'K')
                {
                    Pecas.listaDePecasBrancas.Add('K');

                    // Reseto a peça inimiga
                    pecaInimiga = ' ';

                    // O destino vai receber a peça inimiga vazia
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                    // Depois vai receber a torre
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                    // Lugar onde a torre saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(3, 2);
                    return;
                }


                // Tratamento caso o jogador coma a própria peça
                while (pecaInimiga == 'P' || pecaInimiga == 't' || pecaInimiga == 'c' || pecaInimiga == 'b' || pecaInimiga == 'q' || pecaInimiga == 'k')
                {
                    // Mostrar o tabuleiro
                    tabuleiroXadrez.MostrarTabuleiro(8);

                    // Input do usuario novamente
                    JogoXadrez.VezJogador2();

                    if (pecaInimiga == 'P' || pecaInimiga == 't' || pecaInimiga == 'c' || pecaInimiga == 'b' || pecaInimiga == 'q' || pecaInimiga == 'k')
                    {
                        JogoXadrez.VezJogador1();
                    }

                }


                // Cavalo vai chegar
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

            }
        }

    }
}
