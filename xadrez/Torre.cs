using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrezconsole;

internal class Torre : Peca
{
    public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
    {

    }
    


    public override string ToString()
    {
        return "T";
    }
    private bool PodeMover(Posicao posicao)
    {
        Peca peca = Tabuleiro.Peca(posicao);
        return peca == null || peca.Cor != Cor;
    }
    public override bool[,] MovimentosPossiveis()
    {
        bool[,] movimentosPossiveis = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
        Posicao posicao = new Posicao(0, 0);

        //Norte
        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
        while(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
            if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
            {
                break;
            }
            posicao.Linha -= 1;
        }

        //Sul
        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
        while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
            if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
            {
                break;
            }
            posicao.Linha += 1;
        }

        //Leste
        posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
        while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
            if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
            {
                break;
            }
            posicao.Coluna += 1;
        }

        //Oeste
        posicao.DefinirValores(Posicao.Linha, Posicao.Coluna -1);
        while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
            if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
            {
                break;
            }
            posicao.Coluna -= 1;
        }
        return movimentosPossiveis;
    }

}

