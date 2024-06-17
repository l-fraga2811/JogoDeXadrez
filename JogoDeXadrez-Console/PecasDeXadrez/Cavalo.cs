using JogoDeXadrez_Console.tabuleiro;

namespace JogoDeXadrez_Console.PecasDeXadrez;

public class Cavalo : Peca
{
    public Cavalo(Tabuleiro tab, Cor cor) : base(cor, tab)
    {
        
    }

    public override string ToString()
    {
        return "C";
    }
}