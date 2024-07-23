using JogoDeXadrez_Console;
using JogoDeXadrez_Console.PecasDeXadrez;
using JogoDeXadrez_Console.tabuleiro;
try
{
    PartidaDeXadrez partida = new();

    while (!partida.terminada)
    {
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);

        System.Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

        System.Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.executaMov(origem,destino);
    }

    Tela.imprimirTabuleiro(partida.tab);
}
catch (Exception e)
{
    System.Console.WriteLine(e.Message);
}

