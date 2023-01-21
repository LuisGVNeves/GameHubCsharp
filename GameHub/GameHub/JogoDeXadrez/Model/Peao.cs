using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;
using GameHub.JogoDeXadrez.Controller;
using GameHub.JogoDeXadrez.View;


namespace GameHub.JogoDeXadrez.Model
{
    class Peao
    {
        // # Se o movimento da peça Peoao andar apenas pra frente 1 casa
        public static void VerificarPecaPeao(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            char peca = TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem];

            // # Pegar a peça inimiga que vai estar no destino que o usuário vai querer colocar
            char pecaInimiga = TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino];

            Pecas.deslocamentoVertical = Math.Abs(linhaDestino - linhaOrigem);
            Pecas.deslocamentoHorizontal = Math.Abs(colunaDestino - colunaOrigem);

            // # Tratamento - Se o peão tiver algum deslocamento horizontal, então vou fazer com que o jogador atual, jogue novamente
            while((peca == 'p' || peca == 'P') && Pecas.deslocamentoHorizontal >= 1)
            {
                if(peca == 'p')
                {
                    MenuHub.AdicionarTexto("\n\nPeça peão não pode ser movida pros lados ! \n\n", ConsoleColor.DarkRed);
                    Thread.Sleep(2000);
                    Console.Clear();
                    TabuleiroXadrez.MostrarTabuleiro(8);
                    JogoXadrez.VezJogador1();
                }

                if(peca == 'P')
                {
                    MenuHub.AdicionarTexto("\n\nPeça peão não pode ser movida pros lados ! \n\n", ConsoleColor.DarkRed);
                    Thread.Sleep(2000);
                    Console.Clear();
                    TabuleiroXadrez.MostrarTabuleiro(8);

                    JogoXadrez.VezJogador2();
                }
            }


            // # Tratamento - Se o peão quiser se mover acima de 2 casas na vertical, então vai ser um movimento invalido porque o peão só pode mover 2 casas na primeira jogada, e depois apenas 1 casa para cada peão
            while((peca == 'p' || peca == 'P') && Pecas.deslocamentoVertical <= 2 && Pecas.deslocamentoHorizontal == 0)
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


            // # Tratamento - Se o peão se deslocar apenas na vertical, então só pode andar apenas 1 casa para frente na mesma coluna
            if (peca == 'P' && Pecas.deslocamentoVertical == 1 && Pecas.deslocamentoHorizontal == 0)
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

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                // Se houver torres inimigas
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

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
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

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
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

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
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

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
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

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
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

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                // Tratamento caso o jogador coma a própria peça
                while (pecaInimiga == 'P' || pecaInimiga == 't' || pecaInimiga == 'c' || pecaInimiga == 'b' || pecaInimiga == 'q' || pecaInimiga == 'k')
                {
                    // Mostrar o tabuleiro
                    TabuleiroXadrez.MostrarTabuleiro(8);

                    // Input do usuario novamente
                    JogoXadrez.VezJogador2();

                    // Se a peça for inimiga, ai o jogador inimigo pode jogar
                    if (pecaInimiga == 'P' || pecaInimiga == 't' || pecaInimiga == 'c' || pecaInimiga == 'b' || pecaInimiga == 'q' || pecaInimiga == 'k')
                    {
                        JogoXadrez.VezJogador1();
                    }

                }

                // Torre vai chegar
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }
            if (peca == 'p' && Pecas.deslocamentoVertical == 1 && Pecas.deslocamentoHorizontal == 0)
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

                    Cadastro.usuario1.setPontuacaoJogador(1, 1);
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

                    Cadastro.usuario1.setPontuacaoJogador(1, 1);
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

                    Cadastro.usuario1.setPontuacaoJogador(1, 1);
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

                    Cadastro.usuario1.setPontuacaoJogador(1, 1);
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

                    Cadastro.usuario1.setPontuacaoJogador(1, 1);
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

                    Cadastro.usuario1.setPontuacaoJogador(1, 1);
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

                // Cavalo vai chegar
                TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem];

                // Lugar onde a peça saiu vai ficar vazio
                TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
            }


        }
    }
}
