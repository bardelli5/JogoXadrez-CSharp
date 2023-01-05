using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro {
    internal class Posicao {

        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao() {
        }
        public Posicao(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

        override public string ToString() {
            return linha + ", " + coluna;
        }
    }
}
