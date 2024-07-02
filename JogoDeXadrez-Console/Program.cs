using JogoDeXadrez_Console;
using JogoDeXadrez_Console.PecasDeXadrez;
using JogoDeXadrez_Console.tabuleiro;
try
{
    PartidaDeXadrez partida = new();

    Tela.imprimirTabuleiro(partida.tab);
}
catch (Exception e)
{
    System.Console.WriteLine(e.Message);
}

