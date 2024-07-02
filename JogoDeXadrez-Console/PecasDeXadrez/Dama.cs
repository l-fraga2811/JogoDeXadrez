using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JogoDeXadrez_Console;
using JogoDeXadrez_Console.tabuleiro;

namespace JogoDeXadrez_Console.PecasDeXadrez
{
    public class Dama: Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
            
        }

        public override string ToString()
        {
            return "D";
        }
    }
}