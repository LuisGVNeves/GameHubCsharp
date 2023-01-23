using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;
using GameHub.JogoDeXadrez.Controller;
using GameHub.JogoDeXadrez.View;


namespace GameHub.JogoDeXadrez.Model
{
    class Peao
    {
        public static char peca;
        public static char pecaInimiga;

        // # Se o movimento da peça Peoao andar apenas pra frente 1 casa
        public static void VerificarPecaPeao(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            peca = TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem];

            // # Pegar a peça inimiga que vai estar no destino que o usuário vai querer colocar
            pecaInimiga = TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino];

            Pecas.deslocamentoVertical = Math.Abs(linhaDestino - linhaOrigem);
            Pecas.deslocamentoHorizontal = Math.Abs(colunaDestino - colunaOrigem);

            // # Verifica se o movimento do peão da pra abater a peça inimiga
            AbaterPecas(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

            // # Verifica se o movimento da peça pra horizontal é mais de 1 casa, se for vai proibir
            VerificarMovimentoHorizontal();

            // # Verifica se o movimento da peça pra vertical é mais de uma 1 casa, se for vai proibir
            VerificarMovimentoVerticalPeao(linhaOrigem,colunaOrigem,linhaDestino,colunaDestino);


        }

        public static void VerificarMovimentoVerticalPeao(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Tratamento - Se o peão quiser se mover acima de 2 casas na vertical, então vai ser um movimento invalido porque o peão só pode mover 2 casas na primeira jogada, e depois apenas 1 casa para cada peão
            while ((peca == 'p' || peca == 'P') && Pecas.deslocamentoVertical > 1 && Pecas.deslocamentoHorizontal == 0)
            {
                if (peca == 'p')
                {
                    MenuHub.AdicionarTexto("\n\nMovimento inválido da peça peão\n\n", ConsoleColor.DarkRed);
                    Thread.Sleep(2000);
                    Console.Clear();
                    TabuleiroXadrez.MostrarTabuleiro(8);
                    JogoXadrez.VezJogador1();
                }

                if (peca == 'P')
                {
                    MenuHub.AdicionarTexto("\n\nMovimento inválido da peça peão\n\n", ConsoleColor.DarkRed);
                    Thread.Sleep(2000);
                    Console.Clear();
                    TabuleiroXadrez.MostrarTabuleiro(8);

                    JogoXadrez.VezJogador2();
                }
            }

            // # Tratamento - Se o peão se deslocar apenas na vertical, e tiver peças na frente, o movimento não vai acontecer
            if (peca == 'P' && Pecas.deslocamentoVertical == 1 && Pecas.deslocamentoHorizontal == 0)
            {
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'p' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'B' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'T' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'C' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'Q' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'K' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'p' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'b' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 't' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'c' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'q' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'k')
                {
                    MenuHub.AdicionarTexto("\n  Movimento do peão inválido", ConsoleColor.DarkRed);
                    Thread.Sleep(2000);

                    // Mostrar o tabuleiro
                    TabuleiroXadrez.MostrarTabuleiro(8);

                    JogoXadrez.VezJogador2();
                }
                else
                {
                    // # Verifica se o movimento do peão da pra abater a peça inimiga
                    AbaterPecas(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                    // Peão vai chegar
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem];

                    // Lugar onde a peça saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
                }
            }

            if (peca == 'p' && Pecas.deslocamentoVertical == 1 && Pecas.deslocamentoHorizontal == 0)
            {
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'p' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'B' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'T' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'C' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'Q' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'K' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'p' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'b' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 't' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'c' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'q' ||
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'k')
                {
                    MenuHub.AdicionarTexto("\n  Movimento do peão inválido", ConsoleColor.DarkRed);
                    Thread.Sleep(2000);

                    // Mostrar o tabuleiro
                    TabuleiroXadrez.MostrarTabuleiro(8);

                    JogoXadrez.VezJogador1();
                }
                else
                {
                    // # Verifica se o movimento do peão da pra abater a peça inimiga
                    AbaterPecas(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                    // Peão vai chegar
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem];

                    // Lugar onde a peça saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
                }

            }
        }

        public static void VerificarMovimentoHorizontal()
        {
            // # Tratamento - Se o peão tiver algum deslocamento horizontal, então vou fazer com que o jogador atual, jogue novamente
            while ((peca == 'p' || peca == 'P') && Pecas.deslocamentoHorizontal > 1)
            {
                // Peça Peão
                if (peca == 'P')
                {
                    MenuHub.AdicionarTexto("\n\nPeça peão não pode ser movida pros lados ! \n\n", ConsoleColor.DarkRed);
                    Thread.Sleep(2000);
                    Console.Clear();
                    TabuleiroXadrez.MostrarTabuleiro(8);
                    JogoXadrez.VezJogador2();
                }

                // Peça peão
                if (peca == 'p')
                {
                    MenuHub.AdicionarTexto("\n\nPeça peão não pode ser movida pros lados ! \n\n", ConsoleColor.DarkRed);
                    Thread.Sleep(2000);
                    Console.Clear();
                    TabuleiroXadrez.MostrarTabuleiro(8);
                    JogoXadrez.VezJogador1();
                }

                return;
            }
        }

        public static void AbaterPecas(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Se a peça for igual a P e o deslocamento diagonal for igual a 1 tanto pro lado direito como pro esquerdo, e se no lado direito e esquerdo for vazio, eu posso realizar o movimento

            if (peca == 'P' && Pecas.deslocamentoVertical == 1 && Pecas.deslocamentoHorizontal == 1 && TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == ' ')
            {
                // O destino vai receber a peça inimiga vazia
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                // Depois vai receber a peça atual
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                // Lugar onde a torre saiu vai ficar vazio
                TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                // - Se quando o peão for pra esquerda ou direita tiver a peça em questão, vou fazer a substituição

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] == 'p' || TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] == 'p')
                {
                    Pecas.listaDePecasBrancas.Add('p');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] == 'B' || TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] == 'B')
                {
                    Pecas.listaDePecasBrancas.Add('B');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                // Se houver torres inimigas
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] == 'T' || TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] == 'T')
                {
                    Pecas.listaDePecasBrancas.Add('T');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                // Se houver cavalos inimigos
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] == 'C' || TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] == 'C')
                {
                    Pecas.listaDePecasBrancas.Add('C');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                // Se houver queen inimigos
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] == 'Q' || TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] == 'Q')
                {
                    Pecas.listaDePecasBrancas.Add('Q');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                // Se houver king inimigos
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] == 'K' || TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] == 'K')
                {
                    Pecas.listaDePecasBrancas.Add('K');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

            }
            else
            {
                while (peca == 'P' && Pecas.deslocamentoVertical == 1 && Pecas.deslocamentoHorizontal == 1 && TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] != ' ')
                {
                    MenuHub.AdicionarTexto("Não é possivel realizar o movimento En Passant, porque já está ocupado", ConsoleColor.DarkRed);
                    Thread.Sleep(2000);

                    // Mostrar o tabuleiro
                    TabuleiroXadrez.MostrarTabuleiro(8);

                    JogoXadrez.VezJogador2();
                }
            }


            if (peca == 'p' && Pecas.deslocamentoVertical == 1 && Pecas.deslocamentoHorizontal == 1 && TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == ' ')
            {
                // O destino vai receber a peça inimiga vazia
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = pecaInimiga;

                // Depois vai receber a peça atual
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = peca;

                // Lugar onde a torre saiu vai ficar vazio
                TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                // Se quando o peão for pra esquerda ou direita tiver a peça em questão, vou fazer a substituição

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] == 'P' || TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] == 'P')
                {
                Pecas.listaDePecasVermelhas.Add('P');

                TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] = ' ';
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] = ' ';

                Cadastro.usuario1.setPontuacaoJogador(1, 2);
                return;
            }

            // Se houver torres inimigas
            if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] == 't' || TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] == 't')
            {
                Pecas.listaDePecasVermelhas.Add('t');

                TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] = ' ';
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] = ' ';

                Cadastro.usuario1.setPontuacaoJogador(1, 2);
                return;
            }

            // Se houver cavalos inimigos
            if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] == 'c' || TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] == 'c')
            {
                Pecas.listaDePecasVermelhas.Add('c');

                TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] = ' ';
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] = ' ';

                Cadastro.usuario1.setPontuacaoJogador(1, 2);
                return;
            }

            // // Quando o peão se mover pra esquerda ou direita, se a peça que fica no meio for o bispo, vou substituir por ' '
            if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] == 'b' || TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] == 'b')
            {
                Pecas.listaDePecasVermelhas.Add('b');

                TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] = ' ';
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] = ' ';

                Cadastro.usuario1.setPontuacaoJogador(1, 2);
                return;
            }

            // Quando o peão se mover pra esquerda ou direita, se a peça que fica no meio for a rainha, vou substituir por ' '
            if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] == 'q' || TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] == 'q')
            {
                Pecas.listaDePecasVermelhas.Add('q');

                TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] = ' ';
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] = ' ';

                Cadastro.usuario1.setPontuacaoJogador(1, 2);
                return;
            }

            // Quando o peão se mover pra esquerda ou direita, se a peça que fica no meio for o king, vou substituir por ' '
            if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] == 'k' || TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] == 'k')
            {
                Pecas.listaDePecasVermelhas.Add('k');

                TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 1] = ' ';
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino + 1] = ' ';

                Cadastro.usuario1.setPontuacaoJogador(1, 2);
                return;
            }

        }
            else
            {
                while (peca == 'p' && Pecas.deslocamentoVertical == 1 && Pecas.deslocamentoHorizontal == 1 && TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] != ' ')
                {
                    MenuHub.AdicionarTexto("Não é possivel realizar o movimento En Passant, porque já está ocupado", ConsoleColor.DarkRed);
                    Thread.Sleep(2000);

                    // Mostrar o tabuleiro
                    TabuleiroXadrez.MostrarTabuleiro(8);

                    JogoXadrez.VezJogador1();
                }
            }
        }


    }
}
