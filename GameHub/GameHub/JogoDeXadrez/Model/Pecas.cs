using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.JogoDeXadrez.Model
{
    class Pecas
    {
        // # Variavel pra calcular deslocamento das peças no tabuleiro
        static int deslocamentoVertical;
        static int deslocamentoHorizontal;

        public static List<char> listaDePecasVermelhas = new List<char>();
        public static List<char> listaDePecasBrancas = new List<char>();


        // # Método para mover a peça
        public static bool MoverPeca(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
        {
            // Caso o usuário digite corretamente o intervalo do tabuleiro 8x8: Retorna true ou false
            if (linhaOrigem >= 0 && linhaOrigem < 8 && colunaOrigem >= 0 && colunaOrigem < 8 &&
                linhaDestino >= 0 && linhaDestino < 8 && colunaDestino >= 0 && colunaDestino < 8)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
