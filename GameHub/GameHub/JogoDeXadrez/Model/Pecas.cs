using GameHub.JogoDeXadrez.Controller;
using GameHub.HubAssets.View;
using GameHub.HubAssets.Model;

namespace GameHub.JogoDeXadrez.Model
{
    class Pecas
    {

        public static TabuleiroXadrez tabuleiroXadrez = new TabuleiroXadrez();


        // # Variavel pra calcular deslocamento das peças no tabuleiro
        public static int deslocamentoVertical;
        public static int deslocamentoHorizontal;

        // # Lista para guardar as peças capturadas do tabuleiro
        public static List<char> listaDePecasVermelhas = new List<char>();
        public static List<char> listaDePecasBrancas = new List<char>();



        // # Método para mover a peça
        public static bool MoverPeca(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // Caso o usuário digite corretamente o intervalo do tabuleiro 8x8: Retorna true ou false
            if (linhaOrigem >= 0 && linhaOrigem < 8 && colunaOrigem >= 0 && colunaOrigem < 8 &&
                linhaDestino >= 0 && linhaDestino < 8 && colunaDestino >= 0 && colunaDestino < 8)
            {
                // Verifica o movimento da torre para fazer o movimento
                Torre.VerificarPecaTorre(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                // Verifica o movimento do bispo para fazer o movimento
                Bispo.VerificarPecaBispo(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                // Verifica o movimento do cavalo para fazer o movimento
                Cavalo.VerificarPecaCavalo(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                // Verifica o movimento da rainha para fazer o movimento
                Rainha.VerificarPecaRainha(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                // Verifica o movimento do rei para fazer o movimento
                Rei.VerificarPecaRei(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                // Verifica o movimento do peão para fazer o movimento
                Peao.VerificarPecaPeao(linhaOrigem, colunaOrigem, linhaDestino, colunaDestino);

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
