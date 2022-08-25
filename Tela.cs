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
        string[] a = new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };
        for (int i = 0; i < tabuleiro.Linhas; i++)
        {
            Console.Write(a[i] + "  ");
            for (int j = 0; j < tabuleiro.Colunas; j++)
            {
                if (tabuleiro.Peca(i, j) == null)
                    Console.Write("_ ");
                else
                    Console.Write(tabuleiro.Peca(i, j) + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.Write("   ");
        for (int j = 0; j < tabuleiro.Colunas; j++)
        {
            Console.Write($"{j + 1}" + " ");
        }
        Console.WriteLine();
    }
}
