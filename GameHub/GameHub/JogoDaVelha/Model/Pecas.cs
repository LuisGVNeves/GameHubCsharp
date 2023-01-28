using GameHub.HubAssets.View;
using GameHub.HubAssets.Model;
using GameHub.JogoDaVelha.Controller;

namespace GameHub.JogoDaVelha.Model
{
    internal class Pecas
    {
        public static TabuleiroJogoDaVelha tabuleiroJogoDaVelha = new TabuleiroJogoDaVelha();

        // # Método para verificar matriz na horizontal e ver se teve X X X ou O O O  na horizontal
        public static void VerificaVitoriaHorizontal(string jogarDeNovo)
        {
            bool linhaHorizontalX;
            bool linhaHorizontalO;

            // # Verifica se a primeira, segunda, terceira linha da matriz teve as linhas prenchidas na ordem orizontal X X X

            linhaHorizontalX =
                (tabuleiroJogoDaVelha.getValorLinhasColunas(0, 0, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(0, 1, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(0, 2, "X"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(1, 0, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 2, "X"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(2, 0, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 1, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 2, "X"));

            // # Verifica se a primeira, segunda, terceira linha da matriz teve as linhas prenchidas na ordem orizontal O O  O

            linhaHorizontalO =
                (tabuleiroJogoDaVelha.getValorLinhasColunas(0, 0, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(0, 1, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(0, 2, "O"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(1, 0, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 2, "O"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(2, 0, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 1, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 2, "O"));


            // # Mostra mensagem caso a vitória tenha sido horizontal tanto de X como de O
            if (Cadastro.usuario1.getLetraJogo() == "X" && linhaHorizontalX)
            {
                MenuHub.AdicionarTexto($"\n\nJogador {Cadastro.usuario1.getNome()} Venceu a partida !", ConsoleColor.Green);
                Console.ResetColor();

                Cadastro.usuario1.setPontuacaoJogador(1, 1);

                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                System.Threading.Thread.Sleep(3000);
                Console.Clear();

                JogoDaVelha.View.Menu.SubMenu();
            }
            if (Cadastro.usuario1.getLetraJogo() == "O" && linhaHorizontalO)
            {
                MenuHub.AdicionarTexto($"\n\nJogador {Cadastro.usuario1.getNome()} Venceu a partida !", ConsoleColor.Green);
                Console.ResetColor();

                Cadastro.usuario1.setPontuacaoJogador(1, 1);
                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
            }
            if (Cadastro.usuario2.getLetraJogo() == "X" && linhaHorizontalX)
            {
                MenuHub.AdicionarTexto($"\n\nJogador {Cadastro.usuario2.getNome()} Venceu a partida !", ConsoleColor.Green);
                Console.ResetColor();

                Cadastro.usuario2.setPontuacaoJogador(1, 2);

                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
            }
            if (Cadastro.usuario2.getLetraJogo() == "O" && linhaHorizontalO)
            {
                MenuHub.AdicionarTexto($"\n\nJogador {Cadastro.usuario2.getNome()} Venceu a partida !", ConsoleColor.Green);
                Console.ResetColor();

                Cadastro.usuario2.setPontuacaoJogador(1, 2);

                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
            }

        }


        // # Método para verificar matriz na vertical e ver se teve X X X ou O O O  na vertical
        public static void VerificaVitoriaVertical(string jogarDeNovo)
        {
            bool linhaVerticalX;
            bool linhaVerticalO;

            linhaVerticalX =
                (tabuleiroJogoDaVelha.getValorLinhasColunas(0, 0, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 0, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 0, "X"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(0, 1, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 1, "X"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(0, 2, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 2, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 2, "X"));
                

            linhaVerticalO =
                (tabuleiroJogoDaVelha.getValorLinhasColunas(0, 0, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 0, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 0, "O"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(0, 1, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 1, "O"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(0, 2, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 2, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 2, "O"));


            // # Mostra mensagem caso a vitória tenha sido vertical tanto de X como de O
            if (Cadastro.usuario1.getLetraJogo() == "X" && linhaVerticalX)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nJogador {Cadastro.usuario1.getNome()} Venceu a partida :D");
                Console.ResetColor();

                Cadastro.usuario1.setPontuacaoJogador(1, 1);

                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();

            }
            if (Cadastro.usuario1.getLetraJogo() == "O" && linhaVerticalO)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nJogador {Cadastro.usuario1.getNome()} Venceu a partida :D");
                Console.ResetColor();

                Cadastro.usuario1.setPontuacaoJogador(1, 1);
                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
            }
            if (Cadastro.usuario2.getLetraJogo() == "X" && linhaVerticalX)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nJogador {Cadastro.usuario2.getNome()} Venceu a partida :D");
                Console.ResetColor();

                Cadastro.usuario2.setPontuacaoJogador(1, 2);

                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();

            }
            if (Cadastro.usuario2.getLetraJogo() == "O" && linhaVerticalO)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nJogador {Cadastro.usuario2.getNome()} Venceu a partida :D");
                Console.ResetColor();

                Cadastro.usuario2.setPontuacaoJogador(1, 2);

                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
            }

        }


        // # Método para verificar matriz na diagonal e ver se teve X X X ou O O O  na diagonal
        public static void VerificaVitoriaDiagonal(string jogarDeNovo)
        {
            bool linhaDiagonalX;
            bool linhaDiagonalO;

            linhaDiagonalX =
                (tabuleiroJogoDaVelha.getValorLinhasColunas(2, 0, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(0, 2, "X"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(0, 2, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 0, "X"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(0, 0, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 2, "X"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(2, 2, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "X") && tabuleiroJogoDaVelha.getValorLinhasColunas(0, 0, "X"));


            // Coluna vertical verificando O
            linhaDiagonalO =
                (tabuleiroJogoDaVelha.getValorLinhasColunas(2, 0, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(0, 2, "O"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(0, 2, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 0, "O"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(0, 0, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(2, 2, "O"))
                ||
                (tabuleiroJogoDaVelha.getValorLinhasColunas(2, 2, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "O") && tabuleiroJogoDaVelha.getValorLinhasColunas(0, 0, "O"));

            // # Mostra mensagem caso a vitória tenha sido vertical tanto de X como de O
            if (Cadastro.usuario1.getLetraJogo() == "X" && linhaDiagonalX)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nJogador {Cadastro.usuario1.getNome()} Venceu a partida :D");
                Console.ResetColor();

                Cadastro.usuario1.setPontuacaoJogador(1, 1);

                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
;
            }
            if (Cadastro.usuario1.getLetraJogo() == "O" && linhaDiagonalO)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nJogador {Cadastro.usuario1.getNome()} Venceu a partida :D");
                Console.ResetColor();

                Cadastro.usuario1.setPontuacaoJogador(1, 1);

                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
;

            }
            if (Cadastro.usuario2.getLetraJogo() == "X" && linhaDiagonalX)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nJogador {Cadastro.usuario2.getNome()} Venceu a partida :D");
                Console.ResetColor();

                Cadastro.usuario2.setPontuacaoJogador(1, 1);


                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
;
            }
            if (Cadastro.usuario2.getLetraJogo() == "O" && linhaDiagonalO)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nJogador {Cadastro.usuario2.getNome()} Venceu a partida :D");
                Console.ResetColor();

                Cadastro.usuario2.setPontuacaoJogador(1, 2);

                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
;
            }

        }


        // # Método que verifica se houve empate no jogo
        public static void VerificaEmpate(string jogarDeNovo)
        {
            /*
               - Se o intervalo[1-9] estiver preenchido com numeros o código ocorre normalmente, porém, se não estiver, quer dizer que ele já está lotado de X e O, e se até o número 8 nenhuma função de checar vitoria, chegar empate entrar, então quer dizer que deu velha
               - Aqui eu vou percorrer a matriz, e comparar e ver se é igual a escolha do jogador se for, eu vou substituir o número do intervalo [1-9] pela letra
             */

            if(tabuleiroJogoDaVelha.getValorLinhasColunas(0, 0, "1") || tabuleiroJogoDaVelha.getValorLinhasColunas(0, 1, "2") || tabuleiroJogoDaVelha.getValorLinhasColunas(0, 2, "3") || tabuleiroJogoDaVelha.getValorLinhasColunas(1, 0, "4") || tabuleiroJogoDaVelha.getValorLinhasColunas(1, 1, "5") || tabuleiroJogoDaVelha.getValorLinhasColunas(1, 2, "6") || tabuleiroJogoDaVelha.getValorLinhasColunas(2, 0, "7") || tabuleiroJogoDaVelha.getValorLinhasColunas(2, 1, "8"))
            {
                // Esses métodos logo após a verificação checam o intervalo [0-9] para ver se houve alguma vitória horizontal, vertical ou diagonal antes de cair no else que seria o empate
                VerificaVitoriaHorizontal(jogarDeNovo);
                VerificaVitoriaVertical(jogarDeNovo);
                VerificaVitoriaDiagonal(jogarDeNovo);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n***  Deu velha  ***");
                Console.ResetColor();

                tabuleiroJogoDaVelha.MostrarTabuleiro(3);

                Controller.JogoDaVelha.qtdEmpate++;

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
;

            }


        }
    }
}
