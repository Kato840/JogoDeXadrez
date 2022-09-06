using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrezconsole;

abstract class Peca
{
    public Posicao Posicao { get; set; }
    public Cor Cor { get; protected set; }
    public int QteMovimentos { get; protected set; }
    public Tabuleiro Tabuleiro { get; protected set; }

    public Peca(Tabuleiro tabuleiro, Cor cor)
    {
        Posicao = null;
        Cor = cor;
        QteMovimentos = 0;
        Tabuleiro = tabuleiro;
    }
    public void IncrementarQteMovimentos()
    {
        QteMovimentos++;
    }

    public bool ExisteMovimentosPossiveis()
    {
        bool[,] existeMovimento = MovimentosPossiveis();
        for (int i = 0; i < Tabuleiro.Linhas; i++)
        {
            for (int j = 0; j < Tabuleiro.Colunas; j++)
            {
                if (existeMovimento[i, j])
                {
                    return true;
                }
            }
        }
        return false;
    }
    public bool PodeMoverPara(Posicao posicao)
    {
        return MovimentosPossiveis()[posicao.Linha, posicao.Coluna];
    }
    public abstract bool[,] MovimentosPossiveis();
    

    
}
