using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameHub.Entity.Tabuleiro;

namespace GameHub.JogoDeXadrez.View
{
    class TabuleiroXadrez : Tabuleiros
    {
        void PreencherTabuleiroXadrez()
        {
            // # Linha 1
            tabuleiroXadrez[0, 0] = 'T'; // Torre
            tabuleiroXadrez[0, 1] = 'C'; // Cavalo
            tabuleiroXadrez[0, 2] = 'B'; // Bispo
            tabuleiroXadrez[0, 3] = 'Q'; // Queen
            tabuleiroXadrez[0, 4] = 'K'; // King
            tabuleiroXadrez[0, 5] = 'B'; // Bispo
            tabuleiroXadrez[0, 6] = 'C'; // Cavalo
            tabuleiroXadrez[0, 7] = 'T'; // Torre

            // # Linha 2
            tabuleiroXadrez[1, 0] = 'p'; // Peões
            tabuleiroXadrez[1, 1] = 'p';
            tabuleiroXadrez[1, 2] = 'p';
            tabuleiroXadrez[1, 3] = 'p';
            tabuleiroXadrez[1, 4] = 'p';
            tabuleiroXadrez[1, 5] = 'p';
            tabuleiroXadrez[1, 6] = 'p';
            tabuleiroXadrez[1, 7] = 'p';


            // # Linha 3
            tabuleiroXadrez[2, 0] = ' ';
            tabuleiroXadrez[2, 1] = ' ';
            tabuleiroXadrez[2, 2] = ' ';
            tabuleiroXadrez[2, 3] = ' ';
            tabuleiroXadrez[2, 4] = ' ';
            tabuleiroXadrez[2, 5] = ' ';
            tabuleiroXadrez[2, 6] = ' ';
            tabuleiroXadrez[2, 7] = ' ';

            // # Linha 4
            tabuleiroXadrez[3, 0] = ' ';
            tabuleiroXadrez[3, 1] = ' ';
            tabuleiroXadrez[3, 2] = ' ';
            tabuleiroXadrez[3, 3] = ' ';
            tabuleiroXadrez[3, 4] = ' ';
            tabuleiroXadrez[3, 5] = ' ';
            tabuleiroXadrez[3, 6] = ' ';
            tabuleiroXadrez[3, 7] = ' ';

            // # Linha 5
            tabuleiroXadrez[4, 0] = ' ';
            tabuleiroXadrez[4, 1] = ' ';
            tabuleiroXadrez[4, 2] = ' ';
            tabuleiroXadrez[4, 3] = ' ';
            tabuleiroXadrez[4, 4] = ' ';
            tabuleiroXadrez[4, 5] = ' ';
            tabuleiroXadrez[4, 6] = ' ';
            tabuleiroXadrez[4, 7] = ' ';

            // # Linha 6
            tabuleiroXadrez[5, 0] = ' ';
            tabuleiroXadrez[5, 1] = ' ';
            tabuleiroXadrez[5, 2] = ' ';
            tabuleiroXadrez[5, 3] = ' ';
            tabuleiroXadrez[5, 4] = ' ';
            tabuleiroXadrez[5, 5] = ' ';
            tabuleiroXadrez[5, 6] = ' ';
            tabuleiroXadrez[5, 7] = ' ';

            // # Linha 7
            tabuleiroXadrez[6, 0] = 'P'; // Peões
            tabuleiroXadrez[6, 1] = 'P';
            tabuleiroXadrez[6, 2] = 'P';
            tabuleiroXadrez[6, 3] = 'P';
            tabuleiroXadrez[6, 4] = 'P';
            tabuleiroXadrez[6, 5] = 'P';
            tabuleiroXadrez[6, 6] = 'P';
            tabuleiroXadrez[6, 7] = 'P';

            // # Linha 8
            tabuleiroXadrez[7, 0] = 't'; // Torre
            tabuleiroXadrez[7, 1] = 'c'; // Cavalo
            tabuleiroXadrez[7, 2] = 'b'; // Bispo
            tabuleiroXadrez[7, 3] = 'q'; // Queen
            tabuleiroXadrez[7, 4] = 'k'; // King
            tabuleiroXadrez[7, 5] = 'b'; // Bispo
            tabuleiroXadrez[7, 6] = 'c'; // Cavalo
            tabuleiroXadrez[7, 7] = 't'; // Torre

        }


    }
}
