using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entity.ModeloTabuleiro
{
    class Tabuleiro
    {
        public static char[,] tabuleiro;
        public static int Linhas;
        public static int Colunas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;

            tabuleiro = new char[Linhas, Colunas];
        }

        public static int getValorLinhas()
        {
            return Linhas;
        }
        public static int getValorColunas()
        {
            return Colunas;
        }

    }
}
