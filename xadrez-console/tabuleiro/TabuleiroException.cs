using System;

namespace xadrez_console.tabuleiro {
    internal class TabuleiroException : Exception {
        public TabuleiroException(string msg) : base(msg) {
        }
    }
}
