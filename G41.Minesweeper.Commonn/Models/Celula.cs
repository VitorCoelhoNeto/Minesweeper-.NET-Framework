using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Celula
    {
        public int coluna { get; set; }
        public int linha { get; set; }
        public int numVizinhosBomba { get; set; }
        public bool temMina { get; set; }
        public bool foiClicado { get; set; }
        public bool temFlag { get; set; }

        public Celula(int c, int l, int numV, bool foiClic, bool temMina, bool flag)
        {
            this.coluna = c;
            this.linha = l;
            this.numVizinhosBomba = numV;
            this.temFlag = flag;
            this.foiClicado = foiClic;
            this.temMina = temMina;
        }
    }
}
