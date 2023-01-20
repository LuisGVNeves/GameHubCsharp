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
    }
}
