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
            Console.Write($"{i + 1}" + "  ");
            for (int j = 0; j < tabuleiro.Colunas; j++)
            {

                if (tabuleiro.Peca(i, j) == null)
                {
                    Console.Write("- ");
                }
                else
                {
                    ImprimirPeca(tabuleiro.Peca(i, j));
                    Console.Write(" ");
                }


            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.Write("   ");
        for (int j = 0; j < tabuleiro.Colunas; j++)
        {
            Console.Write(a[j] + " ");            
        }
        Console.WriteLine();
    }
    public static PosicaoXadrez LerPosicaoXadrez()
    {
        string entrada = Console.ReadLine();
        char coluna = entrada[0];
        int linha = int.Parse(entrada[1] + "");
        return new PosicaoXadrez(coluna, linha);
    }
    public static void ImprimirPeca (Peca peca)
    {
        if (peca.Cor == Cor.Branca)
        {
            Console.Write(peca);
        }
        else
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(peca);
            Console.ForegroundColor = aux;
        }
    }
}
