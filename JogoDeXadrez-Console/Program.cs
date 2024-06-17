using JogoDeXadrez_Console;
using JogoDeXadrez_Console.PecasDeXadrez;
using JogoDeXadrez_Console.tabuleiro;

Tabuleiro tab = new Tabuleiro(8,8);

tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0,0));
tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1,3));
tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2,4));

Tela.imprimirTabuleiro(tab);