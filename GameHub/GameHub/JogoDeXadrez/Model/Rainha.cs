using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;
using GameHub.JogoDeXadrez.Controller;


namespace GameHub.JogoDeXadrez.Model
{
    class Rainha : TabuleiroXadrez
    {
        public static TabuleiroXadrez tabuleiroXadrez = new TabuleiroXadrez();


        // # Se o movimento da peça Rainha tiver a mesma quantidade de vezes que for o movimento horizontal ou vertical
        public static void VerificarPecaRainha(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            char peca = TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem];

            // # Pegar a peça inimiga que vai estar no destino que o usuário vai querer colocar
            char pecaInimiga = TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino];

            Pecas.deslocamentoVertical = Math.Abs(linhaDestino - linhaOrigem);
            Pecas.deslocamentoHorizontal = Math.Abs(colunaDestino - colunaOrigem);


            /* 
                No movimento da rainha temos a condição que: 
                Se o deslocamento vertical for a mesma quantidade de quadradinhos que o deslocamento horizontal = Pode mexer
                Se o deslocamente horizontal for igual a 0 = pode mexer 
                Se o deslocamento vertical for igual a 0 = pode mexer

                - Se ela se deslocar só na vertical ta autorizado, só na horizontal também ta autorizado, e se ela se mover na diagonal também é de boa
            */
            if (peca == 'Q' && (Pecas.deslocamentoVertical == Pecas.deslocamentoHorizontal ||
                Pecas.deslocamentoVertical == 0 || Pecas.deslocamentoHorizontal == 0))
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

                    Cadastro.usuario1.setPontuacaoJogador(9, 1);
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

                    Cadastro.usuario1.setPontuacaoJogador(9, 1);
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

                    Cadastro.usuario1.setPontuacaoJogador(9, 1);
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

                    Cadastro.usuario1.setPontuacaoJogador(9, 1);
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

                    Cadastro.usuario1.setPontuacaoJogador(9, 1);
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

                    Cadastro.usuario1.setPontuacaoJogador(9, 1);
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

            if (peca == 'q' && (Pecas.deslocamentoVertical == Pecas.deslocamentoHorizontal ||
                Pecas.deslocamentoVertical == 0 || Pecas.deslocamentoHorizontal == 0))
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

                    Cadastro.usuario2.setPontuacaoJogador(9, 2);
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

                    Cadastro.usuario2.setPontuacaoJogador(9, 2);
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

                    Cadastro.usuario2.setPontuacaoJogador(9, 2);
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

                    Cadastro.usuario2.setPontuacaoJogador(9, 2);
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

                    Cadastro.usuario2.setPontuacaoJogador(9, 2);
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

                    Cadastro.usuario2.setPontuacaoJogador(9, 2);
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
