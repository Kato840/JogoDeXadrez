﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrezconsole;

internal class Tela
{
    public static void ImprimirPartida(PartidaDeXadrez partida)
    {
        ImprimirTabuleiro(partida.Tabuleiro);        
        Console.WriteLine();
        ImprimirPecasCapturadas(partida);
        Console.WriteLine();
        Console.WriteLine($"Turno: {partida.Turno}");
        Console.WriteLine($"Aguardando jogada: {partida.JogadorAtual}");
    }
    public static void  ImprimirPecasCapturadas(PartidaDeXadrez partida)
    {
        Console.WriteLine("Peças capturadas: ");
        Console.Write("Brancas: ");
        ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));
        Console.WriteLine();
        Console.Write("Pretas: ");
        ConsoleColor consoleColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
        Console.ForegroundColor= consoleColor;
        Console.WriteLine();
    }
    public static void ImprimirConjunto(HashSet<Peca> conjunto)
    {
        Console.Write("[");
        foreach(Peca x in conjunto)
        {
            Console.Write(x+" ");
        }
        Console.Write("]");
    }
    public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
    {
        for (int i = 0; i < tabuleiro.Linhas; i++)
        {
            Console.Write(8 - i + "  ");
            for (int j = 0; j < tabuleiro.Colunas; j++)
            {
                    ImprimirPeca(tabuleiro.Peca(i, j));
            }
            Console.WriteLine();            
        }        
        Console.WriteLine("   A B C D E F G H");
        
        
    }

    public static void ImprimirTabuleiro(Tabuleiro tabuleiro, bool[,] posicoesPossiveis)
    {
        ConsoleColor fundoOriginal = Console.BackgroundColor;
        ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

        
        for (int i = 0; i < tabuleiro.Linhas; i++)
        {
            Console.Write(8 - i + "  ");
            for (int j = 0; j < tabuleiro.Colunas; j++)
            {
                if (posicoesPossiveis[i, j])
                {
                    Console.BackgroundColor = fundoAlterado;
                }
                else
                {
                    Console.BackgroundColor = fundoOriginal;
                }
                ImprimirPeca(tabuleiro.Peca(i, j));
                Console.BackgroundColor = fundoOriginal;
            }
            Console.WriteLine();
        }
        Console.WriteLine("   A B C D E F G H");
        
        Console.BackgroundColor = fundoOriginal;
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
        if (peca == null)
        {
            Console.Write("- ");
        }
        else
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
            Console.Write(" ");
        }
    }
}
