using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrezconsole;

internal class Peca
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
}
