using GameHub.HubAssets.Model;
using GameHub.HubAssets.View;
using GameHub.JogoDeXadrez.Controller;


namespace GameHub.JogoDeXadrez.Model
{
    class Bispo : TabuleiroXadrez
    {
        public static char peca;
        public static char pecaInimiga;

        // # Se o movimento da peça Bispo tiver a mesma quantidade de vezes que for o movimento horizontal ou vertical, ou seja, ele sempre vai se movimentar na diagonal
        public static void VerificarPecaBispo(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // # Pegar a peça que o usuário vai alterar no tabuleiro
            peca = TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem];

            // # Pegar a peça inimiga que vai estar no destino que o usuário vai querer colocar
            pecaInimiga = TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino];

            // # Movimentos do bispo, se deslocamento vertical for igual ao deslocamento horizontal | bispo pode mexer
            Pecas.deslocamentoVertical = Math.Abs(linhaDestino - linhaOrigem);
            Pecas.deslocamentoHorizontal = Math.Abs(colunaDestino - colunaOrigem);


            VerificarCasaVazia(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);
            VerificarMovimentoBispo(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);
            JogadorComePropriaPeca(peca);
        }

        // # Método para verificar se onde o bispo vai se deslocar, está vazio
        static void VerificarCasaVazia(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            if (peca == 'B' && Pecas.deslocamentoVertical == Pecas.deslocamentoHorizontal)
            {
                // Se o bispo na movimentação se mover pra uma casa vazia
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == ' ')
                {
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'B';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
                }
            }

            if (peca == 'b' && Pecas.deslocamentoVertical == Pecas.deslocamentoHorizontal)
            {
                // Se o bispo na movimentação se mover pra uma casa vazia
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == ' ')
                {
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'b';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';
                }
            }
        }

        static void VerificarMovimentoBispo(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            if (peca == 'B' && Pecas.deslocamentoVertical == Pecas.deslocamentoHorizontal)
            {
                // Quando o bispo se mover, se uma casa anterior na diagonal for a peça inimiga em questão, vou retirar ela substituindo por ' ' vazia e adicionando o B no lugar
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] == 'P')
                {
                    Pecas.listaDePecasVermelhas.Add('P');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] == 't')
                {
                    Pecas.listaDePecasVermelhas.Add('t');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] == 'c')
                {
                    Pecas.listaDePecasVermelhas.Add('c');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] == 'b')
                {
                    Pecas.listaDePecasVermelhas.Add('b');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] == 'q')
                {
                    Pecas.listaDePecasVermelhas.Add('q');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] == 'k')
                {
                    Pecas.listaDePecasVermelhas.Add('k');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);

                    Console.Clear();
                    MenuHub.AdicionarTexto("                CHEQUE MATE !           ", ConsoleColor.DarkGreen);
                    Thread.Sleep(2000);
                    MenuHub.MenuInicialHub();
                    return;
                }



                // Quando o bispo se mover, se uma casa superior na diagonal for a peça inimiga em questão, vou retirar ela substituindo por ' ' vazia e adicionando o B no lugar
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] == 'P')
                {
                    Pecas.listaDePecasVermelhas.Add('P');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] == 't')
                {
                    Pecas.listaDePecasVermelhas.Add('t');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] == 'c')
                {
                    Pecas.listaDePecasVermelhas.Add('c');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] == 'b')
                {
                    Pecas.listaDePecasVermelhas.Add('b');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] == 'q')
                {
                    Pecas.listaDePecasVermelhas.Add('q');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] == 'k')
                {
                    Pecas.listaDePecasVermelhas.Add('k');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);

                    Console.Clear();
                    MenuHub.AdicionarTexto("                CHEQUE MATE !           ", ConsoleColor.DarkGreen);
                    Thread.Sleep(2000);
                    MenuHub.MenuInicialHub();
                    return;
                }


                // Quando o bispo se mover diretamente na diagonal pra peça inimiga, vou substituir
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'P')
                {
                    Pecas.listaDePecasVermelhas.Add('P');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'B';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 't')
                {
                    Pecas.listaDePecasVermelhas.Add('t');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'B';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'c')
                {
                    Pecas.listaDePecasVermelhas.Add('c');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'B';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'b')
                {
                    Pecas.listaDePecasVermelhas.Add('b');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'B';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'q')
                {
                    Pecas.listaDePecasVermelhas.Add('q');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'B';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'k')
                {
                    Pecas.listaDePecasVermelhas.Add('k');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'B';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario1.setPontuacaoJogador(1, 2);
                    Console.Clear();
                    MenuHub.AdicionarTexto("                CHEQUE MATE !           ", ConsoleColor.DarkGreen);
                    Thread.Sleep(2000);
                    MenuHub.MenuInicialHub();
                    return;
                }

            }

            if (peca == 'b' && Pecas.deslocamentoVertical == Pecas.deslocamentoHorizontal)
            {

                // Quando o bispo se mover, se uma casa anterior na diagonal for a peça inimiga em questão, vou retirar ela substituindo por ' ' vazia e adicionando o B no lugar
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] == 'p')
                {
                    Pecas.listaDePecasBrancas.Add('p');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] == 'T')
                {
                    Pecas.listaDePecasBrancas.Add('T');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] == 'C')
                {
                    Pecas.listaDePecasBrancas.Add('C');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] == 'B')
                {
                    Pecas.listaDePecasBrancas.Add('B');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] == 'Q')
                {
                    Pecas.listaDePecasBrancas.Add('Q');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] == 'K')
                {
                    Pecas.listaDePecasBrancas.Add('K');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 1, colunaDestino - 1] = 'B';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);

                    Console.Clear();
                    MenuHub.AdicionarTexto("                CHEQUE MATE !           ", ConsoleColor.DarkGreen);
                    Thread.Sleep(2000);
                    MenuHub.MenuInicialHub();
                    return;
                }



                // Quando o bispo se mover, se uma casa superior na diagonal for a peça inimiga em questão, vou retirar ela substituindo por ' ' vazia e adicionando o B no lugar
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] == 'p')
                {
                    Pecas.listaDePecasBrancas.Add('p');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = 'b';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] == 'T')
                {
                    Pecas.listaDePecasBrancas.Add('T');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = 'b';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] == 'C')
                {
                    Pecas.listaDePecasBrancas.Add('C');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = 'b';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] == 'B')
                {
                    Pecas.listaDePecasBrancas.Add('B');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = 'b';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] == 'Q')
                {
                    Pecas.listaDePecasBrancas.Add('Q');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = 'b';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] == 'K')
                {
                    Pecas.listaDePecasBrancas.Add('K');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino - 0, colunaDestino - 0] = 'b';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    Console.Clear();
                    MenuHub.AdicionarTexto("                CHEQUE MATE !           ", ConsoleColor.DarkGreen);
                    Thread.Sleep(2000);
                    MenuHub.MenuInicialHub();
                    return;
                }


                // Quando o bispo se mover diretamente na diagonal pra peça inimiga, vou substituir
                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'p')
                {
                    Pecas.listaDePecasBrancas.Add('p');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'b';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'T')
                {
                    Pecas.listaDePecasBrancas.Add('T');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'b';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'C')
                {
                    Pecas.listaDePecasBrancas.Add('C');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'b';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'B')
                {
                    Pecas.listaDePecasBrancas.Add('B');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'B';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'Q')
                {
                    Pecas.listaDePecasBrancas.Add('Q');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'b';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    return;
                }

                if (TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] == 'K')
                {
                    Pecas.listaDePecasBrancas.Add('K');

                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = ' ';
                    TabuleiroXadrez.tabuleiroXadrez[linhaDestino, colunaDestino] = 'b';

                    // Lugar onde bispo saiu vai ficar vazio
                    TabuleiroXadrez.tabuleiroXadrez[linhaOrigem, colunaOrigem] = ' ';

                    Cadastro.usuario2.setPontuacaoJogador(1, 2);
                    Console.Clear();
                    MenuHub.AdicionarTexto("                CHEQUE MATE !           ", ConsoleColor.DarkGreen);
                    Thread.Sleep(2000);
                    MenuHub.MenuInicialHub();
                    return;
                }

            }
        }

        static void JogadorComePropriaPeca(char peca)
        {
            // Tratamento caso o jogador coma a própria peça
            
            if(peca == 'B')
            {
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
            }
            
            if(peca == 'b')
            {
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
            }
        }

    }
}
