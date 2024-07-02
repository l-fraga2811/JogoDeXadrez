using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JogoDeXadrez_Console.tabuleiro;

namespace JogoDeXadrez_Console.PecasDeXadrez
{
    public class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8,8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
        }
        public void executaMov(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQuantidadeDeMovs();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
        private void colocarPecas()
        {
            //Torres pretas
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicoesXadrez('a', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicoesXadrez('h', 8).toPosicao());
            //Cavalos pretos
            tab.colocarPeca(new Cavalo(tab, Cor.Preta), new PosicoesXadrez('b', 8).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Preta), new PosicoesXadrez('g', 8).toPosicao());
            //Bispos pretos
            tab.colocarPeca(new Bispo(tab, Cor.Preta), new PosicoesXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Preta), new PosicoesXadrez('f', 8).toPosicao());
            //Rei preto
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicoesXadrez('d', 8).toPosicao());
            //Dama preta
            tab.colocarPeca(new Dama(tab, Cor.Preta), new PosicoesXadrez('e', 8).toPosicao());

            //Torres brancas
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicoesXadrez('a', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicoesXadrez('h', 1).toPosicao());
            //Cavalos brancos
            tab.colocarPeca(new Cavalo(tab, Cor.Branca), new PosicoesXadrez('b', 1).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Branca), new PosicoesXadrez('g', 1).toPosicao());
            //Bispos brancos
            tab.colocarPeca(new Bispo(tab, Cor.Branca), new PosicoesXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Branca), new PosicoesXadrez('f', 1).toPosicao());
            //Rei branco
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicoesXadrez('d', 1).toPosicao());
            //Dama branca
            tab.colocarPeca(new Dama(tab, Cor.Branca), new PosicoesXadrez('e', 1).toPosicao());
        }
    }
}