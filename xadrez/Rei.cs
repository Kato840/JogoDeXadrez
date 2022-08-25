using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrezconsole;

internal class Rei : Peca
{
    public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
    {

    }

    public override string ToString()
    {
        return "R";
    }
}
