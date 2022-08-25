using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrezconsole;

internal class Tela
{
    public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
    {
        for(int i=0; i<tabuleiro.Linhas; i++)
        {
            for(int j=0; j<tabuleiro.Colunas; j++)
            {
                if(tabuleiro.Peca(i,j) == null)
                    Console.Write("_ ");
                else
                Console.Write( tabuleiro.Peca(i,j) +" ");
            }
            Console.WriteLine();
        }
    }
}
