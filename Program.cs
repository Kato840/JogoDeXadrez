using System;
using xadrezconsole;


namespace xadrezconsole;
internal class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.White;
        try
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 2));
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(3, 3));
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(7, 3));




            Tela.ImprimirTabuleiro(tabuleiro);
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }




    }
}
