using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoDeXadrez_Console.tabuleiro
{
    public class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg) 
        {
            
        }
    }
}