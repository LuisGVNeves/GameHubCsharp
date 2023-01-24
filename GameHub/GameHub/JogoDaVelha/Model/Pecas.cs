using GameHub.HubAssets.View;
using GameHub.HubAssets.Model;
using GameHub.JogoDaVelha.Controller;

namespace GameHub.JogoDaVelha.Model
{
    internal class Pecas : Tabuleiros
    {
        // # Método para verificar matriz na horizontal e ver se teve X X X ou O O O  na horizontal
        public static void VerificaVitoriaHorizontal(string jogarDeNovo)
        {
            bool linhaHorizontalX;
            bool linhaHorizontalO;

            // # Verifica se a primeira, segunda, terceira linha da matriz teve as linhas prenchidas na ordem orizontal X X X

            linhaHorizontalX =
                (tabuleiroJogoDaVelha[0, 0] == "X" && tabuleiroJogoDaVelha[0, 1] == "X" && tabuleiroJogoDaVelha[0, 2] == "X") ||
                (tabuleiroJogoDaVelha[1, 0] == "X" && tabuleiroJogoDaVelha[1, 1] == "X" && tabuleiroJogoDaVelha[1, 2] == "X") ||
                (tabuleiroJogoDaVelha[2, 0] == "X" && tabuleiroJogoDaVelha[2, 1] == "X" && tabuleiroJogoDaVelha[2, 2] == "X");

            // # Verifica se a primeira, segunda, terceira linha da matriz teve as linhas prenchidas na ordem orizontal O O  O

            linhaHorizontalO =
                (tabuleiroJogoDaVelha[0, 0] == "O" && tabuleiroJogoDaVelha[0, 1] == "O" && tabuleiroJogoDaVelha[0, 2] == "O") ||
                (tabuleiroJogoDaVelha[1, 0] == "O" && tabuleiroJogoDaVelha[1, 1] == "O" && tabuleiroJogoDaVelha[1, 2] == "O") ||
                (tabuleiroJogoDaVelha[2, 0] == "O" && tabuleiroJogoDaVelha[2, 1] == "O" && tabuleiroJogoDaVelha[2, 2] == "O");


            // # Mostra mensagem caso a vitória tenha sido horizontal tanto de X como de O
            if (Cadastro.usuario1.getLetraJogo() == "X" && linhaHorizontalX)
            {
                MenuHub.AdicionarTexto($"\n\nJogador {Cadastro.usuario1.getNome()} Venceu a partida !", ConsoleColor.Green);
                Console.ResetColor();

                Cadastro.usuario1.setPontuacaoJogador(1, 1);

                TabuleiroJogoDaVelha.MostrarTabuleiro();

                System.Threading.Thread.Sleep(3000);
                Console.Clear();

                JogoDaVelha.View.Menu.SubMenu();
            }
            if (Cadastro.usuario1.getLetraJogo() == "O" && linhaHorizontalO)
            {
                MenuHub.AdicionarTexto($"\n\nJogador {Cadastro.usuario1.getNome()} Venceu a partida !", ConsoleColor.Green);
                Console.ResetColor();

                Cadastro.usuario1.setPontuacaoJogador(1, 1);
                TabuleiroJogoDaVelha.MostrarTabuleiro();

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
            }
            if (Cadastro.usuario2.getLetraJogo() == "X" && linhaHorizontalX)
            {
                MenuHub.AdicionarTexto($"\n\nJogador {Cadastro.usuario2.getNome()} Venceu a partida !", ConsoleColor.Green);
                Console.ResetColor();

                Cadastro.usuario2.setPontuacaoJogador(1, 2);

                TabuleiroJogoDaVelha.MostrarTabuleiro();

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
            }
            if (Cadastro.usuario2.getLetraJogo() == "O" && linhaHorizontalO)
            {
                MenuHub.AdicionarTexto($"\n\nJogador {Cadastro.usuario2.getNome()} Venceu a partida !", ConsoleColor.Green);
                Console.ResetColor();

                Cadastro.usuario2.setPontuacaoJogador(1, 2);

                TabuleiroJogoDaVelha.MostrarTabuleiro();

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
                (tabuleiroJogoDaVelha[0, 0] == "X" && tabuleiroJogoDaVelha[1, 0] == "X" && tabuleiroJogoDaVelha[2, 0] == "X") ||
                (tabuleiroJogoDaVelha[0, 1] == "X" && tabuleiroJogoDaVelha[1, 1] == "X" && tabuleiroJogoDaVelha[2, 1] == "X") ||
                (tabuleiroJogoDaVelha[0, 2] == "X" && tabuleiroJogoDaVelha[1, 2] == "X" && tabuleiroJogoDaVelha[2, 2] == "X");

            linhaVerticalO =
                (tabuleiroJogoDaVelha[0, 0] == "O" && tabuleiroJogoDaVelha[1, 0] == "O" && tabuleiroJogoDaVelha[2, 0] == "O") ||
                (tabuleiroJogoDaVelha[0, 1] == "O" && tabuleiroJogoDaVelha[1, 1] == "O" && tabuleiroJogoDaVelha[2, 1] == "O") ||
                (tabuleiroJogoDaVelha[0, 2] == "O" && tabuleiroJogoDaVelha[1, 2] == "O" && tabuleiroJogoDaVelha[2, 2] == "O");


            // # Mostra mensagem caso a vitória tenha sido vertical tanto de X como de O
            if (Cadastro.usuario1.getLetraJogo() == "X" && linhaVerticalX)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nJogador {Cadastro.usuario1.getNome()} Venceu a partida :D");
                Console.ResetColor();

                Cadastro.usuario1.setPontuacaoJogador(1, 1);

                TabuleiroJogoDaVelha.MostrarTabuleiro();

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
                TabuleiroJogoDaVelha.MostrarTabuleiro();

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

                TabuleiroJogoDaVelha.MostrarTabuleiro();

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

                TabuleiroJogoDaVelha.MostrarTabuleiro();

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
                (tabuleiroJogoDaVelha[2, 0] == "X" && tabuleiroJogoDaVelha[1, 1] == "X" && tabuleiroJogoDaVelha[0, 2] == "X") ||
                (tabuleiroJogoDaVelha[0, 2] == "X" && tabuleiroJogoDaVelha[1, 1] == "X" && tabuleiroJogoDaVelha[2, 0] == "X") ||
                (tabuleiroJogoDaVelha[0, 0] == "X" && tabuleiroJogoDaVelha[1, 1] == "X" && tabuleiroJogoDaVelha[2, 2] == "X") ||
                (tabuleiroJogoDaVelha[2, 2] == "X" && tabuleiroJogoDaVelha[1, 1] == "X" && tabuleiroJogoDaVelha[0, 0] == "X");

            // Coluna vertical verificando O
            linhaDiagonalO =
                (tabuleiroJogoDaVelha[2, 0] == "O" && tabuleiroJogoDaVelha[1, 1] == "O" && tabuleiroJogoDaVelha[0, 2] == "O") ||
                (tabuleiroJogoDaVelha[0, 2] == "O" && tabuleiroJogoDaVelha[1, 1] == "O" && tabuleiroJogoDaVelha[2, 0] == "O") ||
                (tabuleiroJogoDaVelha[0, 0] == "O" && tabuleiroJogoDaVelha[1, 1] == "O" && tabuleiroJogoDaVelha[2, 2] == "O") ||
                (tabuleiroJogoDaVelha[2, 2] == "O" && tabuleiroJogoDaVelha[1, 1] == "O" && tabuleiroJogoDaVelha[0, 0] == "O");


            // # Mostra mensagem caso a vitória tenha sido vertical tanto de X como de O
            if (Cadastro.usuario1.getLetraJogo() == "X" && linhaDiagonalX)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nJogador {Cadastro.usuario1.getNome()} Venceu a partida :D");
                Console.ResetColor();

                Cadastro.usuario1.setPontuacaoJogador(1, 1);

                TabuleiroJogoDaVelha.MostrarTabuleiro();

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

                TabuleiroJogoDaVelha.MostrarTabuleiro();

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


                TabuleiroJogoDaVelha.MostrarTabuleiro();

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

                TabuleiroJogoDaVelha.MostrarTabuleiro();

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

            if ((tabuleiroJogoDaVelha[0, 0] == "1") || (tabuleiroJogoDaVelha[0, 1] == "2") ||
                (tabuleiroJogoDaVelha[0, 2] == "3") || (tabuleiroJogoDaVelha[1, 0] == "4") ||
                (tabuleiroJogoDaVelha[1, 1] == "5") || (tabuleiroJogoDaVelha[1, 2] == "6") ||
                (tabuleiroJogoDaVelha[2, 0] == "7") || (tabuleiroJogoDaVelha[2, 1] == "8"))
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

                TabuleiroJogoDaVelha.MostrarTabuleiro();

                Controller.JogoDaVelha.qtdEmpate++;

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                JogoDaVelha.View.Menu.SubMenu();
;

            }


        }
    }
}
